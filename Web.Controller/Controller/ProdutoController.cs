using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Controller.DAO;
using Web.Controller.Model;

namespace Web.Controller.Controller
{
    public class ProdutoController
    {
        public ProdutoCantina InserirProduto(string descricao, decimal valor, string tipounid)
        {
            return new ProdutoCantinaDB().InserirProduto(descricao, valor, tipounid);
        }

        public ProdutoController() { }

        public List<ProdutoCantina> ConsultarProduto()
        {
            return new ProdutoCantinaDB().ConsultarProduto();
        }

        public List<ProdutoCantina> ConsultarListaProduto()
        {
            return new ProdutoCantinaDB().ConsultarListaProdutos();
        }

    }
}
