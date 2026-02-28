namespace StudentGradeApplication
{
    partial class frmStudentGradeProgram
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_english = new System.Windows.Forms.Label();
            this.lbl_math = new System.Windows.Forms.Label();
            this.lbl_science = new System.Windows.Forms.Label();
            this.lbl_filipino = new System.Windows.Forms.Label();
            this.lbl_history = new System.Windows.Forms.Label();
            this.lbl_grades = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_english = new System.Windows.Forms.TextBox();
            this.tb_math = new System.Windows.Forms.TextBox();
            this.tb_science = new System.Windows.Forms.TextBox();
            this.tb_filipino = new System.Windows.Forms.TextBox();
            this.tb_history = new System.Windows.Forms.TextBox();
            this.btn_average = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_header.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(43, 20);
            this.lbl_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(363, 37);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Student Grade Calculator";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(18, 79);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(123, 34);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_english
            // 
            this.lbl_english.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_english.Location = new System.Drawing.Point(18, 166);
            this.lbl_english.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_english.Name = "lbl_english";
            this.lbl_english.Size = new System.Drawing.Size(123, 34);
            this.lbl_english.TabIndex = 1;
            this.lbl_english.Text = "English:";
            // 
            // lbl_math
            // 
            this.lbl_math.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_math.Location = new System.Drawing.Point(18, 207);
            this.lbl_math.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_math.Name = "lbl_math";
            this.lbl_math.Size = new System.Drawing.Size(123, 34);
            this.lbl_math.TabIndex = 1;
            this.lbl_math.Text = "Math:";
            // 
            // lbl_science
            // 
            this.lbl_science.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_science.Location = new System.Drawing.Point(18, 248);
            this.lbl_science.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_science.Name = "lbl_science";
            this.lbl_science.Size = new System.Drawing.Size(123, 34);
            this.lbl_science.TabIndex = 1;
            this.lbl_science.Text = "Science:";
            // 
            // lbl_filipino
            // 
            this.lbl_filipino.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filipino.Location = new System.Drawing.Point(18, 289);
            this.lbl_filipino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_filipino.Name = "lbl_filipino";
            this.lbl_filipino.Size = new System.Drawing.Size(123, 34);
            this.lbl_filipino.TabIndex = 1;
            this.lbl_filipino.Text = "Filipino:";
            // 
            // lbl_history
            // 
            this.lbl_history.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_history.Location = new System.Drawing.Point(18, 330);
            this.lbl_history.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_history.Name = "lbl_history";
            this.lbl_history.Size = new System.Drawing.Size(123, 34);
            this.lbl_history.TabIndex = 1;
            this.lbl_history.Text = "History:";
            // 
            // lbl_grades
            // 
            this.lbl_grades.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grades.Location = new System.Drawing.Point(115, 134);
            this.lbl_grades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_grades.Name = "lbl_grades";
            this.lbl_grades.Size = new System.Drawing.Size(123, 34);
            this.lbl_grades.TabIndex = 1;
            this.lbl_grades.Text = "Grades:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(89, 76);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(332, 26);
            this.tb_name.TabIndex = 2;
            // 
            // tb_english
            // 
            this.tb_english.Location = new System.Drawing.Point(89, 163);
            this.tb_english.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_english.Name = "tb_english";
            this.tb_english.Size = new System.Drawing.Size(115, 26);
            this.tb_english.TabIndex = 2;
            // 
            // tb_math
            // 
            this.tb_math.Location = new System.Drawing.Point(89, 204);
            this.tb_math.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_math.Name = "tb_math";
            this.tb_math.Size = new System.Drawing.Size(115, 26);
            this.tb_math.TabIndex = 2;
            // 
            // tb_science
            // 
            this.tb_science.Location = new System.Drawing.Point(89, 245);
            this.tb_science.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_science.Name = "tb_science";
            this.tb_science.Size = new System.Drawing.Size(115, 26);
            this.tb_science.TabIndex = 2;
            // 
            // tb_filipino
            // 
            this.tb_filipino.Location = new System.Drawing.Point(89, 286);
            this.tb_filipino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_filipino.Name = "tb_filipino";
            this.tb_filipino.Size = new System.Drawing.Size(115, 26);
            this.tb_filipino.TabIndex = 2;
            // 
            // tb_history
            // 
            this.tb_history.Location = new System.Drawing.Point(89, 327);
            this.tb_history.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_history.Name = "tb_history";
            this.tb_history.Size = new System.Drawing.Size(115, 26);
            this.tb_history.TabIndex = 2;
            // 
            // btn_average
            // 
            this.btn_average.BackColor = System.Drawing.Color.Gray;
            this.btn_average.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_average.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_average.Location = new System.Drawing.Point(32, 368);
            this.btn_average.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_average.Name = "btn_average";
            this.btn_average.Size = new System.Drawing.Size(150, 80);
            this.btn_average.TabIndex = 3;
            this.btn_average.Text = "Generate Average";
            this.btn_average.UseVisualStyleBackColor = false;
            this.btn_average.Click += new System.EventHandler(this.btn_average_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(212, 144);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(239, 209);
            this.lbl_message.TabIndex = 4;
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStudentGradeProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 481);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_average);
            this.Controls.Add(this.tb_history);
            this.Controls.Add(this.tb_filipino);
            this.Controls.Add(this.tb_science);
            this.Controls.Add(this.tb_math);
            this.Controls.Add(this.tb_english);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_grades);
            this.Controls.Add(this.lbl_history);
            this.Controls.Add(this.lbl_filipino);
            this.Controls.Add(this.lbl_science);
            this.Controls.Add(this.lbl_math);
            this.Controls.Add(this.lbl_english);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_header);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStudentGradeProgram";
            this.Text = "Student Grade Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_english;
        private System.Windows.Forms.Label lbl_math;
        private System.Windows.Forms.Label lbl_science;
        private System.Windows.Forms.Label lbl_filipino;
        private System.Windows.Forms.Label lbl_history;
        private System.Windows.Forms.Label lbl_grades;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_english;
        private System.Windows.Forms.TextBox tb_math;
        private System.Windows.Forms.TextBox tb_science;
        private System.Windows.Forms.TextBox tb_filipino;
        private System.Windows.Forms.TextBox tb_history;
        private System.Windows.Forms.Button btn_average;
        private System.Windows.Forms.Label lbl_message;
    }
}

