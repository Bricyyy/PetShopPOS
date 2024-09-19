using System.Data;
using MySql.Data.MySqlClient;

namespace MilkTeaOrderAndInventorySystem
{

    public class myConnection
    {
        private readonly MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=0102bryan;database=accountdb");

        public MySqlConnection getConnection
        {
            get
            {
                return connection;
            }
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}