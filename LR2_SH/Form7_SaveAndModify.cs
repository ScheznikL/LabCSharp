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
    public partial class Form7_SaveAndModify : Form
    {
        private BindingSource _bsLec,_bsLab, _bsEn, _bsLectr;
        public Form7_SaveAndModify()
        {
            InitializeComponent();
        }

        private void Form7_SaveAndModify_Load(object sender, EventArgs e)
        {
            LbUnName.Text = Storage.Univer.Name;
            _bsLec = new BindingSource();
            _bsLec.DataSource = Storage.Univer.GetLectr;

            dGVLectr.DataSource = _bsLec;
            _bsLab = new BindingSource();
            _bsLab.DataSource = Storage.Univer.GetHall;
            dGVLectr.DataSource = _bsLab;
        }

        private void BtAudToLab_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to save changes to your text?", "University",
        MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Cancel the Closing event from closing the form.
               // e.Cancel = true;
                // Call method to save file...
            }
            else
                Close();
        }
    }
}
