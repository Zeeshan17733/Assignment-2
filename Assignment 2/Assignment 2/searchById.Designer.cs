namespace Assignment_2
{
    partial class searchById
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
            this.sbn = new System.Windows.Forms.TextBox();
            this.Bck = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.Ext = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Student";
            // 
            // sbn
            // 
            this.sbn.Location = new System.Drawing.Point(114, 24);
            this.sbn.Name = "sbn";
            this.sbn.Size = new System.Drawing.Size(100, 20);
            this.sbn.TabIndex = 1;
            // 
            // Bck
            // 
            this.Bck.Location = new System.Drawing.Point(12, 226);
            this.Bck.Name = "Bck";
            this.Bck.Size = new System.Drawing.Size(75, 23);
            this.Bck.TabIndex = 2;
            this.Bck.Text = "Back";
            this.Bck.UseVisualStyleBackColor = true;
            this.Bck.Click += new System.EventHandler(this.Bck_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(104, 226);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Ext
            // 
            this.Ext.Location = new System.Drawing.Point(197, 226);
            this.Ext.Name = "Ext";
            this.Ext.Size = new System.Drawing.Size(75, 23);
            this.Ext.TabIndex = 4;
            this.Ext.Text = "Exit";
            this.Ext.UseVisualStyleBackColor = true;
            this.Ext.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(104, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(139, 153);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // searchById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Ext);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Bck);
            this.Controls.Add(this.sbn);
            this.Controls.Add(this.label1);
            this.Name = "searchById";
            this.Text = "searchById";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sbn;
        private System.Windows.Forms.Button Bck;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button Ext;
        private System.Windows.Forms.ListView listView1;
    }
}