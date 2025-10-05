using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSyte
{
    public class Movies
    {
        public int number { get; set; }
        public string title { get; set; }
        public DateTime showtime { get; set; }
        public double price { get; set; }

        public Movies(int number, string title, DateTime showtime, double price)
        {
            this.number = number;
            this.title = title;
            this.showtime = showtime;
            this.price = price;
        }
        public virtual string DisplayInfo()
        {

            string info = "";
            info += "╔════════════════════════════╗\n";
            info += $"║ Movie Number : {number,-2}           ║\n";
            info += $"║ Title        : {title,-15} ║\n";
            info += $"║ Showtime     : {showtime:dd/MM/yyyy HH:mm} ║\n";
            info += $"║ Price        : {price,5} DH       ║\n";
            info += "╚════════════════════════════╝\n";
            return info;
        }

        public override string ToString()
        {
            return $"{number} - {title} - {showtime:dd/MM/yyyy HH:mm} - {price}DH";
        }


    }
    public class Ticket : Movies
    {
        public string Seat { get; set; }
        public Ticket(int number, string title, DateTime showtime, double price, string seat) : base(number, title, showtime, price)
        {
            this.Seat = seat;
        }
        public override string DisplayInfo()
        {

            // Unicode icons
            string movieIcon = "🎬";   // Movie
            string clockIcon = "⏰";   // Showtime
            string priceIcon = "💰";   // Price
            string seatIcon = "💺";   // Seat

            string info = "";
            info += "╔════════════════════════════════╗\n";
            info += $"║ {movieIcon}  Movie Number : {number,-2}             ║\n";
            info += $"║ {movieIcon}  Title        : {title,-20} ║\n";
            info += $"║ {clockIcon}  Showtime     : {showtime:dd/MM/yyyy HH:mm} ║\n";
            info += $"║ {priceIcon}  Price        : {price,5} DH       ║\n";
            info += $"║ {seatIcon}  Seat         : {Seat,-5}       ║\n";
            info += "╚════════════════════════════════╝\n";

            return info;
        }
    }
}
