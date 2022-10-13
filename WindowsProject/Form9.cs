using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProject
{
    public partial class Form9 : Form
    {
         int Count = 0;
        public Form9()
        {
           
            InitializeComponent();
        }

        private void cbC_CheckedChanged(object sender, EventArgs e)
        {
            rbNormal.Checked = true;
            CheckBox cb=sender as CheckBox;
            int Amt=int.Parse(txtFees.Text);
            if(cb.Checked)
            {
                Count += 1;
                Amt +=Convert.ToInt32(cb.Tag);
            }
            else
            {
                Count -= 1;
                Amt -=Convert.ToInt32(cb.Tag);
            }
            txtFees.Text=Amt.ToString();

        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb=sender as RadioButton;   
            int Amt=int.Parse(txtFees.Text);
            if (rb.Checked)
                Amt += (Convert.ToInt32(rb.Tag) * Count);
            else
                Amt -= (Convert.ToInt32(rb.Tag) * Count);
            txtFees.Text = Amt.ToString();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(Control Ctrl in gbCourses.Controls)
            {
                CheckBox cb = Ctrl as CheckBox;
                cb.Checked = true;
            }
            foreach(Control Ctrl in this.Controls)
            {
                if(Ctrl is TextBox)
                {
                    TextBox tb = Ctrl as TextBox;
                    tb.Clear();
                }
            }
            txtFees.Text = "0";
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
