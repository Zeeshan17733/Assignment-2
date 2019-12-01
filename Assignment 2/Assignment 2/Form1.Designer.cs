namespace Assignment_2
{
    partial class Mainform
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
            this.CSP = new System.Windows.Forms.Button();
            this.SS = new System.Windows.Forms.Button();
            this.DSR = new System.Windows.Forms.Button();
            this.MSA = new System.Windows.Forms.Button();
            this.VA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CSP
            // 
            this.CSP.Location = new System.Drawing.Point(154, 57);
            this.CSP.Name = "CSP";
            this.CSP.Size = new System.Drawing.Size(139, 23);
            this.CSP.TabIndex = 1;
            this.CSP.Text = "Create Student Profile";
            this.CSP.UseVisualStyleBackColor = true;
            this.CSP.Click += new System.EventHandler(this.CSP_Click);
            // 
            // SS
            // 
            this.SS.Location = new System.Drawing.Point(154, 99);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(139, 23);
            this.SS.TabIndex = 2;
            this.SS.Text = "Search Student";
            this.SS.UseVisualStyleBackColor = true;
            this.SS.Click += new System.EventHandler(this.SS_Click);
            // 
            // DSR
            // 
            this.DSR.Location = new System.Drawing.Point(154, 140);
            this.DSR.Name = "DSR";
            this.DSR.Size = new System.Drawing.Size(139, 23);
            this.DSR.TabIndex = 3;
            this.DSR.Text = "Delete Student Record";
            this.DSR.UseVisualStyleBackColor = true;
            this.DSR.Click += new System.EventHandler(this.DSR_Click);
            // 
            // MSA
            // 
            this.MSA.Location = new System.Drawing.Point(154, 183);
            this.MSA.Name = "MSA";
            this.MSA.Size = new System.Drawing.Size(139, 23);
            this.MSA.TabIndex = 4;
            this.MSA.Text = "Mark Student Attendance";
            this.MSA.UseVisualStyleBackColor = true;
            this.MSA.Click += new System.EventHandler(this.MSA_Click);
            // 
            // VA
            // 
            this.VA.Location = new System.Drawing.Point(154, 225);
            this.VA.Name = "VA";
            this.VA.Size = new System.Drawing.Size(139, 23);
            this.VA.TabIndex = 5;
            this.VA.Text = "View Attendance";
            this.VA.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mainform
            // 
            this.ClientSize = new System.Drawing.Size(461, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VA);
            this.Controls.Add(this.MSA);
            this.Controls.Add(this.DSR);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.CSP);
            this.Name = "Mainform";
            this.Text = "Student managemet";
            this.ResumeLayout(false);

        }

        #endregion

        
       
        private System.Windows.Forms.Button CSP;
        private System.Windows.Forms.Button SS;
        private System.Windows.Forms.Button DSR;
        private System.Windows.Forms.Button MSA;
        private System.Windows.Forms.Button VA;
        private System.Windows.Forms.Button button1;
    }
}

