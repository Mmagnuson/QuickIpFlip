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

        public override bool Equals(System.Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Gateway p = (Gateway)obj;
                return (DefaultIPGateway == p.DefaultIPGateway) && (GatewayCostMetric == p.GatewayCostMetric) ;
            }
        }

    }
}