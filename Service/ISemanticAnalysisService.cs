using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service
{
    [ServiceContract]
    public interface ISemanticAnalysisService
    {
        [OperationContract]
        TextAnalysisResult Analyze(String text);
    }

    [DataContract]
    public class TextAnalysisResult
    {
        public TextAnalysisResult(SemanticAnalyzer analyzer)
        {
            this.Words = analyzer.Words;
            this.UniqueWords = analyzer.UniqueWords;
            this.SemanticCore = analyzer.SemanticCore;
            this.CharacterCount = analyzer.CharacterCount;
            this.Water = analyzer.Water;
            this.ClassicNausea = analyzer.ClassicNausea;
            this.AcademicNausea = analyzer.AcademicNausea;
            this.StopWords = analyzer.StopWords;
        }

        [DataMember]
        public String[] Words { get; private set; }

        [DataMember]
        public UniqueWord[] UniqueWords { get; private set; }

        [DataMember]
        public UniqueWord[] SemanticCore { get; private set; }

        [DataMember]
        public UniqueWord[] StopWords { get; private set; }

        [DataMember]
        public int CharacterCount { get; private set; }

        [DataMember]
        public double Water { get; private set; }

        [DataMember]
        public double ClassicNausea { get; private set; }

        [DataMember]
        public double AcademicNausea { get; private set; }
    }
}
