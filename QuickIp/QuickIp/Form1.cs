using QuickIp.Profiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Windows.Forms;

namespace QuickIp
{
    public partial class Form1 : Form
    {
        public List<Profile> ProfileList;
        public Profile ProfileSelected;

        public Form1()
        {
            InitializeComponent();
            ProfileList = new List<Profile>();
            ProfileSelected = new Profile();
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

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "";

            //if (cmbNetworkcards.Items.Count <= 0)
            //{
            //    foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            //    {
            //        if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
            //        {
            //            cmbNetworkcards.Items.Add(ni.Name + " " + ni.OperationalStatus.ToString());
            //        }
            //    }
            //}

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    string DHCPStatus = "";

                    textBox1.Text = textBox1.Text + ni.Name + Environment.NewLine + ni.Description + Environment.NewLine;
                    textBox1.Text = textBox1.Text + ni.NetworkInterfaceType + Environment.NewLine;

                    if (ni.GetIPProperties().DhcpServerAddresses.Count() > 0)
                    {
                        textBox1.Text = textBox1.Text + "(DHCP)" + Environment.NewLine;
                    }

                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            textBox1.Text = textBox1.Text + ip.Address.ToString() + "   " + ip.IPv4Mask.ToString() + Environment.NewLine;
                            //  Console.WriteLine(ip.Address.ToString());
                        }
                    }

                    textBox1.Text = textBox1.Text + Environment.NewLine + Environment.NewLine;
                }
            }



            // ProfileLoader pl = new ProfileLoader();
            //  var pList = pl.LoadProfilesInDirectory();

            //if (!(pList.SequenceEqual(ProfileList) && pList.Count == ProfileList.Count))
            //{
            //    ProfileList = pList;
            //    lbProfiles.Items.Clear();
            //    foreach (var p in ProfileList)
            //    {
            //        lbProfiles.Items.Add(p);
            //    }
            //}
        }

        private void RbDHCP_Click(object sender, EventArgs e)
        {
            if (RbDHCP.Checked)
            {
                RbStaticIP.Checked = false;
                dgIp.Enabled = false;
                RbDNSDHCP.Enabled = true;
            }
        }

        private void RbStaticIP_Click(object sender, EventArgs e)
        {
            if (RbStaticIP.Checked)
            {
                RbDHCP.Checked = false;
                RbDNSDHCP.Checked = false;
                RbDNSStatic.Checked = true;
                dgIp.Enabled = true;
                RbDNSDHCP.Enabled = false;
            }
        }

        private void RbDNSDHCP_Click(object sender, EventArgs e)
        {
            if (!RbStaticIP.Checked)
            {
                RbDNSStatic.Checked = false;
                RbDNSDHCP.Checked = true;
            }
        }

        private void RbDNSStatic_Click(object sender, EventArgs e)
        {
            RbDNSDHCP.Checked = false;
            RbDNSStatic.Checked = true;
        }

  

        private void LbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProfiles.SelectedItem != null)
            {
                var p = (Profile)lbProfiles.SelectedItem;
                ProfileSelected = p;
                UpdateSettings();


            }
        }

        public void UpdateSettings()
        {
            txtProfileName.Text = ProfileSelected.Description;

            if (ProfileSelected.DHCP)
            {

                RbDHCP.Checked = true;
                RbStaticIP.Checked = false;
                dgIp.Enabled = false;
                RbDNSDHCP.Enabled = true;

            }
            else
            {
                RbStaticIP.Checked = true;
                RbDHCP.Checked = false;
                RbDNSDHCP.Checked = false;
                RbDNSStatic.Checked = true;
                dgIp.Enabled = true;
                RbDNSDHCP.Enabled = false;
            }
            if (ProfileSelected.DNS.Count > 0)
            {

            }

        }



        private void BtnSave_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.MAC = "2C:4D:54:EA:22:75";
            p.Description = "DHCP";
            p.DHCP = true;
            // p.DNS.Add(new DomainNameServer("8.8.8.8"));
            //p.DefaultGateway.Add(new Gateway("192.168.0.1"));
            // p.IP.Add(new IPAddress("192.168.0.25", "255.255.255.0"));
            // p.IP.Add(new IPAddress("172.16.20.1", "255.255.255.0"));

            ProfileLoader pl = new ProfileLoader();
            pl.Save(p);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete: " + ProfileSelected.Description, "Delete Ip Profile", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (File.Exists(ProfileSelected.Path))
                {
                    // If file found, delete it
                    File.Delete(ProfileSelected.Path);
                }
            }
        }

        private void bntApply_Click(object sender, EventArgs e)
        {
            ProfileLoader pl = new ProfileLoader();
            pl.Apply(ProfileSelected);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ProfileSelected = new Profile();
            ProfileSelected.DHCP = true;
            UpdateSettings();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}