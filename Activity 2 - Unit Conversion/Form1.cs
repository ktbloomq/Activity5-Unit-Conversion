using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2___Unit_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            float farenheit = 0;
            if(float.TryParse(Input.Text, out farenheit))
            {
                farenheit = float.Parse(Input.Text) * 9 / 5 + 32;
                Output.Text = farenheit.ToString("0.000");
            } else
            {
                MessageBox.Show("Input Error.");
            }
        }
    }
}
