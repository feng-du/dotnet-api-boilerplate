using System;
using Microsoft.Owin.Hosting;



namespace MyProject.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Server listenning on: " + baseAddress);
                Console.ReadLine();
            }
        }
    }




}
