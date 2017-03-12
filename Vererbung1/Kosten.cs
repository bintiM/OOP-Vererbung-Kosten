using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung1
{
    class Kosten
    {
        private string _text;
        virtual public string text
        {
            get
            {  return _text; }
            set { _text = value; }
        }

        private DateTime _datum;
        public DateTime datum
        {
            get { return _datum; }
            set { _datum = value; }
        }

        private decimal _betrag;
        virtual public decimal betrag
        {
            get
            { return _betrag; }
               
            set { _betrag = value; }
        }
        
    }
}