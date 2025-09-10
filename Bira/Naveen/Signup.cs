using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bira.Naveen
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        // ✅ First Name validation (only letters, not empty)
        private bool ValidateFirstName()
        {
            if (string.IsNullOrWhiteSpace(SignupFirstNameTxtBox.Text) || !Regex.IsMatch(SignupFirstNameTxtBox.Text, @"^[A-Za-z]+$"))
            {
                SignupFirstNameTxtBox.BackColor = Color.LightCoral;
                toolTip1.SetToolTip(SignupFirstNameTxtBox, "Enter a valid first name (letters only).");
                return false;
            }
            SignupFirstNameTxtBox.BackColor = Color.LightGreen;
            return true;
        }

        // ✅ Last Name validation
        private bool ValidateLastName()
        {
            if (string.IsNullOrWhiteSpace(SignupLastNameTxtBox.Text) || !Regex.IsMatch(SignupLastNameTxtBox.Text, @"^[A-Za-z]+$"))
            {
                SignupLastNameTxtBox.BackColor = Color.LightCoral;
                toolTip1.SetToolTip(SignupLastNameTxtBox, "Enter a valid last name (letters only).");
                return false;
            }
            SignupLastNameTxtBox.BackColor = Color.LightGreen;
            return true;
        }

        // ✅ Email validation
        private bool ValidateEmail()
        {
            string email = SignupEmailTxtBox.Text;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                SignupEmailTxtBox.BackColor = Color.LightCoral;
                toolTip1.SetToolTip(SignupEmailTxtBox, "Enter a valid email address.");
                return false;
            }
            SignupEmailTxtBox.BackColor = Color.LightGreen;
            return true;
        }

        // ✅ Password validation
        private void SignupPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            string password = SignupPasswordTxtBox.Text;
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            if (Regex.IsMatch(password, pattern))
            {
                SignupPasswordTxtBox.BackColor = Color.LightGreen;
                toolTip1.SetToolTip(SignupPasswordTxtBox, "Strong  password.");
            }
            else
            {
                SignupPasswordTxtBox.BackColor = Color.LightCoral;
                toolTip1.SetToolTip(SignupPasswordTxtBox,
                    "Password must contain:\n- Min 8 characters\n- At least 1 uppercase\n- At least 1 lowercase\n- At least 1 number\n- At least 1 special character");
            }

            // Recheck confirm password also
            SignupConfirmPasswordTxt_TextChanged(sender, e);
        }

        // ✅ Confirm password validation
        private void SignupConfirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (SignupConfirmPasswordTxtBox.Text == SignupPasswordTxtBox.Text && !string.IsNullOrEmpty(SignupConfirmPasswordTxtBox.Text))
            {
                SignupConfirmPasswordTxtBox.BackColor = Color.LightGreen;
                toolTip1.SetToolTip(SignupConfirmPasswordTxtBox, "Passwords match.");
            }
            else
            {
                SignupConfirmPasswordTxtBox.BackColor = Color.LightCoral;
                toolTip1.SetToolTip(SignupConfirmPasswordTxtBox, "Passwords do not match.");
            }
        }

        // ✅ Final validation on Sign Up button click
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            bool validFirst = ValidateFirstName();
            bool validLast = ValidateLastName();
            bool validEmail = ValidateEmail();

            bool validPassword = Regex.IsMatch(SignupPasswordTxtBox.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
            bool passwordsMatch = SignupConfirmPasswordTxtBox.Text == SignupPasswordTxtBox.Text;

            if (validFirst && validLast && validEmail && validPassword && passwordsMatch)
            {
                MessageBox.Show("✅ Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("❌ Please fix the highlighted fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Placeholder for SignIn click
        private void SignInAccTxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirect to Sign In form here.");
        }

        private void SignupTransparentPanel_Paint(object sender, PaintEventArgs e)
        {
            SignupTransparentPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void linkLabelsignuplogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
