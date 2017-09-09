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
    /// <summary>
    /// Pada form ini berisi definisi
    /// khusus untuk user dapat menginput
    /// nilai altitude yang diinginkan
    /// </summary>
    public partial class AltForm : Form
    {
        private readonly Action<double> _setAltitude;
        
        public AltForm(Action<double> setAltitude)
        {
            this._setAltitude = setAltitude;
            InitializeComponent();
        }

        /// <summary>
        /// Method untuk menghandle
        /// autofocus, sehingga ketika form ini dibuka
        /// akan langsung terfocus ke inputBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = inputBox;
        }

        /// <summary>
        /// Method untuk mengvalidasi input
        /// altitude dari user
        /// </summary>
        /// <param name="input">input altitude dari user</param>
        /// <returns>status validasi</returns>
        private bool validate_input(string input)
        {
            if(input.Length < 1)
            {
                errorProvider1.SetError(inputBox, "Please fill the box");
                return false;
            }
            if (!Regex.IsMatch(input, @"^\d+$"))
            {
                errorProvider1.SetError(inputBox, "Please fill with number only");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Method untuk menghandle event
        /// ketika user menggunakan enter
        /// ketika selesai memasukkan input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputBox_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                close_form(add_altitude());
            }
        }

        /// <summary>
        /// Method untuk menghandle event
        /// ketika user menggunakan enter
        /// ketika selesai memasukkan input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                close_form(add_altitude());
            }
        }

        /// <summary>
        /// Method yang bertugas untuk
        /// memberikan nilai altitude yang dimasukkan user
        /// ke form MapForm
        /// </summary>
        /// <returns>status error</returns>
        private bool add_altitude()
        {
            string input = inputBox.Text;
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
                    errorProvider1.SetError(inputBox, "There's an error while trying to fetch the altitude input");
                }
                return success;
            }
            return false;
        }

        /// <summary>
        /// Method untuk menghandle event
        /// ketika user menggunakan button
        /// untuk selesai memasukkan input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            close_form(add_altitude());
        }

        /// <summary>
        /// Method untuk menutup form ini
        /// ketika tidak terjadi error
        /// </summary>
        /// <param name="succ">status error</param>
        private void close_form(Boolean succ)
        {
            if (succ)
            {
                this.Close();
            }
            else
            {
                this.ActiveControl = inputBox;
            }
        }
    }
}
