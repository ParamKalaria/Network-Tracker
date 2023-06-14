using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_King
{
    public partial class ip : Form
    {
        public ip()
        {
            InitializeComponent();
        }

        private void ip_Load(object sender, EventArgs e)
        {
        a: if (Directory.Exists("config"))
            {
            b: if (File.Exists("config/interface.txt"))
                {
                    try
                    {
                        StreamReader streamReader = new StreamReader("config/interface.txt");
                        string nu = streamReader.ReadToEnd();
                        var v1 = int.Parse(nu);

                        string hostName = Dns.GetHostName();
                        string localIP = Dns.GetHostByName(hostName).AddressList[v1].ToString();

                        computernametextBox.Text = hostName;
                        localiptextBox.Text = localIP;
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show("interface file only works with 0 and 1", "Alert");
                    }

                    try
                    {
                        NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                        foreach (NetworkInterface adapter in adapters)
                        {
                            IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                            GatewayIPAddressInformationCollection addresses = adapterProperties.GatewayAddresses;
                            if (addresses.Count > 0)
                            {
                                Console.WriteLine(adapter.Description);
                                foreach (GatewayIPAddressInformation address in addresses)
                                {
                                    gatewaytextBox.Text = address.Address.ToString();
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message, "Alert");
                    }


                    try
                    {
                        string externalip = new WebClient().DownloadString("http://icanhazip.com");
                        externaliptextBox.Text = externalip;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not Connected to Internet");
                    }


                    if (String.IsNullOrEmpty(computernametextBox.Text))
                    {
                        computernametextBox.Text = "N/A";
                    }
                    if (String.IsNullOrEmpty(localiptextBox.Text))
                    {
                        localiptextBox.Text = "N/A";
                    }
                    if (String.IsNullOrEmpty(externaliptextBox.Text))
                    {
                        externaliptextBox.Text = "N/A";
                    }
                    if (String.IsNullOrEmpty(gatewaytextBox.Text))
                    {
                        gatewaytextBox.Text = "N/A";
                    }


                }
                else
                {
                    StreamWriter streamWriter = new StreamWriter("config/interface.txt");
                    streamWriter.WriteLine("0");
                    streamWriter.Flush();
                    streamWriter.Close();
                    goto b;
                }
            }
            else
            {
                Directory.CreateDirectory("config");
                goto a;
            }
        }
    }
}
