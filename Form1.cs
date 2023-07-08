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
            dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "laundromat";
            dbCon.UserName = "root";
            dbCon.Password = "1234";
            string table = ((DataTable)dataGridView.DataSource).TableName;
            string col1 = dataGridView.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Name;
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"Insert Into {table}", dbCon.Connection))
                {
                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { dbCon.Close(); }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "laundromat";
            dbCon.UserName = "root";
            dbCon.Password = "1234";
            string table = ((DataTable)dataGridView.DataSource).TableName;
            string col1 = dataGridView.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Name;
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"Drop {table}", dbCon.Connection))
                {
                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { dbCon.Close(); }
                }
            }
        }

        private void OutLocation_Click(object sender, EventArgs e)
        {
            dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "Laundromat";
            dbCon.UserName = "root";
            dbCon.Password = "1234";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM location", dbCon.Connection))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { dbCon.Close(); }
                }
            }
        }

        private void OutCustomers_Click(object sender, EventArgs e)
        {
            dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "Laundromat";
            dbCon.UserName = "root";
            dbCon.Password = "1234";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer", dbCon.Connection))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { dbCon.Close(); }
                }
            }
        }

        private void OutEmployees_Click(object sender, EventArgs e)
        {
            dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "Laundromat";
            dbCon.UserName = "root";
            dbCon.Password = "1234";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", dbCon.Connection))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { dbCon.Close(); }
                }
            }
        }

        private void OutMachine_Click(object sender, EventArgs e)
        {
            dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "Laundromat";
            dbCon.UserName = "root";
            dbCon.Password = "1234";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM machine", dbCon.Connection))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { dbCon.Close(); }
                }
            }
        }

        private void OutSuppliers_Click(object sender, EventArgs e)
        {
            dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "Laundromat";
            dbCon.UserName = "root";
            dbCon.Password = "1234";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM supplier", dbCon.Connection))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { dbCon.Close(); }
                }
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //update tuple
        }
    }
}
