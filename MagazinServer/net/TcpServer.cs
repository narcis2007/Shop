using MagazinCommon.net;
using MagazinCommon.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MagazinServer.net
{
    class TcpServer
    {
        private readonly IPEndPoint endPoint;

        public TcpServer()
        {
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            endPoint = new IPEndPoint(ipAddress, 11000);
        }

        internal void Start()
        {
            try
            {
                Socket socketListner = new Socket(SocketType.Stream, ProtocolType.Tcp);
                socketListner.Bind(endPoint);
                socketListner.Listen(10);
                Console.WriteLine("Server listens");
                while (true)
                {
                    Console.WriteLine("Waiting for connections");
                    Socket clientSocket = socketListner.Accept();
                    Console.WriteLine("Connection accepted");
                    Task.Factory.StartNew(new ClientHandler(clientSocket, Service).Handle);
                }
            }
            catch (SocketException se)
            {
                Console.WriteLine("Socket exception");
                throw se;
            }
        }

        public Service Service { get; internal set; }

        private class ClientHandler
        {
            private Socket clientSocket;
            private Service helloService;

            public ClientHandler(Socket clientSocket, Service helloService)
            {
                this.clientSocket = clientSocket;
                this.helloService = helloService;
            }

            internal void Handle()
            {
                try
                {
                    Console.WriteLine("Handle client request");
                    byte[] bytes = new byte[1024];
                    int bytesRec = clientSocket.Receive(bytes);
                    Console.WriteLine("Request received");
                    Message request = new Message(Encoding.ASCII.GetString(bytes, 0, bytesRec));
                    string result = helloService.SayHello(request.ToString());
                    byte[] bytesRequest = Encoding.ASCII.GetBytes(result);
                    clientSocket.Send(bytesRequest);
                    Console.WriteLine("Response sent");
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
                catch (SocketException se)
                {
                    Console.WriteLine("Handle client socket exception");
                    //throw se;
                }
            }
        }
    }

}
