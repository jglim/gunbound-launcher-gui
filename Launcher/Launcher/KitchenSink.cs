using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Launcher
{
    public partial class KitchenSink : Form
    {
        public KitchenSink()
        {
            InitializeComponent();
        }

        private void KitchenSink_Load(object sender, EventArgs e)
        {
            txtNoticeURL.Text = Program.mainForm.GetNoticeURL();
        }

        private void BtnLauncherStateCheckingVersion_Click(object sender, EventArgs e)
        {
            Program.mainForm.ChangeLauncherState(MainForm.LauncherState.CHECKING_VERSION);
        }

        private void BtnLauncherStateUpdating_Click(object sender, EventArgs e)
        {
            Program.mainForm.ChangeLauncherState(MainForm.LauncherState.UPDATING);
        }

        private void BtnLauncherStateFullDownloadRequired_Click(object sender, EventArgs e)
        {
            Program.mainForm.ChangeLauncherState(MainForm.LauncherState.FULL_DOWNLOAD_REQUIRED);
        }

        private void BtnLauncherStateAwaitingLogin_Click(object sender, EventArgs e)
        {
            Program.mainForm.ChangeLauncherState(MainForm.LauncherState.AWAITING_LOGIN);
        }

        private void TbProgressExtended_Scroll(object sender, EventArgs e)
        {
            Program.mainForm.SetExtendedProgressPercentage(tbProgressExtended.Value);
        }

        private void TxtProgressExtended_TextChanged(object sender, EventArgs e)
        {
            Program.mainForm.SetExtendedProgressText(txtProgressExtended.Text);
        }

        private void TbProgressOverall_Scroll(object sender, EventArgs e)
        {
            Program.mainForm.SetOverallProgressPercentage(tbProgressOverall.Value);
        }

        private void TxtProgressOverall_TextChanged(object sender, EventArgs e)
        {
            Program.mainForm.SetOverallProgressText(txtProgressOverall.Text);
        }

        private void BtnNoticeNavigate_Click(object sender, EventArgs e)
        {
            Program.mainForm.SetNoticeURL(txtNoticeURL.Text);
        }

        private void BtnShowModal_Click(object sender, EventArgs e)
        {
            GBMessageBox customMessage = new GBMessageBox(txtModalText.Text, MessageBoxButtons.YesNo);
            MessageBox.Show(customMessage.ShowDialog().ToString(), "Dialog Result");
        }
    }
}
