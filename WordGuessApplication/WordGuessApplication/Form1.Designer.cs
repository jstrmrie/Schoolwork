namespace WordGuessApplication
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
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblWordToGuess = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblWrongGuess = new System.Windows.Forms.Label();
            this.lstWrongGuesses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(60, 91);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(260, 29);
            this.txtGuess.TabIndex = 0;
            // 
            // lblWordToGuess
            // 
            this.lblWordToGuess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblWordToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordToGuess.ForeColor = System.Drawing.Color.White;
            this.lblWordToGuess.Location = new System.Drawing.Point(12, 12);
            this.lblWordToGuess.Name = "lblWordToGuess";
            this.lblWordToGuess.Size = new System.Drawing.Size(360, 70);
            this.lblWordToGuess.TabIndex = 1;
            this.lblWordToGuess.Text = "c??????r";
            this.lblWordToGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.Color.White;
            this.btnGuess.Location = new System.Drawing.Point(130, 125);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(120, 30);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWrongGuess
            // 
            this.lblWrongGuess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblWrongGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongGuess.ForeColor = System.Drawing.Color.White;
            this.lblWrongGuess.Location = new System.Drawing.Point(378, 12);
            this.lblWrongGuess.Name = "lblWrongGuess";
            this.lblWrongGuess.Size = new System.Drawing.Size(150, 25);
            this.lblWrongGuess.TabIndex = 3;
            this.lblWrongGuess.Text = "Wrong Guess";
            this.lblWrongGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstWrongGuesses
            // 
            this.lstWrongGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWrongGuesses.FormattingEnabled = true;
            this.lstWrongGuesses.ItemHeight = 15;
            this.lstWrongGuesses.Location = new System.Drawing.Point(379, 41);
            this.lstWrongGuesses.Name = "lstWrongGuesses";
            this.lstWrongGuesses.Size = new System.Drawing.Size(149, 109);
            this.lstWrongGuesses.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 171);
            this.Controls.Add(this.lstWrongGuesses);
            this.Controls.Add(this.lblWrongGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblWordToGuess);
            this.Controls.Add(this.txtGuess);
            this.Name = "Form1";
            this.Text = "Guess The Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblWordToGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblWrongGuess;
        private System.Windows.Forms.ListBox lstWrongGuesses;
    }
}

