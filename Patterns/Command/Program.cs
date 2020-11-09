using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            WebBrowser webBrowser = new WebBrowser(new WebEngine(), new WebFavoriteStorage());
            int selecton;
            while (true)
            {
                Console.WriteLine("1 - Go to url");
                Console.WriteLine("2 - Add to favorite");
                selecton = int.Parse(Console.ReadLine());
                switch (selecton)
                {
                    case 1:
                        webBrowser.LoadPage();
                        break;
                    case 2:
                        webBrowser.AddPageToFavorite();
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }

    // UI
    class WebBrowser
    {
        private readonly WebEngine webEngine;
        private readonly WebFavoriteStorage webFavoriteStorage;

        public WebBrowser(WebEngine webEngine, WebFavoriteStorage webFavoriteStorage)
        {
            this.webEngine = webEngine;
            this.webFavoriteStorage = webFavoriteStorage;
        }

        public void LoadPage()
        {
            var command = new LoadPageCommand(webEngine);
            command.Execute();
        }
        public void AddPageToFavorite()
        {
            var command = new AddToFavoriteCommand(webFavoriteStorage);
            command.Execute();
        }
    }

    interface ICommand
    {
        void Execute();
    }

    class LoadPageCommand : ICommand
    {
        private readonly WebEngine reciever;
        private string url;

        public LoadPageCommand(WebEngine engine)
        {
            this.reciever = engine;
        }
        public void Execute()
        {
            Console.Write("Enter URL: ");
            url = Console.ReadLine();
            Console.WriteLine(reciever.LoadPage(url));            
        }
    }

    class AddToFavoriteCommand : ICommand
    {
        private readonly WebFavoriteStorage reciever;
        private string url;
        private string title;
        public AddToFavoriteCommand(WebFavoriteStorage storage)
        {
            reciever = storage;
        }
        public void Execute()
        {
            Console.Write("Enter URL: ");
            url = Console.ReadLine();
            Console.Write("Enter Title: ");
            title = Console.ReadLine();
            reciever.AddToFavorite(new Favorite() { Url = url, Title = title });
        }
    }

    // Business logic
    class WebEngine
    {
        public string LoadPage(string url)
        {
            WebClient web = new WebClient();
            var html = web.DownloadString(url);
            return html;
        }
    }

    class WebFavoriteStorage
    {
        private readonly List<Favorite> favorites = new List<Favorite>();
        public void AddToFavorite(Favorite favorite)
        {
            favorites.Add(favorite);
        }
        public void RemoveFromFavorite(Favorite favorite)
        {
            favorites.Remove(favorite);
        }
    }
}
