namespace SpeechRecognizer
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.userControl11 = new UCSpeechTranslator.UserControl1();
            this.bOpenFile1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bOpenFile
            // 
            this.bOpenFile.Location = new System.Drawing.Point(0, 0);
            this.bOpenFile.Name = "bOpenFile";
            this.bOpenFile.Size = new System.Drawing.Size(75, 23);
            this.bOpenFile.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 48);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(442, 104);
            this.userControl11.TabIndex = 0;
            // 
            // bOpenFile1
            // 
            this.bOpenFile1.Location = new System.Drawing.Point(17, 21);
            this.bOpenFile1.Name = "bOpenFile1";
            this.bOpenFile1.Size = new System.Drawing.Size(75, 23);
            this.bOpenFile1.TabIndex = 1;
            this.bOpenFile1.Text = "Open File";
            this.bOpenFile1.UseVisualStyleBackColor = true;
            this.bOpenFile1.Click += new System.EventHandler(this.bOpenFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(498, 157);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bOpenFile1);
            this.Controls.Add(this.userControl11);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
      
        private System.Windows.Forms.Button bOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private UCSpeechTranslator.UserControl1 userControl11;
        private System.Windows.Forms.Button bOpenFile1;
        private System.Windows.Forms.Button button1;
    }
}

