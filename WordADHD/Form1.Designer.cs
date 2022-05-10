namespace WordADHD
{
    partial class Form1
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
            this.lstGuesses = new System.Windows.Forms.ListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.txtWord0 = new System.Windows.Forms.TextBox();
            this.txtWord4 = new System.Windows.Forms.TextBox();
            this.txtWord3 = new System.Windows.Forms.TextBox();
            this.txtWord2 = new System.Windows.Forms.TextBox();
            this.txtWord1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstGuesses
            // 
            this.lstGuesses.FormattingEnabled = true;
            this.lstGuesses.ItemHeight = 16;
            this.lstGuesses.Location = new System.Drawing.Point(448, 108);
            this.lstGuesses.Name = "lstGuesses";
            this.lstGuesses.Size = new System.Drawing.Size(191, 196);
            this.lstGuesses.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(150, 242);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(168, 62);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(265, 335);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(113, 335);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 25);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(150, 200);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(168, 22);
            this.txtGuess.TabIndex = 9;
            // 
            // txtWord0
            // 
            this.txtWord0.Location = new System.Drawing.Point(142, 130);
            this.txtWord0.Name = "txtWord0";
            this.txtWord0.Size = new System.Drawing.Size(32, 22);
            this.txtWord0.TabIndex = 10;
            // 
            // txtWord4
            // 
            this.txtWord4.Location = new System.Drawing.Point(294, 130);
            this.txtWord4.Name = "txtWord4";
            this.txtWord4.Size = new System.Drawing.Size(32, 22);
            this.txtWord4.TabIndex = 11;
            // 
            // txtWord3
            // 
            this.txtWord3.Location = new System.Drawing.Point(256, 130);
            this.txtWord3.Name = "txtWord3";
            this.txtWord3.Size = new System.Drawing.Size(32, 22);
            this.txtWord3.TabIndex = 12;
            // 
            // txtWord2
            // 
            this.txtWord2.Location = new System.Drawing.Point(218, 130);
            this.txtWord2.Name = "txtWord2";
            this.txtWord2.Size = new System.Drawing.Size(32, 22);
            this.txtWord2.TabIndex = 13;
            // 
            // txtWord1
            // 
            this.txtWord1.Location = new System.Drawing.Point(180, 130);
            this.txtWord1.Name = "txtWord1";
            this.txtWord1.Size = new System.Drawing.Size(32, 22);
            this.txtWord1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 391);
            this.Controls.Add(this.txtWord1);
            this.Controls.Add(this.txtWord2);
            this.Controls.Add(this.txtWord3);
            this.Controls.Add(this.txtWord4);
            this.Controls.Add(this.txtWord0);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lstGuesses);
            this.Name = "Form1";
            this.Text = "Wordle 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstGuesses;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.TextBox txtWord0;
        private System.Windows.Forms.TextBox txtWord4;
        private System.Windows.Forms.TextBox txtWord3;
        private System.Windows.Forms.TextBox txtWord2;
        private System.Windows.Forms.TextBox txtWord1;
    }
}

