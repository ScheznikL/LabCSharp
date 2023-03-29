using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3_SH
{
    public abstract class Hall
    {
        protected int _ID = -1;
        protected int _places;
        private int engineersCount;
        //protectrd University

        public Hall(int places/*, List<Engineer> engineers*/)
        {
            _places = places;
        }
        public Hall()
        {
            // _engineers = engineers;
            _places = 0;
        }

        public int ID { get => _ID; set => _ID = value; }
        public int Places { get => _places; set => _places = value; }
        public int EngineersCount { get => engineersCount; set => engineersCount = Storage.Univer.Engineer; }

        // public List<Engineer> Engineers { get => _engineers; set => _engineers = value; }
        public virtual void HireEngineer(Engineer engineer)
        {
            EngineersCount++;
        }
        public virtual void FireEngineer(Engineer engineer)
        {
            EngineersCount--;
        }

    }
}
