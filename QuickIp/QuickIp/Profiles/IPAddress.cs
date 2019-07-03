namespace QuickIp.Profiles
{
    public class IPAddress
    {
        public string IpAddress;
        public string SubnetMask;

        //   ValidIpAddressRegex = "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";

        public IPAddress()
        {
        }

        public IPAddress(string ipAddress, string subnetMask)
        {
            IpAddress = ipAddress;
            SubnetMask = subnetMask;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                IPAddress p = (IPAddress)obj;
                return (IpAddress == p.IpAddress) && (SubnetMask == p.SubnetMask);
            }
        }
    }
}