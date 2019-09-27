using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Projeto2
{
    public class Conexao
    {
        public static SqlConnection Conectar()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=ProjetoDS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
                conn.Open();
                return conn;
            }
            catch
            {
                //lança a exceção para quem chamou para tratar
                throw new Exception("Não foi possível conectar. Tente novamente!");
            }
        }
    }
}
