namespace Assignment_2
{
    partial class searchAll
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ext = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.Bck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(104, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(139, 153);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Ext
            // 
            this.Ext.Location = new System.Drawing.Point(197, 198);
            this.Ext.Name = "Ext";
            this.Ext.Size = new System.Drawing.Size(75, 23);
            this.Ext.TabIndex = 8;
            this.Ext.Text = "Exit";
            this.Ext.UseVisualStyleBackColor = true;
            this.Ext.Click += new System.EventHandler(this.Ext_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(104, 198);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 7;
            this.search.Text = "List";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Bck
            // 
            this.Bck.Location = new System.Drawing.Point(12, 198);
            this.Bck.Name = "Bck";
            this.Bck.Size = new System.Drawing.Size(75, 23);
            this.Bck.TabIndex = 6;
            this.Bck.Text = "Back";
            this.Bck.UseVisualStyleBackColor = true;
            this.Bck.Click += new System.EventHandler(this.Bck_Click);
            // 
            // searchAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Ext);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Bck);
            this.Name = "searchAll";
            this.Text = "searchAll";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Ext;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button Bck;
    }
}