namespace Launcher
{
    partial class KitchenSink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenSink));
            this.gbLauncherState = new System.Windows.Forms.GroupBox();
            this.btnLauncherStateCheckingVersion = new System.Windows.Forms.Button();
            this.btnLauncherStateUpdating = new System.Windows.Forms.Button();
            this.btnLauncherStateFullDownloadRequired = new System.Windows.Forms.Button();
            this.btnLauncherStateAwaitingLogin = new System.Windows.Forms.Button();
            this.gbProgressExtended = new System.Windows.Forms.GroupBox();
            this.tbProgressExtended = new System.Windows.Forms.TrackBar();
            this.txtProgressExtended = new System.Windows.Forms.TextBox();
            this.gbProgressOverall = new System.Windows.Forms.GroupBox();
            this.txtProgressOverall = new System.Windows.Forms.TextBox();
            this.tbProgressOverall = new System.Windows.Forms.TrackBar();
            this.gbNotice = new System.Windows.Forms.GroupBox();
            this.txtNoticeURL = new System.Windows.Forms.TextBox();
            this.btnNoticeNavigate = new System.Windows.Forms.Button();
            this.gbModal = new System.Windows.Forms.GroupBox();
            this.btnShowModal = new System.Windows.Forms.Button();
            this.txtModalText = new System.Windows.Forms.TextBox();
            this.gbLauncherState.SuspendLayout();
            this.gbProgressExtended.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgressExtended)).BeginInit();
            this.gbProgressOverall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgressOverall)).BeginInit();
            this.gbNotice.SuspendLayout();
            this.gbModal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLauncherState
            // 
            this.gbLauncherState.Controls.Add(this.btnLauncherStateAwaitingLogin);
            this.gbLauncherState.Controls.Add(this.btnLauncherStateFullDownloadRequired);
            this.gbLauncherState.Controls.Add(this.btnLauncherStateUpdating);
            this.gbLauncherState.Controls.Add(this.btnLauncherStateCheckingVersion);
            this.gbLauncherState.Location = new System.Drawing.Point(12, 12);
            this.gbLauncherState.Name = "gbLauncherState";
            this.gbLauncherState.Size = new System.Drawing.Size(198, 140);
            this.gbLauncherState.TabIndex = 0;
            this.gbLauncherState.TabStop = false;
            this.gbLauncherState.Text = "Launcher State";
            // 
            // btnLauncherStateCheckingVersion
            // 
            this.btnLauncherStateCheckingVersion.Location = new System.Drawing.Point(6, 19);
            this.btnLauncherStateCheckingVersion.Name = "btnLauncherStateCheckingVersion";
            this.btnLauncherStateCheckingVersion.Size = new System.Drawing.Size(181, 23);
            this.btnLauncherStateCheckingVersion.TabIndex = 0;
            this.btnLauncherStateCheckingVersion.Text = "CHECKING_VERSION";
            this.btnLauncherStateCheckingVersion.UseVisualStyleBackColor = true;
            this.btnLauncherStateCheckingVersion.Click += new System.EventHandler(this.BtnLauncherStateCheckingVersion_Click);
            // 
            // btnLauncherStateUpdating
            // 
            this.btnLauncherStateUpdating.Location = new System.Drawing.Point(6, 48);
            this.btnLauncherStateUpdating.Name = "btnLauncherStateUpdating";
            this.btnLauncherStateUpdating.Size = new System.Drawing.Size(181, 23);
            this.btnLauncherStateUpdating.TabIndex = 1;
            this.btnLauncherStateUpdating.Text = "UPDATING";
            this.btnLauncherStateUpdating.UseVisualStyleBackColor = true;
            this.btnLauncherStateUpdating.Click += new System.EventHandler(this.BtnLauncherStateUpdating_Click);
            // 
            // btnLauncherStateFullDownloadRequired
            // 
            this.btnLauncherStateFullDownloadRequired.Location = new System.Drawing.Point(6, 77);
            this.btnLauncherStateFullDownloadRequired.Name = "btnLauncherStateFullDownloadRequired";
            this.btnLauncherStateFullDownloadRequired.Size = new System.Drawing.Size(181, 23);
            this.btnLauncherStateFullDownloadRequired.TabIndex = 2;
            this.btnLauncherStateFullDownloadRequired.Text = "FULL_DOWNLOAD_REQUIRED";
            this.btnLauncherStateFullDownloadRequired.UseVisualStyleBackColor = true;
            this.btnLauncherStateFullDownloadRequired.Click += new System.EventHandler(this.BtnLauncherStateFullDownloadRequired_Click);
            // 
            // btnLauncherStateAwaitingLogin
            // 
            this.btnLauncherStateAwaitingLogin.Location = new System.Drawing.Point(6, 106);
            this.btnLauncherStateAwaitingLogin.Name = "btnLauncherStateAwaitingLogin";
            this.btnLauncherStateAwaitingLogin.Size = new System.Drawing.Size(181, 23);
            this.btnLauncherStateAwaitingLogin.TabIndex = 3;
            this.btnLauncherStateAwaitingLogin.Text = "AWAITING_LOGIN";
            this.btnLauncherStateAwaitingLogin.UseVisualStyleBackColor = true;
            this.btnLauncherStateAwaitingLogin.Click += new System.EventHandler(this.BtnLauncherStateAwaitingLogin_Click);
            // 
            // gbProgressExtended
            // 
            this.gbProgressExtended.Controls.Add(this.txtProgressExtended);
            this.gbProgressExtended.Controls.Add(this.tbProgressExtended);
            this.gbProgressExtended.Location = new System.Drawing.Point(216, 12);
            this.gbProgressExtended.Name = "gbProgressExtended";
            this.gbProgressExtended.Size = new System.Drawing.Size(519, 100);
            this.gbProgressExtended.TabIndex = 1;
            this.gbProgressExtended.TabStop = false;
            this.gbProgressExtended.Text = "Progress (Extended)";
            // 
            // tbProgressExtended
            // 
            this.tbProgressExtended.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProgressExtended.Location = new System.Drawing.Point(6, 19);
            this.tbProgressExtended.Maximum = 100;
            this.tbProgressExtended.Name = "tbProgressExtended";
            this.tbProgressExtended.Size = new System.Drawing.Size(507, 42);
            this.tbProgressExtended.TabIndex = 0;
            this.tbProgressExtended.TickFrequency = 5;
            this.tbProgressExtended.Scroll += new System.EventHandler(this.TbProgressExtended_Scroll);
            // 
            // txtProgressExtended
            // 
            this.txtProgressExtended.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProgressExtended.Location = new System.Drawing.Point(6, 67);
            this.txtProgressExtended.Name = "txtProgressExtended";
            this.txtProgressExtended.Size = new System.Drawing.Size(507, 20);
            this.txtProgressExtended.TabIndex = 1;
            this.txtProgressExtended.TextChanged += new System.EventHandler(this.TxtProgressExtended_TextChanged);
            // 
            // gbProgressOverall
            // 
            this.gbProgressOverall.Controls.Add(this.txtProgressOverall);
            this.gbProgressOverall.Controls.Add(this.tbProgressOverall);
            this.gbProgressOverall.Location = new System.Drawing.Point(216, 118);
            this.gbProgressOverall.Name = "gbProgressOverall";
            this.gbProgressOverall.Size = new System.Drawing.Size(519, 100);
            this.gbProgressOverall.TabIndex = 2;
            this.gbProgressOverall.TabStop = false;
            this.gbProgressOverall.Text = "Progress (Overall)";
            // 
            // txtProgressOverall
            // 
            this.txtProgressOverall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProgressOverall.Location = new System.Drawing.Point(6, 67);
            this.txtProgressOverall.Name = "txtProgressOverall";
            this.txtProgressOverall.Size = new System.Drawing.Size(507, 20);
            this.txtProgressOverall.TabIndex = 1;
            this.txtProgressOverall.TextChanged += new System.EventHandler(this.TxtProgressOverall_TextChanged);
            // 
            // tbProgressOverall
            // 
            this.tbProgressOverall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProgressOverall.Location = new System.Drawing.Point(6, 19);
            this.tbProgressOverall.Maximum = 100;
            this.tbProgressOverall.Name = "tbProgressOverall";
            this.tbProgressOverall.Size = new System.Drawing.Size(507, 42);
            this.tbProgressOverall.TabIndex = 0;
            this.tbProgressOverall.TickFrequency = 5;
            this.tbProgressOverall.Scroll += new System.EventHandler(this.TbProgressOverall_Scroll);
            // 
            // gbNotice
            // 
            this.gbNotice.Controls.Add(this.btnNoticeNavigate);
            this.gbNotice.Controls.Add(this.txtNoticeURL);
            this.gbNotice.Location = new System.Drawing.Point(216, 224);
            this.gbNotice.Name = "gbNotice";
            this.gbNotice.Size = new System.Drawing.Size(519, 59);
            this.gbNotice.TabIndex = 3;
            this.gbNotice.TabStop = false;
            this.gbNotice.Text = "Notice WebBrowser";
            // 
            // txtNoticeURL
            // 
            this.txtNoticeURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoticeURL.Location = new System.Drawing.Point(6, 29);
            this.txtNoticeURL.Name = "txtNoticeURL";
            this.txtNoticeURL.Size = new System.Drawing.Size(413, 20);
            this.txtNoticeURL.TabIndex = 2;
            // 
            // btnNoticeNavigate
            // 
            this.btnNoticeNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoticeNavigate.Location = new System.Drawing.Point(425, 27);
            this.btnNoticeNavigate.Name = "btnNoticeNavigate";
            this.btnNoticeNavigate.Size = new System.Drawing.Size(88, 23);
            this.btnNoticeNavigate.TabIndex = 4;
            this.btnNoticeNavigate.Text = "Navigate";
            this.btnNoticeNavigate.UseVisualStyleBackColor = true;
            this.btnNoticeNavigate.Click += new System.EventHandler(this.BtnNoticeNavigate_Click);
            // 
            // gbModal
            // 
            this.gbModal.Controls.Add(this.txtModalText);
            this.gbModal.Controls.Add(this.btnShowModal);
            this.gbModal.Location = new System.Drawing.Point(12, 158);
            this.gbModal.Name = "gbModal";
            this.gbModal.Size = new System.Drawing.Size(200, 125);
            this.gbModal.TabIndex = 4;
            this.gbModal.TabStop = false;
            this.gbModal.Text = "Modal";
            // 
            // btnShowModal
            // 
            this.btnShowModal.Location = new System.Drawing.Point(6, 92);
            this.btnShowModal.Name = "btnShowModal";
            this.btnShowModal.Size = new System.Drawing.Size(188, 23);
            this.btnShowModal.TabIndex = 4;
            this.btnShowModal.Text = "Show Modal";
            this.btnShowModal.UseVisualStyleBackColor = true;
            this.btnShowModal.Click += new System.EventHandler(this.BtnShowModal_Click);
            // 
            // txtModalText
            // 
            this.txtModalText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModalText.Location = new System.Drawing.Point(6, 19);
            this.txtModalText.Multiline = true;
            this.txtModalText.Name = "txtModalText";
            this.txtModalText.Size = new System.Drawing.Size(188, 67);
            this.txtModalText.TabIndex = 5;
            this.txtModalText.Text = "Multiline\r\nModal\r\n\r\n> Text";
            // 
            // KitchenSink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 297);
            this.Controls.Add(this.gbModal);
            this.Controls.Add(this.gbNotice);
            this.Controls.Add(this.gbProgressOverall);
            this.Controls.Add(this.gbProgressExtended);
            this.Controls.Add(this.gbLauncherState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitchenSink";
            this.Text = "Kitchen Sink";
            this.Load += new System.EventHandler(this.KitchenSink_Load);
            this.gbLauncherState.ResumeLayout(false);
            this.gbProgressExtended.ResumeLayout(false);
            this.gbProgressExtended.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgressExtended)).EndInit();
            this.gbProgressOverall.ResumeLayout(false);
            this.gbProgressOverall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgressOverall)).EndInit();
            this.gbNotice.ResumeLayout(false);
            this.gbNotice.PerformLayout();
            this.gbModal.ResumeLayout(false);
            this.gbModal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLauncherState;
        private System.Windows.Forms.Button btnLauncherStateCheckingVersion;
        private System.Windows.Forms.Button btnLauncherStateUpdating;
        private System.Windows.Forms.Button btnLauncherStateFullDownloadRequired;
        private System.Windows.Forms.Button btnLauncherStateAwaitingLogin;
        private System.Windows.Forms.GroupBox gbProgressExtended;
        private System.Windows.Forms.TextBox txtProgressExtended;
        private System.Windows.Forms.TrackBar tbProgressExtended;
        private System.Windows.Forms.GroupBox gbProgressOverall;
        private System.Windows.Forms.TextBox txtProgressOverall;
        private System.Windows.Forms.TrackBar tbProgressOverall;
        private System.Windows.Forms.GroupBox gbNotice;
        private System.Windows.Forms.Button btnNoticeNavigate;
        private System.Windows.Forms.TextBox txtNoticeURL;
        private System.Windows.Forms.GroupBox gbModal;
        private System.Windows.Forms.TextBox txtModalText;
        private System.Windows.Forms.Button btnShowModal;
    }
}