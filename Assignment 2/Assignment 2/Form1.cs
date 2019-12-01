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
    public partial class Mainform : Form
    {
        
        public Mainform()
        {
            InitializeComponent();
        }

       
        private void CSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            createStudentProfile c = new createStudentProfile();
            c.Closed += (s, args) => this.Close(); 
            c.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SS_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchStudent s = new searchStudent();
            s.Show();
        }

        private void DSR_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteStudentRecord d = new deleteStudentRecord();
            d.Show();
        }

        private void MSA_Click(object sender, EventArgs e)
        {
            this.Hide();
            markAttendance m = new markAttendance();
            m.Show();

        }

        
    }
}
