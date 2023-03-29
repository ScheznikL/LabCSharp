using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3_SH
{
    public class Engineer : Workers
    {
        private int _yearsOnDuty = 999;

        //public string PIb (string name){
        //    PIB = name;
        //    return PIB;
        //    }

        public int YearsOnDuty { get => _yearsOnDuty; set
            { if (value < 90)
                    _yearsOnDuty = value;
                else
                    MessageBox.Show("Number of years too big");
            }
        }
        public bool Certific { get; set; }

        public Engineer(int yearsOnDuty, bool certific,string name,string passport) : base(name, passport)
        {
            YearsOnDuty = yearsOnDuty;
            Certific = certific;
        }

        public Engineer()
        {
        _yearsOnDuty = 0;
        Certific = false;
        }
        //public override List<Workers> ToPrint()
        //{
        //    return base.ToPrint();

        //}
    }
}
