using System;
using TestEntityFramework.Data.Entities;
using TestEntityFramework.Data.Repositories;

namespace TestEntityFramework
{
    internal class Business
    {

        private ISamuraiRepo _samuraiRepo;

        private IHorseRepo _horseRepo;

        private IQuoteRepo _quoteRepo;


        public Business()
        {
            _samuraiRepo = new SamuraiRepo();
            _horseRepo = new HorseRepo();
            _quoteRepo = new QuoteRepo();
        }


        internal void Run()
        {
            Console.Clear();
            Console.WriteLine("What would u like to add?\n 1. Samurai \n 2. Horse \n 3.Quote");
            switch (Console.ReadLine())
            {
                case "1":
                    AddSamurai();
                    break;
                case "2":
                    AddHorse();
                    break;
                case "3":
                    AddQuote();
                    break;
                default:
                    break;
            }

        }


        private void AddSamurai()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine(); 
            Console.WriteLine("Enter Dynasty:");
            _samuraiRepo.AddSamurai(name,Console.ReadLine());
            Run();
        }

        private void AddHorse()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Samurai ID:");
            Horse horse = _horseRepo.CreateHorse(name, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"What is the age of {name}?");
            horse.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"What gender has {name}?");
            horse.Gender = Convert.ToChar(Console.ReadLine());
            _horseRepo.AddHorse(horse);
            Run();
        }

        private void AddQuote()
        {
            Console.WriteLine("Enter quote:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter Samurai ID:");
            _quoteRepo.AddQuote(text, Convert.ToInt32(Console.ReadLine()));
            
            Run();
        }

        
    }
}