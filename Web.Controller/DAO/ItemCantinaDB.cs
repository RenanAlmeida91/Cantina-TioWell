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
    internal class ItemCantinaDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal ItemCantina InserirItem(int numped, int prodId, int qtd)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO ITEM_CANTINA(NumPed, Prod_Id, QtdPed) VALUES (@numped, @prodid, @qtd)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@numped", numped));
            comando.Parameters.Add(new SqlParameter("@prodid", prodId));
            comando.Parameters.Add(new SqlParameter("@tiqtdpo", qtd));

            try
            {
                conn.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema na gravação dos itens!" + e);
            }
            finally
            {
                conn.Close();

            }
            return null;
        }

        internal List<ItemCantina> ConsultarItem()
        {
            List<ItemCantina> lstItens = new List<ItemCantina>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "Select * from ITEM_CANTINA";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ItemCantina itemCantina = new ItemCantina();
                itemCantina.NumPed = Convert.ToInt32(dr["NumPed"].ToString());
                itemCantina.ProdID = Convert.ToInt32(dr["Prod_Id"].ToString());
                itemCantina.Qtd = Convert.ToInt32(dr["QtdPed"].ToString());

                lstItens.Add(itemCantina);
            }
            conn.Close();
            return lstItens;
        }
    }
}
