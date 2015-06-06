using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Configuration;

namespace Service
{
    public class UniqueWord
    {
        public String Word;
        public int Count;
        public float Frequency;

        public UniqueWord(String word)
        {
            this.Word = word;
            this.Count = 1;
            this.Frequency = 0;
        }

        public override string ToString()
        {
            return String.Format("\"{0}\" Count = {1}; Frequency = {2}", Word, Count, Frequency);
        }
    }

    public class SemanticAnalyzer
    {
        private String stopDictionaryPath;
        private int semanticCoreSize;
        const int defaultSemanticCoreSize = 15;

        public readonly String Text;

        public int CharacterCount { get; private set; }
        public int CharacterCountNoWhitespaces { get; private set; }
        public String[] Words { get; private set; }
        public UniqueWord[] UniqueWords { get; private set; }
        public UniqueWord[] SemanticCore { get; private set; }
        public UniqueWord[] StopWords { get; private set; }
        public double Water { get; private set; }
        public int ClassicNausea { get; private set; }
        public int AcademicNausea { get; private set; }

        public SemanticAnalyzer(String text)
        {
            this.Text = text;
            this.stopDictionaryPath = ConfigurationManager.AppSettings["StopWordsDictionaryPath"];
            try
            {
                this.semanticCoreSize = Convert.ToInt32(ConfigurationManager.AppSettings["SemanticCoreSize"]);
            }
            catch
            {
                this.semanticCoreSize = defaultSemanticCoreSize;
            }

            //order matters, modify with caution
            //methods may depend on certain metrics already calculated
            this.CharacterCount = CountCharacters(false);
            this.CharacterCountNoWhitespaces = CountCharacters(true);
            this.Words = GetWords();
            this.UniqueWords = GetUniqueWords();
            this.SemanticCore = GetSemanticCore();
            this.StopWords = GetStopWords();
            this.Water = CountWater();
            this.ClassicNausea = CountClassicNausea();
            this.AcademicNausea = CountAcademicNausea();
        }

        private int CountCharacters(bool noWhitespaces)
        {
            if (noWhitespaces)
                return Regex.Matches(Text, "\\S").Count;
            else
                return Regex.Matches(Text, ".").Count;
        }

        private String[] GetWords()
        {
            return Regex.Matches(this.Text, "[A-Za-zА-Яа-яё]+(-[a-zA-Zа-яА-Яё]+)*").Cast<Match>().Select(match => match.Value).ToArray();
        }

        private UniqueWord[] GetUniqueWords()
        {
            int i;
            var lemmatizer = new LemmaSharp.LemmatizerPrebuiltCompact(LemmaSharp.LanguagePrebuilt.Russian);
            for (i = 0; i < Words.Length; i++)
            {
                Words[i] = lemmatizer.Lemmatize(Words[i].ToLower());
                
            }

            var uniqueWordsList = new List<UniqueWord>();

            //add Words to list of unique Words
            int index;
            foreach (String word in Words)
            {
                if ((index = uniqueWordsList.FindIndex(uniqueWord => uniqueWord.Word == word)) > -1)
                {
                    uniqueWordsList.ElementAt(index).Count += 1;
                }
                else
                {
                    uniqueWordsList.Add(new UniqueWord(word));
                }
            }

            //count frequencies
            var wordCount = Words.Count();
            foreach (UniqueWord uniqueWord in uniqueWordsList)
            {
                uniqueWord.Frequency = Convert.ToSingle(uniqueWord.Count) / Convert.ToSingle(wordCount);
            }

            //sort list by words' counters
            uniqueWordsList.Sort((x, y) => y.Count - x.Count);

            return uniqueWordsList.ToArray();
        }

        private UniqueWord[] GetSemanticCore()
        {
            var semanticCore = new List<UniqueWord>();
            var stopWordsDictionary = File.ReadAllLines(stopDictionaryPath);

            foreach (UniqueWord uniqueWord in UniqueWords)
            {
                if (! stopWordsDictionary.Contains(uniqueWord.Word))
                    semanticCore.Add(uniqueWord);
            }

            if (semanticCore.Count > semanticCoreSize)
                return semanticCore.Take(semanticCoreSize).ToArray();
            else
                return semanticCore.ToArray();
        }

        private UniqueWord[] GetStopWords()
        {
            var stopWords = new List<UniqueWord>();
            var stopWordsDictionary = File.ReadAllLines(stopDictionaryPath);

            foreach (UniqueWord uniqueWord in UniqueWords)
            {
                if (stopWordsDictionary.Contains(uniqueWord.Word))
                    stopWords.Add(uniqueWord);
            }

            return stopWords.ToArray();
        }

        //used to be ToString() for console output purposes
        public String DetailedStringRepresentation()
        {
            var result = String.Format("Characters: {0}\nCharacters w/out whitespaces: {1}\nWords: {2}\nUnique Words: {3}\nWords:\n", CharacterCount, CharacterCountNoWhitespaces, this.Words.Length, UniqueWords.Length);
            
            foreach (String word in Words)
            {
                result += "\t" + word + "\n";
            }

            result += "Unique Words:\n";
            foreach (UniqueWord uword in UniqueWords)
            {
                result += "\t" + uword.ToString() + "\n";
            }

            result += "Semantic core:\n";
            foreach (UniqueWord scword in SemanticCore)
            {
                result += "\t" + scword.ToString() + "\n";
            }

            return result;
        }

        private double CountWater()
        {
            //count non-unique stop words
            var stopWordsDictionary = File.ReadAllLines(stopDictionaryPath);
            int stopWords = 0;
            foreach (String word in Words)
            {
                if (stopWordsDictionary.Contains(word))
                    stopWords++;
            }

            return (double)stopWords / (double)Words.Length;
        }

        //WIP
        private int CountClassicNausea()
        {
            return 0;
        }

        //WIP
        private int CountAcademicNausea()
        {
            return 0;
        }
    }
}
