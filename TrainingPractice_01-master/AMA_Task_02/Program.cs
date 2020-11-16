using System;

namespace AMA_Task_02
{

    class Program
    {
        
        
        static void Main(string[] args)
        {
           string slovo = " "; // "Обнуляем" переменную

            do
            {

                slovo = Console.ReadLine();
               
            }  
            while (slovo != ("exit"));
        }
    }
}
