namespace QuickIp.Profiles
{
    public class Gateway
    {
        public string DefaultIPGateway;
        public int GatewayCostMetric;

        public Gateway()
        {
            GatewayCostMetric = 1;
        }

        public Gateway(string defaultGateway)
        {
            GatewayCostMetric = 1;
            DefaultIPGateway = defaultGateway;
        }

        public Gateway(string defaultGateway, int gatewayCostMetric)
        {
            GatewayCostMetric = gatewayCostMetric;
            DefaultIPGateway = defaultGateway;
        }

    }
}