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
            this.SuspendLayout();
            // 
            // bOpenFile
            // 
            this.bOpenFile.Location = new System.Drawing.Point(6, 3);
            this.bOpenFile.Name = "bOpenFile";
            this.bOpenFile.Size = new System.Drawing.Size(75, 23);
            this.bOpenFile.TabIndex = 1;
            this.bOpenFile.Text = "Open File";
            this.bOpenFile.UseVisualStyleBackColor = true;
            this.bOpenFile.Click += new System.EventHandler(this.bOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(393, 312);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
      
        private System.Windows.Forms.Button bOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

