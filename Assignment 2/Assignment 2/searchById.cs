﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Assignment_2
{
    public partial class searchById : Form
    {
        public searchById()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bck_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchStudent s = new searchStudent();
            s.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string[] all = File.ReadAllLines("C:/Users/Zeeshan Ali Ch/Desktop/data.txt");
            try
            {
                for (int i = 0; i <= all.Length; i = i + 7)
                {
                    if (all[i] == sbn.Text)
                    {
                        listView1.Items.Add(all[i]);
                        listView1.Items.Add(all[i+1]);
                        listView1.Items.Add(all[i+2]);
                        listView1.Items.Add(all[i+3]);
                        listView1.Items.Add(all[i+4]);
                        listView1.Items.Add(all[i+5]);

                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Record not found");
            }

        }
    }
}
