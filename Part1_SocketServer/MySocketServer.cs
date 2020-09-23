using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Part1_SocketServer
{
    class MySocketServer
    {
        static void Main(string[] args)
        {
            var localAddr = IPAddress.Parse("127.0.0.1");
            var localPort = 8080;

            var listener = new TcpListener(localaddr: localAddr, port: localPort);

            listener.Start();
            Console.WriteLine("TCP Socket server started, port: " + localPort);

            var socket = listener.AcceptSocket();
            var networkStream = new NetworkStream(socket);

            var networkStreamWriter = new StreamWriter(networkStream) {AutoFlush = true};

            networkStreamWriter.WriteLine("MyServerResponse: Connected to MySocketServer");
            
            Console.WriteLine("Received connection from client");

            networkStream.Close();
            socket.Close();

            listener.Stop();
        }
    }
}