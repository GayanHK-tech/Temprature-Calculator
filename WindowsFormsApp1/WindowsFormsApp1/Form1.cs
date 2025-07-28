using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            
            double temp=Convert.ToDouble(txtTemp.Text);

            if(rbtnCelcius.Checked)
            {
                double ans = ((temp * 9) / 5) + 32;
                txtAns.Text=ans.ToString();
                txtTemp.Clear();
            }
            else
            {
                double ans = ((temp - 32) * 5) / 9;
                txtAns.Text=ans.ToString();
                txtTemp.Clear();
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtAns.Clear();
        }
    }
}
