using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Controller.Model
{
    public class Funcionario
    {
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _nomeFunc;

        public string NomeFunc
        {
            get { return _nomeFunc; }
            set { _nomeFunc = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _celular;

        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }


    }
}
