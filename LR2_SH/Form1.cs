using System;
using System.Windows.Forms;

namespace LR3_SH
{
    public partial class Form1 : Form
    {
        //public event PropertyChangedEventHandler PropertyChanged;

       // private BindingSource _bs;

        public Form1()
        {
            InitializeComponent();

            
        }

       

    //public static University addNewUniversuty(string name, int faculty, int lab, int lec, int teachers, int engineer, int students)
    //    {
    //        University newUn;
    //        return newUn = new University(name, faculty, lab, lec, teachers, engineer, students);
    //    }

        

        public void FormIntrraction(string TobeDisplayed, string ToButton)
        {

           
            //Form2_AddUn form = new Form2_AddUn();
            //form.Show();
            //form.WhoorWhat.Text = TobeDisplayed;
           
            //_bs.DataSource = Conteiner.ForDisplay;
            //_bs.ResetBindings(false);
            //dataGridView1.DataSource = _bs;
            //dataGridView1.Update();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            Form2_AddUn form = new Form2_AddUn();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
