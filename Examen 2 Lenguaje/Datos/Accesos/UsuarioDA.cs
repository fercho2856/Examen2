using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Accesos
{
    public class UsuarioDA
    {
        readonly string Cadena = "Server= 127.0.0.1; Port=3306; Database=Examen2; Uid=root; Pwd=Pro$t1sparatodos; ";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(string codigo, string clave)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE codigo = @Codigo AND Clave = @Clave;";

                conn = new MySqlConnection(Cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.Codigo = reader[0].ToString();
                   
                   
                    user.Clave = reader[2].ToString();
                    

                }
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {

            }
            return user;



    
        
    }
        }
}
