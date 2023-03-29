using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3_SH
{
    public abstract class Workers
    {
        protected string _passport;
        protected string _PIB;

        public string Passport
        {
            get { return _passport; }
            set
            {
                //if (value.Length <= 8)
                _passport = value;
                //else
                //  MessageBox.Show("Incorrect data!");
            }
        }
        public string PIB { get => _PIB;
            set
            {
                int num;
                if (!string.IsNullOrWhiteSpace(value) && !(int.TryParse(value, out num)))
                    _PIB = value;
                else
                if (string.IsNullOrWhiteSpace(value))
                    MessageBox.Show("Null  value is incorrect, as for name!");
                else
                if (MyValidate.IsInteger(value))
                {
                    MessageBox.Show($"{value} is incorrect, as for name!");
                }
                
            }
        }
        public Workers()
        {
            _passport = "";
            _PIB = "";
        }
        public Workers(string name, string passport) 
        {
            Passport = passport;
            PIB = name;
        }
        //public virtual List<Workers> ToPrint()
        //{
        //    return new List<Workers>();
        //}
       
    }
}
