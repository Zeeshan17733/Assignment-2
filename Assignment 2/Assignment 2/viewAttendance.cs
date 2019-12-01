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
    public partial class viewAttendance : Form
    {
        public viewAttendance()
        {
            InitializeComponent();
        }

        private void viewAttendance_Load(object sender, EventArgs e)
        {
            String[] arrText;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Attendence");
            arrText = File.ReadAllLines("C:/Users/Zeeshan Ali Ch/Desktop/data.txt");
            for (int i = 0; i < arrText.Length; i = i + 7)
            {
                String id = arrText[i];
                String name = arrText[i + 1];
                String attendence = arrText[i + 6];
                dt.Rows.Add(new object[] { id, name, attendence });
            }
            dataGridView1.DataSource = dt;
        }

        private void Ext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform m = new Mainform();
            m.Show();
        }
    }
}
