using System;
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
    public partial class deleteStudentRecord : Form
    {
        public deleteStudentRecord()
        {
            InitializeComponent();
        }

        private void Ext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BCK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform c = new Mainform();
            c.Show();
        }

        private void del_Click(object sender, EventArgs e)
        {
            string[] all = File.ReadAllLines("C:/Users/Zeeshan Ali Ch/Desktop/data.txt");
                bool found = false;
                string[] str = new string[all.Length];
                for (int i = 0; i < all.Length - 2; i = i + 7)
                {

                    if (all[i] == textBox1.Text)
                    {
                        found = true;
                        i = i + 7;
                        MessageBox.Show("Deleted");
                        //return"Deleted successfully";
                    }
                    for (int j = i; j < 7; j++)
                    {
                        str[j] = all[j];
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("not Deleted");
                    //return "Profile not Found";
                }
                File.WriteAllLines("C:\\Users\\Zeeshan Ali Ch\\Desktop\\data.txt", str);
            }

        }
    }

