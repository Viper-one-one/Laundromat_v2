using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.IO;
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
            string update = "UPDATE customer SET customer_id=" + CustID.Text + ", f_name=\"" + cust_f_name.Text + "\", l_name=\"" + cust_l_name.Text + "\", bdate=\'"
                + cust_b_date.Value.Date.ToString("yyyy-MM-dd") + "\', VIP=" + vip.Text + " WHERE customer_id=" + CustID.Text + ";";
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
            string insert = "INSERT INTO customer VALUES (" + CustID.Text + ", \"" + cust_f_name.Text + "\", \"" + cust_l_name.Text + "\", \'" + cust_b_date.Value.ToString("yyyy-MM-dd") + "\', " 
                + vip.Text.ToString() + ");";
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
            if (Int32.Parse(street_num.Text) < 100_000 && Int32.Parse(street_num.Text) > 0)
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
        }

        private void InsertLocation_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(street_num.Text) < 100_000 && Int32.Parse(street_num.Text) > 0)
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
            else
            {
                MessageBox.Show("street number cannot exceed 100,000");
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
            string insert = "INSERT INTO machine VALUES (" + mach_id.Text + ", " + available_1_0.Text + ", " + num_uses.Text + ", " + balance.Text + ", " + capacity_liter.Text + ", \"" + type_mach.Text + "\");";
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
            string update = "UPDATE employee SET employee_id=" + emp_id.Text + ", ssn=" + ssn.Text + ", f_name=\"" + emp_f_name.Text + "\", l_name=\"" + emp_l_name.Text + "\", dob=\'" +
                emp_b_day.Value.Date.ToString("yyyy-MM-dd") + "\', salary=" + salary.Text + ", days_off=" + days_off.Text + ", manager_id=" + man_id.Text + " WHERE employee_id=" + emp_id.Text + ";";
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
            if (Int32.Parse(salary.Text) <= 52000)
            {
                string insert = "INSERT INTO employee VALUES (" + emp_id.Text + ", " + ssn.Text + ", \"" + emp_f_name.Text + "\", \"" + emp_l_name.Text + "\", \'" + emp_b_day.Value.Date.ToString("yyyy-MM-dd")
                    + "\', " + salary.Text + ", " + days_off.Text + ",  " + man_id.Text + ");";
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
            else
            {
                MessageBox.Show("salary must be under $25");
            }
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM employee Where employee_id=" + emp_id.Text +";";
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

        private void MachCustUse_Click(object sender, EventArgs e)
        {
            if (CustMachLookupControlGroup.Visible == false)
            {
                CustMachLookupControlGroup.Visible = true;
            }
            else
            {
                CustMachLookupControlGroup.Visible = false;
            }
        }

        private void OutMachCustLookup_Click(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM machine_customer_use", dbCon.Connection))
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

        private void PaymentControl_Click(object sender, EventArgs e)
        {
            if (PaymentControlGroup.Visible == false)
            {
                PaymentControlGroup.Visible = true;
            }
            else
            {
                PaymentControlGroup.Visible = false;
            }
        }

        private void OutPayment_Click(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM payment", dbCon.Connection))
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

        private void RepairControl_Click(object sender, EventArgs e)
        {
            if (RepairControlGroup.Visible == false)
            {
                RepairControlGroup.Visible = true;
            }
            else
            {
                RepairControlGroup.Visible = false;
            }
        }

        private void OutRepair_Click(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM repair", dbCon.Connection))
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

        private void Query7_CustSelectMachine_Click(object sender, EventArgs e)
        {
            string desiredMach = MachID_Input.Text;
            string desiredCust = CustID_ForSelectMach.Text;
            string query = "INSERT INTO machine_customer_use (m_id, c_id, date_used) SELECT m.machine_id, c.customer_id, CURDATE() FROM machine AS m " +
                 $"JOIN customer AS c ON c.pref_loc = m.mach_loc AND m.available = true WHERE m.machine_id={desiredMach} AND c.customer_id={desiredCust};";
            string update = $"UPDATE machine SET available = false WHERE machine_id = {desiredMach};";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        using (MySqlCommand cmd2 = new MySqlCommand(update, dbCon.Connection))
                        {
                            cmd2.ExecuteNonQuery();
                        }
                        OutMachCustLookup_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Query8_GetCustBalance_Click(object sender, EventArgs e)
        {
            string desiredCust = CustIDInput.Text;
            string query = $"SELECT customer_id, balance FROM customer WHERE customer_id={desiredCust};";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{query}", dbCon.Connection))
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

        private void Query9_EmployeeDayOff_Click(object sender, EventArgs e)
        {
            string emp = EmpID_ForDayOff.Text;
            string query = $"SELECT employee_id, days_off FROM employee WHERE employee_id={emp};";
            string update = $"UPDATE employee SET days_off = days_off+1 WHERE employee_id = {emp};";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{query}", dbCon.Connection))
                {
                    try
                    {
                        using (MySqlCommand cmd2 = new MySqlCommand(update, dbCon.Connection))
                        {
                            cmd2.ExecuteNonQuery();
                        }
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

        private void Query10_PayMach_Click(object sender, EventArgs e)
        {
            string date = emp_b_day.Value.ToString("yyyy-MM-dd");
            string query = $"SELECT m.machine_id, (m.balance - p.amount) AS profit FROM machine AS m JOIN payment AS p ON m.machine_id = p.machine_id WHERE p.date_bought >=\'{date}\';";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{query}", dbCon.Connection))
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

        private void Query11_ShowAvailMach_Click(object sender, EventArgs e)
        {
            string machID = mach_id.Text;
            string query = $"SELECT mcu.m_id, mcu.c_id FROM machine_customer_use AS mcu WHERE mcu.m_id={machID};";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{query}", dbCon.Connection))
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

        private void Query12_ShowAvailMach_Click(object sender, EventArgs e)
        {
            string update = "SELECT DISTINCT m.mach_loc, m.machine_id, m.num_uses FROM machine AS m JOIN location AS l ON m.mach_loc = l.location_num WHERE m.num_uses >=500;";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{update}", dbCon.Connection))
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

        private void Query13_CustPayMach_Click(object sender, EventArgs e)
        {
            string mach = supp_id.Text;
            string query = $"SELECT p.machine_id, p.supplier_id FROM payment AS p JOIN repair AS r ON p.supplier_id = r.supp_id WHERE p.supplier_id = (SELECT supplier_id FROM supplier WHERE supplier_id={mach});";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{query}", dbCon.Connection))
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

        private void Query15_BuyMach_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.manager_id, p.supplier_id, SUM(p.amount) AS total_amount_paid FROM payment AS p GROUP BY p.manager_id, p.supplier_id HAVING COUNT(*) >= 10;";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{query}", dbCon.Connection))
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

        private void Query16_TotPayPer_Click(object sender, EventArgs e)
        {
            string query = "SELECT SUM(m.balance) AS total_balance FROM payment AS p JOIN machine as m ON p.machine_id = m.machine_id GROUP BY p.manager_id, p.supplier_id HAVING COUNT(*) >= 10;";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{query}", dbCon.Connection))
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

        private void Query17_FindProfit_Click(object sender, EventArgs e)
        {
            string query = "SELECT SUM(m.balance) AS total_balance, SUM(p.amount) AS total_amount_paid, (SUM(m.balance) - SUM(p.amount)) AS profit_margin " +
                "FROM payment AS p JOIN machine as m ON p.machine_id = m.machine_id GROUP BY p.manager_id, p.supplier_id HAVING COUNT(*) >= 10";
            if (dbCon.IsConnect())
            {
                using (MySqlCommand cmd = new MySqlCommand($"{query}", dbCon.Connection))
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
    }
}
