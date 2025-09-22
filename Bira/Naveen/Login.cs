using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bira.Naveen
{
    public partial class Login : Form
    {
        private ToolTip toolTip1;

        public Login()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            PasswordTxtBox.UseSystemPasswordChar = true;
            PasswordTxtBox.UseSystemPasswordChar = true;
            ShowHidePassword.Image = Properties.Resources.hide_password_icon;
        }

        // ✅ Username validation with updated UI feedback
        private void UserNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            string username = UserNameTxtBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || username.Length < 4 || username.Contains(' '))
            {
                UserNameTxtBox.ForeColor = Color.IndianRed;
                panelUserUnderline.BackColor = Color.IndianRed; // Change underline color
                toolTip1.SetToolTip(UserNameTxtBox, "Username must be at least 4 characters.");
            }
            else
            {
                UserNameTxtBox.ForeColor = Color.White;
                panelUserUnderline.BackColor = Color.LightGreen; // Change underline color
                toolTip1.SetToolTip(UserNameTxtBox, "Valid username.");
            }
        }

        //  Password validation
        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            string password = PasswordTxtBox.Text;
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";

            if (Regex.IsMatch(password, pattern))
            {
                PasswordTxtBox.ForeColor = Color.White;
                panelPasswordUnderline.BackColor = Color.LightGreen; // Change underline color
                                                                     // toolTip1.SetToolTip(PasswordTxtBox, "Strong password.");
            }
            else
            {
                PasswordTxtBox.ForeColor = Color.IndianRed;
                panelPasswordUnderline.BackColor = Color.IndianRed; // Change underline color
                toolTip1.SetToolTip(PasswordTxtBox,
                    "Password must be at least 8 characters, with:\n- 1 uppercase\n- 1 lowercase\n- 1 number\n- 1 special character.");
            }
        }

        // Helper to check password validity on submit
        private bool IsPasswordValid()
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";
            return Regex.IsMatch(PasswordTxtBox.Text, pattern);
        }

        // ✅ Login button click
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool validUser = !string.IsNullOrEmpty(UserNameTxtBox.Text) && UserNameTxtBox.Text.Length >= 4;
            bool validPassword = IsPasswordValid();
            string Role = "Teamlead"; // Hardcoded for now

            if (validUser && validPassword)
            {
                if (Role == "Teamlead")
                {
                    TeamleadDashboard oTLform = new TeamleadDashboard();
                    this.Hide();
                    oTLform.Show();
                }
                else if (Role == "Member")
                {
                    MemberDashboard memberDashboard = new MemberDashboard();
                    this.Hide();
                    memberDashboard.Show();
                }
                else
                {
                    MessageBox.Show("❌ Unknown role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("❌ Please check your username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabelloginsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void ShowHidePassword_Click(object sender, EventArgs e)
        {
           
            ShowHidepasswordLoad();
        }


        private void ShowHidepasswordLoad()
        {
            if (PasswordTxtBox.UseSystemPasswordChar)
            {
                PasswordTxtBox.UseSystemPasswordChar = false;
                ShowHidePassword.Image = Properties.Resources.show_password_icon;
            }
            else
            {
                PasswordTxtBox.UseSystemPasswordChar = true;
                ShowHidePassword.Image = Properties.Resources.hide_password_icon;
            }
        }
    }
    }
