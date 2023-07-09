namespace Laundromat_v2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EmployeeControlGroup = new System.Windows.Forms.GroupBox();
            this.emp_crud = new System.Windows.Forms.GroupBox();
            this.man_id = new System.Windows.Forms.TextBox();
            this.days_off = new System.Windows.Forms.TextBox();
            this.emp_b_day = new System.Windows.Forms.DateTimePicker();
            this.emp_l_name = new System.Windows.Forms.TextBox();
            this.emp_f_name = new System.Windows.Forms.TextBox();
            this.ssn = new System.Windows.Forms.TextBox();
            this.emp_id = new System.Windows.Forms.TextBox();
            this.DeleteEmployee = new System.Windows.Forms.Button();
            this.InsertEmployee = new System.Windows.Forms.Button();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.OutEmployees = new System.Windows.Forms.Button();
            this.EmployeeControls = new System.Windows.Forms.Button();
            this.MachineControlGroup = new System.Windows.Forms.GroupBox();
            this.mach_crud = new System.Windows.Forms.GroupBox();
            this.type_mach = new System.Windows.Forms.TextBox();
            this.capacity_liter = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.num_uses = new System.Windows.Forms.TextBox();
            this.available_1_0 = new System.Windows.Forms.TextBox();
            this.mach_id = new System.Windows.Forms.TextBox();
            this.DeleteMachine = new System.Windows.Forms.Button();
            this.InsertMachine = new System.Windows.Forms.Button();
            this.UpdateMachine = new System.Windows.Forms.Button();
            this.OutMachine = new System.Windows.Forms.Button();
            this.MachineControls = new System.Windows.Forms.Button();
            this.SupplierControlGroup = new System.Windows.Forms.GroupBox();
            this.supp_crud = new System.Windows.Forms.GroupBox();
            this.supp_name = new System.Windows.Forms.TextBox();
            this.supp_id = new System.Windows.Forms.TextBox();
            this.DeleteSupplier = new System.Windows.Forms.Button();
            this.InsertSupplier = new System.Windows.Forms.Button();
            this.UpdateSupplier = new System.Windows.Forms.Button();
            this.OutSuppliers = new System.Windows.Forms.Button();
            this.SupplierControls = new System.Windows.Forms.Button();
            this.LocationControlGroup = new System.Windows.Forms.GroupBox();
            this.loc_crud = new System.Windows.Forms.GroupBox();
            this.zip_num = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.street_name = new System.Windows.Forms.TextBox();
            this.street_num = new System.Windows.Forms.TextBox();
            this.loc_num = new System.Windows.Forms.TextBox();
            this.DeleteLocation = new System.Windows.Forms.Button();
            this.InsertLocation = new System.Windows.Forms.Button();
            this.UpdateLocation = new System.Windows.Forms.Button();
            this.OutputLocation = new System.Windows.Forms.Button();
            this.LocationControl = new System.Windows.Forms.Button();
            this.CustomerControlGroup = new System.Windows.Forms.GroupBox();
            this.OutCustomers = new System.Windows.Forms.Button();
            this.UpdateCust = new System.Windows.Forms.Button();
            this.InsertCust = new System.Windows.Forms.Button();
            this.DeleteCust = new System.Windows.Forms.Button();
            this.CRUDFields = new System.Windows.Forms.GroupBox();
            this.vip = new System.Windows.Forms.TextBox();
            this.cust_b_date = new System.Windows.Forms.DateTimePicker();
            this.cust_l_name = new System.Windows.Forms.TextBox();
            this.cust_f_name = new System.Windows.Forms.TextBox();
            this.CustID = new System.Windows.Forms.TextBox();
            this.CustControl = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SetConStr = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.EmployeeControlGroup.SuspendLayout();
            this.emp_crud.SuspendLayout();
            this.MachineControlGroup.SuspendLayout();
            this.mach_crud.SuspendLayout();
            this.SupplierControlGroup.SuspendLayout();
            this.supp_crud.SuspendLayout();
            this.LocationControlGroup.SuspendLayout();
            this.loc_crud.SuspendLayout();
            this.CustomerControlGroup.SuspendLayout();
            this.CRUDFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SetConStr);
            this.splitContainer1.Panel1.Controls.Add(this.EmployeeControlGroup);
            this.splitContainer1.Panel1.Controls.Add(this.EmployeeControls);
            this.splitContainer1.Panel1.Controls.Add(this.MachineControlGroup);
            this.splitContainer1.Panel1.Controls.Add(this.MachineControls);
            this.splitContainer1.Panel1.Controls.Add(this.SupplierControlGroup);
            this.splitContainer1.Panel1.Controls.Add(this.SupplierControls);
            this.splitContainer1.Panel1.Controls.Add(this.LocationControlGroup);
            this.splitContainer1.Panel1.Controls.Add(this.LocationControl);
            this.splitContainer1.Panel1.Controls.Add(this.CustomerControlGroup);
            this.splitContainer1.Panel1.Controls.Add(this.CustControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1396, 1219);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.TabIndex = 0;
            // 
            // EmployeeControlGroup
            // 
            this.EmployeeControlGroup.AutoSize = true;
            this.EmployeeControlGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmployeeControlGroup.Controls.Add(this.emp_crud);
            this.EmployeeControlGroup.Controls.Add(this.DeleteEmployee);
            this.EmployeeControlGroup.Controls.Add(this.InsertEmployee);
            this.EmployeeControlGroup.Controls.Add(this.UpdateEmployee);
            this.EmployeeControlGroup.Controls.Add(this.OutEmployees);
            this.EmployeeControlGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeControlGroup.Location = new System.Drawing.Point(0, 775);
            this.EmployeeControlGroup.Name = "EmployeeControlGroup";
            this.EmployeeControlGroup.Padding = new System.Windows.Forms.Padding(10);
            this.EmployeeControlGroup.Size = new System.Drawing.Size(462, 165);
            this.EmployeeControlGroup.TabIndex = 19;
            this.EmployeeControlGroup.TabStop = false;
            this.EmployeeControlGroup.Text = "Employee Control Group";
            this.EmployeeControlGroup.Visible = false;
            // 
            // emp_crud
            // 
            this.emp_crud.AutoSize = true;
            this.emp_crud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emp_crud.Controls.Add(this.salary);
            this.emp_crud.Controls.Add(this.man_id);
            this.emp_crud.Controls.Add(this.days_off);
            this.emp_crud.Controls.Add(this.emp_b_day);
            this.emp_crud.Controls.Add(this.emp_l_name);
            this.emp_crud.Controls.Add(this.emp_f_name);
            this.emp_crud.Controls.Add(this.ssn);
            this.emp_crud.Controls.Add(this.emp_id);
            this.emp_crud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.emp_crud.Location = new System.Drawing.Point(10, 115);
            this.emp_crud.Margin = new System.Windows.Forms.Padding(10);
            this.emp_crud.MinimumSize = new System.Drawing.Size(10, 40);
            this.emp_crud.Name = "emp_crud";
            this.emp_crud.Size = new System.Drawing.Size(442, 40);
            this.emp_crud.TabIndex = 11;
            this.emp_crud.TabStop = false;
            this.emp_crud.Text = "Text Inputs";
            // 
            // man_id
            // 
            this.man_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.man_id.Location = new System.Drawing.Point(420, 16);
            this.man_id.Name = "man_id";
            this.man_id.Size = new System.Drawing.Size(57, 20);
            this.man_id.TabIndex = 13;
            // 
            // days_off
            // 
            this.days_off.Dock = System.Windows.Forms.DockStyle.Left;
            this.days_off.Location = new System.Drawing.Point(363, 16);
            this.days_off.Name = "days_off";
            this.days_off.Size = new System.Drawing.Size(57, 20);
            this.days_off.TabIndex = 12;
            // 
            // emp_b_day
            // 
            this.emp_b_day.Dock = System.Windows.Forms.DockStyle.Left;
            this.emp_b_day.Location = new System.Drawing.Point(244, 16);
            this.emp_b_day.Name = "emp_b_day";
            this.emp_b_day.Size = new System.Drawing.Size(119, 20);
            this.emp_b_day.TabIndex = 11;
            // 
            // emp_l_name
            // 
            this.emp_l_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.emp_l_name.Location = new System.Drawing.Point(173, 16);
            this.emp_l_name.Name = "emp_l_name";
            this.emp_l_name.Size = new System.Drawing.Size(71, 20);
            this.emp_l_name.TabIndex = 10;
            // 
            // emp_f_name
            // 
            this.emp_f_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.emp_f_name.Location = new System.Drawing.Point(108, 16);
            this.emp_f_name.Name = "emp_f_name";
            this.emp_f_name.Size = new System.Drawing.Size(65, 20);
            this.emp_f_name.TabIndex = 9;
            // 
            // ssn
            // 
            this.ssn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ssn.Location = new System.Drawing.Point(54, 16);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(54, 20);
            this.ssn.TabIndex = 8;
            // 
            // emp_id
            // 
            this.emp_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.emp_id.Location = new System.Drawing.Point(3, 16);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(51, 20);
            this.emp_id.TabIndex = 7;
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.AutoSize = true;
            this.DeleteEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteEmployee.Location = new System.Drawing.Point(10, 92);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(442, 23);
            this.DeleteEmployee.TabIndex = 10;
            this.DeleteEmployee.Text = "Delete Employee";
            this.DeleteEmployee.UseVisualStyleBackColor = true;
            this.DeleteEmployee.Click += new System.EventHandler(this.DeleteEmployee_Click);
            // 
            // InsertEmployee
            // 
            this.InsertEmployee.AutoSize = true;
            this.InsertEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertEmployee.Location = new System.Drawing.Point(10, 69);
            this.InsertEmployee.Name = "InsertEmployee";
            this.InsertEmployee.Size = new System.Drawing.Size(442, 23);
            this.InsertEmployee.TabIndex = 9;
            this.InsertEmployee.Text = "Insert Employee";
            this.InsertEmployee.UseVisualStyleBackColor = true;
            this.InsertEmployee.Click += new System.EventHandler(this.InsertEmployee_Click);
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.AutoSize = true;
            this.UpdateEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateEmployee.Location = new System.Drawing.Point(10, 46);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(442, 23);
            this.UpdateEmployee.TabIndex = 8;
            this.UpdateEmployee.Text = "Update Employee";
            this.UpdateEmployee.UseVisualStyleBackColor = true;
            this.UpdateEmployee.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // OutEmployees
            // 
            this.OutEmployees.AutoSize = true;
            this.OutEmployees.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutEmployees.Location = new System.Drawing.Point(10, 23);
            this.OutEmployees.Name = "OutEmployees";
            this.OutEmployees.Size = new System.Drawing.Size(442, 23);
            this.OutEmployees.TabIndex = 7;
            this.OutEmployees.Text = "Output Employees";
            this.OutEmployees.UseVisualStyleBackColor = true;
            this.OutEmployees.Click += new System.EventHandler(this.OutEmployees_Click);
            // 
            // EmployeeControls
            // 
            this.EmployeeControls.AutoSize = true;
            this.EmployeeControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmployeeControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeControls.Location = new System.Drawing.Point(0, 752);
            this.EmployeeControls.Name = "EmployeeControls";
            this.EmployeeControls.Size = new System.Drawing.Size(462, 23);
            this.EmployeeControls.TabIndex = 18;
            this.EmployeeControls.Text = "Employee Controls";
            this.EmployeeControls.UseVisualStyleBackColor = true;
            this.EmployeeControls.Click += new System.EventHandler(this.EmployeeControls_Click);
            // 
            // MachineControlGroup
            // 
            this.MachineControlGroup.AutoSize = true;
            this.MachineControlGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MachineControlGroup.Controls.Add(this.mach_crud);
            this.MachineControlGroup.Controls.Add(this.DeleteMachine);
            this.MachineControlGroup.Controls.Add(this.InsertMachine);
            this.MachineControlGroup.Controls.Add(this.UpdateMachine);
            this.MachineControlGroup.Controls.Add(this.OutMachine);
            this.MachineControlGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.MachineControlGroup.Location = new System.Drawing.Point(0, 587);
            this.MachineControlGroup.Name = "MachineControlGroup";
            this.MachineControlGroup.Padding = new System.Windows.Forms.Padding(10);
            this.MachineControlGroup.Size = new System.Drawing.Size(462, 165);
            this.MachineControlGroup.TabIndex = 17;
            this.MachineControlGroup.TabStop = false;
            this.MachineControlGroup.Text = "Machine Control Group";
            this.MachineControlGroup.Visible = false;
            // 
            // mach_crud
            // 
            this.mach_crud.AutoSize = true;
            this.mach_crud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mach_crud.Controls.Add(this.type_mach);
            this.mach_crud.Controls.Add(this.capacity_liter);
            this.mach_crud.Controls.Add(this.balance);
            this.mach_crud.Controls.Add(this.num_uses);
            this.mach_crud.Controls.Add(this.available_1_0);
            this.mach_crud.Controls.Add(this.mach_id);
            this.mach_crud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mach_crud.Location = new System.Drawing.Point(10, 115);
            this.mach_crud.Margin = new System.Windows.Forms.Padding(10);
            this.mach_crud.MinimumSize = new System.Drawing.Size(10, 40);
            this.mach_crud.Name = "mach_crud";
            this.mach_crud.Size = new System.Drawing.Size(442, 40);
            this.mach_crud.TabIndex = 12;
            this.mach_crud.TabStop = false;
            this.mach_crud.Text = "Text Inputs";
            // 
            // type_mach
            // 
            this.type_mach.Dock = System.Windows.Forms.DockStyle.Left;
            this.type_mach.Location = new System.Drawing.Point(295, 16);
            this.type_mach.Name = "type_mach";
            this.type_mach.Size = new System.Drawing.Size(100, 20);
            this.type_mach.TabIndex = 12;
            // 
            // capacity_liter
            // 
            this.capacity_liter.Dock = System.Windows.Forms.DockStyle.Left;
            this.capacity_liter.Location = new System.Drawing.Point(236, 16);
            this.capacity_liter.Name = "capacity_liter";
            this.capacity_liter.Size = new System.Drawing.Size(59, 20);
            this.capacity_liter.TabIndex = 11;
            // 
            // balance
            // 
            this.balance.Dock = System.Windows.Forms.DockStyle.Left;
            this.balance.Location = new System.Drawing.Point(173, 16);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(63, 20);
            this.balance.TabIndex = 10;
            // 
            // num_uses
            // 
            this.num_uses.Dock = System.Windows.Forms.DockStyle.Left;
            this.num_uses.Location = new System.Drawing.Point(108, 16);
            this.num_uses.Name = "num_uses";
            this.num_uses.Size = new System.Drawing.Size(65, 20);
            this.num_uses.TabIndex = 9;
            // 
            // available_1_0
            // 
            this.available_1_0.Dock = System.Windows.Forms.DockStyle.Left;
            this.available_1_0.Location = new System.Drawing.Point(54, 16);
            this.available_1_0.Name = "available_1_0";
            this.available_1_0.Size = new System.Drawing.Size(54, 20);
            this.available_1_0.TabIndex = 8;
            // 
            // mach_id
            // 
            this.mach_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.mach_id.Location = new System.Drawing.Point(3, 16);
            this.mach_id.Name = "mach_id";
            this.mach_id.Size = new System.Drawing.Size(51, 20);
            this.mach_id.TabIndex = 7;
            // 
            // DeleteMachine
            // 
            this.DeleteMachine.AutoSize = true;
            this.DeleteMachine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteMachine.Location = new System.Drawing.Point(10, 92);
            this.DeleteMachine.Name = "DeleteMachine";
            this.DeleteMachine.Size = new System.Drawing.Size(442, 23);
            this.DeleteMachine.TabIndex = 11;
            this.DeleteMachine.Text = "Delete Machine";
            this.DeleteMachine.UseVisualStyleBackColor = true;
            this.DeleteMachine.Click += new System.EventHandler(this.DeleteMachine_Click);
            // 
            // InsertMachine
            // 
            this.InsertMachine.AutoSize = true;
            this.InsertMachine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertMachine.Location = new System.Drawing.Point(10, 69);
            this.InsertMachine.Name = "InsertMachine";
            this.InsertMachine.Size = new System.Drawing.Size(442, 23);
            this.InsertMachine.TabIndex = 10;
            this.InsertMachine.Text = "Insert Machine";
            this.InsertMachine.UseVisualStyleBackColor = true;
            this.InsertMachine.Click += new System.EventHandler(this.InsertMachine_Click);
            // 
            // UpdateMachine
            // 
            this.UpdateMachine.AutoSize = true;
            this.UpdateMachine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateMachine.Location = new System.Drawing.Point(10, 46);
            this.UpdateMachine.Name = "UpdateMachine";
            this.UpdateMachine.Size = new System.Drawing.Size(442, 23);
            this.UpdateMachine.TabIndex = 9;
            this.UpdateMachine.Text = "Update Machine";
            this.UpdateMachine.UseVisualStyleBackColor = true;
            this.UpdateMachine.Click += new System.EventHandler(this.UpdateMachine_Click);
            // 
            // OutMachine
            // 
            this.OutMachine.AutoSize = true;
            this.OutMachine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutMachine.Location = new System.Drawing.Point(10, 23);
            this.OutMachine.Name = "OutMachine";
            this.OutMachine.Size = new System.Drawing.Size(442, 23);
            this.OutMachine.TabIndex = 8;
            this.OutMachine.Text = "Output Machines";
            this.OutMachine.UseVisualStyleBackColor = true;
            this.OutMachine.Click += new System.EventHandler(this.OutMachine_Click);
            // 
            // MachineControls
            // 
            this.MachineControls.AutoSize = true;
            this.MachineControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MachineControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.MachineControls.Location = new System.Drawing.Point(0, 564);
            this.MachineControls.Name = "MachineControls";
            this.MachineControls.Size = new System.Drawing.Size(462, 23);
            this.MachineControls.TabIndex = 16;
            this.MachineControls.Text = "Machine Controls";
            this.MachineControls.UseVisualStyleBackColor = true;
            this.MachineControls.Click += new System.EventHandler(this.MachineControls_Click);
            // 
            // SupplierControlGroup
            // 
            this.SupplierControlGroup.AutoSize = true;
            this.SupplierControlGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SupplierControlGroup.Controls.Add(this.supp_crud);
            this.SupplierControlGroup.Controls.Add(this.DeleteSupplier);
            this.SupplierControlGroup.Controls.Add(this.InsertSupplier);
            this.SupplierControlGroup.Controls.Add(this.UpdateSupplier);
            this.SupplierControlGroup.Controls.Add(this.OutSuppliers);
            this.SupplierControlGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.SupplierControlGroup.Location = new System.Drawing.Point(0, 399);
            this.SupplierControlGroup.Name = "SupplierControlGroup";
            this.SupplierControlGroup.Padding = new System.Windows.Forms.Padding(10);
            this.SupplierControlGroup.Size = new System.Drawing.Size(462, 165);
            this.SupplierControlGroup.TabIndex = 15;
            this.SupplierControlGroup.TabStop = false;
            this.SupplierControlGroup.Text = "Supplier Control Group";
            this.SupplierControlGroup.Visible = false;
            // 
            // supp_crud
            // 
            this.supp_crud.AutoSize = true;
            this.supp_crud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.supp_crud.Controls.Add(this.supp_name);
            this.supp_crud.Controls.Add(this.supp_id);
            this.supp_crud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.supp_crud.Location = new System.Drawing.Point(10, 115);
            this.supp_crud.Margin = new System.Windows.Forms.Padding(10);
            this.supp_crud.MinimumSize = new System.Drawing.Size(10, 40);
            this.supp_crud.Name = "supp_crud";
            this.supp_crud.Size = new System.Drawing.Size(442, 40);
            this.supp_crud.TabIndex = 19;
            this.supp_crud.TabStop = false;
            this.supp_crud.Text = "Text Inputs";
            // 
            // supp_name
            // 
            this.supp_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.supp_name.Location = new System.Drawing.Point(54, 16);
            this.supp_name.Name = "supp_name";
            this.supp_name.Size = new System.Drawing.Size(100, 20);
            this.supp_name.TabIndex = 8;
            // 
            // supp_id
            // 
            this.supp_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.supp_id.Location = new System.Drawing.Point(3, 16);
            this.supp_id.Name = "supp_id";
            this.supp_id.Size = new System.Drawing.Size(51, 20);
            this.supp_id.TabIndex = 7;
            // 
            // DeleteSupplier
            // 
            this.DeleteSupplier.AutoSize = true;
            this.DeleteSupplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteSupplier.Location = new System.Drawing.Point(10, 92);
            this.DeleteSupplier.Name = "DeleteSupplier";
            this.DeleteSupplier.Size = new System.Drawing.Size(442, 23);
            this.DeleteSupplier.TabIndex = 18;
            this.DeleteSupplier.Text = "Delete Supplier";
            this.DeleteSupplier.UseVisualStyleBackColor = true;
            this.DeleteSupplier.Click += new System.EventHandler(this.DeleteSupplier_Click);
            // 
            // InsertSupplier
            // 
            this.InsertSupplier.AutoSize = true;
            this.InsertSupplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertSupplier.Location = new System.Drawing.Point(10, 69);
            this.InsertSupplier.Name = "InsertSupplier";
            this.InsertSupplier.Size = new System.Drawing.Size(442, 23);
            this.InsertSupplier.TabIndex = 17;
            this.InsertSupplier.Text = "Insert Supplier";
            this.InsertSupplier.UseVisualStyleBackColor = true;
            this.InsertSupplier.Click += new System.EventHandler(this.InsertSupplier_Click);
            // 
            // UpdateSupplier
            // 
            this.UpdateSupplier.AutoSize = true;
            this.UpdateSupplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateSupplier.Location = new System.Drawing.Point(10, 46);
            this.UpdateSupplier.Name = "UpdateSupplier";
            this.UpdateSupplier.Size = new System.Drawing.Size(442, 23);
            this.UpdateSupplier.TabIndex = 16;
            this.UpdateSupplier.Text = "Update Supplier";
            this.UpdateSupplier.UseVisualStyleBackColor = true;
            this.UpdateSupplier.Click += new System.EventHandler(this.UpdateSupplier_Click);
            // 
            // OutSuppliers
            // 
            this.OutSuppliers.AutoSize = true;
            this.OutSuppliers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutSuppliers.Location = new System.Drawing.Point(10, 23);
            this.OutSuppliers.Name = "OutSuppliers";
            this.OutSuppliers.Size = new System.Drawing.Size(442, 23);
            this.OutSuppliers.TabIndex = 9;
            this.OutSuppliers.Text = "Output Suppliers";
            this.OutSuppliers.UseVisualStyleBackColor = true;
            this.OutSuppliers.Click += new System.EventHandler(this.OutSuppliers_Click);
            // 
            // SupplierControls
            // 
            this.SupplierControls.AutoSize = true;
            this.SupplierControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SupplierControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.SupplierControls.Location = new System.Drawing.Point(0, 376);
            this.SupplierControls.Name = "SupplierControls";
            this.SupplierControls.Size = new System.Drawing.Size(462, 23);
            this.SupplierControls.TabIndex = 14;
            this.SupplierControls.Text = "Supplier Controls";
            this.SupplierControls.UseVisualStyleBackColor = true;
            this.SupplierControls.Click += new System.EventHandler(this.SupplierControls_Click);
            // 
            // LocationControlGroup
            // 
            this.LocationControlGroup.AutoSize = true;
            this.LocationControlGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LocationControlGroup.Controls.Add(this.loc_crud);
            this.LocationControlGroup.Controls.Add(this.DeleteLocation);
            this.LocationControlGroup.Controls.Add(this.InsertLocation);
            this.LocationControlGroup.Controls.Add(this.UpdateLocation);
            this.LocationControlGroup.Controls.Add(this.OutputLocation);
            this.LocationControlGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationControlGroup.Location = new System.Drawing.Point(0, 211);
            this.LocationControlGroup.Name = "LocationControlGroup";
            this.LocationControlGroup.Padding = new System.Windows.Forms.Padding(10);
            this.LocationControlGroup.Size = new System.Drawing.Size(462, 165);
            this.LocationControlGroup.TabIndex = 13;
            this.LocationControlGroup.TabStop = false;
            this.LocationControlGroup.Text = "Location Control Group";
            this.LocationControlGroup.Visible = false;
            // 
            // loc_crud
            // 
            this.loc_crud.AutoSize = true;
            this.loc_crud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loc_crud.Controls.Add(this.zip_num);
            this.loc_crud.Controls.Add(this.state);
            this.loc_crud.Controls.Add(this.city);
            this.loc_crud.Controls.Add(this.street_name);
            this.loc_crud.Controls.Add(this.street_num);
            this.loc_crud.Controls.Add(this.loc_num);
            this.loc_crud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loc_crud.Location = new System.Drawing.Point(10, 115);
            this.loc_crud.Margin = new System.Windows.Forms.Padding(10);
            this.loc_crud.MinimumSize = new System.Drawing.Size(10, 40);
            this.loc_crud.Name = "loc_crud";
            this.loc_crud.Size = new System.Drawing.Size(442, 40);
            this.loc_crud.TabIndex = 9;
            this.loc_crud.TabStop = false;
            this.loc_crud.Text = "Text Inputs";
            // 
            // zip_num
            // 
            this.zip_num.Dock = System.Windows.Forms.DockStyle.Left;
            this.zip_num.Location = new System.Drawing.Point(302, 16);
            this.zip_num.Name = "zip_num";
            this.zip_num.Size = new System.Drawing.Size(61, 20);
            this.zip_num.TabIndex = 12;
            // 
            // state
            // 
            this.state.Dock = System.Windows.Forms.DockStyle.Left;
            this.state.Location = new System.Drawing.Point(236, 16);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(66, 20);
            this.state.TabIndex = 11;
            // 
            // city
            // 
            this.city.Dock = System.Windows.Forms.DockStyle.Left;
            this.city.Location = new System.Drawing.Point(173, 16);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(63, 20);
            this.city.TabIndex = 10;
            // 
            // street_name
            // 
            this.street_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.street_name.Location = new System.Drawing.Point(108, 16);
            this.street_name.Name = "street_name";
            this.street_name.Size = new System.Drawing.Size(65, 20);
            this.street_name.TabIndex = 9;
            // 
            // street_num
            // 
            this.street_num.Dock = System.Windows.Forms.DockStyle.Left;
            this.street_num.Location = new System.Drawing.Point(54, 16);
            this.street_num.Name = "street_num";
            this.street_num.Size = new System.Drawing.Size(54, 20);
            this.street_num.TabIndex = 8;
            // 
            // loc_num
            // 
            this.loc_num.Dock = System.Windows.Forms.DockStyle.Left;
            this.loc_num.Location = new System.Drawing.Point(3, 16);
            this.loc_num.Name = "loc_num";
            this.loc_num.Size = new System.Drawing.Size(51, 20);
            this.loc_num.TabIndex = 7;
            // 
            // DeleteLocation
            // 
            this.DeleteLocation.AutoSize = true;
            this.DeleteLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteLocation.Location = new System.Drawing.Point(10, 92);
            this.DeleteLocation.Name = "DeleteLocation";
            this.DeleteLocation.Size = new System.Drawing.Size(442, 23);
            this.DeleteLocation.TabIndex = 8;
            this.DeleteLocation.Text = "Delete Location";
            this.DeleteLocation.UseVisualStyleBackColor = true;
            this.DeleteLocation.Click += new System.EventHandler(this.DeleteLocation_Click);
            // 
            // InsertLocation
            // 
            this.InsertLocation.AutoSize = true;
            this.InsertLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertLocation.Location = new System.Drawing.Point(10, 69);
            this.InsertLocation.Name = "InsertLocation";
            this.InsertLocation.Size = new System.Drawing.Size(442, 23);
            this.InsertLocation.TabIndex = 7;
            this.InsertLocation.Text = "Insert Location";
            this.InsertLocation.UseVisualStyleBackColor = true;
            this.InsertLocation.Click += new System.EventHandler(this.InsertLocation_Click);
            // 
            // UpdateLocation
            // 
            this.UpdateLocation.AutoSize = true;
            this.UpdateLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateLocation.Location = new System.Drawing.Point(10, 46);
            this.UpdateLocation.Name = "UpdateLocation";
            this.UpdateLocation.Size = new System.Drawing.Size(442, 23);
            this.UpdateLocation.TabIndex = 6;
            this.UpdateLocation.Text = "Update Location";
            this.UpdateLocation.UseVisualStyleBackColor = true;
            this.UpdateLocation.Click += new System.EventHandler(this.UpdateLocation_Click);
            // 
            // OutputLocation
            // 
            this.OutputLocation.AutoSize = true;
            this.OutputLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutputLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputLocation.Location = new System.Drawing.Point(10, 23);
            this.OutputLocation.Name = "OutputLocation";
            this.OutputLocation.Size = new System.Drawing.Size(442, 23);
            this.OutputLocation.TabIndex = 5;
            this.OutputLocation.Text = "Output Location";
            this.OutputLocation.UseVisualStyleBackColor = true;
            this.OutputLocation.Click += new System.EventHandler(this.OutLocation_Click);
            // 
            // LocationControl
            // 
            this.LocationControl.AutoSize = true;
            this.LocationControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LocationControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationControl.Location = new System.Drawing.Point(0, 188);
            this.LocationControl.Name = "LocationControl";
            this.LocationControl.Size = new System.Drawing.Size(462, 23);
            this.LocationControl.TabIndex = 12;
            this.LocationControl.Text = "Location Controls";
            this.LocationControl.UseVisualStyleBackColor = true;
            this.LocationControl.Click += new System.EventHandler(this.LocationControl_Click);
            // 
            // CustomerControlGroup
            // 
            this.CustomerControlGroup.AutoSize = true;
            this.CustomerControlGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CustomerControlGroup.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerControlGroup.Controls.Add(this.OutCustomers);
            this.CustomerControlGroup.Controls.Add(this.UpdateCust);
            this.CustomerControlGroup.Controls.Add(this.InsertCust);
            this.CustomerControlGroup.Controls.Add(this.DeleteCust);
            this.CustomerControlGroup.Controls.Add(this.CRUDFields);
            this.CustomerControlGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerControlGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CustomerControlGroup.Location = new System.Drawing.Point(0, 23);
            this.CustomerControlGroup.Name = "CustomerControlGroup";
            this.CustomerControlGroup.Padding = new System.Windows.Forms.Padding(10);
            this.CustomerControlGroup.Size = new System.Drawing.Size(462, 165);
            this.CustomerControlGroup.TabIndex = 11;
            this.CustomerControlGroup.TabStop = false;
            this.CustomerControlGroup.Text = "Customer Control Group";
            this.CustomerControlGroup.Visible = false;
            // 
            // OutCustomers
            // 
            this.OutCustomers.AutoSize = true;
            this.OutCustomers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutCustomers.Location = new System.Drawing.Point(10, 23);
            this.OutCustomers.Name = "OutCustomers";
            this.OutCustomers.Size = new System.Drawing.Size(442, 23);
            this.OutCustomers.TabIndex = 6;
            this.OutCustomers.Text = "Output Customers";
            this.OutCustomers.UseVisualStyleBackColor = true;
            this.OutCustomers.Click += new System.EventHandler(this.OutCustomers_Click);
            // 
            // UpdateCust
            // 
            this.UpdateCust.AutoSize = true;
            this.UpdateCust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateCust.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UpdateCust.Location = new System.Drawing.Point(10, 46);
            this.UpdateCust.Margin = new System.Windows.Forms.Padding(1);
            this.UpdateCust.Name = "UpdateCust";
            this.UpdateCust.Size = new System.Drawing.Size(442, 23);
            this.UpdateCust.TabIndex = 2;
            this.UpdateCust.Text = "Update Customer";
            this.UpdateCust.UseVisualStyleBackColor = true;
            this.UpdateCust.Click += new System.EventHandler(this.Update_Click);
            // 
            // InsertCust
            // 
            this.InsertCust.AutoSize = true;
            this.InsertCust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertCust.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InsertCust.Location = new System.Drawing.Point(10, 69);
            this.InsertCust.Name = "InsertCust";
            this.InsertCust.Size = new System.Drawing.Size(442, 23);
            this.InsertCust.TabIndex = 0;
            this.InsertCust.Text = "Insert Customer";
            this.InsertCust.UseVisualStyleBackColor = true;
            this.InsertCust.Click += new System.EventHandler(this.Insert_Click);
            // 
            // DeleteCust
            // 
            this.DeleteCust.AutoSize = true;
            this.DeleteCust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteCust.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeleteCust.Location = new System.Drawing.Point(10, 92);
            this.DeleteCust.Margin = new System.Windows.Forms.Padding(1);
            this.DeleteCust.Name = "DeleteCust";
            this.DeleteCust.Size = new System.Drawing.Size(442, 23);
            this.DeleteCust.TabIndex = 3;
            this.DeleteCust.Text = "Delete Customer";
            this.DeleteCust.UseVisualStyleBackColor = true;
            this.DeleteCust.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CRUDFields
            // 
            this.CRUDFields.AutoSize = true;
            this.CRUDFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CRUDFields.Controls.Add(this.vip);
            this.CRUDFields.Controls.Add(this.cust_b_date);
            this.CRUDFields.Controls.Add(this.cust_l_name);
            this.CRUDFields.Controls.Add(this.cust_f_name);
            this.CRUDFields.Controls.Add(this.CustID);
            this.CRUDFields.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CRUDFields.Location = new System.Drawing.Point(10, 115);
            this.CRUDFields.Margin = new System.Windows.Forms.Padding(10);
            this.CRUDFields.MinimumSize = new System.Drawing.Size(10, 40);
            this.CRUDFields.Name = "CRUDFields";
            this.CRUDFields.Size = new System.Drawing.Size(442, 40);
            this.CRUDFields.TabIndex = 8;
            this.CRUDFields.TabStop = false;
            this.CRUDFields.Text = "Text Inputs";
            // 
            // vip
            // 
            this.vip.Dock = System.Windows.Forms.DockStyle.Left;
            this.vip.Location = new System.Drawing.Point(377, 16);
            this.vip.Name = "vip";
            this.vip.Size = new System.Drawing.Size(49, 20);
            this.vip.TabIndex = 11;
            // 
            // cust_b_date
            // 
            this.cust_b_date.Dock = System.Windows.Forms.DockStyle.Left;
            this.cust_b_date.Location = new System.Drawing.Point(256, 16);
            this.cust_b_date.Name = "cust_b_date";
            this.cust_b_date.Size = new System.Drawing.Size(121, 20);
            this.cust_b_date.TabIndex = 10;
            // 
            // cust_l_name
            // 
            this.cust_l_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.cust_l_name.Location = new System.Drawing.Point(154, 16);
            this.cust_l_name.Name = "cust_l_name";
            this.cust_l_name.Size = new System.Drawing.Size(102, 20);
            this.cust_l_name.TabIndex = 9;
            // 
            // cust_f_name
            // 
            this.cust_f_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.cust_f_name.Location = new System.Drawing.Point(54, 16);
            this.cust_f_name.Name = "cust_f_name";
            this.cust_f_name.Size = new System.Drawing.Size(100, 20);
            this.cust_f_name.TabIndex = 8;
            // 
            // CustID
            // 
            this.CustID.Dock = System.Windows.Forms.DockStyle.Left;
            this.CustID.Location = new System.Drawing.Point(3, 16);
            this.CustID.Name = "CustID";
            this.CustID.Size = new System.Drawing.Size(51, 20);
            this.CustID.TabIndex = 7;
            // 
            // CustControl
            // 
            this.CustControl.AutoSize = true;
            this.CustControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CustControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustControl.Location = new System.Drawing.Point(0, 0);
            this.CustControl.Name = "CustControl";
            this.CustControl.Size = new System.Drawing.Size(462, 23);
            this.CustControl.TabIndex = 10;
            this.CustControl.Text = "Customer Controls";
            this.CustControl.UseVisualStyleBackColor = true;
            this.CustControl.Click += new System.EventHandler(this.CustControl_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(930, 1219);
            this.dataGridView.TabIndex = 6;
            // 
            // SetConStr
            // 
            this.SetConStr.AutoSize = true;
            this.SetConStr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetConStr.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetConStr.Location = new System.Drawing.Point(0, 940);
            this.SetConStr.Name = "SetConStr";
            this.SetConStr.Size = new System.Drawing.Size(462, 23);
            this.SetConStr.TabIndex = 20;
            this.SetConStr.Text = "Set Conneciton String";
            this.SetConStr.UseVisualStyleBackColor = true;
            this.SetConStr.Click += new System.EventHandler(this.SetConStr_Click);
            // 
            // salary
            // 
            this.salary.Dock = System.Windows.Forms.DockStyle.Left;
            this.salary.Location = new System.Drawing.Point(477, 16);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(100, 20);
            this.salary.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 1219);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.EmployeeControlGroup.ResumeLayout(false);
            this.EmployeeControlGroup.PerformLayout();
            this.emp_crud.ResumeLayout(false);
            this.emp_crud.PerformLayout();
            this.MachineControlGroup.ResumeLayout(false);
            this.MachineControlGroup.PerformLayout();
            this.mach_crud.ResumeLayout(false);
            this.mach_crud.PerformLayout();
            this.SupplierControlGroup.ResumeLayout(false);
            this.SupplierControlGroup.PerformLayout();
            this.supp_crud.ResumeLayout(false);
            this.supp_crud.PerformLayout();
            this.LocationControlGroup.ResumeLayout(false);
            this.LocationControlGroup.PerformLayout();
            this.loc_crud.ResumeLayout(false);
            this.loc_crud.PerformLayout();
            this.CustomerControlGroup.ResumeLayout(false);
            this.CustomerControlGroup.PerformLayout();
            this.CRUDFields.ResumeLayout(false);
            this.CRUDFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button InsertCust;
        private System.Windows.Forms.Button UpdateCust;
        private System.Windows.Forms.Button DeleteCust;
        private System.Windows.Forms.Button OutputLocation;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button OutCustomers;
        private System.Windows.Forms.Button OutEmployees;
        private System.Windows.Forms.Button OutMachine;
        private System.Windows.Forms.Button OutSuppliers;
        private System.Windows.Forms.Button CustControl;
        private System.Windows.Forms.GroupBox CustomerControlGroup;
        private System.Windows.Forms.Button LocationControl;
        private System.Windows.Forms.GroupBox LocationControlGroup;
        private System.Windows.Forms.Button DeleteLocation;
        private System.Windows.Forms.Button InsertLocation;
        private System.Windows.Forms.Button UpdateLocation;
        private System.Windows.Forms.Button SupplierControls;
        private System.Windows.Forms.GroupBox SupplierControlGroup;
        private System.Windows.Forms.Button DeleteSupplier;
        private System.Windows.Forms.Button InsertSupplier;
        private System.Windows.Forms.Button UpdateSupplier;
        private System.Windows.Forms.GroupBox MachineControlGroup;
        private System.Windows.Forms.Button MachineControls;
        private System.Windows.Forms.Button DeleteMachine;
        private System.Windows.Forms.Button InsertMachine;
        private System.Windows.Forms.Button UpdateMachine;
        private System.Windows.Forms.Button EmployeeControls;
        private System.Windows.Forms.GroupBox EmployeeControlGroup;
        private System.Windows.Forms.Button DeleteEmployee;
        private System.Windows.Forms.Button InsertEmployee;
        private System.Windows.Forms.Button UpdateEmployee;
        private System.Windows.Forms.TextBox CustID;
        private System.Windows.Forms.GroupBox CRUDFields;
        private System.Windows.Forms.TextBox cust_f_name;
        private System.Windows.Forms.TextBox cust_l_name;
        private System.Windows.Forms.GroupBox mach_crud;
        private System.Windows.Forms.TextBox num_uses;
        private System.Windows.Forms.TextBox available_1_0;
        private System.Windows.Forms.TextBox mach_id;
        private System.Windows.Forms.GroupBox supp_crud;
        private System.Windows.Forms.TextBox supp_name;
        private System.Windows.Forms.TextBox supp_id;
        private System.Windows.Forms.GroupBox loc_crud;
        private System.Windows.Forms.TextBox street_name;
        private System.Windows.Forms.TextBox street_num;
        private System.Windows.Forms.TextBox loc_num;
        private System.Windows.Forms.GroupBox emp_crud;
        private System.Windows.Forms.TextBox emp_f_name;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.TextBox emp_id;
        private System.Windows.Forms.TextBox vip;
        private System.Windows.Forms.DateTimePicker cust_b_date;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox zip_num;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.TextBox type_mach;
        private System.Windows.Forms.TextBox capacity_liter;
        private System.Windows.Forms.TextBox days_off;
        private System.Windows.Forms.DateTimePicker emp_b_day;
        private System.Windows.Forms.TextBox emp_l_name;
        private System.Windows.Forms.TextBox man_id;
        private System.Windows.Forms.Button SetConStr;
        private System.Windows.Forms.TextBox salary;
    }
}

