using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(textCelsius.Text);
            double fahrenheint = (celsius * 9 / 5) + 32;
            textFahrenheit.Text = fahrenheint.ToString();
        }
    }
}
