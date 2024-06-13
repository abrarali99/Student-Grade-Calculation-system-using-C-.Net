using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentgrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double english, maths, science, tot,avg;
        string grade;

        private void button1_Click(object sender, EventArgs e)
        {
            english=int.Parse(textBox2.Text);
            maths=int.Parse(textBox3.Text);
            science=int.Parse(textBox4.Text);
            tot=english+maths+science;
            avg = tot / 3;

            textBox5.Text= avg.ToString();

            if (avg > 90)
            {
                grade = "A";

            }
            else if (avg > 75 && avg < 89)
            {
                grade = "B+";

            }
            else if (avg > 65 && avg < 74)
            {
                grade = "c+";

            }
            else if (avg > 60 && avg < 64)
            {
                grade = "c";

            }
            else 
            {
                grade = "f";

            }

            textBox6.Text = grade;




        }
    }
}
