using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Nettbutikk
{
    class Ad
    {
        public bool HasBoobs;
        public string Name;
        public string Content;
        public string Brand;

        public Ad(string brand, string name, string content, bool hasBoobs = false)
        {
            Brand = brand;
            HasBoobs = hasBoobs;
            Name = name;
            Content = content;
        }

        public void ShowAdForSeconds(int seconds)
        {
            var hasBoobsText = HasBoobs ? "This Ad also has boobs. Bask in the glory of boobs ( . Y . )" : "";
            var adText = $"And now a word from our sponsor: {Brand}\n{hasBoobsText}\n{Content}";

            Console.WriteLine(adText);
            Thread.Sleep(seconds * 1000);
            Console.Clear();
        }
    }
}
