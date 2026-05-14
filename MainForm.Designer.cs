namespace ParentalControlApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTabCtrl = new TabControl();
            homeTab = new TabPage();
            restrictionTab = new TabPage();
            activityLogTab = new TabPage();
            settingTab = new TabPage();
            systemLogTab = new TabPage();
            loginPnl = new Panel();
            loginMsgLbl = new Label();
            signupLinkLbl = new LinkLabel();
            signupMsgLbl = new Label();
            loginBtn = new Button();
            loginPaswrdTxtBox = new TextBox();
            loginPaswrdLbl = new Label();
            loginUserNameTxtBox = new TextBox();
            loginUserNameLbl = new Label();
            LoginTitleLbl = new Label();
            colorDialog1 = new ColorDialog();
            topPnl = new Panel();
            logoutBtn = new Button();
            chomePnl = new Panel();
            cPicBx = new PictureBox();
            cUserName = new Label();
            ctablePnl = new TableLayoutPanel();
            cScreenTimeLbl = new Label();
            label1 = new Label();
            cStatusLbl = new Label();
            cMsgBxPnl = new Panel();
            cMsgBxTitleLbl = new Label();
            childRtb = new RichTextBox();
            cTxtMsg = new TextBox();
            sendBtn = new Button();
            MainTabCtrl.SuspendLayout();
            homeTab.SuspendLayout();
            loginPnl.SuspendLayout();
            topPnl.SuspendLayout();
            chomePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cPicBx).BeginInit();
            ctablePnl.SuspendLayout();
            cMsgBxPnl.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabCtrl
            // 
            MainTabCtrl.Controls.Add(homeTab);
            MainTabCtrl.Controls.Add(restrictionTab);
            MainTabCtrl.Controls.Add(activityLogTab);
            MainTabCtrl.Controls.Add(settingTab);
            MainTabCtrl.Controls.Add(systemLogTab);
            MainTabCtrl.Dock = DockStyle.Left;
            MainTabCtrl.ItemSize = new Size(48, 35);
            MainTabCtrl.Location = new Point(0, 0);
            MainTabCtrl.Name = "MainTabCtrl";
            MainTabCtrl.SelectedIndex = 0;
            MainTabCtrl.Size = new Size(549, 41);
            MainTabCtrl.TabIndex = 0;
            // 
            // homeTab
            // 
            homeTab.Controls.Add(chomePnl);
            homeTab.Location = new Point(4, 39);
            homeTab.Name = "homeTab";
            homeTab.Padding = new Padding(3);
            homeTab.Size = new Size(541, 0);
            homeTab.TabIndex = 0;
            homeTab.Text = "Home";
            homeTab.UseVisualStyleBackColor = true;
            // 
            // restrictionTab
            // 
            restrictionTab.Location = new Point(4, 39);
            restrictionTab.Name = "restrictionTab";
            restrictionTab.Padding = new Padding(3);
            restrictionTab.Size = new Size(541, 0);
            restrictionTab.TabIndex = 1;
            restrictionTab.Text = "Restriction";
            restrictionTab.UseVisualStyleBackColor = true;
            // 
            // activityLogTab
            // 
            activityLogTab.Location = new Point(4, 39);
            activityLogTab.Name = "activityLogTab";
            activityLogTab.Size = new Size(541, 0);
            activityLogTab.TabIndex = 2;
            activityLogTab.Text = "ActivityLog";
            activityLogTab.UseVisualStyleBackColor = true;
            // 
            // settingTab
            // 
            settingTab.Location = new Point(4, 39);
            settingTab.Name = "settingTab";
            settingTab.Size = new Size(541, 0);
            settingTab.TabIndex = 3;
            settingTab.Text = "Setting";
            settingTab.UseVisualStyleBackColor = true;
            // 
            // systemLogTab
            // 
            systemLogTab.Location = new Point(4, 39);
            systemLogTab.Name = "systemLogTab";
            systemLogTab.Size = new Size(541, 0);
            systemLogTab.TabIndex = 4;
            systemLogTab.Text = "SystemLog";
            systemLogTab.UseVisualStyleBackColor = true;
            // 
            // loginPnl
            // 
            loginPnl.Controls.Add(loginMsgLbl);
            loginPnl.Controls.Add(signupLinkLbl);
            loginPnl.Controls.Add(signupMsgLbl);
            loginPnl.Controls.Add(loginBtn);
            loginPnl.Controls.Add(loginPaswrdTxtBox);
            loginPnl.Controls.Add(loginPaswrdLbl);
            loginPnl.Controls.Add(loginUserNameTxtBox);
            loginPnl.Controls.Add(loginUserNameLbl);
            loginPnl.Controls.Add(LoginTitleLbl);
            loginPnl.Location = new Point(0, 0);
            loginPnl.Name = "loginPnl";
            loginPnl.Size = new Size(784, 568);
            loginPnl.TabIndex = 0;
            // 
            // loginMsgLbl
            // 
            loginMsgLbl.AutoSize = true;
            loginMsgLbl.ForeColor = Color.Red;
            loginMsgLbl.Location = new Point(292, 406);
            loginMsgLbl.Name = "loginMsgLbl";
            loginMsgLbl.Size = new Size(0, 15);
            loginMsgLbl.TabIndex = 16;
            // 
            // signupLinkLbl
            // 
            signupLinkLbl.AutoSize = true;
            signupLinkLbl.Location = new Point(479, 448);
            signupLinkLbl.Name = "signupLinkLbl";
            signupLinkLbl.Size = new Size(44, 15);
            signupLinkLbl.TabIndex = 15;
            signupLinkLbl.TabStop = true;
            signupLinkLbl.Text = "Signup";
            signupLinkLbl.LinkClicked += signupLinkLbl_LinkClicked;
            // 
            // signupMsgLbl
            // 
            signupMsgLbl.AutoSize = true;
            signupMsgLbl.FlatStyle = FlatStyle.Flat;
            signupMsgLbl.Location = new Point(349, 448);
            signupMsgLbl.Name = "signupMsgLbl";
            signupMsgLbl.Size = new Size(131, 15);
            signupMsgLbl.TabIndex = 14;
            signupMsgLbl.Text = "Don't have an account?";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.CadetBlue;
            loginBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(229, 345);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(320, 40);
            loginBtn.TabIndex = 13;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginPaswrdTxtBox
            // 
            loginPaswrdTxtBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPaswrdTxtBox.Location = new Point(303, 232);
            loginPaswrdTxtBox.Name = "loginPaswrdTxtBox";
            loginPaswrdTxtBox.PasswordChar = '•';
            loginPaswrdTxtBox.Size = new Size(220, 25);
            loginPaswrdTxtBox.TabIndex = 12;
            loginPaswrdTxtBox.TextChanged += loginPaswrdTxtBox_TextChanged;
            // 
            // loginPaswrdLbl
            // 
            loginPaswrdLbl.AutoSize = true;
            loginPaswrdLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPaswrdLbl.Location = new Point(229, 232);
            loginPaswrdLbl.Name = "loginPaswrdLbl";
            loginPaswrdLbl.Size = new Size(68, 17);
            loginPaswrdLbl.TabIndex = 11;
            loginPaswrdLbl.Text = "password:";
            // 
            // loginUserNameTxtBox
            // 
            loginUserNameTxtBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginUserNameTxtBox.Location = new Point(303, 185);
            loginUserNameTxtBox.Name = "loginUserNameTxtBox";
            loginUserNameTxtBox.Size = new Size(220, 25);
            loginUserNameTxtBox.TabIndex = 10;
            loginUserNameTxtBox.TextChanged += loginUserNameTxtBox_TextChanged;
            // 
            // loginUserNameLbl
            // 
            loginUserNameLbl.AutoSize = true;
            loginUserNameLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginUserNameLbl.Location = new Point(229, 188);
            loginUserNameLbl.Name = "loginUserNameLbl";
            loginUserNameLbl.Size = new Size(68, 17);
            loginUserNameLbl.TabIndex = 9;
            loginUserNameLbl.Text = "username:";
            // 
            // LoginTitleLbl
            // 
            LoginTitleLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginTitleLbl.Location = new Point(209, 115);
            LoginTitleLbl.Name = "LoginTitleLbl";
            LoginTitleLbl.Size = new Size(360, 40);
            LoginTitleLbl.TabIndex = 8;
            LoginTitleLbl.Text = "Parental Control System";
            LoginTitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // topPnl
            // 
            topPnl.Controls.Add(logoutBtn);
            topPnl.Controls.Add(MainTabCtrl);
            topPnl.Dock = DockStyle.Top;
            topPnl.Location = new Point(0, 0);
            topPnl.Name = "topPnl";
            topPnl.Size = new Size(784, 41);
            topPnl.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.None;
            logoutBtn.BackColor = Color.CadetBlue;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(697, 12);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(75, 27);
            logoutBtn.TabIndex = 1;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // chomePnl
            // 
            chomePnl.Controls.Add(cMsgBxPnl);
            chomePnl.Controls.Add(ctablePnl);
            chomePnl.Controls.Add(cUserName);
            chomePnl.Controls.Add(cPicBx);
            chomePnl.Location = new Point(-4, 3);
            chomePnl.Name = "chomePnl";
            chomePnl.Size = new Size(784, 526);
            chomePnl.TabIndex = 17;
            // 
            // cPicBx
            // 
            cPicBx.Anchor = AnchorStyles.None;
            cPicBx.Location = new Point(96, 94);
            cPicBx.Name = "cPicBx";
            cPicBx.Size = new Size(60, 60);
            cPicBx.TabIndex = 0;
            cPicBx.TabStop = false;
            // 
            // cUserName
            // 
            cUserName.AutoSize = true;
            cUserName.Font = new Font("Segoe UI", 11F);
            cUserName.Location = new Point(172, 140);
            cUserName.Name = "cUserName";
            cUserName.Size = new Size(0, 20);
            cUserName.TabIndex = 1;
            // 
            // ctablePnl
            // 
            ctablePnl.ColumnCount = 2;
            ctablePnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.85549F));
            ctablePnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.14451F));
            ctablePnl.Controls.Add(cScreenTimeLbl, 0, 0);
            ctablePnl.Controls.Add(label1, 1, 0);
            ctablePnl.Controls.Add(cStatusLbl, 0, 1);
            ctablePnl.Location = new Point(43, 216);
            ctablePnl.Name = "ctablePnl";
            ctablePnl.RowCount = 2;
            ctablePnl.RowStyles.Add(new RowStyle(SizeType.Percent, 53.4050179F));
            ctablePnl.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5949821F));
            ctablePnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ctablePnl.Size = new Size(692, 205);
            ctablePnl.TabIndex = 2;
            // 
            // cScreenTimeLbl
            // 
            cScreenTimeLbl.AutoSize = true;
            cScreenTimeLbl.Dock = DockStyle.Top;
            cScreenTimeLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cScreenTimeLbl.Location = new Point(3, 0);
            cScreenTimeLbl.Name = "cScreenTimeLbl";
            cScreenTimeLbl.Size = new Size(339, 21);
            cScreenTimeLbl.TabIndex = 0;
            cScreenTimeLbl.Text = "Screen Time Left";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 1;
            label1.Text = "Restricted Apps";
            // 
            // cStatusLbl
            // 
            cStatusLbl.AutoSize = true;
            cStatusLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cStatusLbl.Location = new Point(3, 109);
            cStatusLbl.Name = "cStatusLbl";
            cStatusLbl.Size = new Size(57, 21);
            cStatusLbl.TabIndex = 2;
            cStatusLbl.Text = "Status";
            // 
            // cMsgBxPnl
            // 
            cMsgBxPnl.Controls.Add(sendBtn);
            cMsgBxPnl.Controls.Add(cTxtMsg);
            cMsgBxPnl.Controls.Add(childRtb);
            cMsgBxPnl.Controls.Add(cMsgBxTitleLbl);
            cMsgBxPnl.Location = new Point(322, 448);
            cMsgBxPnl.Name = "cMsgBxPnl";
            cMsgBxPnl.Size = new Size(462, 120);
            cMsgBxPnl.TabIndex = 3;
            // 
            // cMsgBxTitleLbl
            // 
            cMsgBxTitleLbl.AutoSize = true;
            cMsgBxTitleLbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cMsgBxTitleLbl.Location = new Point(3, 0);
            cMsgBxTitleLbl.Name = "cMsgBxTitleLbl";
            cMsgBxTitleLbl.Size = new Size(110, 17);
            cMsgBxTitleLbl.TabIndex = 0;
            cMsgBxTitleLbl.Text = "Chat with parent";
            // 
            // childRtb
            // 
            childRtb.Location = new Point(0, 20);
            childRtb.Name = "childRtb";
            childRtb.ReadOnly = true;
            childRtb.Size = new Size(462, 59);
            childRtb.TabIndex = 1;
            childRtb.Text = "";
            childRtb.TextChanged += childRtb_TextChanged;
            // 
            // cTxtMsg
            // 
            cTxtMsg.Location = new Point(0, 85);
            cTxtMsg.Name = "cTxtMsg";
            cTxtMsg.Size = new Size(201, 23);
            cTxtMsg.TabIndex = 2;
            // 
            // sendBtn
            // 
            sendBtn.BackColor = Color.CadetBlue;
            sendBtn.ForeColor = Color.White;
            sendBtn.Location = new Point(207, 85);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(75, 23);
            sendBtn.TabIndex = 3;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(784, 568);
            Controls.Add(topPnl);
            Controls.Add(loginPnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parental Control System";
            MainTabCtrl.ResumeLayout(false);
            homeTab.ResumeLayout(false);
            loginPnl.ResumeLayout(false);
            loginPnl.PerformLayout();
            topPnl.ResumeLayout(false);
            chomePnl.ResumeLayout(false);
            chomePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cPicBx).EndInit();
            ctablePnl.ResumeLayout(false);
            ctablePnl.PerformLayout();
            cMsgBxPnl.ResumeLayout(false);
            cMsgBxPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabCtrl;
        private TabPage homeTab;
        private TabPage restrictionTab;
        private TabPage activityLogTab;
        private TabPage settingTab;
        private TabPage systemLogTab;
        private Panel loginPnl;
        private LinkLabel signupLinkLbl;
        private Label signupMsgLbl;
        private Button loginBtn;
        private TextBox loginPaswrdTxtBox;
        private Label loginPaswrdLbl;
        private TextBox loginUserNameTxtBox;
        private Label loginUserNameLbl;
        private Label LoginTitleLbl;
        private ColorDialog colorDialog1;
        private Label loginMsgLbl;
        private Panel topPnl;
        private Panel chomePnl;
        private Button logoutBtn;
        private Label cUserName;
        private PictureBox cPicBx;
        private TableLayoutPanel ctablePnl;
        private Label cScreenTimeLbl;
        private Label label1;
        private Label cStatusLbl;
        private Panel cMsgBxPnl;
        private RichTextBox childRtb;
        private Label cMsgBxTitleLbl;
        private Button sendBtn;
        private TextBox cTxtMsg;
    }
}
