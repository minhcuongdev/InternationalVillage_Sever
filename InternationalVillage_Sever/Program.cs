﻿using System;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;


namespace InternationalVillage_Sever
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://localhost:8087/";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine($"Server running at {url}");
                Console.ReadLine();
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR("/signalchat", new HubConfiguration());

            GlobalHost.Configuration.MaxIncomingWebSocketMessageSize = null;
        }
    }
}
