using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((txtResults.Text == "0")||(operation_pressed))
                txtResults.Clear();
            
            Button b = (Button)sender;
            txtResults.Text = txtResults.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResults.Text = "0";
        }

        private void btnOperator(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(txtResults.Text);
            operation_pressed = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

            switch(operation)
            {
                case "+":
                    txtResults.Text = (value + Double.Parse(txtResults.Text)).ToString();
                    break;
                case "-":
                    txtResults.Text = (value + Double.Parse(txtResults.Text)).ToString();
                    break;
                case "*":
                    txtResults.Text = (value + Double.Parse(txtResults.Text)).ToString();
                    break;
                case "/":
                    txtResults.Text = (value + Double.Parse(txtResults.Text)).ToString();
                    break;
            }
        }
    }
}
