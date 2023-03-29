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
    public partial class Form5_AddLab : Form
    {
        private Lab laboratory;
        public Form5_AddLab()
        {
            InitializeComponent();
            mTBid.Text = Convert.ToString(Storage.Univer.Lab);
        }
        private void BtAddToHalls_Click(object sender, EventArgs e)
        {
            Addition();
        }
        private void BtNextToAud_Click(object sender, EventArgs e)
        {
            Addition();
            Form6_AddAud form = new Form6_AddAud();
            form.Show();
            Hide();
        }
        public void Addition()
        {
            laboratory = new Lab();
            double speed = 0;
            laboratory.NumberOfComp = (int)nUpDNumOfComp.Value;
            laboratory.Places = (int)nUpDNumOfSeats.Value;
            string FromDesplay = mTbWifiS.Text;
            string Mask = mTbWifiS.MaskedTextProvider.Mask;
            int index = FromDesplay.IndexOf("Mbit");
            string subSpeed = FromDesplay.Remove(index);
            try
            {
                speed = Convert.ToDouble(subSpeed);
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
            laboratory.WifiSpeed = speed;
            if(laboratory != null)
                Storage.Univer.LabAuditoriums(laboratory);
        }
    }
}
