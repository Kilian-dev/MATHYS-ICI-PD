using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace reseau
{
    class Program
    {
        static void Main(string[] args)
        {
            
              UdpClient Le_Client = new UdpClient(); // creation tuyau
            string adresse_le_serveur = "10.5.102.157"; // unicast 1 seul / broadcast tout le monde
                                                        //masque  255.255.240
                                                        // broadcast 10.5.111.255

            IPEndPoint adresse_process_distant = new IPEndPoint(IPAddress.Parse(adresse_le_serveur),999); // specifie le point distant

            byte[] data = Encoding.ASCII.GetBytes("kln");

           for(int i = 0;i<5;i++)
            {
                Le_Client.Send(data, data.Length, adresse_process_distant);
            }
        }
    }
}
