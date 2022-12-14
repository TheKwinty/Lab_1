using System;
using Lab_1;

namespace ConsolePrintEditionAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================");
            Freight_train freight_train = new Freight_train("Вантажний", 54345, 54, 48, "-", "-", 94, 23,  "Хімічнонебезпечні речовини");
            freight_train.Print_Freight_train();
            Console.WriteLine("================================================");
            Passenger_train passenger_train = new Print_Passenger_train("Пасажирський", 84646, 74, 18, "-", "-", 85, 14, 117, 89);
            passenger_train.Print();

        }
    }
}