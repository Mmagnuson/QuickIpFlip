using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickIp.Profiles
{
    public class Gateway
    {
        public string DefaultIPGateway;
        public int GatewayCostMetric;

        public Gateway ()
        {
            GatewayCostMetric = 1;
        }

    }
}
