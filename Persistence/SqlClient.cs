﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence
{
     class SqlClient : ISqlClient
    {
        private readonly string _connectionString;

        public SqlClient(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Task<int> ExecuteAsync(string sql, object param = null)
        {
            using var connection = new MySqlConnection(_connectionString);

            return connection.ExecuteAsync(sql, param);
        }

        public Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null)
        {
            using var connection = new MySqlConnection(_connectionString);

            return connection.QueryAsync<T>(sql, param);
        }
    }
}
