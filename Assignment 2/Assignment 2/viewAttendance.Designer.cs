namespace Assignment_2
{
    partial class viewAttendance
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bck = new System.Windows.Forms.Button();
            this.Ext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // Bck
            // 
            this.Bck.Location = new System.Drawing.Point(12, 226);
            this.Bck.Name = "Bck";
            this.Bck.Size = new System.Drawing.Size(75, 23);
            this.Bck.TabIndex = 1;
            this.Bck.Text = "Back";
            this.Bck.UseVisualStyleBackColor = true;
            this.Bck.Click += new System.EventHandler(this.Bck_Click);
            // 
            // Ext
            // 
            this.Ext.Location = new System.Drawing.Point(177, 226);
            this.Ext.Name = "Ext";
            this.Ext.Size = new System.Drawing.Size(75, 23);
            this.Ext.TabIndex = 2;
            this.Ext.Text = "Exit";
            this.Ext.UseVisualStyleBackColor = true;
            this.Ext.Click += new System.EventHandler(this.Ext_Click);
            // 
            // viewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Ext);
            this.Controls.Add(this.Bck);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewAttendance";
            this.Text = "viewAttendance";
            this.Load += new System.EventHandler(this.viewAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bck;
        private System.Windows.Forms.Button Ext;
    }
}