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
        public Form1()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            if (str == null || str == "")
                textBoxOut.Text = "Enter a string";
            else
            {
                textBoxOut.Text = str;
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Deleted");
        }

        private void dropDown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
