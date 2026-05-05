using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>()
            {
                "Sonic the Hedgehog",
                "The Legend of Zelda",
                "Minecraft",
                "Super Mario Bros",
                "Fortnite",
                "ProAm"
            };
            videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
            
        }
    }
}
