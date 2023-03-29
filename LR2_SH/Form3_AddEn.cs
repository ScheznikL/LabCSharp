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
    public partial class Form3_AddEn : Form
    {

        private Engineer engeneer_temp;
        
        public Form3_AddEn()
        {
            InitializeComponent();
        //_bs = new BindingSource();
        //_bs.DataSource = Conteiner.Univer;
        //dataGridView1.DataSource = _bs;

    }


        private void BtAddEn_Click(object sender, EventArgs e)
        {
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show($"{engeneer.}", "To Welcoe page", buttons, MessageBoxIcon.Question);
            //if (result == System.Windows.Forms.DialogResult.Yes)
            //{
            Addition();
           Form4_AddLecturer form = new Form4_AddLecturer();
                form.Show();
                Hide();
            //}
        }

        private void BtEnAddToList_Click(object sender, EventArgs e)
        {
            Addition();
            tBName.Clear();
            tBSurName.Clear();
            tBLastName.Clear();
            maskedTBPassport.Clear();
            maskedTBYearsOnW.Clear();
            checkBoxCertific.Checked = false;

        }
        public void Addition()
        {
            int years = 0;
            engeneer_temp = new Engineer();
            try
            {
                years = Convert.ToInt32(maskedTBYearsOnW.Text);
            }
            catch (Exception err)
            {
                Form3_AddEn form = new Form3_AddEn();
                if (err is FormatException)
                {
                    MessageBox.Show(form.Owner, $"Incorrect input!");
                }
                else
                {
                    MessageBox.Show(form.Owner, $"Error!");
                }
            }
            engeneer_temp.YearsOnDuty = years;
            engeneer_temp.Certific = checkBoxCertific.Checked;
            engeneer_temp.PIB = $"{ tBName.Text} {tBSurName.Text} {tBLastName.Text}";
            engeneer_temp.Passport = maskedTBPassport.Text;

            if (maskedTBPassport.Text != "" && maskedTBYearsOnW.Text != "99")
            {
                Storage.Univer.Engineers(engeneer_temp);
            }
            else
                MessageBox.Show("Incorrect input!");
        }
    }
}
