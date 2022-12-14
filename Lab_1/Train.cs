using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Train
    {
        private string type { get; set; }
        private int number { get; set; }
        private int speed { get; set; }
        private int quantity_w { get; set; }
        private string final_s { get; set; }
        private string starting_s { get; set; }
        private int distance { get; set; }
        private int speed_change { get; set; }
        //
        public Train(string type,
            int number,
            int speed,
            int quantity_w,
            string final_s,
            string starting_s,
            int distance,
            int speed_chang)
        {
            this.type = type;
            this.number = number;
            this.speed = speed;
            this.quantity_w = quantity_w;
            this.final_s = final_s;
            this.starting_s = starting_s;
            this.distance = distance;
            this.speed_change = speed_change;
        }

        public void Print()
        {
            Console.WriteLine($"type: {type}");
            Console.WriteLine($"number: {number}");
            Console.WriteLine($"speed: {speed} км/год");
            Console.WriteLine($"quantity_w: {quantity_w}");
            Console.WriteLine($"final_s: {final_s}");
            Console.WriteLine($"starting_s: {starting_s}");
            Console.WriteLine($"distance: {distance}");
            Console.WriteLine($"speed_change: {speed_change} км/год");
        }
    }
}