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
    public partial class mark : Form
    {
        public mark()
        {
            InitializeComponent();
        }

        private void mark_Load(object sender, EventArgs e)
        {
            String[] arrText;
            String attendence;
            int coloumn = 40;
            arrText = File.ReadAllLines("D:/Uni/BSE-5/VP/Assignments/AssignmentTwoData.txt");
            int totalLabels = arrText.Length / 7;
            int totalRadioButtons = (arrText.Length / 7) * 2;
            Label[] labels = new Label[totalLabels];
            RadioButton[] rButtons = new RadioButton[totalRadioButtons];
            //for (int i = 0; i < arrText.Length; i = i + 7)
            //{

            //}
            for (int i = 0; i < arrText.Length; i = i + 7)
            {
                Label l = new Label();
                l.AutoSize = true;
                l.Location = new Point(156, coloumn);
                l.Text = arrText[i + 1];
                l.Font = new Font("Berlin Sans FB", 12);

                this.Controls.Add(l);

                RadioButton r1 = new RadioButton();
                r1.AutoSize = true;
                r1.Text = "Present";
                r1.Location = new Point(300, coloumn);
                r1.Font = new Font("Berlin Sans FB", 12);

                this.Controls.Add(r1);

                RadioButton r2 = new RadioButton();
                r2.AutoSize = true;
                r2.Text = "Absent";
                r2.Location = new Point(400, coloumn);
                r2.Font = new Font("Berlin Sans FB", 12);
                // Adding this label to the form 
                this.Controls.Add(r2);
                coloumn = coloumn + 40;
            }
        }
    }
}
