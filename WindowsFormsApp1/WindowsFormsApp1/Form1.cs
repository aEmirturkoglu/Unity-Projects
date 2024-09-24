using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        public void CalculateButton_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            string operation;

            if (double.TryParse(Num1TextBox.Text, out num1) && double.TryParse(Num2TextBox.Text, out num2))
            {
                if (AddRadioButton.Checked)
                    operation = "+";
                else if (SubtractRadioButton.Checked)
                    operation = "-";
                else if (MultiplyRadioButton.Checked)
                    operation = "*";
                else if (DivideRadioButton.Checked)
                    operation = "/";
                else if (ModulusRadioButton.Checked)
                    operation = "%";
                else
                {
                    MessageBox.Show("Please select an operation.");
                    return;
                }

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
                        result = num1 / num2;
                        break;
                    case "%":
                        result = num1 % num2;
                        break;
                    default:
                        MessageBox.Show("Invalid operation.");
                        return;
                }

                ResultLabel.Text = result.ToString();
                
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}
