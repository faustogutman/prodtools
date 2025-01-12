using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProdTools
{
    internal class ConnectionDB
    {
    }
}



public class DatabaseConnection
{
    private string connectionString;

    public DatabaseConnection(string connString)
    {
        connectionString = connString;
    }

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    public void OpenConnection(SqlConnection connection)
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection(SqlConnection connection)
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }
}



