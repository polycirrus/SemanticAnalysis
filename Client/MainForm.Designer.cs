namespace Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textInputGroupBox = new System.Windows.Forms.GroupBox();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.textBoxInputRadioButton = new System.Windows.Forms.RadioButton();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileInputRadioButton = new System.Windows.Forms.RadioButton();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wordsDataGridView = new System.Windows.Forms.DataGridView();
            this.characterCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uniqueWordsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.semanticCoreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.stopWordsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.waterLabel = new System.Windows.Forms.Label();
            this.classicNauseaLabel = new System.Windows.Forms.Label();
            this.academicNauseaLabel = new System.Windows.Forms.Label();
            this.textInputGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueWordsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanticCoreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopWordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textInputGroupBox
            // 
            this.textInputGroupBox.Controls.Add(this.inputRichTextBox);
            this.textInputGroupBox.Controls.Add(this.textBoxInputRadioButton);
            this.textInputGroupBox.Controls.Add(this.fileNameLabel);
            this.textInputGroupBox.Controls.Add(this.browseButton);
            this.textInputGroupBox.Controls.Add(this.fileInputRadioButton);
            this.textInputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.textInputGroupBox.Name = "textInputGroupBox";
            this.textInputGroupBox.Size = new System.Drawing.Size(431, 628);
            this.textInputGroupBox.TabIndex = 0;
            this.textInputGroupBox.TabStop = false;
            this.textInputGroupBox.Text = "Ввод текста";
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Enabled = false;
            this.inputRichTextBox.Location = new System.Drawing.Point(26, 45);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(399, 577);
            this.inputRichTextBox.TabIndex = 4;
            this.inputRichTextBox.Text = "";
            // 
            // textBoxInputRadioButton
            // 
            this.textBoxInputRadioButton.AutoSize = true;
            this.textBoxInputRadioButton.Location = new System.Drawing.Point(6, 45);
            this.textBoxInputRadioButton.Name = "textBoxInputRadioButton";
            this.textBoxInputRadioButton.Size = new System.Drawing.Size(14, 13);
            this.textBoxInputRadioButton.TabIndex = 3;
            this.textBoxInputRadioButton.TabStop = true;
            this.textBoxInputRadioButton.UseVisualStyleBackColor = true;
            this.textBoxInputRadioButton.CheckedChanged += new System.EventHandler(this.textBoxInputRadioButton_CheckedChanged);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(170, 21);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 13);
            this.fileNameLabel.TabIndex = 2;
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Location = new System.Drawing.Point(89, 16);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileInputRadioButton
            // 
            this.fileInputRadioButton.AutoSize = true;
            this.fileInputRadioButton.Location = new System.Drawing.Point(6, 19);
            this.fileInputRadioButton.Name = "fileInputRadioButton";
            this.fileInputRadioButton.Size = new System.Drawing.Size(77, 17);
            this.fileInputRadioButton.TabIndex = 0;
            this.fileInputRadioButton.TabStop = true;
            this.fileInputRadioButton.Text = "Из файла:";
            this.fileInputRadioButton.UseVisualStyleBackColor = true;
            this.fileInputRadioButton.CheckedChanged += new System.EventHandler(this.fileInputRadioButton_CheckedChanged);
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(12, 646);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(431, 30);
            this.analyzeButton.TabIndex = 1;
            this.analyzeButton.Text = "Анализировать";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.academicNauseaLabel);
            this.groupBox1.Controls.Add(this.classicNauseaLabel);
            this.groupBox1.Controls.Add(this.waterLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.stopWordsDataGridView);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.semanticCoreDataGridView);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.uniqueWordsDataGridView);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.wordsDataGridView);
            this.groupBox1.Controls.Add(this.characterCountLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(449, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 673);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результаты анализа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Слова:";
            // 
            // wordsDataGridView
            // 
            this.wordsDataGridView.AllowUserToAddRows = false;
            this.wordsDataGridView.AllowUserToDeleteRows = false;
            this.wordsDataGridView.AllowUserToResizeColumns = false;
            this.wordsDataGridView.AllowUserToResizeRows = false;
            this.wordsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.wordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word});
            this.wordsDataGridView.Location = new System.Drawing.Point(9, 59);
            this.wordsDataGridView.Name = "wordsDataGridView";
            this.wordsDataGridView.RowHeadersVisible = false;
            this.wordsDataGridView.Size = new System.Drawing.Size(394, 119);
            this.wordsDataGridView.TabIndex = 2;
            // 
            // characterCountLabel
            // 
            this.characterCountLabel.AutoSize = true;
            this.characterCountLabel.Location = new System.Drawing.Point(134, 25);
            this.characterCountLabel.Name = "characterCountLabel";
            this.characterCountLabel.Size = new System.Drawing.Size(0, 13);
            this.characterCountLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество символов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Уникальные слова:";
            // 
            // uniqueWordsDataGridView
            // 
            this.uniqueWordsDataGridView.AllowUserToAddRows = false;
            this.uniqueWordsDataGridView.AllowUserToDeleteRows = false;
            this.uniqueWordsDataGridView.AllowUserToResizeColumns = false;
            this.uniqueWordsDataGridView.AllowUserToResizeRows = false;
            this.uniqueWordsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uniqueWordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uniqueWordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.uniqueWordsDataGridView.Location = new System.Drawing.Point(9, 200);
            this.uniqueWordsDataGridView.Name = "uniqueWordsDataGridView";
            this.uniqueWordsDataGridView.RowHeadersVisible = false;
            this.uniqueWordsDataGridView.Size = new System.Drawing.Size(394, 119);
            this.uniqueWordsDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Слово";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 91;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "Частота";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 74;
            // 
            // Word
            // 
            this.Word.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Word.HeaderText = "Слово";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            this.Word.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Семантическое ядро:";
            // 
            // semanticCoreDataGridView
            // 
            this.semanticCoreDataGridView.AllowUserToAddRows = false;
            this.semanticCoreDataGridView.AllowUserToDeleteRows = false;
            this.semanticCoreDataGridView.AllowUserToResizeColumns = false;
            this.semanticCoreDataGridView.AllowUserToResizeRows = false;
            this.semanticCoreDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.semanticCoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.semanticCoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.semanticCoreDataGridView.Location = new System.Drawing.Point(9, 343);
            this.semanticCoreDataGridView.Name = "semanticCoreDataGridView";
            this.semanticCoreDataGridView.RowHeadersVisible = false;
            this.semanticCoreDataGridView.Size = new System.Drawing.Size(394, 119);
            this.semanticCoreDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Слово";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 91;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.HeaderText = "Частота";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Стоп-слова:";
            // 
            // stopWordsDataGridView
            // 
            this.stopWordsDataGridView.AllowUserToAddRows = false;
            this.stopWordsDataGridView.AllowUserToDeleteRows = false;
            this.stopWordsDataGridView.AllowUserToResizeColumns = false;
            this.stopWordsDataGridView.AllowUserToResizeRows = false;
            this.stopWordsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.stopWordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stopWordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.stopWordsDataGridView.Location = new System.Drawing.Point(9, 486);
            this.stopWordsDataGridView.Name = "stopWordsDataGridView";
            this.stopWordsDataGridView.RowHeadersVisible = false;
            this.stopWordsDataGridView.Size = new System.Drawing.Size(394, 119);
            this.stopWordsDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Слово";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 91;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.HeaderText = "Частота";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Вода:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 631);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Классическая тошнота:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 649);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Академическая тошнота:";
            // 
            // waterLabel
            // 
            this.waterLabel.AutoSize = true;
            this.waterLabel.Location = new System.Drawing.Point(47, 613);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(0, 13);
            this.waterLabel.TabIndex = 13;
            // 
            // classicNauseaLabel
            // 
            this.classicNauseaLabel.AutoSize = true;
            this.classicNauseaLabel.Location = new System.Drawing.Point(139, 631);
            this.classicNauseaLabel.Name = "classicNauseaLabel";
            this.classicNauseaLabel.Size = new System.Drawing.Size(0, 13);
            this.classicNauseaLabel.TabIndex = 14;
            // 
            // academicNauseaLabel
            // 
            this.academicNauseaLabel.AutoSize = true;
            this.academicNauseaLabel.Location = new System.Drawing.Point(147, 649);
            this.academicNauseaLabel.Name = "academicNauseaLabel";
            this.academicNauseaLabel.Size = new System.Drawing.Size(0, 13);
            this.academicNauseaLabel.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.textInputGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Семантический анализ";
            this.textInputGroupBox.ResumeLayout(false);
            this.textInputGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueWordsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanticCoreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopWordsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox textInputGroupBox;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RadioButton textBoxInputRadioButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.RadioButton fileInputRadioButton;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label characterCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView wordsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView stopWordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView semanticCoreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView uniqueWordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.Label academicNauseaLabel;
        private System.Windows.Forms.Label classicNauseaLabel;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;

    }
}

