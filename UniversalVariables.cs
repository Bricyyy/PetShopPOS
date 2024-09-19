using System.Data;
using MySql.Data.MySqlClient;

namespace MilkTeaOrderAndInventorySystem
{

    static class UniversalVariables
    {
        public static MySqlConnection conn = new MySqlConnection();
        public static DataSet ds = new DataSet();
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataReader dr;
        public static string sql;

        public static MySqlConnection conn1 = new MySqlConnection();
        public static DataSet ds1 = new DataSet();
        public static MySqlCommand cmd1 = new MySqlCommand();
        public static MySqlDataReader dr1;
        public static string sql1;

        public static MySqlConnection conn2 = new MySqlConnection();
        public static DataSet ds2 = new DataSet();
        public static MySqlCommand cmd2 = new MySqlCommand();
        public static MySqlDataReader dr2;
        public static string sql2;

        public static void connect()
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            dr = cmd.ExecuteReader();
        }

        public static void connectAlt()
        {
            cmd1.CommandText = sql1;
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = conn1;
            conn1.Open();
            dr1 = cmd1.ExecuteReader();
        }

        public static void connectAgain()
        {
            cmd2.CommandText = sql2;
            cmd2.CommandType = CommandType.Text;
            cmd2.Connection = conn2;
            conn2.Open();
            dr2 = cmd2.ExecuteReader();
        }

    }
}