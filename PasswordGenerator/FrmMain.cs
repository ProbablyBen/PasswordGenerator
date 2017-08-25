using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class FrmMain : Form
    {
        private readonly List<char> _digits =
            new List<char> {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

        private readonly List<char> _lowerChars =
            new List<char>
            {
                'a',
                'b',
                'c',
                'd',
                'e',
                'f',
                'g',
                'h',
                'i',
                'j',
                'k',
                'l',
                'm',
                'n',
                'o',
                'p',
                'q',
                'r',
                's',
                't',
                'u',
                'v',
                'w',
                'x',
                'y',
                'z'
            };

        private readonly List<char> _special =
            new List<char> {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+'};

        private readonly List<char> _upperChars =
            new List<char>
            {
                'A',
                'B',
                'C',
                'D',
                'E',
                'F',
                'G',
                'H',
                'I',
                'J',
                'K',
                'L',
                'M',
                'N',
                'O',
                'P',
                'Q',
                'R',
                'S',
                'T',
                'U',
                'V',
                'W',
                'X',
                'Y',
                'Z'
            };

        private readonly Random _random = new Random();

        /// <summary>
        ///     Initializes a new instance of the <see cref="FrmMain" /> class.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Gets a value indicating whether the user input is valid input.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this user input is valid input; otherwise, <c>false</c>.
        /// </value>
        private bool IsValidInput => !string.IsNullOrEmpty(txtLength.Text) && int.TryParse(txtLength.Text, out int len);

        /// <summary>
        ///     Gets the input value.
        /// </summary>
        /// <value>
        ///     The input value.
        /// </value>
        private int InputValue => int.Parse(txtLength.Text);

        /// <summary>
        ///     Generates a password.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtOutput.Text = ""; // Reset current output


            if (!ValidateAllUserInput())
            {
                return;
            }

            List<char> dictionary = new List<char>(); // Create empty list of characters

            // Adding each option to dictionary if checked

            if (chkDigits.Checked)
            {
                dictionary.AddRange(_digits);
            }
            if (chkLowerCase.Checked)
            {
                dictionary.AddRange(_lowerChars);
            }
            if (chkUpperCase.Checked)
            {
                dictionary.AddRange(_upperChars);
            }
            if (chkSpecial.Checked)
            {
                dictionary.AddRange(_special);
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < InputValue; i++)
            {
                int randomNum = _random.Next(dictionary.Count);
                sb.Append(dictionary[randomNum]); // Add random char to password being generated
            }
            txtOutput.Text = sb.ToString();
        }

        /// <summary>
        ///     Copys the password to the clipboard.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                Clipboard.SetText(txtOutput.Text);
            }
        }

        /// <summary>
        ///     Validates the user input.
        /// </summary>
        /// <returns>Password Length.</returns>
        private bool ValidateAllUserInput()
        {
            if (!IsValidInput) // Confirm that the user did not enter anything into the length textbox
            {
                MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!(InputValue <= 2048 && InputValue > 0)) // If not meeting length requirements
            {
                MessageBox.Show("Password does not meet length requirements", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            // Confirm at least one of the checkboxes have been checked
            if (!(chkDigits.Checked || chkLowerCase.Checked || chkSpecial.Checked ||
                  chkUpperCase.Checked)) // If none are checked
            {
                MessageBox.Show("Please check one of the password options!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}