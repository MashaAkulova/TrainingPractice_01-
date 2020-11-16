using System;
namespace AMA_Task_01
{

    class Program
    {

        public const int Dimonds_cost = 55;   //Стоимость 1 кристалла
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму ваших средств: ");
            int Gold = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Сколько кристаллов вам необходимо обменять в банке? 1 кристалл = {Dimonds_cost} золота");
            int Dimonds = Convert.ToInt32(Console.ReadLine());
            try                            
            {
                int calculation = Gold - Dimonds * Dimonds_cost;
                int[] arr = new int[Gold + 1];
                arr[calculation] = 1;
                Console.WriteLine($"Операция проведена успешна. У вас {calculation} золота и {Dimonds} кристаллов.");

                Console.ReadKey();
            }
            catch (Exception e)            // для ошибок
            {
                Console.WriteLine($"У вас недостаточно средств, пополните счет и возвращайтесь. \n{Gold} золота и 0 кристалл(ов).");

                int fail = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
            };
        }
    }


}


