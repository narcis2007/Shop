using MagazinCommon.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeElectronice.net
{
    public class TcpClient
    {
        private readonly EndPoint endPoint;

        internal TcpClient()
        {
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            endPoint = new IPEndPoint(ipAddress, 11000);
        }
        internal Message Execute(Message request)
        {
            try
            {
                Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(endPoint);
                Console.WriteLine("Socket connected");
                byte[] bytesRequest = Encoding.ASCII.GetBytes(request.ToString());
                socket.Send(bytesRequest);
                Console.WriteLine("Request sent");
                byte[] bytes = new byte[1024];
                int bytesRec = socket.Receive(bytes);
                Console.WriteLine("Response received");
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                return new Message(Encoding.ASCII.GetString(bytes, 0, bytesRec));
            }
            catch (SocketException se)
            {
                Console.WriteLine("Socket exception");
                throw se;
            }
        }
    }
}
