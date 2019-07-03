using System.Collections.Generic;
using System.Linq;

namespace QuickIp.Profiles
{
    public class Profile
    {
        public bool DHCP;
        public string MAC;
        public string Description;
        public string Path;

        public List<DomainNameServer> DNS;
        public List<Gateway> DefaultGateway;
        public List<IPAddress> IP;


        public Profile()
        {
            DHCP = false;
            DNS = new List<DomainNameServer>();
            DefaultGateway = new List<Gateway>();
            IP = new List<IPAddress>();
        }


        public override string ToString()
        {
            return Description;
        }


        public override bool Equals(System.Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {

               
                Profile p = (Profile)obj;
                return ( Description == p.Description) && (DHCP == p.DHCP) && (MAC == p.MAC) && DNS.SequenceEqual(p.DNS) && DefaultGateway.SequenceEqual(p.DefaultGateway) &&  IP.SequenceEqual(p.IP);
            }
        }
    }
}