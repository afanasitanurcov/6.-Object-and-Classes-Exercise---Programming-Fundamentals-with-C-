using System;
using System.Collections.Generic;

namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phrases = new[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };

            var events = new[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            var authors = new[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            var cities = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                
                var phrase = phrases[random.Next(phrases.Length)];
                var @event = events[random.Next(events.Length)];
                var author = authors[random.Next(authors.Length)];
                var city = cities[random.Next(cities.Length)];
                Console.WriteLine($"{phrase} {@event} {author} – {city}.");
            }
        }
    }
    
}
