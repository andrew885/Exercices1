using System;

namespace NailsHit
{
    class Program
    {
        static void Main(string[] args)
        {
            int nails;
            int hit;
            Console.Write("Enter nails number (from 1 to 10):");
            string input1 = Console.ReadLine();
            Console.Write("Enter hits amount for 1 nail (from 1 to 5):");
            string input2 = Console.ReadLine();

            //Проверка правильности введенных данных
            bool nails_result = int.TryParse(input1, out nails);
            if (nails_result == false)
            {
                Console.WriteLine("Wrong input");
                return;
            }                       

            bool hit_result = int.TryParse(input2, out hit);
            if (hit_result == false)
            {
                Console.WriteLine("Wrong input");
                return;
            }              

            if (1 > nails | nails > 10 | 1 > hit | hit > 5)
            {
                Console.WriteLine("Wrong input");
                return;
            }                          

            //Выполнение забития гвоздей в цикле
            int total = hit * nails;
            Console.WriteLine($"Total number of hits will be {hit*nails}");
            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine($"{i} hit was made"); //здесь может быть что-то , что эмитирует удар по гвоздю
                if (i % hit == 0)
                    Console.WriteLine("Nail is hammered");
            }
            Console.WriteLine($"All {nails} are hammered!!!");
        }
        
    }
}
