namespace DXWindows
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogoTop = new DevExpress.XtraEditors.PictureEdit();
            this.lblTitleTop = new DevExpress.XtraEditors.LabelControl();
            this.picStatusNet = new DevExpress.XtraEditors.PictureEdit();
            this.picTeamview = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblVersion = new DevExpress.XtraEditors.LabelControl();
            this.lblStatusNet = new DevExpress.XtraEditors.LabelControl();
            this.lblHotline = new DevExpress.XtraEditors.LabelControl();
            this.lblTeamview = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusNet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamview.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(46, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 24);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(46, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 24);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.BarAnimationElementThickness = 2;
            this.progressPanel1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPanel1.ImageHorzOffset = 150;
            this.progressPanel1.Location = new System.Drawing.Point(0, 0);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(618, 277);
            this.progressPanel1.TabIndex = 11;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(12)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.picLogoTop);
            this.panel1.Controls.Add(this.lblTitleTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 72);
            this.panel1.TabIndex = 13;
            // 
            // picLogoTop
            // 
            this.picLogoTop.EditValue = global::DXWindows.Properties.Resources.logo_480;
            this.picLogoTop.Location = new System.Drawing.Point(8, 11);
            this.picLogoTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogoTop.Name = "picLogoTop";
            // 
            // 
            // 
            this.picLogoTop.Properties.AllowFocused = false;
            this.picLogoTop.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picLogoTop.Properties.Appearance.Options.UseBackColor = true;
            this.picLogoTop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogoTop.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picLogoTop.Size = new System.Drawing.Size(128, 51);
            this.picLogoTop.TabIndex = 3;
            // 
            // lblTitleTop
            // 
            this.lblTitleTop.Appearance.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitleTop.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitleTop.Appearance.Options.UseFont = true;
            this.lblTitleTop.Appearance.Options.UseForeColor = true;
            this.lblTitleTop.Location = new System.Drawing.Point(216, 15);
            this.lblTitleTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblTitleTop.Name = "lblTitleTop";
            this.lblTitleTop.Size = new System.Drawing.Size(322, 39);
            this.lblTitleTop.TabIndex = 2;
            this.lblTitleTop.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // picStatusNet
            // 
            this.picStatusNet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStatusNet.EditValue = global::DXWindows.Properties.Resources.status_net_2;
            this.picStatusNet.Location = new System.Drawing.Point(208, 135);
            this.picStatusNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picStatusNet.Name = "picStatusNet";
            // 
            // 
            // 
            this.picStatusNet.Properties.AllowFocused = false;
            this.picStatusNet.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picStatusNet.Properties.Appearance.Options.UseBackColor = true;
            this.picStatusNet.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picStatusNet.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picStatusNet.Size = new System.Drawing.Size(20, 18);
            this.picStatusNet.TabIndex = 18;
            this.picStatusNet.ToolTip = "Bấm để kiểm tra lại tình trạng internet!";
            this.picStatusNet.Click += new System.EventHandler(this.StatusNetClick);
            // 
            // picTeamview
            // 
            this.picTeamview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTeamview.EditValue = global::DXWindows.Properties.Resources.teamview_12;
            this.picTeamview.Location = new System.Drawing.Point(46, 248);
            this.picTeamview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTeamview.Name = "picTeamview";
            // 
            // 
            // 
            this.picTeamview.Properties.AllowFocused = false;
            this.picTeamview.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picTeamview.Properties.Appearance.Options.UseBackColor = true;
            this.picTeamview.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picTeamview.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picTeamview.Size = new System.Drawing.Size(18, 18);
            this.picTeamview.TabIndex = 19;
            this.picTeamview.ToolTip = "Bấm để mở hỗ trợ từ xa";
            this.picTeamview.Click += new System.EventHandler(this.TeamviewClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Controls.Add(this.lblStatusNet);
            this.panel2.Controls.Add(this.picStatusNet);
            this.panel2.Controls.Add(this.picTeamview);
            this.panel2.Controls.Add(this.lblHotline);
            this.panel2.Controls.Add(this.lblTeamview);
            this.panel2.Controls.Add(this.progressPanel1);
            this.panel2.Location = new System.Drawing.Point(8, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 277);
            this.panel2.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ImageOptions.Image = global::DXWindows.Properties.Resources.exit1;
            this.btnExit.Location = new System.Drawing.Point(399, 189);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ImageOptions.Image = global::DXWindows.Properties.Resources.rd_global_icon_16_register;
            this.btnLogin.Location = new System.Drawing.Point(208, 189);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 43);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "";
            this.txtUserName.Location = new System.Drawing.Point(208, 25);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            // 
            // 
            // 
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtUserName.Size = new System.Drawing.Size(344, 32);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(208, 78);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            // 
            // 
            // 
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(344, 32);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Location = new System.Drawing.Point(9, 163);
            this.labelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(604, 20);
            this.labelControl4.TabIndex = 15;
            // 
            // lblVersion
            // 
            this.lblVersion.Appearance.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.lblVersion.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Appearance.Options.UseFont = true;
            this.lblVersion.Appearance.Options.UseForeColor = true;
            this.lblVersion.Location = new System.Drawing.Point(46, 197);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(113, 29);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "Version 2.0";
            // 
            // lblStatusNet
            // 
            this.lblStatusNet.Appearance.Font = new System.Drawing.Font("Candara", 10F);
            this.lblStatusNet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblStatusNet.Appearance.Options.UseFont = true;
            this.lblStatusNet.Appearance.Options.UseForeColor = true;
            this.lblStatusNet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStatusNet.Location = new System.Drawing.Point(232, 132);
            this.lblStatusNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblStatusNet.Name = "lblStatusNet";
            this.lblStatusNet.Size = new System.Drawing.Size(188, 24);
            this.lblStatusNet.TabIndex = 17;
            this.lblStatusNet.Text = "Không kết nối internet";
            this.lblStatusNet.ToolTip = "Bấm để kiểm tra lại tình trạng internet!";
            this.lblStatusNet.Click += new System.EventHandler(this.StatusNetClick);
            // 
            // lblHotline
            // 
            this.lblHotline.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblHotline.Appearance.Options.UseForeColor = true;
            this.lblHotline.Location = new System.Drawing.Point(414, 246);
            this.lblHotline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblHotline.Name = "lblHotline";
            this.lblHotline.Size = new System.Drawing.Size(0, 19);
            this.lblHotline.TabIndex = 20;
            this.lblHotline.Visible = false;
            // 
            // lblTeamview
            // 
            this.lblTeamview.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblTeamview.Appearance.Options.UseForeColor = true;
            this.lblTeamview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTeamview.Location = new System.Drawing.Point(68, 246);
            this.lblTeamview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblTeamview.Name = "lblTeamview";
            this.lblTeamview.Size = new System.Drawing.Size(86, 19);
            this.lblTeamview.TabIndex = 21;
            this.lblTeamview.Text = "Hỗ trợ từ xa";
            this.lblTeamview.ToolTip = "Bấm để mở hỗ trợ từ xa";
            this.lblTeamview.Click += new System.EventHandler(this.TeamviewClick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(633, 354);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusNet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamview.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit picLogoTop;
        private DevExpress.XtraEditors.LabelControl lblTitleTop;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblVersion;
        private DevExpress.XtraEditors.LabelControl lblStatusNet;
        private DevExpress.XtraEditors.PictureEdit picStatusNet;
        private DevExpress.XtraEditors.PictureEdit picTeamview;
        private DevExpress.XtraEditors.LabelControl lblHotline;
        private DevExpress.XtraEditors.LabelControl lblTeamview;
    }
}