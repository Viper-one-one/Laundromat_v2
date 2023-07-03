using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Laundromat_v2 {
    public class DBHandler
    {
	    public DBHandler()
	    {
	    }
        public MySqlDataReader UseDB(object sender, int typeOfCmd)
        {
            
            var dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "homework";
            dbCon.UserName = "root";
            dbCon.Password = "1234";
            
            if (dbCon.IsConnect())
            {
                switch (typeOfCmd)
                {
                    case 1:
                        string query = "Select * From product";
                        var cmd = new MySqlCommand(query, dbCon.Connection);
                        var reader = cmd.ExecuteReader();
                        
                        return reader;
                    case 2:
                        string query2 = "Select * From pc";
                        var cmd2 = new MySqlCommand(query2, dbCon.Connection);
                        var reader2 = cmd2.ExecuteReader();
                        
                        return (reader2);
                    default:
                        dbCon.Close();
                        throw new Exception("error in cmd switch");
                }
            }
            dbCon.Close();
            throw new Exception("error in cmd switch");
            
        }
    }
}
