using Microsoft.Data.SqlClient;
using ParentalControlApp.DB;
using ParentalControlApp.UserControls;
namespace ParentalControlApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void signupLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SignupControl signup = new SignupControl();

            loginPnl.Visible = false;
            MainTabCtrl.Visible = false;
            this.Controls.Add(signup);
            signup.Anchor = AnchorStyles.None;
            signup.BringToFront();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = loginUserNameTxtBox.Text;
            string password = loginPaswrdTxtBox.Text;
            string role;
            bool validatePassword;
            Guid userID;
            DBConnection.Initialize();
            if (string.IsNullOrEmpty(loginUserNameTxtBox.Text) ||
               string.IsNullOrEmpty(loginPaswrdTxtBox.Text))
            {

                loginMsgLbl.Text = "please enter valid username and password";
            }

            string loginSql = @"SELECT * FROM Users WHERE userName = @userName";
            using (SqlCommand cmd = new SqlCommand(loginSql, DBConnection._connection))
                try
                {


                    {
                        cmd.Parameters.AddWithValue("@userName", userName);
                        var ret = cmd.ExecuteReader();
                        if (!ret.HasRows)
                        {
                            loginMsgLbl.Text = "Wrong username or password";
                            return;
                        }
                        if (ret.Read())
                        {
                            validatePassword = BCrypt.Net.BCrypt.
                                EnhancedVerify(password, ret["password"].ToString());
                            if (!validatePassword)
                            {
                                loginMsgLbl.Text = "Wrong username or password";
                            }
                            userID = Guid.Parse(ret["use_id"].ToString());
                            role = ret["role"].ToString();

                    else
                            {

                            }

                        }
                        else
                        {
                            loginMsgLbl.Text = "wrong username or password";
                        }

                    }
                    DBConnection._connection.Close();
                }
                catch (Exception)
                {
                    DBConnection._connection.Close();
                    Exception d = new Exception("Wrong username and password");
                    throw d;
                }

        }

        private void loginUserNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            loginMsgLbl.Text = "";
        }

        private void loginPaswrdTxtBox_TextChanged(object sender, EventArgs e)
        {
            loginMsgLbl.Text = "";
        }

        private void childRtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctablePnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
