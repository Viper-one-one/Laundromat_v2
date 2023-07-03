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
            this.AllProducts = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.AllProducts);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.Delete);
            this.splitContainer1.Panel1.Controls.Add(this.Update);
            this.splitContainer1.Panel1.Controls.Add(this.Insert);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // AllProducts
            // 
            this.AllProducts.AutoSize = true;
            this.AllProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AllProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AllProducts.Location = new System.Drawing.Point(0, 338);
            this.AllProducts.Name = "AllProducts";
            this.AllProducts.Size = new System.Drawing.Size(265, 23);
            this.AllProducts.TabIndex = 5;
            this.AllProducts.Text = "Get All Products";
            this.AllProducts.UseVisualStyleBackColor = true;
            this.AllProducts.Click += new System.EventHandler(this.AllProducts_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AllProducts;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

