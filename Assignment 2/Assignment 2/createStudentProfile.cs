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
    public partial class createStudentProfile : Form
    {

        public createStudentProfile()
        {
            InitializeComponent();
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

        private void Save_Click(object sender, EventArgs e)
        {
            string name, id, dept, university, semester, status, cgpa;
            string[] all = File.ReadAllLines("C:/Users/Zeeshan Ali Ch/Desktop/data.txt");
            for (int i = 0; i < all.Length; i = i + 7)
            {
                if (all[i] == Sid.Text)
                {
                    //Console.WriteLine("Id already exists");
                }
                else
                {


                    name = Sname.Text;
                    id = Sid.Text;
                    dept = dep.Text;
                    university = uni.Text;
                    semester = sem.Text;
                    cgpa = Cgpa.Text;
                    status = "NA";
                    using (StreamWriter s = File.AppendText("C://Users//Zeeshan Ali Ch//Desktop//data.txt"))
                    {
                        s.WriteLine(id);
                        s.WriteLine(name);
                        s.WriteLine(sem);
                        s.WriteLine(Cgpa);
                        s.WriteLine(dep);
                        s.WriteLine(uni);
                        s.WriteLine(status);
                    }
                }
            }

        }

    }
}
