using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3_SH
{
    public class Lab : Hall
    {
        private int _numberOfComp;
        private double _wifiSpeed;

        public int NumberOfComp { get { return _numberOfComp; } set { _numberOfComp = value; } }
        public double WifiSpeed { get { return _wifiSpeed; } set { _wifiSpeed = value; } }

        public Lab(int numberOfComp, double wifiSpeed, int places/*, List<Engineer> engineers*/)
            : base(places)
        {
            _numberOfComp = numberOfComp;
            _wifiSpeed = wifiSpeed;
        }

        public Lab()
        {
            _numberOfComp = 0;
            _wifiSpeed = 0.0;
        }

        public override void HireEngineer(Engineer engineer)
        {
        
        }
        public override void FireEngineer(Engineer engineer)
        {

        }
        //public Lab(string _ID, int _places, List<Engineer> engineers, int numberOfDevices, double wifiSpeed)
        //    : base(_ID, _places)
        //{
        //    _numberOfComp = numberOfDevices;
        //    _wifiSpeed = wifiSpeed;
        //}


        //public bool Equals(Lab rhs)
        //{
        //    return _ID == rhs._ID && _places == rhs._places;/* && itsEngineers.Equals(rhs.itsEngineers)
        //        && _numberOfComp == rhs._numberOfComp && itsWifiSpeed == rhs.itsWifiSpeed;*/
        //}
    }
}
