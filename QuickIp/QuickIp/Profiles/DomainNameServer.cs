namespace QuickIp.Profiles
{
    public class DomainNameServer
    {
        public string DomainServerIP;

        public DomainNameServer()
        {

        }

        public DomainNameServer ( string dns )
        {
            DomainServerIP = dns;
        }

    }
}