using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Controller.Model;

namespace Web.Controller.DAO
{
    internal class ProdutoCantinaDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal ProdutoCantina InserirProduto(string descricao, decimal valor, string tipounid)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO PRODUTO_CANTINA(DescProd, ValUnit, TipoUn) VALUES (@desc, @valor, @tipo)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@desc", descricao));
            comando.Parameters.Add(new SqlParameter("@valor", valor));
            comando.Parameters.Add(new SqlParameter("@tipo", tipounid));

            try
            {
                conn.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema na gravação dos produtos!" + e);
            }
            finally
            {
                conn.Close();

            }
            return null;
        }

        internal List<ProdutoCantina> ConsultarProduto()
        {
            List<ProdutoCantina> lstProdutos = new List<ProdutoCantina>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "Select * from PRODUTO_CANTINA";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProdutoCantina produto = new ProdutoCantina();
                produto.ProdID = Convert.ToInt32(dr["ProdId"].ToString());
                produto.DescProd = dr["DescProd"].ToString();
                produto.ValUnit = Convert.ToDecimal(dr["ValUnit"].ToString());
                produto.TipoUn = dr["TipoUn"].ToString();

                lstProdutos.Add(produto);
            }
            conn.Close();
            return lstProdutos;
        }

        internal List<ProdutoCantina> ConsultarListaProdutos()
        {
            List<ProdutoCantina> lstProdutos = new List<ProdutoCantina>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "Select ProdId, DescProd from PRODUTO_CANTINA ORDER BY DescProd";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProdutoCantina produto = new ProdutoCantina();
                produto.ProdID = Convert.ToInt32(dr["ProdId"].ToString());
                produto.DescProd = dr["DescProd"].ToString();
                lstProdutos.Add(produto);
            }
            conn.Close();
            return lstProdutos;
        }
    }
}
