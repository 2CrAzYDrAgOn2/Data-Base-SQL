using System.Data.SqlClient;

namespace test_DataBase
{
    internal class DataBase
    {
        private readonly SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-2DIOKB9\SQLExpress;Initial Catalog=test;Integrated Security=True");

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}