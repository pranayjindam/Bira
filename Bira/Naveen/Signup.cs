using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bira.Naveen
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            // Hide password input characters
            SignupPasswordTxtBox.UseSystemPasswordChar = true;
            SignupConfirmPasswordTxtBox.UseSystemPasswordChar = true;
        }

        // --- REAL-TIME VALIDATION EVENT HANDLERS ---

        private void SignupFirstNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFirstName();
        }

        private void SignupLastNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            ValidateLastName();
        }

        private void SignupEmailTxtBox_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void SignupPasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword();
            // Re-check the confirmation field whenever the main password changes
            ValidateConfirmPassword();
        }

        private void SignupConfirmPasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            ValidateConfirmPassword();
        }

        // --- VALIDATION LOGIC METHODS ---

        private bool ValidateFirstName()
        {
            if (string.IsNullOrWhiteSpace(SignupFirstNameTxtBox.Text) || !Regex.IsMatch(SignupFirstNameTxtBox.Text, @"^[A-Za-z]+$"))
            {
                panelFirstNameUnderline.BackColor = Color.IndianRed;
                toolTip1.SetToolTip(SignupFirstNameTxtBox, "First name must contain letters only.");
                return false;
            }
            panelFirstNameUnderline.BackColor = Color.LightGreen;
            toolTip1.SetToolTip(SignupFirstNameTxtBox, "Valid first name.");
            return true;
        }

        private bool ValidateLastName()
        {
            if (string.IsNullOrWhiteSpace(SignupLastNameTxtBox.Text) || !Regex.IsMatch(SignupLastNameTxtBox.Text, @"^[A-Za-z]+$"))
            {
                panelLastNameUnderline.BackColor = Color.IndianRed;
                toolTip1.SetToolTip(SignupLastNameTxtBox, "Last name must contain letters only.");
                return false;
            }
            panelLastNameUnderline.BackColor = Color.LightGreen;
            toolTip1.SetToolTip(SignupLastNameTxtBox, "Valid last name.");
            return true;
        }

        private bool ValidateEmail()
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(SignupEmailTxtBox.Text, emailPattern))
            {
                panelEmailUnderline.BackColor = Color.IndianRed;
                toolTip1.SetToolTip(SignupEmailTxtBox, "Enter a valid email address.");
                return false;
            }
            panelEmailUnderline.BackColor = Color.LightGreen;
            toolTip1.SetToolTip(SignupEmailTxtBox, "Valid email address.");
            return true;
        }

        private bool ValidatePassword()
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";
            if (Regex.IsMatch(SignupPasswordTxtBox.Text, pattern))
            {
                panelPasswordUnderline.BackColor = Color.LightGreen;
                toolTip1.SetToolTip(SignupPasswordTxtBox, "Strong password.");
                return true;
            }
            panelPasswordUnderline.BackColor = Color.IndianRed;
            toolTip1.SetToolTip(SignupPasswordTxtBox,
                "Password must contain:\n- Min 8 characters\n- 1 uppercase\n- 1 lowercase\n- 1 number\n- 1 special character");
            return false;
        }

        private bool ValidateConfirmPassword()
        {
            if (SignupConfirmPasswordTxtBox.Text == SignupPasswordTxtBox.Text && !string.IsNullOrEmpty(SignupConfirmPasswordTxtBox.Text))
            {
                panelConfirmPasswordUnderline.BackColor = Color.LightGreen;
                toolTip1.SetToolTip(SignupConfirmPasswordTxtBox, "Passwords match.");
                return true;
            }
            panelConfirmPasswordUnderline.BackColor = Color.IndianRed;
            toolTip1.SetToolTip(SignupConfirmPasswordTxtBox, "Passwords do not match.");
            return false;
        }

        // --- BUTTON AND LINK CLICK EVENTS ---

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            // Run all validations on click to be sure
            if (ValidateFirstName() && ValidateLastName() && ValidateEmail() && ValidatePassword() && ValidateConfirmPassword())
            {
                MessageBox.Show("✅ Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: Add logic to save user to the database
            }
            else
            {
                MessageBox.Show("❌ Please fix the fields highlighted in red.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabelsignuplogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}