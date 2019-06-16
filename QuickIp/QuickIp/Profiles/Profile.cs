using System.Collections.Generic;

namespace QuickIp.Profiles
{
    public class Profile
    {
        public bool DHCP;
        public string MAC;
        public string Description;

        public List<DomainNameServer> DNS;
        public List<Gateway> DefaultGateway;
        public List<IPAddress> IP;

        public Profile()
        {
            DNS = new List<DomainNameServer>();
            DefaultGateway = new List<Gateway>();
            IP = new List<IPAddress>();
        }
    }
}