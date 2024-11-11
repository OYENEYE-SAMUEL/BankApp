using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BankApp.Context
{
    public class BankContext
    {
        private readonly IConfiguration _config;
        public BankContext(IConfiguration config)
        {
            _config = config;
        }

        public MySqlConnection OpenConnection()
        {
            return new MySqlConnection(_config.GetConnectionString("Connection"));
        }
    }
}