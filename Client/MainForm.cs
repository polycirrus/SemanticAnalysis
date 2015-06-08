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
using System.IO;

namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            fileSelected = false;
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

                characterCountLabel.Text = _analysisResult.CharacterCount.ToString();
                waterLabel.Text = _analysisResult.Water.ToString();
                classicNauseaLabel.Text = _analysisResult.ClassicNausea.ToString();
                academicNauseaLabel.Text = _analysisResult.AcademicNausea.ToString();

                foreach (String word in _analysisResult.Words)
                {
                    wordsDataGridView.Rows.Add(word);
                }

                foreach (UniqueWord word in _analysisResult.UniqueWords)
                {
                    uniqueWordsDataGridView.Rows.Add(word.Word, word.Count, word.Frequency);
                }

                foreach (UniqueWord word in _analysisResult.SemanticCore)
                {
                    semanticCoreDataGridView.Rows.Add(word.Word, word.Count, word.Frequency);
                }

                foreach (UniqueWord word in _analysisResult.StopWords)
                {
                    stopWordsDataGridView.Rows.Add(word.Word, word.Count, word.Frequency);
                }
            }
        }

        private bool fileSelected;
        private String fileName;

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            String text;

            if (fileInputRadioButton.Checked)
            {
                if (fileSelected)
                {
                    text = File.ReadAllText(fileName);
                }
                else
                {
                    MessageBox.Show("Файл не выбран.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                text = inputRichTextBox.Text;
            }

            var client = new SemanticAnalysisService.SemanticAnalysisServiceClient();
            AnalysisResult = client.Analyze(text);
        }

        private void fileInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fileInputRadioButton.Checked)
                browseButton.Enabled = true;
            else
                browseButton.Enabled = false;
        }

        private void textBoxInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxInputRadioButton.Checked)
                inputRichTextBox.Enabled = true;
            else
                inputRichTextBox.Enabled = false;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileSelected = true;
                fileName = dialog.FileName;
                fileNameLabel.Text = fileName;
            }
        }
    }
}
