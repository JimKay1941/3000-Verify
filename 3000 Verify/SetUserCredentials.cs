using System;
using System.Windows.Forms;
using _3000_Verify.Properties;

namespace _3000_Verify
{
    public partial class SetUserCredentials : Form
    {
        public SetUserCredentials()
        {
            InitializeComponent();
        }

        private void SetUserCredentials_Load(object sender, EventArgs e)
        {
            textUserId.Text = Settings.Default.UserId;
            textSqlServer.Text = Settings.Default.SqlServer;
			textPassword1.Text = Settings.Default.Password;
			textPassword2.Text = Settings.Default.Password;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "";

            if (textPassword1.Text != textPassword2.Text)
            {
                txtStatus.Text = @"Passwords do not match. Please retype them.";
                return;
            }

            if (textPassword1.Text != "")
            {
                Settings.Default.Password = textPassword1.Text;
            }

            Settings.Default.UserId = textUserId.Text;
            Settings.Default.SqlServer = textSqlServer.Text;
			Settings.Default.Save();

            Settings.Default.UserConnectionString =
                "Data Source=" + Settings.Default.SqlServer +
                ";Initial Catalog=" + Settings.Default.UserId +
                ";Persist Security Info=True;User ID=" + Settings.Default.UserId +
                ";Password=" + Settings.Default.Password;

			Settings.Default.ChineseStudyConnection =
				 "Data Source=" + Settings.Default.SqlServer +
				";Initial Catalog=ChineseStudy"  +
				";Persist Security Info=True;User ID=" + Settings.Default.UserId +
				";Password=" + Settings.Default.Password;

            Settings.Default.Save();

			Close();
        }

        private void textUserPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                buttonOK_Click(sender, e);
            }
        }
    }
}
