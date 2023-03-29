using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3_SH
{
    public partial class Form4_AddLecturer : Form
    {
        private Lecturer lecturer;
        public Form4_AddLecturer()
        {
            InitializeComponent();
        }

        private void BtNextToLab_Click(object sender, EventArgs e)
        {
            Addition();
            Storage.Univer.WorkerAdd();
            Form5_AddLab form = new Form5_AddLab();
            form.Show();
            Hide();
           
        }
       

        private void BTAddMore_Click(object sender, EventArgs e)
        {
            Addition();
            tBLectName.Clear();
            tBSurName.Clear();
            tBLName.Clear();
            maskedTBPassport.Clear();
            nUpDSubj.Value = 0;
            nUpDScWorks.Value = 0;
        }
        public void Addition()
        {
            lecturer = new Lecturer();
            lecturer.ScientificWNum = (int)nUpDScWorks.Value;
            lecturer.SubjNum = (int)nUpDSubj.Value;
            lecturer.PIB = $"{ tBLectName.Text} {tBSurName.Text} {tBLName.Text}";
            lecturer.Passport = maskedTBPassport.Text;

            if (maskedTBPassport.Text != "" && !MyValidate.IsInteger(lecturer.PIB))
            {
                Storage.Univer.AddLecturer(lecturer);
               
            }
            else
                MessageBox.Show("Incorrect input!");
        }
    }
}
