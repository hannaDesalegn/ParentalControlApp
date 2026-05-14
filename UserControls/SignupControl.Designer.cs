namespace ParentalControlApp.UserControls
{
    partial class SignupControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signupTitleLbl = new Label();
            signupPaswrdTxtBox = new TextBox();
            signupPaswrdLbl = new Label();
            signupUserNameTxtBox = new TextBox();
            signupUserNameLbl = new Label();
            roleCombBox = new ComboBox();
            roleLbl = new Label();
            signupBtn = new Button();
            signupMsgLbl = new Label();
            SuspendLayout();
            // 
            // signupTitleLbl
            // 
            signupTitleLbl.Anchor = AnchorStyles.None;
            signupTitleLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupTitleLbl.Location = new Point(212, 89);
            signupTitleLbl.Name = "signupTitleLbl";
            signupTitleLbl.Size = new Size(360, 40);
            signupTitleLbl.TabIndex = 1;
            signupTitleLbl.Text = "Parental Control System";
            signupTitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signupPaswrdTxtBox
            // 
            signupPaswrdTxtBox.Anchor = AnchorStyles.None;
            signupPaswrdTxtBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupPaswrdTxtBox.Location = new Point(306, 206);
            signupPaswrdTxtBox.Name = "signupPaswrdTxtBox";
            signupPaswrdTxtBox.PasswordChar = '•';
            signupPaswrdTxtBox.Size = new Size(220, 25);
            signupPaswrdTxtBox.TabIndex = 8;
            signupPaswrdTxtBox.TextChanged += signupPaswrdTxtBox_TextChanged;
            // 
            // signupPaswrdLbl
            // 
            signupPaswrdLbl.Anchor = AnchorStyles.None;
            signupPaswrdLbl.AutoSize = true;
            signupPaswrdLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupPaswrdLbl.Location = new Point(232, 206);
            signupPaswrdLbl.Name = "signupPaswrdLbl";
            signupPaswrdLbl.Size = new Size(68, 17);
            signupPaswrdLbl.TabIndex = 7;
            signupPaswrdLbl.Text = "password:";
            // 
            // signupUserNameTxtBox
            // 
            signupUserNameTxtBox.Anchor = AnchorStyles.None;
            signupUserNameTxtBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupUserNameTxtBox.Location = new Point(306, 159);
            signupUserNameTxtBox.Name = "signupUserNameTxtBox";
            signupUserNameTxtBox.Size = new Size(220, 25);
            signupUserNameTxtBox.TabIndex = 6;
            signupUserNameTxtBox.TextChanged += signupUserNameTxtBox_TextChanged;
            // 
            // signupUserNameLbl
            // 
            signupUserNameLbl.Anchor = AnchorStyles.None;
            signupUserNameLbl.AutoSize = true;
            signupUserNameLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupUserNameLbl.Location = new Point(232, 162);
            signupUserNameLbl.Name = "signupUserNameLbl";
            signupUserNameLbl.Size = new Size(68, 17);
            signupUserNameLbl.TabIndex = 5;
            signupUserNameLbl.Text = "username:";
            // 
            // roleCombBox
            // 
            roleCombBox.Anchor = AnchorStyles.None;
            roleCombBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleCombBox.FormattingEnabled = true;
            roleCombBox.Items.AddRange(new object[] { "Child", "Parent", "Admin" });
            roleCombBox.Location = new Point(306, 246);
            roleCombBox.Name = "roleCombBox";
            roleCombBox.Size = new Size(121, 23);
            roleCombBox.TabIndex = 9;
            roleCombBox.SelectedIndexChanged += roleCombBox_SelectedIndexChanged;
            // 
            // roleLbl
            // 
            roleLbl.AutoSize = true;
            roleLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleLbl.Location = new Point(232, 253);
            roleLbl.Name = "roleLbl";
            roleLbl.Size = new Size(34, 17);
            roleLbl.TabIndex = 10;
            roleLbl.Text = "role:";
            // 
            // signupBtn
            // 
            signupBtn.Anchor = AnchorStyles.None;
            signupBtn.BackColor = Color.CadetBlue;
            signupBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupBtn.ForeColor = Color.White;
            signupBtn.Location = new Point(232, 341);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(320, 40);
            signupBtn.TabIndex = 11;
            signupBtn.Text = "Signup";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += signupBtn_Click;
            // 
            // signupMsgLbl
            // 
            signupMsgLbl.Anchor = AnchorStyles.None;
            signupMsgLbl.AutoSize = true;
            signupMsgLbl.ForeColor = Color.Red;
            signupMsgLbl.Location = new Point(383, 423);
            signupMsgLbl.Name = "signupMsgLbl";
            signupMsgLbl.Size = new Size(0, 15);
            signupMsgLbl.TabIndex = 12;
            signupMsgLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignupControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(signupMsgLbl);
            Controls.Add(signupBtn);
            Controls.Add(roleLbl);
            Controls.Add(roleCombBox);
            Controls.Add(signupPaswrdTxtBox);
            Controls.Add(signupPaswrdLbl);
            Controls.Add(signupUserNameTxtBox);
            Controls.Add(signupUserNameLbl);
            Controls.Add(signupTitleLbl);
            Name = "SignupControl";
            Size = new Size(784, 568);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signupTitleLbl;
        private TextBox signupPaswrdTxtBox;
        private Label signupPaswrdLbl;
        private TextBox signupUserNameTxtBox;
        private Label signupUserNameLbl;
        private ComboBox roleCombBox;
        private Label roleLbl;
        private Button signupBtn;
        private Label signupMsgLbl;
    }
}
