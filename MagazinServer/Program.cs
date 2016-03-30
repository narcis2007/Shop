using MagazinCommon.service;
using MagazinServer.net;
using MagazinServer.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServer tcpServer = new TcpServer();
            Service service = new ServiceImpl();
            tcpServer.Service = service;
            tcpServer.Start();
        }
    }
}
