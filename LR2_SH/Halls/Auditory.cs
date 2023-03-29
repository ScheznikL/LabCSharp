using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3_SH
{
    public class Auditory : Hall
    {
        private int _NumberOfboards;
        private bool _HasProjector;
        private bool _hasWifi;

        public int NumberOfBoards { get { return _NumberOfboards; } set { _NumberOfboards = value; } }
        public bool HasProjector { get { return _HasProjector; } set { _HasProjector = value; } }

        public bool HasWifi { get => _hasWifi; set => _hasWifi = value; }

        public Auditory(int places, int numofBoards, bool wifi, bool hasProjector/*, List<Engineer> engineers*/)
            : base(places/*,engineers*/)
        {
            _NumberOfboards = numofBoards;
            _HasProjector = hasProjector;
            _hasWifi = wifi;
        }
        public Auditory()
        {
            _NumberOfboards = 0;
            _HasProjector = false;
            _hasWifi = false;
        }
        public override void HireEngineer(Engineer engineer)
        {

        }
        public override void FireEngineer(Engineer engineer)
        {

        }

    }
}
