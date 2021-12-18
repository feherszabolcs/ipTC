using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
            string UserIpInString = "";
            //Return the user's public ip
            try
            {
                UserIpInString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("A funkció nem érhető el!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (UserIpInString != "")
            {
                var UserIP = IPAddress.Parse(UserIpInString);
                usedIPs.Add(UserIP);
                return UserIP;
            }
            else return null;


        }
        public string CalculateMaxHost(string ip, string mask) //-> maszkhoz tartozó max hostok
        {
            NetworkOptimizer nw = new NetworkOptimizer();
            IPTranslate it = new IPTranslate();

            string[] m = ip.Split('.');
            string ipInBin = it.OctettToBin(m[0]) + it.OctettToBin(m[1]) + it.OctettToBin(m[2]) + it.OctettToBin(m[3]);

            int host = int.Parse(mask);
            double net = 32 - host;

            if (net < 2) MessageBox.Show("A legnagyobb maszk maximum 30 bites lehet!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);

            double maxhosts = Math.Pow(2, net) - 2;

           
            return maxhosts.ToString();
        }
        public Brush FromHex(string hex) //Szín beállítására
        {
            var c = new BrushConverter();
            return (Brush)c.ConvertFromString(hex);
        }

    }
}
