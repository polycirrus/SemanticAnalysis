using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace SemanticAnalysisTests
{
    [TestClass]
    public class SemanticAnalysisTests
    {
        const String stopDictionaryPath = "stop.txt";

        public String RandomWord(Random random)
        {
            const String chars = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            var wordLength = random.Next(3, 10);
            var wordChars = new Char[wordLength];
            for (int i = 0; i < wordLength; i++)
                wordChars[i] = chars[random.Next(chars.Length)];

            return new String(wordChars);
        }

        public String RandomNonWord(Random random)
        {
            const String chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-=_+";

            var wordLength = random.Next(3, 10);
            var wordChars = new Char[wordLength];
            for (int i = 0; i < wordLength; i++)
                wordChars[i] = chars[random.Next(chars.Length)];

            return new String(wordChars);
        }

        [TestMethod]
        public void RandomTextTest()
        {
            //arrange
            var random = new Random();
            var lemmatizer = new LemmaSharp.LemmatizerPrebuiltCompact(LemmaSharp.LanguagePrebuilt.Russian);

            var stopWordsDictionary = File.ReadAllLines(stopDictionaryPath);

            var wordCount = random.Next(500, 1500);
            var stopWordPercentage = (random.NextDouble() + 1) / 3;
            var keyWordsCount = random.Next(15, 25);
            var keyWords = new Dictionary<String, int>();
            for (int i = 1; i <= keyWordsCount; i++)
            {
                var randomWord = RandomWord(random);
                while (stopWordsDictionary.Contains(randomWord))
                    randomWord = RandomWord(random);
                while (keyWords.ContainsKey(randomWord))
                    randomWord = RandomWord(random);
                keyWords.Add(randomWord, 0);
            }
            var stopWords = new Dictionary<String, int>();
            String randomText = "";
            for (int i = 1; i <= wordCount; i++)
            {
                if (random.NextDouble() > stopWordPercentage)
                {
                    //add key word
                    var word = keyWords.ElementAt(random.Next(keyWordsCount));
                    randomText += word.Key + ' ';
                    keyWords[word.Key]++;
                }
                else
                {
                    //add stop word
                    var word = stopWordsDictionary[random.Next(stopWordsDictionary.Length)];
                    randomText += word + ' ';
                    var key = lemmatizer.Lemmatize(word);
                    if (stopWords.ContainsKey(key))
                        stopWords[key]++;
                    else
                        stopWords.Add(key, 1);
                }
            }

            //act
            var analyzer = new Service.SemanticAnalyzer(randomText);

            //assert
            Assert.AreEqual(wordCount, analyzer.Words.Length);

            var expectedUniqueWords = stopWords.ToList().Concat(keyWords.ToList().Select(keyValuePair => new KeyValuePair<String, int>(lemmatizer.Lemmatize(keyValuePair.Key), keyValuePair.Value)).ToList()).ToList();
            var actualUniqueWords = analyzer.UniqueWords.Select(element => new KeyValuePair<String, int>(element.Word, element.Count)).ToList();
            CollectionAssert.AreEquivalent(expectedUniqueWords, actualUniqueWords);

            var expectedStopWords = stopWords.ToList();
            var actualStopWords = analyzer.StopWords.Select(stopWord => new KeyValuePair<String, int>(stopWord.Word, stopWord.Count)).ToList();
            CollectionAssert.AreEquivalent(expectedStopWords, actualStopWords);

            var expectedKeyWords = keyWords.Keys.Select(element => lemmatizer.Lemmatize(element)).ToList();
            var actualSemanticCore = analyzer.SemanticCore.Select(element => element.Word).ToList();
            CollectionAssert.IsSubsetOf(actualSemanticCore, expectedKeyWords);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyTextTest()
        {
            //arrange
            var random = new Random();

            var wordCount = random.Next(1, 50);
            String randomText = "";
            for (int i = 1; i <= wordCount; i++)
            {
                randomText += RandomNonWord(random) + ' ';
            }

            //act
            var analyzer = new Service.SemanticAnalyzer(randomText); 
        }
    }
}
