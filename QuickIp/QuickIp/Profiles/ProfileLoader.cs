﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuickIp.Profiles
{
    public class ProfileLoader
    {
        public Profile Load()
        {
            //  var appPath = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);

            // JsonConvert.DeserializeObject<List<CoordinatePolygon>>(fileData)

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var separator = Path.DirectorySeparatorChar;
            var fileData = File.ReadAllText(docPath + separator + "IpSettings" + separator + "WriteLines.txt");

            var p = JsonConvert.DeserializeObject<Profile>(fileData);

            return p;
        }

        public bool Save(Profile p)
        {
            var s = JsonConvert.SerializeObject(p, Formatting.Indented);

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var separator = Path.DirectorySeparatorChar;

            using (StreamWriter outputFile = new StreamWriter(docPath + separator + "IpSettings" + separator + "WriteLines.txt"))
            {
                outputFile.Write(s);
            }

            return false;
        }

        public void Apply(Profile p)
        {
            Dictionary<string, string> nics = NetworkManagement.getNetworkcardDescriptionAndMacAddresses();

            if (nics.TryGetValue(p.MAC, out string n))
            {
                if (p.DHCP)
                {
                    NetworkManagement.enableDHCP(p.MAC);
                    if (p.DNS.Count > 0)
                    {
                        foreach (var dns in p.DNS)
                        {
                            NetworkManagement.setDNS(p.MAC, dns.DomainServerIP);
                        }
                    }
                }
                else
                {
                }
            }
            else
            {
                int yy = 0;
            }
        }
    }
}