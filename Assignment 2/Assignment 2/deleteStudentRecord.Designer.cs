namespace Assignment_2
{
    partial class deleteStudentRecord
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
            this.BCK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Id";
            // 
            // BCK
            // 
            this.BCK.Location = new System.Drawing.Point(21, 265);
            this.BCK.Name = "BCK";
            this.BCK.Size = new System.Drawing.Size(75, 23);
            this.BCK.TabIndex = 1;
            this.BCK.Text = "Back";
            this.BCK.UseVisualStyleBackColor = true;
            this.BCK.Click += new System.EventHandler(this.BCK_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Ext
            // 
            this.Ext.Location = new System.Drawing.Point(336, 265);
            this.Ext.Name = "Ext";
            this.Ext.Size = new System.Drawing.Size(75, 23);
            this.Ext.TabIndex = 3;
            this.Ext.Text = "Exit";
            this.Ext.UseVisualStyleBackColor = true;
            this.Ext.Click += new System.EventHandler(this.Ext_Click);
            // 
            // deleteStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 315);
            this.Controls.Add(this.Ext);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BCK);
            this.Controls.Add(this.label1);
            this.Name = "deleteStudentRecord";
            this.Text = "deleteStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BCK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Ext;
    }
}