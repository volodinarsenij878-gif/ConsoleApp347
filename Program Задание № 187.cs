using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program187
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Климатическая зона (1–5): ");
            if (!int.TryParse(Console.ReadLine(), out int zone) || zone < 1 || zone > 5)
            {
                Console.WriteLine("Ошибка.");
                return;
            }

            string desc;
            switch (zone)
            {
                case 1: desc = "Арктическая: очень холодно, вечная мерзлота, короткое лето."; break;
                case 2: desc = "Субарктическая: холодные зимы, прохладное лето, высокая влажность."; break;
                case 3: desc = "Умеренная: чёткая смена сезонов, умеренные температуры."; break;
                case 4: desc = "Субтропическая: тёплое лето, мягкая зима, много осадков."; break;
                case 5: desc = "Тропическая: жарко круглый год, высокая влажность, дожди."; break;
                default: return;
            }
            Console.WriteLine(desc);
        }
    }
}
