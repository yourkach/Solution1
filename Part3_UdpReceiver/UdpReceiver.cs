using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Part3_UdpReceiver
{
    class UdpReceiver
    {
        static void Main(string[] args)
        {
            var port = 8080;

            var clientReceiver = new UdpClient(port);

            Console.WriteLine("UDP server receiver started, port: " + port);
            Console.WriteLine("Waiting for data..");
            
            IPEndPoint endPoint = null;

            byte[] data = clientReceiver.Receive(ref endPoint);
            var stringData = Encoding.ASCII.GetString(data);

            Console.WriteLine("Received data:\n" + stringData);
            clientReceiver.Close();
        }
    }
}