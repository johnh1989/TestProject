using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    static class Program
    {

        public static MyApi myApi;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            myApi = RestService.For<MyApi>("http://echo.jsontest.com");

            Application.Run(new Form1());
        }
    }
}
