using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Passenger_train : Train
    {
        public int occupied_seats { get; set; }
        public int vacant_seats { get; set; }

        public Passenger_train(string type,
            int number,
            int speed,
            int quantity_w,
            string final_s,
            string starting_s,
            int distance,
            int speed_change,
            int occupied_seats,
            int vacant_seats) : base(type, number, speed, quantity_w, final_s,
                starting_s, distance, speed_change)
        {
            this.occupied_seats = occupied_seats;
            this.vacant_seats = vacant_seats;
        }
        public void Print_Passenger_train()
        {
            Print();
            Console.WriteLine($"occupied_seats: {occupied_seats}");
            Console.WriteLine($"vacant_seats: {vacant_seats}");
        }
    }
}

