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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
                MessageBox.Show("user clicked on radio button1.");
            else if (radioButton2.Checked)
                MessageBox.Show("user clicked on radio button 2.");
            else if (radioButton3.Checked)
                MessageBox.Show("User clicked on radio button 3.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("User clicked on check box 1.");
            if (checkBox2.Checked)
                MessageBox.Show("User clicked on check box 2.");
            if (checkBox3.Checked)
                MessageBox.Show("User clicked on check box 3.");
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
