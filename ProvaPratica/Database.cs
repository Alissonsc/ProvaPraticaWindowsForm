using System;
using MySql.Data.MySqlClient;

namespace ProvaPratica
{
    public static class Database
    {
        //Implemente o método SalvarUsuario
        public static bool SalvarUsuario(Usuario usuario)
        {
            string connectionString = "server=localhost;port=3306;user id=root" + "; database=ti_113_windowsforms;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string verificarTelQuery = "SELECT COUNT(*) FROM usuarios WHERE Telefone = @Telefone";
                    using (MySqlCommand cmdVerificar = new MySqlCommand(verificarTelQuery, connection))
                    {
                        cmdVerificar.Parameters.AddWithValue("@Telefone", usuario.Telefone);

                        int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                        if (count > 0)
                        {
                            Console.WriteLine("Este número de telefone já está registrado.");
                            return false;
                        }
                    }

                    string query = "INSERT INTO usuarios (nome, telefone) VALUES (@Nome, @Telefone)";
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