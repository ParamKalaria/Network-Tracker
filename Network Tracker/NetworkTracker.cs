using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Network_King
{
    public partial class NetworkTracker : Form
    {
        public NetworkTracker()
        {
            InitializeComponent();
        }

        private void NetworkKing_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void NetworkKing_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Network Tracker is Running in Background";
            notifyIcon1.BalloonTipText = "Right Click on Application Icon";
            notifyIcon1.ShowBalloonTip(100);



            string config = "config";//DIR
            string ipsearch = "IP Saved";//DIR
            string logs = "logs";//DIR


            string ipinterface = "config/interface.txt";

            filecheck fc = new filecheck();

            fc.CheckDir(config,ipsearch,logs);

            fc.CheckFile(ipinterface);

        }

        private void iPInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ip ip = new ip();
            ip.ShowDialog();
        }

        private void iPFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ipfinder ipfinder = new ipfinder();
            ipfinder.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passwordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordgenerator pg = new passwordgenerator();
            pg.ShowDialog();
        }

        private void pingAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PingAddress pingAddress = new PingAddress();
            pingAddress.ShowDialog();
        }

        private void iPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changeip changeip = new Changeip();
            changeip.ShowDialog();
        }

       
    }
}
