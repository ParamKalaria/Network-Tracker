using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Network_King
{
    public partial class PingAddress : Form
    {
        public PingAddress()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(pingtextBox.Text, 1000);
                if (reply != null)
                {
                    pingrichTextBox.Text = "Status :  " + reply.Status + " \nNetwork Latency : " + reply.RoundtripTime.ToString() + " \nAddress : " + reply.Address;
                    //Console.WriteLine(reply.ToString());

                }
            }
            catch
            {
                pingrichTextBox.Text = "ERROR: You have Some TIMEOUT issue";
            }
        }

        private void PingAddress_Load(object sender, EventArgs e)
        {

        }
    }
}
