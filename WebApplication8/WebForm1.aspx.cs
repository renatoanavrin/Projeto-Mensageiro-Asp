using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;


namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var connString = "Server=localhost;Database=mensageiro;Uid=root;Pwd=master"; //Aqui você substitui pelos seus dados
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            MySqlDataReader dr;

            try
            {
                connection.Open();
                command.CommandText = "select c.* from usuario a join amigos b on a.usuarioid = b.usuarioid join usuario c on b.usuarioamigoid = c.usuarioid where a.login = 'renato'";
                /*MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);*/
                dr = command.ExecuteReader();
                String divs = "";
                while (dr.Read())
                {
                    divs = divs + "<div onclick='javascript: DivClicked(" + '"' + dr["login"] + '"' + "); return true;'" + " class='usuario' id=" + dr["login"] + ">" + dr["nome"] + "</div>";
                    //<div onclick="javascript:DivClicked(); return true;">click aqui</div>   
                }
                Literal1.Text = divs;
            }
            finally
            {
                connection.Close();
            }

        }

        protected void addUsuario_Click(object sender, EventArgs e)
        {

            /*OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;*/

            var connString = "Server=localhost;Database=mensageiro;Uid=root;Pwd=master"; //Aqui você substitui pelos seus dados
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            MySqlDataReader dr;

            try
            {
                connection.Open();
                command.CommandText = "select c.* from usuario a join amigos b on a.usuarioid = b.usuarioid join usuario c on b.usuarioamigoid = c.usuarioid where a.login = 'renato'";
                /*MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);*/
                dr = command.ExecuteReader();
                String divs = "";
                while (dr.Read())
                {
                    divs = divs + "<div onclick='javascript: DivClicked(" + '"'+dr["login"] +'"' +"); return true;'" + " class='usuario' id=" + dr["login"] + ">" + dr["nome"] + "</div>";
                    //<div onclick="javascript:DivClicked(); return true;">click aqui</div>   
                }
                Literal1.Text = divs;
            }
            finally
            {
                    connection.Close();
            }


            //conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\\Users\\Renato\\mensageiro\\mensageiro.mdb";

            //C:\Users\Renato\mensageiro

            //  cmd.Connection = conn;
            //cmd.CommandText ="select a.nome from usuario as a inner join usuarioAmigos as b where a.usuario_id = b.usuario_id ";
            /*cmd.CommandText = "select nome from usuario";

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

/*            String divs = "";

            while (dr.Read())
            {
                divs = divs + "<div class='usuario'>" + dr["nome"] +"</div>";
            }


 

            /*for (int x=0; x<=10;x++)
            {
                divs = divs + "<div class='usuario jumbotron'>usuario" +x+ " </div>";
            }*/
  

            //conn.Close();
            /*< div class="usuario">
                    teste
                </div>*/
        }

        protected void btnHidden_OnClick(object sender, EventArgs e)
        {
            
        }
    }
}