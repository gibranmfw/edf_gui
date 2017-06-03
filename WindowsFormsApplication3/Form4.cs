using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        public Form2 parentForm { get; set; }
        private int motorValue = 700;

        public Form4()
        {
            InitializeComponent();
        }

        public int getMotorValue()
        {
            return this.motorValue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(radioButton1.Checked)
            {
                String[] temp = radioButton1.Text.Split(' ');
                motorValue = Int32.Parse(temp[0]);
            }
            else if (radioButton2.Checked)
            {
                String[] temp = radioButton2.Text.Split(' ');
                motorValue = Int32.Parse(temp[0]);
            }
            else if(radioButton3.Checked && validateInput(userInput.Text))
            {
                motorValue = Int32.Parse(userInput.Text);
            }

            parentForm.sendtoSerial(motorValue + "");
        }
 
        public bool validateInput(string input)
        {
            // Confirm that the e-mail address string is not empty.
            if (input.Length == 0)
            {
                errorProvider1.SetError(userInput, "Please fill the box");
                return false;
            }
            int temp = Int32.Parse(input);
            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (temp < 700)
            {
                errorProvider1.SetError(userInput, "minimum value: 700");
                return false;
            }
            if(temp > 2000)
            {
                errorProvider1.SetError(userInput, "maximum value: 2000");
                return false;
            }

            errorProvider1.SetError(userInput, "");
            return true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                userInput.Enabled = true;
            else
                userInput.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
