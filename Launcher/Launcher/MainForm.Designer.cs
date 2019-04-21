namespace Launcher
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCancelUpdate = new System.Windows.Forms.PictureBox();
            this.btnOption = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.PictureBox();
            this.wbNotice = new System.Windows.Forms.WebBrowser();
            this.btnStartGame = new System.Windows.Forms.PictureBox();
            this.btnFullDownload = new System.Windows.Forms.PictureBox();
            this.btnForgetPassword = new System.Windows.Forms.PictureBox();
            this.btnSysMinimize = new System.Windows.Forms.PictureBox();
            this.btnSysClose = new System.Windows.Forms.PictureBox();
            this.pnlCheckVersion = new System.Windows.Forms.Panel();
            this.pbAnim = new System.Windows.Forms.PictureBox();
            this.tmrVersionCheckAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlFullDownload = new System.Windows.Forms.Panel();
            this.pnlUpdateProgress = new System.Windows.Forms.Panel();
            this.pnlOverallProgressDisplay = new System.Windows.Forms.Panel();
            this.lblOverallDetailW = new System.Windows.Forms.TextBox();
            this.lblOverallDetail = new System.Windows.Forms.TextBox();
            this.pnlExtendedProgressDisplay = new System.Windows.Forms.Panel();
            this.lblProgressDetailW = new System.Windows.Forms.TextBox();
            this.lblProgressDetail = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForgetPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSysMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSysClose)).BeginInit();
            this.pnlCheckVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnim)).BeginInit();
            this.pnlUpdateProgress.SuspendLayout();
            this.pnlOverallProgressDisplay.SuspendLayout();
            this.pnlExtendedProgressDisplay.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Image = global::Launcher.Properties.Resources.cancel_normal;
            this.btnCancelUpdate.InitialImage = global::Launcher.Properties.Resources.cancel_normal;
            this.btnCancelUpdate.Location = new System.Drawing.Point(280, 411);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(97, 26);
            this.btnCancelUpdate.TabIndex = 0;
            this.btnCancelUpdate.TabStop = false;
            this.btnCancelUpdate.Click += new System.EventHandler(this.BtnCancelUpdate_Click);
            this.btnCancelUpdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnCancelUpdate_MouseDown);
            this.btnCancelUpdate.MouseEnter += new System.EventHandler(this.BtnCancelUpdate_MouseEnter);
            this.btnCancelUpdate.MouseLeave += new System.EventHandler(this.BtnCancelUpdate_MouseLeave);
            this.btnCancelUpdate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCancelUpdate_MouseUp);
            // 
            // btnOption
            // 
            this.btnOption.Image = global::Launcher.Properties.Resources.option_normal;
            this.btnOption.Location = new System.Drawing.Point(98, 411);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(67, 26);
            this.btnOption.TabIndex = 1;
            this.btnOption.TabStop = false;
            this.btnOption.Click += new System.EventHandler(this.BtnOption_Click);
            this.btnOption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnOption_MouseDown);
            this.btnOption.MouseEnter += new System.EventHandler(this.BtnOption_MouseEnter);
            this.btnOption.MouseLeave += new System.EventHandler(this.BtnOption_MouseLeave);
            this.btnOption.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnOption_MouseUp);
            // 
            // btnRegister
            // 
            this.btnRegister.Image = global::Launcher.Properties.Resources.register_normal;
            this.btnRegister.Location = new System.Drawing.Point(8, 411);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 26);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.TabStop = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            this.btnRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRegister_MouseDown);
            this.btnRegister.MouseEnter += new System.EventHandler(this.BtnRegister_MouseEnter);
            this.btnRegister.MouseLeave += new System.EventHandler(this.BtnRegister_MouseLeave);
            this.btnRegister.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRegister_MouseUp);
            // 
            // wbNotice
            // 
            this.wbNotice.IsWebBrowserContextMenuEnabled = false;
            this.wbNotice.Location = new System.Drawing.Point(10, 26);
            this.wbNotice.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNotice.Name = "wbNotice";
            this.wbNotice.ScrollBarsEnabled = false;
            this.wbNotice.Size = new System.Drawing.Size(364, 322);
            this.wbNotice.TabIndex = 3;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Image = global::Launcher.Properties.Resources.start_game_normal;
            this.btnStartGame.Location = new System.Drawing.Point(270, 411);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(107, 26);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.TabStop = false;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            this.btnStartGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnStartGame_MouseDown);
            this.btnStartGame.MouseEnter += new System.EventHandler(this.BtnStartGame_MouseEnter);
            this.btnStartGame.MouseLeave += new System.EventHandler(this.BtnStartGame_MouseLeave);
            this.btnStartGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnStartGame_MouseUp);
            // 
            // btnFullDownload
            // 
            this.btnFullDownload.Image = global::Launcher.Properties.Resources.user_down_normal;
            this.btnFullDownload.Location = new System.Drawing.Point(260, 411);
            this.btnFullDownload.Name = "btnFullDownload";
            this.btnFullDownload.Size = new System.Drawing.Size(117, 26);
            this.btnFullDownload.TabIndex = 5;
            this.btnFullDownload.TabStop = false;
            this.btnFullDownload.Click += new System.EventHandler(this.BtnFullDownload_Click);
            this.btnFullDownload.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFullDownload_MouseDown);
            this.btnFullDownload.MouseEnter += new System.EventHandler(this.BtnFullDownload_MouseEnter);
            this.btnFullDownload.MouseLeave += new System.EventHandler(this.BtnFullDownload_MouseLeave);
            this.btnFullDownload.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFullDownload_MouseUp);
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.Image = global::Launcher.Properties.Resources.forget_pwd_normal;
            this.btnForgetPassword.Location = new System.Drawing.Point(278, 11);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Size = new System.Drawing.Size(79, 33);
            this.btnForgetPassword.TabIndex = 6;
            this.btnForgetPassword.TabStop = false;
            this.btnForgetPassword.Click += new System.EventHandler(this.BtnForgetPassword_Click);
            this.btnForgetPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnForgetPassword_MouseDown);
            this.btnForgetPassword.MouseEnter += new System.EventHandler(this.BtnForgetPassword_MouseEnter);
            this.btnForgetPassword.MouseLeave += new System.EventHandler(this.BtnForgetPassword_MouseLeave);
            this.btnForgetPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnForgetPassword_MouseUp);
            // 
            // btnSysMinimize
            // 
            this.btnSysMinimize.Image = global::Launcher.Properties.Resources.sys_minimize_normal;
            this.btnSysMinimize.Location = new System.Drawing.Point(349, 5);
            this.btnSysMinimize.Name = "btnSysMinimize";
            this.btnSysMinimize.Size = new System.Drawing.Size(14, 11);
            this.btnSysMinimize.TabIndex = 7;
            this.btnSysMinimize.TabStop = false;
            this.btnSysMinimize.Click += new System.EventHandler(this.BtnSysMinimize_Click);
            this.btnSysMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSysMinimize_MouseDown);
            this.btnSysMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSysMinimize_MouseUp);
            // 
            // btnSysClose
            // 
            this.btnSysClose.Image = global::Launcher.Properties.Resources.sys_close_normal;
            this.btnSysClose.Location = new System.Drawing.Point(365, 5);
            this.btnSysClose.Name = "btnSysClose";
            this.btnSysClose.Size = new System.Drawing.Size(14, 11);
            this.btnSysClose.TabIndex = 8;
            this.btnSysClose.TabStop = false;
            this.btnSysClose.Click += new System.EventHandler(this.BtnSysClose_Click);
            this.btnSysClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSysClose_MouseDown);
            this.btnSysClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSysClose_MouseUp);
            // 
            // pnlCheckVersion
            // 
            this.pnlCheckVersion.BackgroundImage = global::Launcher.Properties.Resources.checking_version;
            this.pnlCheckVersion.Controls.Add(this.pbAnim);
            this.pnlCheckVersion.Location = new System.Drawing.Point(8, 355);
            this.pnlCheckVersion.Name = "pnlCheckVersion";
            this.pnlCheckVersion.Size = new System.Drawing.Size(369, 50);
            this.pnlCheckVersion.TabIndex = 9;
            // 
            // pbAnim
            // 
            this.pbAnim.Image = global::Launcher.Properties.Resources.vc_anim_0;
            this.pbAnim.Location = new System.Drawing.Point(55, 2);
            this.pbAnim.Name = "pbAnim";
            this.pbAnim.Size = new System.Drawing.Size(32, 46);
            this.pbAnim.TabIndex = 10;
            this.pbAnim.TabStop = false;
            // 
            // tmrVersionCheckAnimation
            // 
            this.tmrVersionCheckAnimation.Enabled = true;
            this.tmrVersionCheckAnimation.Interval = 150;
            this.tmrVersionCheckAnimation.Tick += new System.EventHandler(this.TmrVersionCheckAnimation_Tick);
            // 
            // pnlFullDownload
            // 
            this.pnlFullDownload.BackgroundImage = global::Launcher.Properties.Resources.direct_down;
            this.pnlFullDownload.Location = new System.Drawing.Point(8, 355);
            this.pnlFullDownload.Name = "pnlFullDownload";
            this.pnlFullDownload.Size = new System.Drawing.Size(369, 50);
            this.pnlFullDownload.TabIndex = 10;
            // 
            // pnlUpdateProgress
            // 
            this.pnlUpdateProgress.BackgroundImage = global::Launcher.Properties.Resources.progress;
            this.pnlUpdateProgress.Controls.Add(this.pnlOverallProgressDisplay);
            this.pnlUpdateProgress.Controls.Add(this.lblOverallDetail);
            this.pnlUpdateProgress.Controls.Add(this.pnlExtendedProgressDisplay);
            this.pnlUpdateProgress.Controls.Add(this.lblProgressDetail);
            this.pnlUpdateProgress.Location = new System.Drawing.Point(8, 355);
            this.pnlUpdateProgress.Name = "pnlUpdateProgress";
            this.pnlUpdateProgress.Size = new System.Drawing.Size(369, 50);
            this.pnlUpdateProgress.TabIndex = 11;
            // 
            // pnlOverallProgressDisplay
            // 
            this.pnlOverallProgressDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(148)))));
            this.pnlOverallProgressDisplay.Controls.Add(this.lblOverallDetailW);
            this.pnlOverallProgressDisplay.Location = new System.Drawing.Point(1, 27);
            this.pnlOverallProgressDisplay.Name = "pnlOverallProgressDisplay";
            this.pnlOverallProgressDisplay.Size = new System.Drawing.Size(166, 22);
            this.pnlOverallProgressDisplay.TabIndex = 2;
            // 
            // lblOverallDetailW
            // 
            this.lblOverallDetailW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(148)))));
            this.lblOverallDetailW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblOverallDetailW.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblOverallDetailW.ForeColor = System.Drawing.Color.White;
            this.lblOverallDetailW.Location = new System.Drawing.Point(3, 4);
            this.lblOverallDetailW.Name = "lblOverallDetailW";
            this.lblOverallDetailW.ReadOnly = true;
            this.lblOverallDetailW.Size = new System.Drawing.Size(360, 13);
            this.lblOverallDetailW.TabIndex = 1;
            this.lblOverallDetailW.Text = "0% (Overall Progress)";
            this.lblOverallDetailW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOverallDetail
            // 
            this.lblOverallDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(218)))));
            this.lblOverallDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblOverallDetail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblOverallDetail.Location = new System.Drawing.Point(4, 31);
            this.lblOverallDetail.Name = "lblOverallDetail";
            this.lblOverallDetail.ReadOnly = true;
            this.lblOverallDetail.Size = new System.Drawing.Size(360, 13);
            this.lblOverallDetail.TabIndex = 2;
            this.lblOverallDetail.Text = "0% (Overall Progress)";
            this.lblOverallDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlExtendedProgressDisplay
            // 
            this.pnlExtendedProgressDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.pnlExtendedProgressDisplay.Controls.Add(this.lblProgressDetailW);
            this.pnlExtendedProgressDisplay.Location = new System.Drawing.Point(1, 1);
            this.pnlExtendedProgressDisplay.Name = "pnlExtendedProgressDisplay";
            this.pnlExtendedProgressDisplay.Size = new System.Drawing.Size(166, 22);
            this.pnlExtendedProgressDisplay.TabIndex = 1;
            // 
            // lblProgressDetailW
            // 
            this.lblProgressDetailW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.lblProgressDetailW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProgressDetailW.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblProgressDetailW.ForeColor = System.Drawing.Color.White;
            this.lblProgressDetailW.Location = new System.Drawing.Point(3, 4);
            this.lblProgressDetailW.Name = "lblProgressDetailW";
            this.lblProgressDetailW.ReadOnly = true;
            this.lblProgressDetailW.Size = new System.Drawing.Size(360, 13);
            this.lblProgressDetailW.TabIndex = 1;
            this.lblProgressDetailW.Text = "0% (Extended Progress Detail)";
            this.lblProgressDetailW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProgressDetail
            // 
            this.lblProgressDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(218)))));
            this.lblProgressDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProgressDetail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblProgressDetail.Location = new System.Drawing.Point(4, 5);
            this.lblProgressDetail.Name = "lblProgressDetail";
            this.lblProgressDetail.ReadOnly = true;
            this.lblProgressDetail.Size = new System.Drawing.Size(360, 13);
            this.lblProgressDetail.TabIndex = 0;
            this.lblProgressDetail.Text = "0% (Extended Progress Detail)";
            this.lblProgressDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackgroundImage = global::Launcher.Properties.Resources.login;
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.btnForgetPassword);
            this.pnlLogin.Location = new System.Drawing.Point(8, 355);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(369, 50);
            this.pnlLogin.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(120, 29);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(128, 14);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(120, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(128, 13);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsername_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.frame;
            this.ClientSize = new System.Drawing.Size(384, 442);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlUpdateProgress);
            this.Controls.Add(this.pnlFullDownload);
            this.Controls.Add(this.pnlCheckVersion);
            this.Controls.Add(this.btnSysClose);
            this.Controls.Add(this.btnSysMinimize);
            this.Controls.Add(this.btnFullDownload);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.wbNotice);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnCancelUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(384, 442);
            this.MinimumSize = new System.Drawing.Size(384, 442);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GunBound Login";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForgetPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSysMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSysClose)).EndInit();
            this.pnlCheckVersion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnim)).EndInit();
            this.pnlUpdateProgress.ResumeLayout(false);
            this.pnlUpdateProgress.PerformLayout();
            this.pnlOverallProgressDisplay.ResumeLayout(false);
            this.pnlOverallProgressDisplay.PerformLayout();
            this.pnlExtendedProgressDisplay.ResumeLayout(false);
            this.pnlExtendedProgressDisplay.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCancelUpdate;
        private System.Windows.Forms.PictureBox btnOption;
        private System.Windows.Forms.PictureBox btnRegister;
        private System.Windows.Forms.WebBrowser wbNotice;
        private System.Windows.Forms.PictureBox btnStartGame;
        private System.Windows.Forms.PictureBox btnFullDownload;
        private System.Windows.Forms.PictureBox btnForgetPassword;
        private System.Windows.Forms.PictureBox btnSysMinimize;
        private System.Windows.Forms.PictureBox btnSysClose;
        private System.Windows.Forms.Panel pnlCheckVersion;
        private System.Windows.Forms.PictureBox pbAnim;
        private System.Windows.Forms.Timer tmrVersionCheckAnimation;
        private System.Windows.Forms.Panel pnlFullDownload;
        private System.Windows.Forms.Panel pnlUpdateProgress;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox lblProgressDetail;
        private System.Windows.Forms.Panel pnlExtendedProgressDisplay;
        private System.Windows.Forms.TextBox lblProgressDetailW;
        private System.Windows.Forms.Panel pnlOverallProgressDisplay;
        private System.Windows.Forms.TextBox lblOverallDetailW;
        private System.Windows.Forms.TextBox lblOverallDetail;
    }
}