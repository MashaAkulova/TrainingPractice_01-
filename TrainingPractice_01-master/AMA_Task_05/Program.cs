using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            
            int[,] maze = new int[,]     //Паттерн лабиринта
            {
{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
{1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,2,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
{1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,0,0,0,1,0,1,1,1,1,0,1,1,1,2,1,1,1,1,1,1},
{1,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,1,1,0,1,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
{1,0,0,0,1,0,1,1,1,1,1,1,1,0,1,0,1,0,0,0,0,0,1,0,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1},
{1,0,1,0,1,0,1,0,0,0,0,0,1,0,1,0,1,0,1,0,1,1,1,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,1},
{1,0,1,0,1,0,1,1,0,1,1,1,1,0,1,0,1,0,1,0,0,0,0,0,1,0,0,1,0,1,1,1,1,1,1,1,1,0,1},
{1,0,1,0,1,0,1,1,0,1,1,1,1,0,1,0,1,1,1,1,1,1,1,1,1,0,0,1,0,1,0,0,0,0,0,0,1,0,1},
{1,0,1,0,1,0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,1,0,0,0,1,0,1},
{1,0,1,0,1,1,1,1,1,1,1,1,1,0,1,0,1,0,1,1,1,1,0,1,0,0,0,1,0,1,0,0,1,1,0,0,1,2,1},
{1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,1,0,0,1,0,1,0,1,1,1,0,1,1,0,0,1,0,0,1,0,1},
{1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,0,1,0,0,1,0,1,0,1,0,0,0,0,1,0,0,1,0,0,1,0,1},
{1,0,0,0,0,2,0,0,0,0,0,0,0,0,1,0,1,0,1,0,0,1,0,1,0,1,0,0,1,0,1,0,0,1,0,0,1,0,1},
{1,0,1,1,1,1,1,1,1,1,0,1,0,1,1,0,1,0,1,0,0,1,0,1,0,1,0,0,1,0,1,1,0,1,1,0,1,0,1},
{1,0,1,0,0,0,0,1,0,1,0,1,0,1,1,0,1,0,1,0,0,1,0,1,1,1,0,0,1,0,1,1,0,0,1,0,1,0,1},
{1,0,1,0,1,1,0,1,0,0,0,1,0,1,1,0,0,0,0,0,0,1,0,0,0,0,0,1,1,0,1,1,0,0,1,0,1,0,1},
{1,0,1,0,1,1,0,1,0,1,0,1,0,1,1,1,1,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,3},
{1,0,0,0,1,1,0,1,0,1,0,1,0,1,1,0,1,0,0,1,0,0,0,0,0,0,0,0,1,0,1,1,0,0,1,0,1,1,1},
{1,0,1,0,1,1,0,0,0,2,0,0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,1,0,1,0,1,1,0,0,1,0,0,0,1},
{1,0,1,0,1,1,0,1,1,1,1,1,1,1,1,0,1,0,1,1,0,1,1,1,1,0,1,0,1,0,1,1,1,1,1,1,1,0,1},
{1,0,1,2,1,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,1,0,1,0,1,0,0,0,0,0,0,0,0,0,1},
{1,0,1,0,1,1,0,1,0,1,1,1,0,1,1,1,1,1,1,1,1,0,0,0,1,0,1,0,0,0,1,1,1,1,0,0,1,0,1},
{1,0,1,0,1,1,0,1,0,1,1,1,0,1,1,0,0,0,1,1,1,1,1,1,1,0,1,0,1,0,0,1,0,1,0,0,1,0,1},
{1,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,1,0,0,1,0,1,0,0,1,0,1},
{1,0,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1},
{1,0,0,0,0,0,1,0,0,0,0,2,1,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},




            };
            
            int x = 1, y = 1; //Х и У - координаты Игрока
            int i = 0;
            int j = 0;
            Console.WriteLine("В этом году вы стали королевским рыцарем, теперь вы можете отправиться в поход для освоение земель, чтобы ваш народ не  голодал" +
                "\nлабиринт является одним из испытаний на пути к плодородным почвам" +
                "\n" +
                "\nКороль вас предупреждает об опасности, таящиеся в них..." +
                "\n" +
                "\nВ кромешной темноте, вам нужно найти выход и остаться в живых!");
            Console.WriteLine(" _______________¶§____¶§____¶§_____________________________________________¶¶¶____________________________");
            Console.WriteLine(" _______________¶1¶___¶¶___¶¶____________________________________________$¶¶¶¶¶___________________________");
            Console.WriteLine("  _______________¶§__§¶¶__¶_¶¶__________________________________________¶¶¶¶¶¶¶¶v_________________________");
            Console.WriteLine(" _______________¶____________¶__________________________________________¶8_____¶¶_________________________");
            Console.WriteLine(" _______________¶____________¶_________________________________________¶¶_______¶¶________________________");
            Console.WriteLine(" _______________¶____________¶_________________________________________¶¶¶¶¶¶¶¶¶¶¶________________________");
            Console.WriteLine(" ______________¶¶¶¶¶_________¶_________________________________________¶q__¶__8_v¶________________________");
            Console.WriteLine(" _____________¶¶¶¶1§¶1§1_¶¶¶¶¶¶_________________________________________¶8$33¶¶¶¶¶________________________");
            Console.WriteLine(" _____________¶¶¶¶¶¶¶__¶_¶¶¶¶¶¶__________________________________________¶¶¶¶¶¶¶¶_________________________");
            Console.WriteLine(" ______________¶¶¶_____¶___¶¶¶¶__________________________________________¶¶¶¶¶¶¶¶_________________________");
            Console.WriteLine(" ______________¶¶¶___§¶¶___1¶¶¶______________________________________¶¶_¶¶¶¶¶¶¶¶¶¶________________________");
            Console.WriteLine(" ________________¶__¶¶¶¶¶¶_§¶___________________________________¶¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶_¶v_¶_________________");
            Console.WriteLine(" ________________¶¶¶¶1__¶¶§¶___________________________________¶¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_¶¶$¶________________");
            Console.WriteLine(" _________________1¶______¶§_____________________________________¶¶3___¶$_$¶¶¶¶¶88__¶¶8__¶________________");
            Console.WriteLine("  __________________1¶¶¶¶¶¶___________________________________¶____¶¶_____¶¶oq¶3¶q___¶¶$___¶______________");
            Console.WriteLine("  ___________________¶¶¶¶¶___________________________________¶____¶¶_____¶¶oq¶3¶q___¶¶$__  _¶_____________");
            Console.WriteLine("    _____________1¶¶¶¶¶¶¶¶¶¶________________________________¶____q¶¶v______q¶$¶______¶¶v____ ¶¶___________");
            Console.WriteLine(" __________¶¶____________11§§§§¶¶¶_________________________¶________________¶$¶______ ¶¶v____¶¶___________");
            Console.WriteLine(" __________¶1____________________¶________________________3___qq¶¶¶___¶¶¶qo8o¶$___3¶¶¶o______q____________");
            Console.WriteLine(" _________¶¶¶___________________¶¶§__________________________o3¶¶¶¶v____v¶¶¶¶_____$¶¶¶¶q______¶___________");
            Console.WriteLine(" _________¶¶¶__________________1¶¶¶______________________¶¶¶¶¶¶¶¶_v¶¶¶¶8_v¶¶¶¶___3q¶¶v_¶¶¶¶¶¶¶¶___________");
            Console.WriteLine(" ________¶¶¶¶__________________¶¶§¶______________________8¶¶3¶¶¶__8¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__¶¶¶¶¶¶¶¶¶_________");
            Console.WriteLine(" ________¶¶§¶¶________________¶¶¶¶¶§______________________¶¶¶¶¶_________¶¶¶¶¶¶¶¶¶¶8q_____8¶¶¶¶¶¶__________");
            Console.WriteLine(" _______¶¶¶1¶¶¶¶_____________¶¶¶¶¶¶¶__________________________¶¶¶¶¶¶¶3q_____________qq3$¶¶¶¶¶¶____________");
            Console.WriteLine(" ______¶¶¶§§¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_1¶¶¶¶_______________________________¶¶¶¶¶¶¶¶v____v¶¶¶¶¶¶¶¶¶________________");
            Console.WriteLine(" ______¶¶¶§¶¶¶1___§___¶¶__¶_____¶¶¶¶¶____________________________¶q_____$¶8qov8q¶q___3¶___________________");
            Console.WriteLine(" _____¶¶¶¶§¶¶¶§__§¶___¶_________¶¶¶¶¶____________________________________¶¶¶¶¶qq¶_____q¶__________________");
            Console.WriteLine(" _____¶¶¶¶§¶1¶____¶___¶____1____¶¶¶1¶¶_______¶¶__________________¶_______q3¶¶¶8$¶______¶3_________________");
            Console.WriteLine(" _____¶_¶¶¶¶_¶____¶___¶____§____¶¶¶¶¶¶_______¶¶¶¶¶_______________¶¶¶¶¶q__qo¶¶¶¶¶q____¶¶¶¶_________________");
            Console.WriteLine(" ____1¶_¶1¶§_¶____¶___¶____1____§¶¶¶1¶_______§¶¶¶¶_______________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__________________");
            Console.WriteLine(" ____¶¶¶¶¶¶__¶____¶§__¶____1____1¶1¶¶¶¶_______¶§¶¶¶______________o__$_q¶¶¶¶¶¶¶¶¶¶¶¶¶__¶_3_________________");
            Console.WriteLine(" ____¶§¶§¶§__¶____¶§__§¶___1_____¶11¶¶¶§_____§¶1¶¶¶______________¶___¶¶_¶¶¶¶¶¶q¶¶¶___¶_v__________________");
            Console.WriteLine(" ____¶¶¶§¶1__¶____¶¶___¶___§_____¶11¶¶§¶_____¶_¶¶________________q__¶___¶¶¶¶¶¶¶_¶¶¶¶¶¶___¶________________");
            Console.WriteLine(" ____¶¶¶¶¶___¶____¶¶__§¶___¶_____¶§1§¶¶¶¶___¶¶1¶________________¶$¶v_¶¶¶¶¶¶_8_3_¶¶¶¶¶__¶¶¶________________");
            Console.WriteLine(" ___1§¶¶¶¶___¶____¶¶___§___¶_____¶¶_¶¶¶¶¶___¶_¶________________¶¶__¶¶¶¶¶¶¶__¶88¶___¶¶¶¶¶__8¶¶q____________");
            Console.WriteLine("___¶§¶§¶¶__1¶____¶1_______¶_____1¶_¶¶¶¶¶__§¶1¶_________________¶¶¶___¶¶¶¶¶__¶88¶___3¶¶¶¶q3$¶¶q____________");
            Console.WriteLine(" ___¶§¶§¶§___¶____¶1_______¶______¶_¶¶¶¶¶__¶_¶§________________8¶¶¶¶¶¶¶¶____¶qq¶____¶¶¶¶¶_¶¶$_____________");
            Console.WriteLine(" ___¶¶¶¶¶§___¶____¶________¶______¶¶¶¶_¶¶¶¶¶1¶_________________q¶¶___¶¶¶____¶qq¶______¶¶___¶8¶____________");
            Console.WriteLine(" __1¶¶¶¶¶§__1¶____¶________¶______¶¶§¶__¶¶¶¶¶¶_________________¶8¶___¶¶_____¶oo¶______¶¶___¶¶q$___________");
            Console.WriteLine(" __¶¶¶¶¶¶___1¶____¶________¶______§¶1¶§__¶¶¶¶¶_________________o¶¶___¶¶_____¶oo¶______¶¶____¶_¶___________");
            Console.WriteLine(" __¶¶¶¶¶____§§____¶_______¶¶_______¶§¶¶__¶¶¶¶¶_________________q¶v__8¶¶_____¶__¶______¶¶¶___¶3¶___________");
            Console.WriteLine(" __¶¶¶¶¶1___¶____¶§_______¶¶_______¶§§¶__¶¶¶¶__________________¶¶___¶¶______¶__¶_______¶¶___¶$o___________");
            Console.WriteLine(" _¶§¶¶¶____¶____¶________¶1_______¶¶§¶_¶¶¶¶___________________¶¶q__¶¶_______¶__¶_______3¶q__¶¶v___________");
            Console.WriteLine(" __¶1¶¶¶___§¶____¶________¶________¶¶1¶1¶¶¶___________________¶¶__¶¶¶_______¶__¶________¶¶q_q¶____________");
            Console.WriteLine(" _1¶¶¶¶§___¶¶___¶¶________¶_________¶_§¶¶¶¶___________________¶3__¶¶________¶__¶_________¶¶__¶____________");
            Console.WriteLine(" 1§_§¶____¶¶___¶¶________¶_________¶1_¶¶¶___________________¶¶_____¶¶_______¶__¶__________¶__¶$___________");
            Console.WriteLine(" _§1_______¶1___¶¶________¶_________¶¶_¶___________________¶______¶¶¶¶¶_____¶¶_¶__________¶__¶$___________");
            Console.WriteLine("_¶_______¶¶____¶¶________¶_________§¶_¶__________________3¶____¶¶¶¶¶¶_______¶¶_¶¶_______¶_q3¶___¶¶¶¶______");
            Console.WriteLine(" _¶_______¶§____¶¶_______1¶_________1¶_§1_______________¶¶____¶¶¶¶_________¶¶¶_¶¶¶_______¶¶¶¶¶¶____¶¶¶____");
            Console.WriteLine(" _¶______§¶_____¶§_______¶___________¶__¶_______________¶¶v__¶¶¶¶¶________¶¶¶___¶¶¶__________3¶¶_____$¶¶__");
            Console.WriteLine(" _§______¶¶_____¶________¶___________¶__¶______________¶_q8¶¶¶____________¶¶¶___¶¶¶___________¶¶¶¶¶___¶¶__");
            Console.WriteLine(" §_______¶¶_____¶________¶___________¶__¶______________¶q__________________¶¶___¶¶_________________q8__¶¶¶");
            Console.WriteLine("¶_______¶¶____¶¶________¶____________¶_1____________________________________¶¶_¶¶_____________________¶q__");
            Console.WriteLine("___1¶¶¶¶¶¶¶¶¶¶¶1§§1§¶¶¶¶¶¶§§1__§¶¶¶_¶¶_______________________________________¶_¶__________________________");
            Console.WriteLine(" ____1§§§¶¶¶¶¶¶¶¶§§¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_______________________________________¶___________________________");
            Console.WriteLine("\nВ любой момент времени, вы можете вернуться обратно в свое королевство, нажав на клавишу Esc");
            Console.WriteLine("\nНажмите на любую клавишу что-бы начать...");
           
            Console.ReadKey();
        Again:
            x = 1;
            y = 1;
            try 
            {
                


                while (true)  //Прорисовка Лабиринта путем бесконечно цикла
                {
                    Console.Clear(); 
                    
                    
                    for ( i = 0; i < maze.GetLength(0); i++)
                    {
                        for ( j = 0; j < maze.GetLength(1); j++)
                        {
                            if (maze[i, j] == 0) Console.Write(",");

                            if (maze[i, j] == 1) Console.Write("▒");
                            if (maze[i, j] == 2) Console.Write("*");
                            if (maze[i, j] == 3) Console.Write("E");
                        }

                        Console.WriteLine();
                    }
                    Console.WriteLine("\n * - Опасные существа");
                    Console.Write("\n E - Выход");


                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("1");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;

                    

                    ConsoleKeyInfo ki = Console.ReadKey(); // Обработка управления с клавиатуры
                    if (ki.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine("Вы не прошли испытание" +
                            "\n Вы не готовы, вам нужно еще много тренироваться ");
                        Console.ReadKey();
                        break;
                    
                    }                        

                    if (ki.Key == ConsoleKey.LeftArrow && maze[y, x - 1] == 0) x--;

                    if (ki.Key == ConsoleKey.RightArrow && maze[y, x + 1] == 0) x++;

                    if (ki.Key == ConsoleKey.UpArrow && maze[y - 1, x] == 0) y--;

                    if (ki.Key == ConsoleKey.DownArrow && maze[y + 1, x] == 0) y++;

                    if (ki.Key == ConsoleKey.LeftArrow && maze[y, x - 1] == 2) goto Dead;

                    if (ki.Key == ConsoleKey.RightArrow && maze[y, x + 1] == 2) goto Dead; ;

                    if (ki.Key == ConsoleKey.UpArrow && maze[y - 1, x] == 2) goto Dead; ;

                    if (ki.Key == ConsoleKey.DownArrow && maze[y + 1, x] == 2) goto Dead; ;





                }

            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine("Поздравляю! Вы прошли испытание!!!");
                Console.ReadKey();
                Environment.Exit(0);
            }
        Dead:
            Console.Clear();
            Console.WriteLine("В темноте вы понимаете, что наткнулись на монстра ");
            Console.ReadKey();
            Console.WriteLine("\n Он нападает на вас");
            Console.WriteLine("            ████████████████████████████████      ");
            Console.WriteLine("            ████▀░█████▀▀▀▀▀▀▀▀▀▀█████░▀████      ");
            Console.WriteLine("            ██▀░░███▀░░░░░░░░░░░░░░▀███░░▀██      ");
            Console.WriteLine("            ██░░░▀░░░░░░░░░░░░░░░░░░░░▀░░░██      ");
            Console.WriteLine("            ██▄░░░░░░░░░░░░░░░░░░░░░░░░░░▄██      ");
            Console.WriteLine("            ███▄░░░░░▄█▄░░░░░░░░▄█▄░░░░░▄███      ");
            Console.WriteLine("            ███░░░░░░█▀▀█▄░░░░▄█▀▀█░░░░░░███      ");
            Console.WriteLine("            ███░░░░░░▀███▀▀░░▀▀███▀░░░░░░███      ");
            Console.WriteLine("            ███░░░░░░░░░░░░░░░░░░░░░░░░░░███      ");
            Console.WriteLine("            ████░░░░░░░░░░░░░░░░░░░░░░░░████      ");
            Console.WriteLine("            ████▄░░░░░░░░░▄██▄░░░░░░░░░▄████      ");
            Console.WriteLine("            █████▄░░░░░░░░░░░░░░░░░░░░▄█████      ");
            Console.WriteLine("            ███████░░░░█▀░▄░░▄░▀█░░░░███████      ");
            Console.WriteLine("            ████████░░░▀░░█░░█░░▀░░░████████      ");
            Console.WriteLine("            █████████░░░░░░░░░░░░░░█████████      ");
            Console.WriteLine("            ██████████░░░░░░░░░░░░██████████      ");
            Console.WriteLine("            ███████████▄▄░░░░░░▄▄███████████      ");
            Console.WriteLine("            ████████████████████████████████      ");

            Console.WriteLine("\n Спустя мгновение, существо пробивает вам грудь");
            Console.ReadKey();
            Console.WriteLine("\n Вы понимаете, что это последние минуты вашей жизни...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear(); 
            Console.WriteLine("\n Вы мертвы. Нажмите на любую клавишу что-бы начать сначала...");
            Console.ReadKey();
            
            goto Again;

            
            
            


   


        }
    }
}