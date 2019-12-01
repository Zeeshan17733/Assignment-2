namespace Assignment_2
{
    partial class searchStudent
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
            this.sbi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BCK = new System.Windows.Forms.Button();
            this.EXT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sbi
            // 
            this.sbi.Location = new System.Drawing.Point(201, 55);
            this.sbi.Name = "sbi";
            this.sbi.Size = new System.Drawing.Size(98, 23);
            this.sbi.TabIndex = 0;
            this.sbi.Text = " Search By ID";
            this.sbi.UseVisualStyleBackColor = true;
            this.sbi.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search By Name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BCK
            // 
            this.BCK.Location = new System.Drawing.Point(30, 267);
            this.BCK.Name = "BCK";
            this.BCK.Size = new System.Drawing.Size(75, 23);
            this.BCK.TabIndex = 3;
            this.BCK.Text = "Back";
            this.BCK.UseVisualStyleBackColor = true;
            this.BCK.Click += new System.EventHandler(this.BCK_Click);
            // 
            // EXT
            // 
            this.EXT.Location = new System.Drawing.Point(346, 267);
            this.EXT.Name = "EXT";
            this.EXT.Size = new System.Drawing.Size(75, 23);
            this.EXT.TabIndex = 4;
            this.EXT.Text = "Exit";
            this.EXT.UseVisualStyleBackColor = true;
            this.EXT.Click += new System.EventHandler(this.EXT_Click);
            // 
            // searchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 315);
            this.Controls.Add(this.EXT);
            this.Controls.Add(this.BCK);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sbi);
            this.Name = "searchStudent";
            this.Text = "searchStudent";
            this.Load += new System.EventHandler(this.searchStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sbi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BCK;
        private System.Windows.Forms.Button EXT;
    }
}