using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMathHelper
{
    public partial class Math : Form
    {
        public Math()
        {
            InitializeComponent();
        }

        private void bFactorial_Click(object sender, EventArgs e)
        {
            FactorialForm factorial = new FactorialForm();
            factorial.ShowDialog();
            this.Close();
        }

        private void bQuadraticEquation_Click(object sender, EventArgs e)
        {
            QuadraticEquation qe = new QuadraticEquation();
            qe.ShowDialog();
            this.Close();
        }
    }
}
