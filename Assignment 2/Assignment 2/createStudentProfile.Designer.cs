namespace Assignment_2
{
    partial class createStudentProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sid = new System.Windows.Forms.TextBox();
            this.Sname = new System.Windows.Forms.TextBox();
            this.Cgpa = new System.Windows.Forms.TextBox();
            this.dep = new System.Windows.Forms.TextBox();
            this.uni = new System.Windows.Forms.TextBox();
            this.sem = new System.Windows.Forms.ComboBox();
            this.BCK = new System.Windows.Forms.Button();
            this.EXT = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CGPA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Depatment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "University";
            // 
            // Sid
            // 
            this.Sid.Location = new System.Drawing.Point(92, 48);
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(121, 20);
            this.Sid.TabIndex = 6;
            // 
            // Sname
            // 
            this.Sname.Location = new System.Drawing.Point(349, 45);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(100, 20);
            this.Sname.TabIndex = 7;
            // 
            // Cgpa
            // 
            this.Cgpa.Location = new System.Drawing.Point(349, 113);
            this.Cgpa.Name = "Cgpa";
            this.Cgpa.Size = new System.Drawing.Size(100, 20);
            this.Cgpa.TabIndex = 9;
            // 
            // dep
            // 
            this.dep.Location = new System.Drawing.Point(92, 179);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(121, 20);
            this.dep.TabIndex = 10;
            // 
            // uni
            // 
            this.uni.Location = new System.Drawing.Point(349, 175);
            this.uni.Name = "uni";
            this.uni.Size = new System.Drawing.Size(100, 20);
            this.uni.TabIndex = 11;
            // 
            // sem
            // 
            this.sem.FormattingEnabled = true;
            this.sem.Items.AddRange(new object[] {
            "First ",
            "Second",
            "Third",
            "Forth",
            "Fifth",
            "Sixth",
            "Seventh",
            "Eighth"});
            this.sem.Location = new System.Drawing.Point(92, 117);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(121, 21);
            this.sem.TabIndex = 12;
            // 
            // BCK
            // 
            this.BCK.Location = new System.Drawing.Point(39, 264);
            this.BCK.Name = "BCK";
            this.BCK.Size = new System.Drawing.Size(75, 23);
            this.BCK.TabIndex = 13;
            this.BCK.Text = "Back";
            this.BCK.UseVisualStyleBackColor = true;
            this.BCK.Click += new System.EventHandler(this.BCK_Click);
            // 
            // EXT
            // 
            this.EXT.Location = new System.Drawing.Point(349, 264);
            this.EXT.Name = "EXT";
            this.EXT.Size = new System.Drawing.Size(75, 23);
            this.EXT.TabIndex = 14;
            this.EXT.Text = "Exit";
            this.EXT.UseVisualStyleBackColor = true;
            this.EXT.Click += new System.EventHandler(this.EXT_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(189, 264);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 15;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // createStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 315);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.EXT);
            this.Controls.Add(this.BCK);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.uni);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.Cgpa);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.Sid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "createStudentProfile";
            this.Text = "createStudentProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Sid;
        private System.Windows.Forms.TextBox Sname;
        private System.Windows.Forms.TextBox Cgpa;
        private System.Windows.Forms.TextBox dep;
        private System.Windows.Forms.TextBox uni;
        private System.Windows.Forms.ComboBox sem;
        private System.Windows.Forms.Button BCK;
        private System.Windows.Forms.Button EXT;
        private System.Windows.Forms.Button Save;
    }
}