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
    public partial class FactorialForm : Form
    {
        public FactorialForm()
        {
            InitializeComponent();
        }

        private void bCountFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                MyMath math = new MyMath();
                tbRes.Text = math.Factorial(int.Parse(tbInput.Text)).ToString();
                tbInput.Text = "";
            }
            catch(ParameterException ex)
            {
                MessageBox.Show("Вы веели неверное значение!");
            }
            catch { MessageBox.Show("Произошла какая-то ошибка!"); }
        }
    }
}
