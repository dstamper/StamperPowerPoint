using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageRequest.Model;

namespace WinFormViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Starting");
            UnsplashImageClient client = new ImageRequest.Model.UnsplashImageClient();
            client.MakeRequest("car").Wait();
            Console.WriteLine("Finished");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
