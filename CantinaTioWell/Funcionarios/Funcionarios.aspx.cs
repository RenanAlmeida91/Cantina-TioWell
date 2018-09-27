using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Controller.Controller;
using Web.Controller.Model;

namespace CantinaTioWell.Funcionarios
{
    public partial class Funcionarios : System.Web.UI.Page
    {
        public int id = 0;
        public string nome, email, celular = "";

        internal void LimparFormulario()
        {
            txtID.Text = txtNome.Text = TxtCel.Text = txtEmail.Text = nome = celular = email = "";
            id = 0;
            txtID.ReadOnly = false;
            botaocadastro.Style.Add("display", "block");
            botoeseditar.Style.Add("display", "hide");
            msgsucesso.Style.Add("display", "hide");
            msgerro.Style.Add("display", "hide");
            btnConsultaID.Enabled = true;
            btnConsultaNome.Enabled = true;
        }

        public void MontarTabelaFuncionario(List<Funcionario> lista)
        {
            StringBuilder gridFunc = new StringBuilder();
  
            foreach (var item in lista)
            {
                id = item.Codigo;
                nome = item.NomeFunc;
                email = item.Email;
                celular = item.Celular;
                gridFunc.Append(" <tr> ");
                gridFunc.Append(String.Format(" <td>{0}</td> ", item.Codigo));
                gridFunc.Append(String.Format(" <td>{0}</td> ", item.NomeFunc));
                gridFunc.Append(String.Format(" <td>{0}</td> ", item.Email));
                gridFunc.Append(String.Format(" <td>{0}</td> ", item.Celular));
                gridFunc.Append(" </tr> ");
            }
            tabfuncionarios.InnerHtml = gridFunc.ToString();

        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        protected void btnConsultaID_Click(object sender, EventArgs e)
        {
            string idconsulta = txtID.Text;
            if (idconsulta != "")
            {
                List<Funcionario> lstFuncionarioid = new FuncionarioController().ConsultarFuncionarioID(idconsulta);
                if (lstFuncionarioid.Count > 0)
                {
                    MontarTabelaFuncionario(lstFuncionarioid);

                    txtNome.Text = nome;
                    txtEmail.Text = email;
                    TxtCel.Text = celular;
                    txtID.ReadOnly = true;
                    btnConsultaID.Enabled = false;
                    btnConsultaNome.Enabled = false;
                    botaocadastro.Style.Add("display", "hide");
                    botoeseditar.Style.Add("display", "block");
                    alertaid.Style.Add("display", "hide");
                }
                else
                {
                    alertaid.Style.Add("display", "block");
                }
            }
        }

        protected void btnConsultaNome_Click(object sender, EventArgs e)
        {
            string nomeconsulta = txtNome.Text;
            if (nomeconsulta != "")
            {
                List<Funcionario> lstFuncionarionome = new FuncionarioController().ConsultarFuncionarioNome(nomeconsulta);
                if (lstFuncionarionome.Count > 0)
                {
                    MontarTabelaFuncionario(lstFuncionarionome);

                    //Verifica se a lista retornada contém somente um restultado;
                    //Se Tiver somente um resultado, popula os campos do formulário com os dados do funcionário.
                    if (lstFuncionarionome.Count == 1)
                    {
                        txtID.Text = id.ToString();
                        txtNome.Text = nome;
                        txtEmail.Text = email;
                        TxtCel.Text = celular;
                        txtID.ReadOnly = true;
                        btnConsultaID.Enabled = false;
                        btnConsultaNome.Enabled = false;
                        alertnome.Style.Add("display", "hide");
                        botaocadastro.Style.Add("display", "hide");
                        botoeseditar.Style.Add("display", "block");
                        alertaid.Style.Add("display", "hide");
                    }
                }
                else
                {
                    alertnome.Style.Add("display", "block");
                }
            }
        }

        protected void btnUpdFunc_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtID.Text);
            nome = txtNome.Text;
            email = txtEmail.Text;
            celular = TxtCel.Text;
            if (id > 1)
            {
                Funcionario funcionario = new FuncionarioController().AtualizaFuncionario(id, nome, email, celular);
                txtsucesso.InnerText = "Usuário atualizado com sucesso.";
                msgsucesso.Style.Add("display", "block");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('ID Inválido')", true);
            }
        }

        protected void btnEnviaCad_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            email = txtEmail.Text;
            celular = TxtCel.Text;
            if (nome != "")
            {
                if (email != "")
                {
                    Funcionario funcionario = new FuncionarioController().InserirFuncionario(nome, email, celular);
                    txtsucesso.InnerText = "Usuário cadastrado com sucesso.";
                    msgsucesso.Style.Add("display", "block");
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('O campo E-mail é Obrigatório')", true);
                    txtEmail.Focus();
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('O campo Nome é Obrigatório')", true);
                txtNome.Focus();
            }

        }

        protected void btnDeleta_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtID.Text);
            if (id > 1)
            {
                Funcionario funcionario = new FuncionarioController().RemoverFuncionario(id);
                txtsucesso.InnerText = "Usuário removido com sucesso.";
                msgsucesso.Style.Add("display", "block");
                System.Threading.Thread.Sleep(5000);
                LimparFormulario();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('ID Inválido')", true);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (msgsucesso.Style.ToString() == "display:block")
            {
                System.Threading.Thread.Sleep(5000);
                LimparFormulario();
            }

            List<Funcionario> lstFuncionarios = new FuncionarioController().ConsultarFuncionario();
            //verifico se há informações na tabela
            if (lstFuncionarios.Count > 0)
            {
                //Se SIM, usa o String Builder para concatenar os dados e montar a tabela
                StringBuilder gridFunc = new StringBuilder();
                foreach (var item in lstFuncionarios)
                {
                    gridFunc.Append(" <tr> ");
                    gridFunc.Append(String.Format(" <td>{0}</td> ", item.Codigo));
                    gridFunc.Append(String.Format(" <td>{0}</td> ", item.NomeFunc));
                    gridFunc.Append(String.Format(" <td>{0}</td> ", item.Email));
                    gridFunc.Append(String.Format(" <td>{0}</td> ", item.Celular));
                    gridFunc.Append(" </tr> ");

                }
                //informa o <tbody> que os dados serão os do String Builder
                tabfuncionarios.InnerHtml = gridFunc.ToString();
                botaocadastro.Style.Add("display", "block");
                msgsucesso.Style.Add("display", "hide");
                msgerro.Style.Add("display", "hide");

            }
        }
    }
}