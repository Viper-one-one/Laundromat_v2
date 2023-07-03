using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundromat_v2
{
    public partial class Form1 : Form
    {
        DBHandler handler = new DBHandler();
        DBConnection dbCon = DBConnection.Instance();
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Update");
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Inserted");

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Deleted");
        }

        private void AllProducts_Click(object sender, EventArgs e)
        {
            dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "homework";
            dbCon.UserName = "root";
            dbCon.Password = "1234";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM PRODUCT", dbCon.Connection))
                {
                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            int row = 0;
                            while (reader.Read())
                            {
                                textBoxOut.AppendText(reader.GetString(row) + " ");
                                row++;
                                if (row > 2)
                                {
                                    row = 0;
                                    textBoxOut.AppendText("\n");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { dbCon.Close(); }
                }
            }
        }
    }
}
