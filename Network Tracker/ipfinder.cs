using System;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace Network_King
{
    public partial class ipfinder : Form
    {
        public ipfinder()
        {
            InitializeComponent();
        }

        private void webaddressbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string HostName = webaddresstextBox.Text;
                IPAddress[] ipaddress = Dns.GetHostAddresses(HostName);

                foreach (IPAddress ipaddr in ipaddress)
                {
                    iptextBox.Text = ipaddr.ToString();
                    string ipa = ipaddr.ToString();



                    // string geoip = new WebClient().DownloadString("https://api.ipgeolocationapi.com/geolocate/" + ipa);
                    //richTextBox1.Text = geoip;
                }
                string webadd = webaddresstextBox.Text;

                StreamWriter sw = new StreamWriter("IP Saved/" + webadd + ".txt");
                sw.WriteLine(iptextBox.Text);
                sw.Flush();
                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {      
            try
            {
                Clipboard.SetText(iptextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ipfinder_Load(object sender, EventArgs e)
        {

        }
    }
}
