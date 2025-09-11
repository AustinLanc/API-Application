using Newtonsoft.Json.Linq;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace APIApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void loginSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameInput.Text;
                string password = passwordInput.Text;

                if (username == null || username == "")
                {
                    errorMsg.Text = "Please enter a username";
                }
                else if (password == null || password == "")
                {
                    errorMsg.Text = "Please enter a password";
                }
                else
                {
                    Domain domain = Domain.GetCurrentDomain();
                    DirectoryServer dc = domain.FindDomainController();

                    string ldapPath = $"LDAP://{dc.Name}";

                    using (DirectoryEntry entry = new DirectoryEntry(ldapPath, username, password))
                    {
                        object nativeObject = entry.NativeObject;
                        Home mainForm = new Home();
                        mainForm.Show();

                        this.Hide();
                    }
                }

            }
            catch (Exception ex)
            {
                errorMsg.Text = ex.Message;
            }


        }
    }
}
