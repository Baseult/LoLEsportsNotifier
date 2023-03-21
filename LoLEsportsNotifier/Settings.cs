using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LoLEsportsNotifier
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public bool GetDesktopNotifications = true;
        public int CheckEachXSeconds = 10;

        private void NotificationBox_CheckedChanged(object sender, EventArgs e)
        {
            GetDesktopNotifications = notificationBox.Checked;
        }

        private void CheckSeconds_ValueChanged(object sender, EventArgs e)
        {
            CheckEachXSeconds = Convert.ToInt32(checkSeconds.Value);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Hello there!\r\n\r\nI'm delighted to share that all of my programs are free to use.\r\n\r\nIf you appreciate my work and would like to support me, you can make a donation of any amount you like. Your contribution will help me keep improving my programs and creating more useful tools.\r\n\r\nEvery donation, no matter how small, makes a big difference and will be greatly appreciated, as it will help me cover the costs of maintaining my website and push my motivation to continue publishing my work for free.\r\n\r\nThank you so much for your support and generosity. I'm grateful for your consideration and I hope my programs can continue to be useful to you in the future.\r\n\r\nWould you like to Donate? ", "Donations", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("https://www.paypal.com/donate/?hosted_button_id=JX6DWXC4TLPFW");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            var obj = (Form1)Application.OpenForms["Form1"];
            obj?.bgw.CancelAsync();
            obj?.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            var obj = (Form1)Application.OpenForms["Form1"];
            if (obj != null) obj.WindowState = FormWindowState.Minimized;
        }
    }
}
