using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace BoxConfigurator
{
    class Device
    {
        private int _type_of_hardware;      // enum ?
        private int _address;
        private int _year;
        private int _week;
        private int _sn;

        public int Type
        {
            get { return _type_of_hardware; }
            set { _type_of_hardware = value; }
        }

        public int Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int Week
        {
            get { return _week; }
            set { _week = value; }
        }

        public int Sn
        {
            get { return _sn; }
            set { _sn = value; }
        }

    }
}
