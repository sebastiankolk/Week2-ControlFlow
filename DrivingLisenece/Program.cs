using System;

namespace DrivingLisenece
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana,
            //et juhiluba saada (tingimuseks 18 aastat vana)

            Console.WriteLine("Millal oled sa sündinud?");

            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int Age = 2021 - YearOfBirth;
            
           
            
            if (Age < 18)

            {
                Console.WriteLine("Oled liiga noor, et omada juhilube.");
            }

            else if (Age > 18)

            {
                Console.WriteLine("Oled piisavalt vana, et omada juhilube.");

            }

            else

            {
                Console.WriteLine("Oled piisavalt vana, et hakkada juhilube tegema.");
            }
            Console.WriteLine("Kena päeva!");


        }
    }
}
