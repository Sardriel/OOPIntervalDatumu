using System;

namespace OOPIntervalDatumu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pro zadaný interval datumů vypíše všechny pátky 13.:");
            Console.WriteLine("Zadejte 1. datum:");
            DateTime datumJedna = DateTime.Parse(Console.ReadLine());
            int rokJedna = datumJedna.Year;
            Console.WriteLine("Zadejte 2. datum:");
            DateTime datumDva = DateTime.Parse(Console.ReadLine());
            int rokDva = datumDva.Year;
            Console.Write("Pátky 13.: ");
            for (int rok = rokJedna; rok <= rokDva; rok++)
            {
                for (int mesic = 1; mesic <= 12; mesic++)
                {
                    DateTime datumPomocna = new DateTime(rok, mesic, 13);

                    if (datumPomocna < datumJedna)
                    {
                        continue;
                    }
                    if (datumPomocna>datumDva)
                    {
                        break;
                    }
                    if (datumPomocna.DayOfWeek == DayOfWeek.Friday)
                    {
                        Console.Write("{0}, ",datumPomocna.ToShortDateString());
                    }

                }

            }
            

            
            

            
        }
    }
}
