using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPratica
{
    using MySql.Data.MySqlClient;
    using System;
    public static class Database
    {
        //Implemente o método SalvarUsuario
        public static bool SalvarUsuario(Usuario usuario)
        {
            string connectionString = "server=localhost;port=3306;user id=root" + "; database=ti_113_windowsforms;";

            string query = "INSERT INTO usuarios (nome, telefone) VALUES (@Nome, @Telefone)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                        cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao salvar o usuário: {ex.Message}");
                    return false;

                }
            }
        }
    }
}
