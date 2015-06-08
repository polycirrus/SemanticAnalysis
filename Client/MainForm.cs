using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using Service;

namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private TextAnalysisResult _analysisResult;
        private TextAnalysisResult AnalysisResult
        {
            get
            {
                return _analysisResult;
            }

            set
            {
                _analysisResult = value;
            }
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            var client = new SemanticAnalysisService.SemanticAnalysisServiceClient();
            var result = client.Analyze("Суд прися́жных — институт судебной системы, состоящий из коллегии присяжных заседателей, отобранных по методике случайной выборки только для данного дела и решающих вопросы факта, и одного недопрофессиональнейшего судьи, решающего вопросы пра́ва.");

            foreach (UniqueWord word in result.UniqueWords)
            {
                dataGridView1.Rows.Add(word.Word, word.Count, word.Frequency);
            }
        }
    }
}
