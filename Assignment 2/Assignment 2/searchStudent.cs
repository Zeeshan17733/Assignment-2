using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class searchStudent : Form
    {
        
        public searchStudent()
        {
            
            InitializeComponent();
        }

        private void searchStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void EXT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BCK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform f = new Mainform();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchById d = new searchById();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
