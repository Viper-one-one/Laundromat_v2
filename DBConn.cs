using MySql.Data;
using MySql.Data.MySqlClient;

namespace Laundromat_v2
{
    public class DBConnection
    {
        private DBConnection()
        {
        }

        public string Server 
        {
            get 
            {
                return this.Server;
            }
            set
            {
                this.Server = value; 
            }
        }
        public string DatabaseName 
        {
            get 
            {
                return this.DatabaseName;
            }
            set
            {
                this.DatabaseName = value;
            }
        }
        public string UserName 
        {
            get
            {
                return this.UserName;
            }
            set
            {
                this.UserName = value;
            }
        }
        public string Password 
        {
            get
            {
                return this.Password;
            }
            set
            {
                this.Password = value;
            }
        }

        private MySqlConnection Connection 
        {
            get
            {
                return this.Connection
            }
            set
            {
                this.Connection = value;
            }
        }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
                Connection = new MySqlConnection(connstring);
                Connection.Open();
            }

            return true;
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}