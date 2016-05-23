using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WebApplication8.Models
{
    public class amigos
    {


        public String retornaAmigos(String login,String amigoSelecionado)
        {
            var connString = "Server=localhost;Database=mensageiro;Uid=root;Pwd=master"; //Aqui você substitui pelos seus dados
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            MySqlDataReader dr;
            
            amigos am = new amigos();


            // Store input argument in a local variable.
            try
            {
                connection.Open();
                command.CommandText = "select c.* from usuario a join amigos b on a.usuarioid = b.usuarioid join usuario c on b.usuarioamigoid = c.usuarioid where a.login = '" +login +"'";
                /*MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);*/
                dr = command.ExecuteReader();
                String divs = "", selecionado = "";
                while (dr.Read())
                {
                    if (amigoSelecionado == Convert.ToString(dr["login"]))
                    {
                        selecionado = " selecionado";
                    }
                    else
                    {
                        // hiddenchoice.Text =""+ dr["login"];
                        selecionado = "";
                    }



                    divs = divs + "<a href='#'><div onclick='javascript: DivClicked(" + '"' + dr["login"] + '"' + "); return true;'" + " class='usuario " + selecionado + "' id=" + dr["login"] + ">" + dr["nome"] + "</div></a>";
                    //<div onclick="javascript:DivClicked(); return true;">click aqui</div>   
                }
                return divs;
            }
            finally
            {
                connection.Close();
            }
            
        }

    }
}