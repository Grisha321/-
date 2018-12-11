namespace Шифр_Цезаря
{
    partial class fWork
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
            this.tbOriginalText = new System.Windows.Forms.TextBox();
            this.tbResultText = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStepBack = new System.Windows.Forms.Button();
            this.btnLoadText = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbKey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStepUp = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // tbOriginalText
            // 
            this.tbOriginalText.Location = new System.Drawing.Point(12, 12);
            this.tbOriginalText.Multiline = true;
            this.tbOriginalText.Name = "tbOriginalText";
            this.tbOriginalText.Size = new System.Drawing.Size(697, 562);
            this.tbOriginalText.TabIndex = 0;
            this.tbOriginalText.Text = "Исходный текст";
            // 
            // tbResultText
            // 
            this.tbResultText.Location = new System.Drawing.Point(815, 12);
            this.tbResultText.Multiline = true;
            this.tbResultText.Name = "tbResultText";
            this.tbResultText.Size = new System.Drawing.Size(697, 562);
            this.tbResultText.TabIndex = 1;
            this.tbResultText.Text = "Результат работы";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1437, 664);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Завершить ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStepBack
            // 
            this.btnStepBack.Location = new System.Drawing.Point(736, 632);
            this.btnStepBack.Name = "btnStepBack";
            this.btnStepBack.Size = new System.Drawing.Size(75, 23);
            this.btnStepBack.TabIndex = 4;
            this.btnStepBack.Text = "Шаг назад";
            this.btnStepBack.UseVisualStyleBackColor = true;
            this.btnStepBack.Click += new System.EventHandler(this.btnStepBack_Click);
            // 
            // btnLoadText
            // 
            this.btnLoadText.Location = new System.Drawing.Point(12, 606);
            this.btnLoadText.Name = "btnLoadText";
            this.btnLoadText.Size = new System.Drawing.Size(134, 23);
            this.btnLoadText.TabIndex = 6;
            this.btnLoadText.Text = "загрузить текст ";
            this.btnLoadText.UseVisualStyleBackColor = true;
            this.btnLoadText.Click += new System.EventHandler(this.btnLoadText_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files|*.txt|docx files|*.docx";
            this.openFileDialog1.FilterIndex = 2;
            // 
            // cbKey
            // 
            this.cbKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKey.FormattingEnabled = true;
            this.cbKey.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33"});
            this.cbKey.Location = new System.Drawing.Point(490, 606);
            this.cbKey.Name = "cbKey";
            this.cbKey.Size = new System.Drawing.Size(121, 21);
            this.cbKey.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "размер шага";
            // 
            // btnStepUp
            // 
            this.btnStepUp.Location = new System.Drawing.Point(736, 587);
            this.btnStepUp.Name = "btnStepUp";
            this.btnStepUp.Size = new System.Drawing.Size(75, 23);
            this.btnStepUp.TabIndex = 9;
            this.btnStepUp.Text = "Шаг вперед";
            this.btnStepUp.UseVisualStyleBackColor = true;
            this.btnStepUp.Click += new System.EventHandler(this.btnStepUp_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(1287, 609);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 10;
            this.btnSaveAs.Text = "Сохранить ";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "txt files|*.txt|docx files|*.docx";
            this.saveFileDialog1.FilterIndex = 2;
            // 
            // fWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 702);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnStepUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKey);
            this.Controls.Add(this.btnLoadText);
            this.Controls.Add(this.btnStepBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbResultText);
            this.Controls.Add(this.tbOriginalText);
            this.Name = "fWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbResultText;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStepBack;
        public System.Windows.Forms.Button btnLoadText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox tbOriginalText;
        private System.Windows.Forms.ComboBox cbKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStepUp;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}