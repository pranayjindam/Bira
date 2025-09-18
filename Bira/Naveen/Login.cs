using System;
using Bira.UI;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using Bira.Naveen;


namespace Bira.Naveen
{
    public partial class Login : Form
    {
        private ToolTip toolTip1;

        public Login()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();

        }

        // ✅ Username validation

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();

            LoginIndex loginform = new LoginIndex
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill   // ✅ makes it fill the panel
            };

            panelmain.Controls.Add(loginform);
            loginform.Show();
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            Signup signupform = new Signup
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill   // ✅ makes it fill the panel
            };
            panelmain.Controls.Add(signupform);
            signupform.Show();
        }


        

        private void Login_Load(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();

            LoginIndex loginform = new LoginIndex
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill   // ✅ makes it fill the panel
            };

            panelmain.Controls.Add(loginform);
            loginform.Show();
        }
    }
}
