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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = (Button)sender;
                if (b.Name == "button1")
                    MessageBox.Show("user has clicked on Button 1");
                else
                    MessageBox.Show("User is clicked on Button 2");
            }
            else if (sender is TextBox)
            {
                TextBox t = (TextBox)sender;
                if (t.Name == "TextBox1")
                    MessageBox.Show("user has clicked on TextBox 1");
                else
                    MessageBox.Show("User has clicked on TextBox 2");
            }
            else
            {
                MessageBox.Show("User has clicked on Form 7");
            }
        }
        
    }
}
