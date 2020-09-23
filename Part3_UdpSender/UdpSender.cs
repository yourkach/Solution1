using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Part3_UdpSender
{
    class UdpSender
    {
        static void Main(string[] args)
        {
            var host = "127.0.0.1";
            var port = 8080;

            var clientSender = new UdpClient(host, port);

            Console.WriteLine("UDP client sender started, port: " + port);

            IPEndPoint endPoint = null;

            Console.WriteLine("Enter data to send:");
            
            var dataToSend = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(dataToSend);

            clientSender.Send(data, data.Length, endPoint);
            
            Console.WriteLine("Data has been sent");
            clientSender.Close();
        }
    }
}