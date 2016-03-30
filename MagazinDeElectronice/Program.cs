using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagazinDeElectronice.ui;
using MagazinDeElectronice.repository;
using MagazinDeElectronice.controller;
using MagazinDeElectronice.net;
using MagazinDeElectronice.service;

namespace MagazinDeElectronice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Repository repository = new Repository();
            //ProductController controller = new ProductController(repository);
            ServiceProxy service = new ServiceProxy();
            TcpClient tcpClient = new TcpClient();
            service.TcpClient = tcpClient;
            Application.Run(new Main(service));
        }
    }
}
