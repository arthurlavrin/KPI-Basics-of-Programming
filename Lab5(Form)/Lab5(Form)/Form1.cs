using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    double x = Convert.ToDouble(textBox1.Text);
                    double z;

                    z = Math.Sqrt(x) + Math.Log(10*x*x + Math.Exp(x));
                    //z = (Math.Cos(x) + x + Math.Pow(Math.E, x + 2) + Math.Log(3 * Math.Log(Math.Sqrt(2 * x + Math.Sin(x))))) / Math.Pow(Math.E, Math.Sin(x));
                    textBox2.Text = z.ToString();
                   
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
