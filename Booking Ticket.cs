using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    class Program
    {
        class Movies
        {
            public int number { get; set; }
            public string title { get; set; }
            public double duration { get; set; }
            public double price { get; set; }  

            public Movies(string title, double duration, double price, int number)
            {
                this.title = title;
                this.duration = duration;
                this.price = price;
                this.number = number;
            }
            public virtual void GetInfo()
            {
                Console.WriteLine($"Title: {title}, Duration: {duration} mins, Price: ${price}DH");
            }
        }

        class Ticket : Movies
        {
            public int seatNumber { get; set; }
            public DateTime showTime { get; set; }

            public Ticket(int seatNumber, DateTime showTime, string title, double duration, double price,int number) : base (title, duration, price,number)
            {
                this.seatNumber = seatNumber;
                this.showTime = showTime;
            }
            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Seat Number: {seatNumber}, Show Time: {showTime}");
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "🎟️ Cinema Ticket Booking System";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================================");
            Console.WriteLine("        🎬 Welcome to ELY Cinema Booking");
            Console.WriteLine("==============================================");
            Console.ResetColor();

            // Movies list
            List<Movies> movies = new List<Movies>
    {
        new Movies("Inception", 190, 100,1),
        new Movies("The Matrix", 60, 150,2),
        new Movies("Interstellar", 120, 120,3)
    };

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n🍿 Available Movies:\n");
            Console.ResetColor();

            foreach (var movie in movies)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"[{movie.number}] ");
                Console.ResetColor();
                Console.WriteLine($"🎞️ {movie.title} | ⏱️ {movie.duration} mins | 💰 {movie.price} DH");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n👉 Select a movie by number:");
            Console.ResetColor();

            int choice = int.Parse(Console.ReadLine());
            Movies selectedMovies = movies.FirstOrDefault(m => m.number == choice);

            if (selectedMovies != null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n🎥 You selected: {selectedMovies.title}");
                Console.ResetColor();

                Console.WriteLine("\n💺 Enter your seat number:");
                int seatNumber = Convert.ToInt32(Console.ReadLine());

                List<DateTime> time = new List<DateTime>
        {
            new DateTime(2025, 10, 5, 14, 30, 0),
            new DateTime(2025, 10, 5, 17, 0, 0),
            new DateTime(2025, 10, 5, 20, 15, 0)
        };

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n🕒 Available Showtimes:");
                Console.ResetColor();

                int i = 1;
                foreach (var item in time)
                {
                    Console.WriteLine($"   [{i}] 🎞️ {item:HH:mm}");
                    i++;
                }

                Console.WriteLine("\n⏰ Please choose the showtime number:");
                int timeChoice = int.Parse(Console.ReadLine());
                DateTime dateTime = time[timeChoice - 1];

                // Ticket creation
                Ticket ticket = new Ticket(
                    seatNumber,
                    dateTime,
                    selectedMovies.title,
                    selectedMovies.duration,
                    selectedMovies.price,
                    selectedMovies.number
                );

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✅ Booking Confirmed!");
                Console.ResetColor();
                Console.WriteLine("--------------------------------------------------");
                ticket.GetInfo();
                Console.WriteLine("--------------------------------------------------");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n🎉 Thank you for booking with ELY Cinema!");
                Console.WriteLine("Enjoy your movie! 🍿");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Invalid movie selection. Exiting...");
                Console.ResetColor();
                Environment.Exit(0);
            }
        }


    }
}
