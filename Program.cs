using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeAndRonSwanson
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($"Kanye: {quote.KanyeQuote()}");
                Console.WriteLine();
                Console.WriteLine($"Ron Swanson: {quote.RonQuote()}");
            }
        }
    }
}
