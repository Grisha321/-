namespace Шифр_Цезаря
{
    partial class fMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWork = new System.Windows.Forms.Button();
            this.btnReadMe = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(287, 83);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(151, 56);
            this.btnWork.TabIndex = 0;
            this.btnWork.Text = "К работе!";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnReadMe
            // 
            this.btnReadMe.Location = new System.Drawing.Point(287, 202);
            this.btnReadMe.Name = "btnReadMe";
            this.btnReadMe.Size = new System.Drawing.Size(151, 53);
            this.btnReadMe.TabIndex = 1;
            this.btnReadMe.Text = "ReadMe!";
            this.btnReadMe.UseVisualStyleBackColor = true;
            this.btnReadMe.Click += new System.EventHandler(this.btnReadMe_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(287, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadMe);
            this.Controls.Add(this.btnWork);
            this.Name = "fMenu";
            this.Text = "Шифр Цезаря";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnReadMe;
        private System.Windows.Forms.Button btnExit;
    }
}

