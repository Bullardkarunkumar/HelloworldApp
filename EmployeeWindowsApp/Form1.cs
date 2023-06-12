using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Button syntax Btn but it is not giving any error 
        private void button1_Click(object sender, EventArgs e)
        {
            // Label syntax Lbl but it is not giving any error 
            label1.Text = "Hello Employee";

        }
    }
}
