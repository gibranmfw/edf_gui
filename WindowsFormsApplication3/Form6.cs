using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class Form6 : Form
    {
        private readonly Action<double> _setAltitude;

        public Form6(Action<double> setAltitude)
        {
            this._setAltitude = setAltitude;
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox2;
        }

        private bool validate_input(string input)
        {
            if(input.Length < 1)
            {
                errorProvider1.SetError(textBox2, "Please fill the box");
                return false;
            }
            if (!Regex.IsMatch(input, @"^\d+$"))
            {
                errorProvider1.SetError(textBox2, "Please fill with number only");
                return false;
            }
            return true;
        }

        private void textBox_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bool succ = add_altitude();
                if (succ)
                {
                    this.Close();
                }
                else
                {
                    this.ActiveControl = textBox2;
                }
            }
        }

        private void form6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                bool succ = add_altitude();
                if (succ)
                {
                    this.Close();
                }
                else
                {
                    this.ActiveControl = textBox2;
                }
            }
        }

        private bool add_altitude()
        {
            string input = textBox2.Text;
            if (validate_input(input))
            {
                double n;
                bool success = Double.TryParse(input, out n);
                if (success)
                {
                    _setAltitude(n);
                }
                else
                {
                    errorProvider1.SetError(textBox2, "There's an error while trying to fetch the altitude input");
                }
                return success;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool succ = add_altitude();
            if(succ)
            {
                this.Close();
            }
            else
            {
                this.ActiveControl = textBox2;
            }
        }
    }
}
