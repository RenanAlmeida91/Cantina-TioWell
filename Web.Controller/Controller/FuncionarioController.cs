using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Controller.DAO;
using Web.Controller.Model;

namespace Web.Controller.Controller
{
    public class FuncionarioController
    {
        public Funcionario InserirFuncionario(string nome, string email, string celular)
        {
            return new FuncionarioDB().InserirFuncionario(nome, email, celular);
        }

        public FuncionarioController() { }

        public Funcionario AtualizaFuncionario (int id, string nome, string email, string celular)
        {
            return new FuncionarioDB().AtualizaFuncionario(id,nome,email,celular);
        }

        public Funcionario RemoverFuncionario (int id)
        {
            return new FuncionarioDB().RemoverFuncionario(id);
        }

        public List<Funcionario> ConsultarFuncionario()
        {
            return new FuncionarioDB().ConsultarFuncionario();
        }

        public List<Funcionario> ConsultarFuncionarioID(string id)
        {
            return new FuncionarioDB().ConsultarFuncionarioID(id);
        }

        public List<Funcionario> ConsultarFuncionarioNome(string nome)
        {
            return new FuncionarioDB().ConsultarFuncionarioNome(nome);
        }

        public List<Funcionario> ConsultarListaFuncionario()
        {
            return new FuncionarioDB().ConsultarListaFuncionario();
        }

    }
}
