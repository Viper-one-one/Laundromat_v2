using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Laundromat_v2
{
    internal static class Program
    {
        private static MySqlConnection connection;
        private static string server;
        private static string database;
        private static string user;
        private static string password;
        private static string port;
        private static  string connectionString;
        private static string sslM;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }

        static int DBDelete()
        {
            return 0;
        }

        static int DBUpdate()
        {
            return 0;
        }

        static int DBInsert()
        {
            
        }
    }
}
