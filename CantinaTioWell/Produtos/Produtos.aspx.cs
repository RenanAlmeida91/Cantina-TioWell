using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CantinaTioWell.Produtos
{
    public partial class Produtos : System.Web.UI.Page
    {
        internal int id = 0;
        internal string produto = "";
        internal decimal valor = 0;

        internal void LimparFormulario()
        {
            txtID.Text = txtProd.Text = txtID.Text = txtValor.Text = produto = "";
            id = 0;
            valor = 0;
            txtID.ReadOnly = false;
            botaocadastro.Style.Add("display", "block");
            botoeseditar.Style.Add("display", "hide");
            msgsucesso.Style.Add("display", "hide");
            msgerro.Style.Add("display", "hide");
            btnConsultaID.Enabled = true;
            btnConsultaProd.Enabled = true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}