using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
            string update = "UPDATE customer SET customer_id=" + CustID.Text + ", f_name=\"" + cust_f_name.Text + "\", l_name=\"" + cust_l_name.Text + "\", bdate=\'" + cust_b_date.Value.Date.ToString("yyyy-MM-dd") + "\', VIP=" + vip.Text + " WHERE customer_id=" + CustID.Text + ";";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{update}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO customer VALUES (" + CustID.Text + ", \"" + cust_f_name.Text + "\", \"" + cust_l_name.Text + "\", \'" + cust_b_date.Value.ToString("yyyy-MM-dd") + "\', " + vip.Text.ToString() + ");";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{insert}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM customer Where customer_id=" + CustID.Text;
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{delete}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void OutLocation_Click(object sender, EventArgs e)
        {
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
                }
            }
        }

        private void OutCustomers_Click(object sender, EventArgs e)
        {
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
                }
            }
        }

        private void OutEmployees_Click(object sender, EventArgs e)
        {
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
                }
            }
        }

        private void OutMachine_Click(object sender, EventArgs e)
        {
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
                }
            }
        }

        private void OutSuppliers_Click(object sender, EventArgs e)
        {
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
                }
            }
        }

        private void CustControl_Click(object sender, EventArgs e)
        {
            if (CustomerControlGroup.Visible == false)
            {
                CustomerControlGroup.Visible = true;
            }
            else
            {
                CustomerControlGroup.Visible = false;
            }
        }

        private void LocationControl_Click(object sender, EventArgs e)
        {
            if (LocationControlGroup.Visible == false)
            {
                LocationControlGroup.Visible = true;
            }
            else
            {
                LocationControlGroup.Visible = false;
            }
        }

        private void SupplierControls_Click(object sender, EventArgs e)
        {
            if (SupplierControlGroup.Visible == false)
            {
                SupplierControlGroup.Visible = true;
            }
            else
            {
                SupplierControlGroup.Visible = false;
            }
        }

        private void MachineControls_Click(object sender, EventArgs e)
        {
            if (MachineControlGroup.Visible == false)
            {
                MachineControlGroup.Visible = true;
            }
            else
            {
                MachineControlGroup.Visible = false;
            }
        }

        private void EmployeeControls_Click(object sender, EventArgs e)
        {
            if (EmployeeControlGroup.Visible == false)
            {
                EmployeeControlGroup.Visible = true;
            }
            else
            {
                EmployeeControlGroup.Visible = false;
            }
        }

        private void SetConStr_Click(object sender, EventArgs e)
        {
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "laundromat";
            dbCon.UserName = "root";
            dbCon.Password = "1234";
        }

        private void UpdateLocation_Click(object sender, EventArgs e)
        {
            string update = "UPDATE location SET location_num=" + loc_num.Text + ", street_no=" + street_num.Text + ", street_name=\"" + street_name.Text + "\", city=\"" + city.Text + "\", state=\"" 
                + state.Text + "\", zip=" + zip_num.Text + " WHERE location_num=" + loc_num.Text + ";";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{update}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void InsertLocation_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO location VALUES (" + loc_num.Text + ", " + street_num.Text + ", \"" + street_name.Text + "\", \"" + city.Text + "\", \"" + state.Text + "\", " + zip_num.Text + ");";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{insert}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void DeleteLocation_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM location Where location_num=" + loc_num.Text;
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{delete}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            string update = "UPDATE supplier SET supplier_id=" + supp_id.Text + ", supplier_name=\"" + supp_name.Text + "\" WHERE supplier_id=" + supp_id.Text + ";";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{update}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void InsertSupplier_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO supplier VALUES (" + supp_id.Text + ", \"" + supp_name.Text + "\");";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{insert}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM supplier Where supplier_id=" + supp_id.Text;
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{delete}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void UpdateMachine_Click(object sender, EventArgs e)
        {
            string update = "UPDATE machine SET machine_id=" + mach_id.Text + ", available=" + available_1_0.Text + ", num_uses=" + num_uses.Text + ", balance=" + balance.Text + ", capacity=" + capacity_liter.Text + ", type=\"" + type_mach.Text + "\" WHERE machine_id=" + mach_id.Text + ";";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{update}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void InsertMachine_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO machine VALUES (" + mach_id.Text + ", " + available_1_0.Text + ", " + num_uses.Text + ", " + balance.Text + ", " + capacity_liter.Text + ", \"" + type_mach + "\");";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{insert}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void DeleteMachine_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM machine Where machine_id=" + mach_id.Text;
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{delete}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            string update = "UPDATE employee SET employee_id=" + emp_id.Text + ", ssn=" + ssn.Text + ", f_name=\"" + emp_f_name + ", l_name=\"" + emp_l_name + ", dob=\'" +
                emp_b_day.Value.Date.ToString("yyyy-MM-dd") + "\', salary=" + salary.Text + ", " + days_off.Text + ", " + man_id.Text + " WHERE employee_id=" + emp_id.Text + ";";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{update}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void InsertEmployee_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO employee VALUES (" + emp_id.Text + ", " + ssn.Text + ", \"" + emp_f_name.Text + "\", " + ", \"" + emp_l_name.Text + "\", " + emp_b_day.Value.Date.ToString("yyyy-MM-dd") 
                + ", " + salary.Text + ", " + days_off.Text + ",  " + man_id.Text + ");";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{insert}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM employee Where employee_id=" + emp_id.Text;
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{delete}", dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
