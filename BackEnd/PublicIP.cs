using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Media;
using IP_TranslatorCalculator.Pages;

namespace IP_TranslatorCalculator.BackEnd
{
    class PublicIP
    {
        public static readonly IPAddress _ClassA = IPAddress.Parse("255.0.0.0");
        public static readonly IPAddress _ClassB = IPAddress.Parse("255.255.0.0");
        public static readonly IPAddress _ClassC = IPAddress.Parse("255.255.255.0");
        public List<IPAddress> usedIPs = new List<IPAddress>();
        public IPAddress StoreIP()
        {
            //Return the user's public ip
            string UserIpInString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
            var UserIP = IPAddress.Parse(UserIpInString);
            usedIPs.Add(UserIP);

            return UserIP;
        }
        public string CalculateMaxHost(string ip, string mask)
        {
            NetworkOptimizer nw = new NetworkOptimizer();
            IPTranslate it = new IPTranslate();

            string[] m = ip.Split('.'); //IP binárisba
            string ipInBin = it.OctettToBin(m[0]) + it.OctettToBin(m[1]) + it.OctettToBin(m[2]) + it.OctettToBin(m[3]);

            int host = int.Parse(mask);
            double net = 32 - host;

            if (net < 2) throw new ArgumentException("Túl sok eszköz!");

            double maxhosts = Math.Pow(2, net) - 2;

           
            return maxhosts.ToString();
        }
        public Brush FromHex(string hex)
        {
            var c = new System.Windows.Media.BrushConverter();
            return (Brush)c.ConvertFromString(hex);
        }


    }
}
