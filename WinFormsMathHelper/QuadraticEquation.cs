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
    public partial class QuadraticEquation : Form
    {
        public QuadraticEquation()
        {
            InitializeComponent();
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            MyMath math = new MyMath();

            try
            {
                var results = math.QuadraticEquation(int.Parse(tbA.Text), int.Parse(tbB.Text), int.Parse(tbC.Text));

                tbRes.Text = tbA.Text = tbB.Text = tbC.Text = "";

                int it = 0;

                if (results != null)

                    foreach (var el in results)
                    {
                        tbRes.Text += "[x" + ++it + "] = " + el.ToString() + " ; ";
                    }

                else

                    tbRes.Text = "Действительных корней нет.";
            }
            catch { }
        }
    }
}
