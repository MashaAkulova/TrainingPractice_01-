using System;

namespace AMA_Task_03
{
    class Program
    {
        
public static int t = 3; // Кол-во попыток взято 3, для удобствa
        static void Main(string[] args)
        { 
          
           string MASHA666 = "MASHA666"; // Пароль
           
            
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите пароль: ");
                string password = Console.ReadLine();
                if (password == MASHA666)
                {

                    goto Finish_good;

                }

                else if (t == 0)
                {
                    goto Finish_bad;
                }
                else
                {

                    Console.WriteLine($"Пароль неверен, кол-во попыток: {t}");
                    t--;
                }



            }
        
        Finish_good:
            Console.WriteLine();
            Console.WriteLine("Пароль верен, Здраствуйте господин мы вас ждали  \n");
            Console.ReadKey();
            Environment.Exit(0);

        Finish_bad:
            Console.WriteLine();
            Console.WriteLine("Вы привысили количесвто попыток  \n");
            Console.ReadKey();
            Environment.Exit(0);



        }
    }
}
