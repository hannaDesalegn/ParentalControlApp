using BCrypt;
using ParentalControlApp.DB;
using ParentalControlApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ParentalControlApp;

namespace ParentalControlApp.UserControls
{
    public partial class SignupControl : UserControl
    {
        public SignupControl()
        {
            InitializeComponent();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(signupUserNameTxtBox.Text) ||
                string.IsNullOrEmpty(signupPaswrdTxtBox.Text)||
                (roleCombBox.SelectedItem == null))

            {
                signupMsgLbl.Text = "Please enter all required fields";
                return;
            }
            if (signupPaswrdTxtBox.Text.Length < 8)
            {
                signupMsgLbl.Text = "password must be at least 8 characters";
                return;
            }
            DBConnection.Initialize();
            Guid userID = Guid.NewGuid();
            string userName = signupUserNameTxtBox.Text;
            string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(signupPaswrdTxtBox.Text);
            string role = roleCombBox.SelectedItem.ToString();
            string userCheckSql = @"SELECT COUNT(*) FROM Users WHERE username =@userName";
            using (SqlCommand cmd = new SqlCommand(userCheckSql, DBConnection._connection))
            {
                cmd.Parameters.AddWithValue("@userName", userName);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    signupMsgLbl.Text = "user already exist";
                    signupMsgLbl.ForeColor = Color.Red;
                    return;
                }

            }


            string userSql = @"INSERT INTO Users(user_id,username,password,role) VALUES (@userID,@userName,@hashedPassword,@role)";
            using (SqlCommand cmd = new SqlCommand(userSql, DBConnection._connection))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();
                    signupMsgLbl.Text = "Regisitered successfully";
                    signupMsgLbl.ForeColor = Color.Green;
                    
                    DBConnection._connection.Close();
                    this.Controls.Clear();

                }
                catch (Exception ex)
                {
                    signupMsgLbl.Text = ex.Message;
                    DBConnection._connection.Close();
                }
            }

        }

        private void signupUserNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            signupMsgLbl.Text = "";
        }

        private void signupPaswrdTxtBox_TextChanged(object sender, EventArgs e)
        {
            signupMsgLbl.Text = "";
        }

        private void roleCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            signupMsgLbl.Text = "";
        }


    }
}
