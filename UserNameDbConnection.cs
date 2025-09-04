using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LernbibliothekFiA
{
    public static class UserNameDbConnection
    {
        public static MySqlConnection GetConnection(string dbuserName)
        {
            string connectionDb = $"Server=localhost;Port=3306;Database={dbuserName};Uid=root;Pwd=061289";
            return new MySqlConnection(connectionDb);
        }
    }
}
