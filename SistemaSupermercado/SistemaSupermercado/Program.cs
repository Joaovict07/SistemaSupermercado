using System;
using MySqlConnector;

namespace SistemaSupermercado
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "Server=localhost;User ID=root;Password=12345;Database=supermercadoDB";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    Console.WriteLine("Conexão com o MySQL realizada com sucesso!");
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Erro de conexão: {ex.Message}");
                }
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}