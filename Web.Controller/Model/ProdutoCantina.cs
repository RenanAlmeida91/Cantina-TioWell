using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Controller.Model
{
    public class ProdutoCantina
    {
        private int _prodID;

        public int ProdID
        {
            get { return _prodID; }
            set { _prodID = value; }
        }

        private string _descProd;

        public string DescProd
        {
            get { return _descProd; }
            set { _descProd = value; }
        }

        private decimal _valUnit;

        public decimal ValUnit
        {
            get { return _valUnit; }
            set { _valUnit = value; }
        }

        private string _tipoUn;

        public string TipoUn
        {
            get { return _tipoUn; }
            set { _tipoUn = value; }
        }



    }
}
