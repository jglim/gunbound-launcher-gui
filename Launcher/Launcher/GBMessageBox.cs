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
    public partial class GBMessageBox : Form
    {
        MessageBoxButtons _messageBoxButtons;
        public GBMessageBox(string messageBody, MessageBoxButtons messageBoxButtons)
        {
            // The ampersand "Alt hotkeys" may not be in the right places
            string msgOk = "&OK";
            string msgCancel = "&Cancel";
            string msgYes = "&Yes";
            string msgNo = "&No";
            string msgRetry = "&Retry";
            string msgAbort = "Abort";
            string msgIgnore = "Ignore";
            _messageBoxButtons = messageBoxButtons;
            InitializeComponent();
            if (_messageBoxButtons == MessageBoxButtons.OK)
            {
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button1.Text = msgOk;
                button1.Click += delegate { this.DialogResult = DialogResult.OK; this.Close(); };
                this.AcceptButton = button1;
                this.CancelButton = button1;
            }
            if (_messageBoxButtons == MessageBoxButtons.OKCancel)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button1.Text = msgOk;
                button2.Text = msgCancel;
                button1.Click += delegate { this.DialogResult = DialogResult.OK; this.Close(); };
                button2.Click += delegate { this.DialogResult = DialogResult.Cancel; this.Close(); };
                this.AcceptButton = button1;
                this.CancelButton = button2;
            }
            if (_messageBoxButtons == MessageBoxButtons.YesNo)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button1.Text = msgNo;
                button2.Text = msgYes;
                button1.Click += delegate { this.DialogResult = DialogResult.No; this.Close(); };
                button2.Click += delegate { this.DialogResult = DialogResult.Yes; this.Close(); };
                this.AcceptButton = button2;
                this.CancelButton = button1;
            }
            if (_messageBoxButtons == MessageBoxButtons.YesNoCancel)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button1.Text = msgNo;
                button2.Text = msgYes;
                button3.Text = msgCancel;
                button1.Click += delegate { this.DialogResult = DialogResult.Cancel; this.Close(); };
                button2.Click += delegate { this.DialogResult = DialogResult.No; this.Close(); };
                button3.Click += delegate { this.DialogResult = DialogResult.Yes; this.Close(); };
                this.AcceptButton = button3;
                this.CancelButton = button1;
            }
            if (_messageBoxButtons == MessageBoxButtons.RetryCancel)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button1.Text = msgCancel;
                button2.Text = msgRetry;
                button1.Click += delegate { this.DialogResult = DialogResult.Cancel; this.Close(); };
                button2.Click += delegate { this.DialogResult = DialogResult.Retry; this.Close(); };
                this.AcceptButton = button2;
                this.CancelButton = button1;
            }
            if (_messageBoxButtons == MessageBoxButtons.AbortRetryIgnore)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button1.Text = msgIgnore;
                button2.Text = msgRetry;
                button3.Text = msgAbort;
                button1.Click += delegate { this.DialogResult = DialogResult.Ignore; this.Close(); };
                button2.Click += delegate { this.DialogResult = DialogResult.Retry; this.Close(); };
                button3.Click += delegate { this.DialogResult = DialogResult.Abort; this.Close(); };
                this.AcceptButton = button2;
                this.CancelButton = button1;
            }
            lblMessageBody.Text = messageBody;
        }

        private void GBMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
