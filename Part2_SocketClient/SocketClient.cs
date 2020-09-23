using System;
using System.Net;
using System.Net.Sockets;

namespace Part2_SocketClient
{
    class SocketClient
    {
        static void Main(string[] args)
        {
            var host = "127.0.0.1";
            Int32 port = -1;

            Console.WriteLine("Enter port:");
            Int32.TryParse(Console.ReadLine(), out port);
            
            try
            {
                var client = new TcpClient(host, port);
                var stream = client.GetStream();
                Console.WriteLine("Connection successful");
                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection error");
                Console.WriteLine(e);
            }
        }
    }
}