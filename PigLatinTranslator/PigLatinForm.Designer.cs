namespace PigLatinTranslator
{
    partial class PigLatinForm
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
            this.UserInputBox = new System.Windows.Forms.TextBox();
            this.TranslationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TranslateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TranslatedWordsBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wordToTranslateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserInputBox
            // 
            this.UserInputBox.Location = new System.Drawing.Point(187, 52);
            this.UserInputBox.Name = "UserInputBox";
            this.UserInputBox.Size = new System.Drawing.Size(276, 20);
            this.UserInputBox.TabIndex = 0;
            // 
            // TranslationBox
            // 
            this.TranslationBox.Location = new System.Drawing.Point(187, 161);
            this.TranslationBox.Name = "TranslationBox";
            this.TranslationBox.Size = new System.Drawing.Size(276, 20);
            this.TranslationBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the sentence:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "The pig latin equivalent of:";
            // 
            // TranslateButton
            // 
            this.TranslateButton.Location = new System.Drawing.Point(35, 393);
            this.TranslateButton.Name = "TranslateButton";
            this.TranslateButton.Size = new System.Drawing.Size(75, 23);
            this.TranslateButton.TabIndex = 4;
            this.TranslateButton.Text = "Translate";
            this.TranslateButton.UseVisualStyleBackColor = true;
            this.TranslateButton.Click += new System.EventHandler(this.TranslateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(212, 393);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(388, 393);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "All words translated top pig Latin so far:";
            // 
            // TranslatedWordsBox
            // 
            this.TranslatedWordsBox.Location = new System.Drawing.Point(35, 282);
            this.TranslatedWordsBox.Name = "TranslatedWordsBox";
            this.TranslatedWordsBox.Size = new System.Drawing.Size(428, 79);
            this.TranslatedWordsBox.TabIndex = 8;
            this.TranslatedWordsBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "is:";
            // 
            // wordToTranslateBox
            // 
            this.wordToTranslateBox.Location = new System.Drawing.Point(187, 113);
            this.wordToTranslateBox.Name = "wordToTranslateBox";
            this.wordToTranslateBox.Size = new System.Drawing.Size(276, 20);
            this.wordToTranslateBox.TabIndex = 10;
            // 
            // PigLatinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 442);
            this.Controls.Add(this.wordToTranslateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TranslatedWordsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TranslateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TranslationBox);
            this.Controls.Add(this.UserInputBox);
            this.Name = "PigLatinForm";
            this.Text = "Pig Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputBox;
        private System.Windows.Forms.TextBox TranslationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TranslateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TranslatedWordsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox wordToTranslateBox;
    }
}

