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

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            var serviceClient = new ServiceReference1.SemanticAnalysisServiceClient();
            var results = serviceClient.Analyze("kek");
            foreach (UniqueWord word in results.UniqueWords)
            {
                dataGridView1.Rows.Add(word.Word, word.Count, word.Frequency);
            }
        }
    }
}
