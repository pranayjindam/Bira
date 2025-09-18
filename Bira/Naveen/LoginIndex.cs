using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bira.Naveen
{
    public partial class LoginIndex : Form
    {
        public LoginIndex()
        {
            InitializeComponent();
        }

        // ✅ Username validation
        private void UserNameTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            string username = UserNameTxtBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || username.Length < 4 || username.Contains(' '))
            {
                SystemSounds.Hand.Play();
                UserNameTxtBox.BackColor = Color.LightCoral;
              //  toolTip1.SetToolTip(UserNameTxtBox, "Username must be at least 4 characters.");
            }
            else
            {
                UserNameTxtBox.BackColor = Color.LightGreen;
            }
        }

        // ✅ Password validation
        private bool ValidatePassword()
        {
            string password = PasswordTxtBox.Text;

            // Same regex as Signup (uppercase, lowercase, number, special char, min 8)
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";

            if (Regex.IsMatch(password, pattern))
            {
                PasswordTxtBox.BackColor = Color.LightGreen;
                return true;
            }
            else
            {

                PasswordTxtBox.BackColor = Color.LightCoral;
            //    toolTip1.SetToolTip(PasswordTxtBox,
            //        "Password must be at least 8 characters, with:\n- 1 uppercase\n- 1 lowercase\n- 1 number\n- 1 special character.");
                return false;
            }
        }

        // ✅ Login button click
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool validUser = !string.IsNullOrEmpty(UserNameTxtBox.Text) && UserNameTxtBox.Text.Length >= 4;
            bool validPassword = ValidatePassword();
            string Role = "Teamlead";



            if (validUser && validPassword)
            {
                //MessageBox.Show("✅ Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Role == "Teamlead")
                {
                    SystemSounds.Asterisk.Play();

                    TeamleadDashboard oTLform = new TeamleadDashboard();
                    this.Hide();
                    oTLform.Show();
                }
                else if (Role == "Member")
                {
                    SystemSounds.Asterisk.Play();

                    this.Hide();
                    MemberDashboard memberDashboard = new MemberDashboard();
                    memberDashboard.Show();
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("❌ Unknown role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // TODO: Connect this with your DB (e.g., MySQL) for actual login verification
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("❌ Please check your username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ✅ Forgot password
        private void ForgettonPasswordTxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirect to Forgot Password page here.");
        }



        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelloginsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //LoginTransparentPanel.Controls.Clear();
            //Signup oTeamForm = new Signup
            //{
            //    TopLevel = false,
            //    FormBorderStyle = FormBorderStyle.None,
            //    Dock = DockStyle.Fill
            //};

            //LoginTransparentPanel.Controls.Add(oTeamForm);
            //oTeamForm.Show();
            this.Hide(); // Hide current login
            Signup oSignupForm = new Signup(); // Pass this Login reference
            oSignupForm.Show();
        }
      
    }
}
