using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Controller.Model
{
    public class ItemCantina
    {
        private int _numPed;

        public int NumPed
        {
            get { return _numPed; }
            set { _numPed = value; }
        }

        private int _prodId;

        public int ProdID
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        private int _qtd;

        public int Qtd
        {
            get { return _qtd; }
            set { _qtd = value; }
        }



    }
}
