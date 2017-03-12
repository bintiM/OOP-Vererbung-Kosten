using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung1
{
    class kmPauschale : Kosten
    {
        private int _strecke;

        public int strecke
        {
            get { return _strecke; }
            set { _strecke = value; }
        }

        public override decimal betrag
        {
            get { return strecke * 0.52m; }
            set { }
        }

        public override string text
        {
            get
            {
                return "km-Pauschale";
            }

            set
            {
            }
        }

    }
}
