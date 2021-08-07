using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObtMarkofSE_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblGrade_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ComputerArchitecture = 0;
            int SoftwareEngineering = 0;
            int DataStructure = 0;
            int English = 0;
            int DataBase = 0;
            int OperationResearch = 0;
            int totalMarks = 0;
            double percentage = 0;
            ComputerArchitecture = Convert.ToInt32(txtObtMarkofCA.Text);
            SoftwareEngineering = Convert.ToInt32(txtObtMarkofSE.Text);
            DataStructure = Convert.ToInt32(txtObtMarkofDS.Text);
            English = Convert.ToInt32(txtObtMarkofEng.Text);
            DataBase = Convert.ToInt32(txtObtMarkofDB.Text);
            OperationResearch = Convert.ToInt32(txtObtMarkofOR.Text);
            totalMarks = ComputerArchitecture + SoftwareEngineering + DataStructure + English + DataBase + OperationResearch;
            lblTotal.Text = totalMarks.ToString();
            percentage = totalMarks / 300.0 * 100;
            lblPercentage.Text = string.Format("{0:F2}%", percentage);
            if (percentage > 80)
            {
                lblGrade.Text = "A1";
            }
            else if (percentage > 70)
            {
                lblGrade.Text = "A";
            }
            else if (percentage > 60)
            {
                lblGrade.Text = "B";
            }
            else if (percentage > 50)
            {
                lblGrade.Text = "C";
            }
            else if (percentage > 40)
            {
                lblGrade.Text = "Fail";
            }

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void lblFatherName_Click(object sender, EventArgs e)
        {

        }
    }
}
