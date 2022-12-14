using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Freight_train : Train
    {
        public string type_of_cargo { get; set; }

        public Freight_train(string type,
            int number,
            int speed,
            int quantity_w,
            string final_s,
            string starting_s,
            int distance,
            int speed_change,
            string type_of_cargo) : base(type, number, speed, quantity_w, final_s,
                starting_s, distance, speed_change)
        {
            this.type_of_cargo = type_of_cargo;
        }
        public void Print_Freight_train()
        {
            Print();
            Console.WriteLine($"type_of_cargo: {type_of_cargo}");
        }
    }
}