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
    public partial class Form2_AddUn : Form
    {
        public Form2_AddUn()
        {
            InitializeComponent();
           
        }

        private void BtAddUnData_Click(object sender, EventArgs e)
        {
            if(nUpDNumOfFacult.Value != 0)
            Storage.Univer.Faculty = (int)nUpDNumOfFacult.Value;
            if (nUpDNumOfStud.Value != 0)
                Storage.Univer.Students = (int)nUpDNumOfStud.Value;
            if (!MyValidate.IsInteger(TbUnName.Text))
            {
                Storage.Univer.Name = TbUnName.Text;
            }
            else
            {
                MessageBox.Show("Incorrect input!");
            }
            
            Form3_AddEn form = new Form3_AddEn();
            form.Show();
            Hide();
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Chanches won't be saved. Are you sure?", "To Welcoe page", buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                Hide();
            }
        }
    }
}
