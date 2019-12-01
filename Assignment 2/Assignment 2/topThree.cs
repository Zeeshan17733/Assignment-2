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
    public partial class topThree : Form
    {
        public topThree()
        {
            InitializeComponent();
         
        }

        private void bck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform m = new Mainform();
            m.Show();
        }

        private void Ext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void topThree_Load(object sender, EventArgs e)
        {
            int count = File.ReadLines("C:/Users/Zeeshan Ali Ch/Desktop/data.txt").Count();
            string[] lines = File.ReadAllLines("C:/Users/Zeeshan Ali Ch/Desktop/data.txt");
            string[] names = new string[count / 7];
            string[] IDs = new string[count / 7];
            double[] cgpas = new double[count / 7];
            int j = 0;
            for (int i = 0; i < count; i += 7)
            {
                cgpas[j] = Convert.ToDouble(lines[i + 3]);
                names[j] = lines[i + 1];
                IDs[j] = lines[i];
                j++;
            }
            for (int i = 0; i < count / 7; i++)
            {
                for (int k = 0; k < (count / 7) - 1; k++)
                {
                    if (cgpas[k] < cgpas[k + 1])
                    {
                        double temp; string temp1; string temp2;
                        temp = cgpas[k]; temp1 = names[k]; temp2 = IDs[k];
                        cgpas[k] = cgpas[k + 1]; names[k] = names[k + 1]; IDs[k] = IDs[k + 1];
                        cgpas[k + 1] = temp; names[k + 1] = temp1; IDs[k + 1] = temp2;
                    }
                }
            }
            label7.Text = names[0];
            label9.Text = Convert.ToString(cgpas[0]);
            label10.Text = IDs[1];
            label11.Text = names[1];
            label17.Text = Convert.ToString(cgpas[1]);
            label18.Text = IDs[2];
            label19.Text = names[2];
            label20.Text = Convert.ToString(cgpas[2]);
        }
        }
    }

