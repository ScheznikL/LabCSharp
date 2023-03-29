using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LR3_SH
{
    public class Lecturer : Workers
    {
        private int _subjNum;
        private int _scientificWNum;
        private int _students;

        public int SubjNum
        {
            get => _subjNum;
            set
            {
                if (value < 5)
                {
                    _subjNum = value;
                }
                else
                {
                    MessageBox.Show("One lector can lecture only up to 5 subjects!");
                }
            }
        }
        public int ScientificWNum { get => _scientificWNum; set => _scientificWNum = value; }

        public Lecturer()
        {
            _students = 0;
            _subjNum = 0;
            _scientificWNum = 0;
        }

        public Lecturer(int subjNum, int scientificWNum, int students, string name, string passport) : base(name, passport)
        {
            _subjNum = subjNum;
            _scientificWNum = scientificWNum;
            _students = students;
        }

        //public bool AddStudent(Student student)
        //{
        //    if (_students.Count < 10)
        //    {
        //        _students.Add(student);
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        //public void RemoveStudent(Student student)
        //{
        //    _students.Remove(student);
        //}



    }
}
