namespace QuickIp.Profiles
{
    public class DomainNameServer
    {
        public string DomainServerIP;

        public DomainNameServer()
        {
        }

        public DomainNameServer(string dns)
        {
            DomainServerIP = dns;
        }

        public override bool Equals(System.Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                DomainNameServer p = (DomainNameServer)obj;
                return (DomainServerIP == p.DomainServerIP);
            }
        }
    }
}