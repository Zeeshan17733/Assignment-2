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
    public partial class markAttendance : Form
    {
        public markAttendance()
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
            Mainform f = new Mainform();
            f.Show();
        }
    }
}
