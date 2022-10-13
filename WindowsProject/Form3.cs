using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("User clicked on he Form.");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the windows appliction developmenet.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User clicked on button.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("User clicked on text box.");
        }
    }
}
