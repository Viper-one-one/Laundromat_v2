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
            this.OutSuppliers = new System.Windows.Forms.Button();
            this.OutMachine = new System.Windows.Forms.Button();
            this.OutEmployees = new System.Windows.Forms.Button();
            this.OutCustomers = new System.Windows.Forms.Button();
            this.OutputLocation = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.OutSuppliers);
            this.splitContainer1.Panel1.Controls.Add(this.OutMachine);
            this.splitContainer1.Panel1.Controls.Add(this.OutEmployees);
            this.splitContainer1.Panel1.Controls.Add(this.OutCustomers);
            this.splitContainer1.Panel1.Controls.Add(this.OutputLocation);
            this.splitContainer1.Panel1.Controls.Add(this.Delete);
            this.splitContainer1.Panel1.Controls.Add(this.Update);
            this.splitContainer1.Panel1.Controls.Add(this.Insert);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // OutSuppliers
            // 
            this.OutSuppliers.AutoSize = true;
            this.OutSuppliers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutSuppliers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutSuppliers.Location = new System.Drawing.Point(0, 266);
            this.OutSuppliers.Name = "OutSuppliers";
            this.OutSuppliers.Size = new System.Drawing.Size(265, 23);
            this.OutSuppliers.TabIndex = 9;
            this.OutSuppliers.Text = "Output Suppliers";
            this.OutSuppliers.UseVisualStyleBackColor = true;
            this.OutSuppliers.Click += new System.EventHandler(this.OutSuppliers_Click);
            // 
            // OutMachine
            // 
            this.OutMachine.AutoSize = true;
            this.OutMachine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutMachine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutMachine.Location = new System.Drawing.Point(0, 289);
            this.OutMachine.Name = "OutMachine";
            this.OutMachine.Size = new System.Drawing.Size(265, 23);
            this.OutMachine.TabIndex = 8;
            this.OutMachine.Text = "Output Machines";
            this.OutMachine.UseVisualStyleBackColor = true;
            this.OutMachine.Click += new System.EventHandler(this.OutMachine_Click);
            // 
            // OutEmployees
            // 
            this.OutEmployees.AutoSize = true;
            this.OutEmployees.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutEmployees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutEmployees.Location = new System.Drawing.Point(0, 312);
            this.OutEmployees.Name = "OutEmployees";
            this.OutEmployees.Size = new System.Drawing.Size(265, 23);
            this.OutEmployees.TabIndex = 7;
            this.OutEmployees.Text = "Output Employees";
            this.OutEmployees.UseVisualStyleBackColor = true;
            this.OutEmployees.Click += new System.EventHandler(this.OutEmployees_Click);
            // 
            // OutCustomers
            // 
            this.OutCustomers.AutoSize = true;
            this.OutCustomers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutCustomers.Location = new System.Drawing.Point(0, 335);
            this.OutCustomers.Name = "OutCustomers";
            this.OutCustomers.Size = new System.Drawing.Size(265, 23);
            this.OutCustomers.TabIndex = 6;
            this.OutCustomers.Text = "Output Customers";
            this.OutCustomers.UseVisualStyleBackColor = true;
            this.OutCustomers.Click += new System.EventHandler(this.OutCustomers_Click);
            // 
            // OutputLocation
            // 
            this.OutputLocation.AutoSize = true;
            this.OutputLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutputLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutputLocation.Location = new System.Drawing.Point(0, 358);
            this.OutputLocation.Name = "OutputLocation";
            this.OutputLocation.Size = new System.Drawing.Size(265, 23);
            this.OutputLocation.TabIndex = 5;
            this.OutputLocation.Text = "Output Location";
            this.OutputLocation.UseVisualStyleBackColor = true;
            this.OutputLocation.Click += new System.EventHandler(this.OutLocation_Click);
            // 
            // Delete
            // 
            this.Delete.AutoSize = true;
            this.Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Delete.Location = new System.Drawing.Point(0, 381);
            this.Delete.Margin = new System.Windows.Forms.Padding(1);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(265, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Update.Location = new System.Drawing.Point(0, 404);
            this.Update.Margin = new System.Windows.Forms.Padding(1);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(265, 23);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.AutoSize = true;
            this.Insert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Insert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Insert.Location = new System.Drawing.Point(0, 427);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(265, 23);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(531, 450);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(531, 450);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button OutputLocation;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button OutCustomers;
        private System.Windows.Forms.Button OutEmployees;
        private System.Windows.Forms.Button OutMachine;
        private System.Windows.Forms.Button OutSuppliers;
    }
}

