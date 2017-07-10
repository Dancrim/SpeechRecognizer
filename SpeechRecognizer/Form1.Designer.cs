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
            this.ucSpeechTranslator1 = new UCSpeechTranslator.UCSpeechTranslator();
            this.SuspendLayout();
            // 
            // ucSpeechTranslator1
            // 
            this.ucSpeechTranslator1.Location = new System.Drawing.Point(64, 52);
            this.ucSpeechTranslator1.Name = "ucSpeechTranslator1";
            this.ucSpeechTranslator1.Size = new System.Drawing.Size(142, 90);
            this.ucSpeechTranslator1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ucSpeechTranslator1);
            this.Name = "MainForm";
            this.Text = "SpeechRecognizer";
            this.ResumeLayout(false);

        }

        #endregion

        private UCSpeechTranslator.UCSpeechTranslator ucSpeechTranslator1;
    }
}

