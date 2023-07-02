using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Laundromat_v2 {
    public class DBHandler
    {
	    public DBHandler()
	    {
	    }
        public void useDB()
        {
            var dbCon = DBConnection.Instance();
            dbCon.Server = "test_server";
            dbCon.DatabaseName = "test";
            dbCon.UserName = "root";
            dbCon.Password = "1234";
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query = "SELECT * FROM tab1";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
                }
                dbCon.Close();
            }
        }
    }
}
