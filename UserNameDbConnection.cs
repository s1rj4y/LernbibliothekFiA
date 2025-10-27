using MySql.Data.MySqlClient;
using System;

namespace LernbibliothekFiA
{
    public static class UserNameDbConnection
    {     
        public static MySqlConnection GetConnection(string dbuserName)
        {
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD");

            string connectionDb = $"Server=localhost;Port=3306;Database={dbuserName};Uid=root;{password}";
            return new MySqlConnection(connectionDb);
        }
    }
}
