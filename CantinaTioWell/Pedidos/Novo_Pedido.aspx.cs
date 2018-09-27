using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Controller.Controller;
using Web.Controller.Model;

namespace CantinaTioWell.Pedidos
{
    public partial class Novo_Pedido : System.Web.UI.Page
    {
        internal int itens;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<Funcionario> lstFuncionarios = new FuncionarioController().ConsultarListaFuncionario();
                List<ProdutoCantina> lstProdutos = new ProdutoController().ConsultarListaProduto();
                ddlNomeFunc.Items.Insert(0, new ListItem(String.Empty, String.Empty));
                ddlProdutos.Items.Insert(0, new ListItem(String.Empty, String.Empty));
                txtNumPed.Text = "1";

                if (lstFuncionarios.Count > 0)
                {
                    int i = 1;
                    foreach (var item in lstFuncionarios)
                    {
                        //ddlNomeFunc.Items.Add(item.NomeFunc);
                        ddlNomeFunc.Items.Insert(i++, new ListItem(item.NomeFunc, Convert.ToString(item.Codigo)));
                    }
                    i = 1;
                    foreach (var item2 in lstProdutos)
                    {
                        ddlProdutos.Items.Insert(i++, new ListItem(item2.DescProd, Convert.ToString(item2.ProdID)));
                    }
                }
                ddlNomeFunc.SelectedIndex = 0;
                itens = 0;
            }
        }
        List<ItemCantina> lstItensPedido = new List<ItemCantina>();

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            do
            {
                List<ItemCantina> lstItensPedido = new List<ItemCantina>();
                lstItensPedido.Add(new ItemCantina { ProdID = Convert.ToInt32(ddlProdutos.SelectedValue), Qtd = Convert.ToInt32(txtqtd.Text) });
            } while (lstItensPedido.Count == 0);
            lstItensPedido.Add(new ItemCantina { ProdID = Convert.ToInt32(ddlProdutos.SelectedValue), Qtd = Convert.ToInt32(txtqtd.Text) });
        }
    }
}