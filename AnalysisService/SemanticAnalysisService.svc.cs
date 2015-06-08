using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AnalysisService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class SemanticAnalysisService : ISemanticAnalysisService
    {
        public TextAnalysisResult Analyze(String text)
        {
            var analyzer = new SemanticAnalyzer(text);
            return new TextAnalysisResult(analyzer);

        }
    }
}
