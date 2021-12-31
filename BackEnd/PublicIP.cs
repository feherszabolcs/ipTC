using IP_TranslatorCalculator.Pages;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Media;

namespace IP_TranslatorCalculator.BackEnd
{
    class PublicIP
    {
        public IPAddress StoreIP()
        {
            string UserIpInString = "";
            //Publikus ip megszerzése
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
                return IPAddress.Parse(UserIpInString);
            }
            else return null;


        }
        public string CalculateMaxHost(string ip, string mask) //-> maszkhoz tartozó max hostok
        {
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
