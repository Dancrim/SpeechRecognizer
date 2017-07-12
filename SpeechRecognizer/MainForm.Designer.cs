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
            this.bOpenFile1 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ucSpeechRecognizer = new UCSpeechTranslator.UCSpeechRecognizer();
            this.SuspendLayout();
            // 
            // bOpenFile
            // 
            this.bOpenFile.Location = new System.Drawing.Point(0, 0);
            this.bOpenFile.Name = "bOpenFile";
            this.bOpenFile.Size = new System.Drawing.Size(75, 23);
            this.bOpenFile.TabIndex = 0;
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
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(98, 21);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ucSpeechRecognizer
            // 
            this.ucSpeechRecognizer.AudioFile = "Путь: ";
            this.ucSpeechRecognizer.Location = new System.Drawing.Point(12, 50);
            this.ucSpeechRecognizer.Name = "ucSpeechRecognizer";
            this.ucSpeechRecognizer.Size = new System.Drawing.Size(565, 259);
            this.ucSpeechRecognizer.TabIndex = 3;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(607, 345);
            this.Controls.Add(this.ucSpeechRecognizer);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.bOpenFile1);
            this.Name = "MainForm";
            this.Text = "SpeechRecognizer";
            this.ResumeLayout(false);

        }

        #endregion
      
        private System.Windows.Forms.Button bOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private UCSpeechTranslator.UCSpeechRecognizer UCSpeechTranslator;
        private System.Windows.Forms.Button bOpenFile1;
        private System.Windows.Forms.Button ExitButton;
        private UCSpeechTranslator.UCSpeechRecognizer ucSpeechRecognizer;
    }
}

