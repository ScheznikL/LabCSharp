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
    public partial class Form6_AddAud : Form
    {
        private Auditory auditory;
        public Form6_AddAud()
        {
            InitializeComponent();
            mTBid.Text = Convert.ToString(Storage.Univer.Lec);
        }

        private void BtSubbmitUn_Click(object sender, EventArgs e)
        {
            Addition();
            Storage.Univer.Halls();
            Form7_SaveAndModify form = new Form7_SaveAndModify();
            form.Show();
            Hide();
        }

        private void AddAudtoList_Click(object sender, EventArgs e)
        {
            Addition();
        }
        public void Addition()
        {
            auditory = new Auditory();
            auditory.HasProjector = ChBProj.Checked;
            auditory.HasWifi = chBWiFi.Checked;
            auditory.NumberOfBoards = (int)nUpDNumOfBoards.Value;
            auditory.Places = (int)nUpDNumOfSeats.Value;

            if (nUpDNumOfSeats.Value != 0)
            {
            Storage.Univer.LectureAuditoriums(auditory);
            }
            else
                MessageBox.Show("Incorrect input!");
        }
    }
    //string name, int faculty, int students,
    //        List<Hall> halls, Dictionary<string, Workers> Workerdict
}
