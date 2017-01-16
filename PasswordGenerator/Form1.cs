using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        #region Password character lists
        private List<char> _upperChars =
            new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private List<char> _lowerChars =
            new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private List<char> _digits =
            new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private List<char> _special =
            new List<char> { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+' };
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtOutput.Text = ""; // Reset current output

            bool wantsDigits = false;
            bool wantsLowerCase = false;
            bool wantsSpecial = false;
            bool wantsUpperCase = false;
            int length = 0;
            #region Confirm everything is valid
            if (txtLength.Text == "" || txtLength.Text == null)  // Confirm that the user did not enter anything into the length textbox
            {
                MessageBox.Show("Please enter a length for your password!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!(int.TryParse(txtLength.Text, out length))) // If not a valid integer
            {
                MessageBox.Show("Invalid characters entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(length <= 2048 & length > 0)) // If not meeting length requirements
            {
                MessageBox.Show("Password does not meet length requirements", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm at least one of the checkboxes have been checked
            if (!(chkDigits.Checked || chkLowerCase.Checked || chkSpecial.Checked || chkUpperCase.Checked)) // If none are checked
            {
                MessageBox.Show("Please check one of the password options!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion
            // Convert checkstate to bool values
            wantsDigits = chkDigits.Checked;
            wantsLowerCase = chkLowerCase.Checked;
            wantsSpecial = chkSpecial.Checked;
            wantsUpperCase = chkUpperCase.Checked;

            // All requirements are now met, start the generation of the password

            List<char> dictionary = new List<char> { }; // Create empty list of dictionary

            // Adding each option to dictionary if checked
            if (wantsDigits)
                dictionary.AddRange(_digits);
            if (wantsLowerCase)
                dictionary.AddRange(_lowerChars);
            if (wantsUpperCase)
                dictionary.AddRange(_upperChars);
            if (wantsSpecial)
                dictionary.AddRange(_special);

            string password = "";
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                int randomNum = rand.Next(dictionary.Count);
                password += dictionary[randomNum]; // Add random char to password being generated
            }
            txtOutput.Text = password;
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            string s = txtOutput.Text;
            if(!(s == null || s == ""))
            {
                Clipboard.SetText(txtOutput.Text);
            }
        }
    }
}
