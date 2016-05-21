using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addUsuario_Click(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;

            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\\Users\\Renato\\mensageiro\\mensageiro.mdb";
            //C:\Users\Renato\mensageiro

            cmd.Connection = conn;
            //cmd.CommandText ="select a.nome from usuario as a inner join usuarioAmigos as b where a.usuario_id = b.usuario_id ";
            cmd.CommandText = "select nome from usuario";

            cmd.CommandType = CommandType.Text;

            conn.Open();

            dr = cmd.ExecuteReader();


            /*
             * while (rdr.Read())
                {
                    lbProdutos.Items.Add(rdr["ProductID"].ToString() +
                    " - " + rdr["ProductName"].ToString() + " - " + rdr["UnitPrice"].ToString());
                    nuReg++;
                }*/

            String divs = "";

            while (dr.Read())
            {
                divs = divs + "<div class='usuario'>" + dr["nome"] +"</div>";
            }


 

            /*for (int x=0; x<=10;x++)
            {
                divs = divs + "<div class='usuario jumbotron'>usuario" +x+ " </div>";
            }*/
            Literal1.Text = divs;

            conn.Close();
            /*< div class="usuario">
                    teste
                </div>*/
        }
    }
}