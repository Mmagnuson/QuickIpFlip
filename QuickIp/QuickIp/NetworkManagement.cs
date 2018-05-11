using System;
using System.Collections.Generic;
using System.Management;

//this class taken directly from
// http://stackoverflow.com/questions/209779/how-can-you-change-network-settings-ip-address-dns-wins-host-name-with-code
// author : balexandre
// a few modification have been made to extend the abilities of the class

namespace QuickIp
{
    public static class NetworkManagement
    {
        private static ManagementObjectCollection getOC()
        {

            ManagementObjectSearcher objMC = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
            //ManagementObjectSearcher objMC = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration ");
            return objMC.Get();
        }

        private static ManagementObjectCollection getOC(string NIC)
        {
            ManagementObjectSearcher objMC = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE' AND MACAddress='" + NIC + "'");
            return objMC.Get();
        }

        public static Dictionary<string, string> getNetworkcardDescriptionAndMacAddresses()
        {
            var nicInfo = new Dictionary<string, string>();
            var objMOC = getOC();
            foreach (ManagementObject mo in objMOC)
            {
                
                nicInfo.Add(mo["MACAddress"].ToString(), mo["Description"].ToString());
            }
            return nicInfo;
        }

        public static Dictionary<string, string> getNetworkInfoBasedOnNIC(string NIC)
        {
            var objMOC = getOC(NIC);
            var tmpDict = new Dictionary<string, string>();
            //index 0 is ipv4, 1 is ipv6
            foreach (ManagementObject objMO in objMOC)
            {
                //this is probably considered a sin in some circles but it gets it done.
                //cast the return object to a string array, if its a null returns a new array with one blank element, concert that array into a comma separated list
                var ip = String.Join(", ", (((string[])objMO["IPAddress"] ?? new string[] { "" })));
                var subnet = String.Join(", ", (((string[])objMO["IPSubnet"] ?? new string[] { "" })));
                var dns = String.Join(", ", (((string[])objMO["DNSServerSearchOrder"] ?? new string[] { "" })));
                var gateway = String.Join(", ", (((string[])objMO["DefaultIPGateway"] ?? new string[] { "" })));

                tmpDict.Add("IPAddress", ip);
                tmpDict.Add("IPSubnet", subnet);
                tmpDict.Add("DNSServerSearchOrder", dns);
                tmpDict.Add("DefaultIPGateway", gateway);
                tmpDict.Add("MACAddress", objMO["MACAddress"].ToString());
            }
            return tmpDict;
        }

        public static void enableDHCP(string NIC)
        {
            var objMOC = getOC();
            foreach (ManagementObject objMO in objMOC)
            {
                if (!(bool)objMO["DHCPEnabled"])
                {
                    if (objMO["MACAddress"].Equals(NIC))
                    {
                        try
                        {
                            ManagementBaseObject EnableDHCPParams = objMO.GetMethodParameters("EnableDHCP");
                            var returnCodeObj = objMO.InvokeMethod("EnableDHCP", EnableDHCPParams, null);
                            //var tmp = Convert.ToInt32(returnCodeObj.Properties["ReturnValue"].Value); //return value that handles the response code of the action.

                            ManagementBaseObject newDNS = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                            newDNS["DNSServerSearchOrder"] = null;
                            ManagementBaseObject setDNS = objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Set's a new IP Address and it's Submask of the local machine
        /// </summary>
        /// <param name="ip_address">The IP Address</param>
        /// <param name="subnet_mask">The Submask IP Address</param>
        /// <remarks>Requires a reference to the System.Management namespace</remarks>
        public static void setIP(string NIC, string ip_address, string subnet_mask)
        {
            var objMOC = getOC();

            foreach (ManagementObject objMO in objMOC)
            {
                if (objMO["MACAddress"].Equals(NIC))
                {
                    try
                    {
                        ManagementBaseObject setIP;
                        ManagementBaseObject newIP = objMO.GetMethodParameters("EnableStatic");

                        newIP["IPAddress"] = new string[] { ip_address };
                        newIP["SubnetMask"] = new string[] { subnet_mask };

                        setIP = objMO.InvokeMethod("EnableStatic", newIP, null);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Set's a new Gateway address of the local machine
        /// </summary>
        /// <param name="gateway">The Gateway IP Address</param>
        /// <remarks>Requires a reference to the System.Management namespace</remarks>
        public static void setGateway(string NIC, string gateway)
        {
            var objMOC = getOC();

            foreach (ManagementObject objMO in objMOC)
            {
                if (objMO["MACAddress"].Equals(NIC))
                {
                    try
                    {
                        ManagementBaseObject setGateway;
                        ManagementBaseObject newGateway = objMO.GetMethodParameters("SetGateways");

                        newGateway["DefaultIPGateway"] = new string[] { gateway };
                        newGateway["GatewayCostMetric"] = new int[] { 1 };

                        setGateway = objMO.InvokeMethod("SetGateways", newGateway, null);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Set's the DNS Server of the local machine
        /// </summary>
        /// <param name="NIC">NIC address</param>
        /// <param name="DNS">DNS server address</param>
        /// <remarks>Requires a reference to the System.Management namespace</remarks>
        public static void setDNS(string NIC, string DNS)
        {
            var objMOC = getOC();
            foreach (ManagementObject objMO in objMOC)
            {
                if (objMO["MACAddress"].Equals(NIC))
                {
                    try
                    {
                        ManagementBaseObject newDNS = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        newDNS["DNSServerSearchOrder"] = DNS.Split(',');
                        ManagementBaseObject setDNS = objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Set's WINS of the local machine
        /// </summary>
        /// <param name="NIC">NIC Address</param>
        /// <param name="priWINS">Primary WINS server address</param>
        /// <param name="secWINS">Secondary WINS server address</param>
        /// <remarks>Requires a reference to the System.Management namespace</remarks>
        public static void setWINS(string NIC, string priWINS, string secWINS)
        {
            var objMOC = getOC();

            foreach (ManagementObject objMO in objMOC)
            {
                if (objMO["MACAddress"].Equals(NIC))
                {
                    try
                    {
                        ManagementBaseObject setWINS;
                        ManagementBaseObject wins = objMO.GetMethodParameters("SetWINSServer");
                        wins.SetPropertyValue("WINSPrimaryServer", priWINS);
                        wins.SetPropertyValue("WINSSecondaryServer", secWINS);

                        setWINS = objMO.InvokeMethod("SetWINSServer", wins, null);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
    }
}