using System;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace Network_King
{
    public partial class Changeip : Form
    {
        public Changeip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strCmdText;
                strCmdText = "netsh interface ipv4 set address name="+ "Ethernet" + "static" + iptextBox.Text + subnettextBox.Text + gatewaytextBox.Text;
                Process.Start("CMD.exe", strCmdText);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Done");
        }

        private void Changeip_Load(object sender, EventArgs e)
        {

        }
    }
}
