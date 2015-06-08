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
            this.fileInputRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.textBoxInputRadioButton = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.characterCountLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textInputGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textInputGroupBox
            // 
            this.textInputGroupBox.Controls.Add(this.richTextBox1);
            this.textInputGroupBox.Controls.Add(this.textBoxInputRadioButton);
            this.textInputGroupBox.Controls.Add(this.fileNameLabel);
            this.textInputGroupBox.Controls.Add(this.button1);
            this.textInputGroupBox.Controls.Add(this.fileInputRadioButton);
            this.textInputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.textInputGroupBox.Name = "textInputGroupBox";
            this.textInputGroupBox.Size = new System.Drawing.Size(431, 161);
            this.textInputGroupBox.TabIndex = 0;
            this.textInputGroupBox.TabStop = false;
            this.textInputGroupBox.Text = "Ввод текста";
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(170, 21);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 13);
            this.fileNameLabel.TabIndex = 2;
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
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(399, 110);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(12, 179);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(431, 30);
            this.analyzeButton.TabIndex = 1;
            this.analyzeButton.Text = "Анализировать";
            this.analyzeButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.characterCountLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результаты анализа";
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
            // characterCountLabel
            // 
            this.characterCountLabel.AutoSize = true;
            this.characterCountLabel.Location = new System.Drawing.Point(134, 25);
            this.characterCountLabel.Name = "characterCountLabel";
            this.characterCountLabel.Size = new System.Drawing.Size(0, 13);
            this.characterCountLabel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 471);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox textInputGroupBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton textBoxInputRadioButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton fileInputRadioButton;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label characterCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}

