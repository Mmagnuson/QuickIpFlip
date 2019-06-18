using QuickIp.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Windows.Forms;

namespace QuickIp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bb = IsRunAsAdmin();

            Dictionary<string, string> nics = NetworkManagement.getNetworkcardDescriptionAndMacAddresses();
            var xxx = nics.ToArray();
            NetworkManagement.setGateway(xxx[0].Key, "192.168.0.1");

            NetworkManagement.setIP(xxx[0].Key, "192.168.0.10", "255.255.255.0");
        }

        private void btnDHCP_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> nics = NetworkManagement.getNetworkcardDescriptionAndMacAddresses();
            var xxx = nics.ToArray();
            NetworkManagement.enableDHCP(xxx[0].Key);
        }

        private bool IsRunAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    //  Console.WriteLine(ni.Name);
                    textBox1.Text = textBox1.Text + ni.Name + Environment.NewLine;
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            textBox1.Text = textBox1.Text + ip.Address.ToString() + Environment.NewLine;
                            //  Console.WriteLine(ip.Address.ToString());
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    string DHCPStatus = "";
                    if (ni.GetIPProperties().DhcpServerAddresses.Count() > 0)
                    {
                        DHCPStatus = "DHCP";
                    }

                    textBox1.Text = textBox1.Text + ni.Name + " " + DHCPStatus + Environment.NewLine;

                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            textBox1.Text = textBox1.Text + ip.Address.ToString() + Environment.NewLine;
                            //  Console.WriteLine(ip.Address.ToString());
                        }
                    }

                    textBox1.Text = textBox1.Text + Environment.NewLine + Environment.NewLine;
                }
            }
        }

        private void RbDHCP_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDHCP.Checked)
            {
                RbStaticIP.Checked = false;
                dgIp.Enabled = false;
            }
        }

        private void RbStaticIP_CheckedChanged(object sender, EventArgs e)
        {
            if (RbStaticIP.Checked)
            {
                RbDHCP.Checked = false;
                RbDNSDHCP.Checked = false;
                RbDNSStatic.Checked = true;
                dgIp.Enabled = true;
            }
        }

        private void RbDNSDHCP_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDNSDHCP.Checked)
            {
                RbDNSStatic.Checked = false;
            }
        }

        private void RbDNSStatic_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.MAC = "2C:4D:54:EA:22:75";
            p.Description = "Test Profile";
            p.DHCP = false;
            p.DNS.Add(new DomainNameServer("8.8.8.8"));
            p.DefaultGateway.Add(new Gateway("192.168.0.1"));
            p.IP.Add(new IPAddress("192.168.0.25", "255.255.255.0"));
            p.IP.Add(new IPAddress("172.16.20.1", "255.255.255.0"));

            ProfileLoader pl = new ProfileLoader();
            pl.Save(p);
        }

        private void bntLoad_Click(object sender, EventArgs e)
        {
            ProfileLoader pl = new ProfileLoader();
            var p = pl.Load();

            pl.Apply(p);

            int xxx = 0;
        }
    }
}