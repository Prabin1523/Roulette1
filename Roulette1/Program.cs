using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette1
{
    class Program
    {

        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Select From the Following Option:");

            Console.WriteLine("A - numbers 1-36");
            Console.WriteLine("B-  Odd or Even ");
            Console.WriteLine("C - Red or Black ");
            Console.WriteLine("D - low(1-18) or high(19-36)");
            Console.WriteLine("E - Dozens: row thirds");
            Console.WriteLine("F - Columns: first, second and third");
            Console.WriteLine("G - Street rows: ");
            Console.WriteLine("H - 6 numbers: Double rows");
            Console.WriteLine("I - Split any two contiguous numbers");
            Console.WriteLine("J - Corner: any four contiguous numbers");
            string userInput = Console.ReadLine();
            Console.Clear();

            if (userInput == "A" || userInput == "a")
            {

                Console.WriteLine("Select from the 0 - 36 or 00 (winning number 37 = 00)" );
                string userNum = Console.ReadLine();
                int userNum2 = Convert.ToInt32(userNum);

                Random rando = new Random();
                int roll = rando.Next(0, 37);
                Console.WriteLine("Winning number is: " + roll);

                if (roll == userNum2)
                {
                    YouWin();
                }
                else if (userNum2 == 0 && roll == 37 )
                {
                    YouWin();
                }
                else
                {
                    YouLose();
                }

                goto start;

            }
            else if (userInput == "B" || userInput == "b")
            {
                Console.WriteLine("Type odd or even");
                string oddEven = Console.ReadLine();

                Random rando = new Random();
                int roll = rando.Next(0, 37);
                Console.WriteLine("Winning number is: " + roll);
                if (roll % 2 == 0 && oddEven == "even" || oddEven == "EVEN")
                {
                    YouWin();
                }
                else if (roll % 2 != 0 && oddEven == "odd" || oddEven == "ODD")
                {
                    YouWin();
                }
                else
                {
                    YouLose();
                }
                
                goto start;
            }


            else if (userInput == "C" || userInput == "c")
            {
                Console.WriteLine("Type red or black. all odd numbers are Red and all even numbers are Black");
                string color = Console.ReadLine();

                Random rando = new Random();
                int roll = rando.Next(0, 37);

                Console.WriteLine("Winning number is: " + roll);
                if (roll % 2 == 0)
                {
                    if (color == "black")
                    {
                        YouWin();
                    }
                    else if (color != "black")
                    {
                        YouLose();
                    }

                }
                if (roll % 2 != 0)
                {
                    if (color == "red")
                    {
                        YouWin();

                    }
                    else if (color != "red")
                    {
                        YouLose();
                    }

                }

                goto start;
            }

            else if (userInput == "D" || userInput == "d")
            {
                Console.WriteLine("Select a for low(1-18) or b for high(19-36)");
                string highLow = Console.ReadLine();


                Random rando = new Random();
                int roll = rando.Next(0, 37);
                Console.WriteLine("Winning number is: " + roll);
                // int highLow2 = Convert.ToInt32(highLow);

                if ((highLow == "a".ToLower()) && ((roll > 0) && (roll < 19)))
                {
                    YouWin();
                }

                if ((highLow == "b".ToLower()) && ((roll > 18) && (roll < 37)))
                {
                    YouWin();
                }
                else
                {
                    YouLose();
                }

                goto start;

            }
            if (userInput == "E" || userInput == "e")
            {
                Console.WriteLine("Select from the Dozons: a for 1-12  b for 13-24,  c for 25-36) ");
                string rowThirds = Console.ReadLine();
                Random rando = new Random();
                int roll = rando.Next(0, 37);
                Console.WriteLine("Winning number is: " + roll);

                if ((rowThirds == "a".ToLower()) && ((roll > 0) && (roll < 13)))
                {
                    YouWin();
                }
                else if ((rowThirds == "b".ToLower()) && ((roll > 12) && (roll < 25)))
                {
                    YouWin();
                }
                else if ((rowThirds == "c".ToLower()) && ((roll > 25) && (roll < 37)))
                {
                    YouWin();
                }
                else
                {
                    YouLose();
                }

                goto start;
            }

            if (userInput == "F" || userInput == "f")
            {
                Console.WriteLine("Select from Columns: a for 1st column, b for 2nd column, c for 3rd column ");
                string columns = (Console.ReadLine());
               
                Random rando = new Random();
                int roll = rando.Next(0, 37);
                Console.WriteLine("Winning number is: " + roll);

                // for (roll = 1; roll <= 34; roll += 3)
                
                // if(columns == "a" && roll > 0 && roll < 35)
                {
                    if (columns == "a"  && (roll == 1 || roll == 4 || roll == 7 || roll == 10 || roll == 13 || roll == 16 || roll == 19 ||
                        roll == 22 || roll == 25 || roll == 28 || roll == 31 || roll == 34))
                    {
                        YouWin();
                    }
                    else if (columns == "b" && (roll == 2 || roll == 5 || roll == 8 || roll == 11 || roll == 14 || roll == 17 || roll == 20 ||
                        roll == 23 || roll == 26 || roll == 29 || roll == 32 || roll == 35))
                    {
                        YouWin();
                    }

                    else if (columns == "c" && (roll == 3 || roll == 6 || roll == 9 || roll == 12 || roll == 15 || roll == 18 || roll == 21 ||
                          roll == 24 || roll == 27 || roll == 30 || roll == 33 || roll == 36))
                    {
                        YouWin();

                    }
                    else
                    {
                        YouLose();
                    }

                    goto start;

                }


            }
            if (userInput == "G" || userInput == "g")
            {
                Console.WriteLine("Select from stree rows: m for row(1/2/3)      n for row(4/5/6)       o for row(7/8/9) " +
                                      " p for row(10/11/12)  q for row (13/14/15)  r for row (16/17/18)   s for row(19/20/21)   t for row(22/23/24)" +
                                     " u for row (25/26/27)  v for row (28/29/30)   w for row(31/32/33)   x for row(34/35/36)");

                string rows = Console.ReadLine();
                Random rando = new Random();
                int roll = rando.Next(0, 37);
                Console.WriteLine("Winning number is: " + roll);

                if (rows == "m" && roll > 0 && roll < 4)

                {
                    YouWin();
                }

                else if (rows == "n" && roll > 3 && roll < 7)
                {
                    YouWin();
                }
                else if (rows == "o" && roll > 6 && roll < 10)
                {
                    YouWin();

                }
                else if (rows == "p" && roll > 9 && roll < 13)
                {
                    YouWin();
                }
                else if (rows == "q" && roll > 12 && roll < 16)
                {
                    YouWin();
                }
                else if (rows == "r" && roll > 15 && roll < 19)
                {
                    YouWin();
                }
                else if (rows == "s" && roll > 18 && roll < 22)
                {
                    YouWin();

                }
                else if (rows == "t" && roll > 21 && roll < 25)
                {
                    YouWin();
                }
                else if (rows == "u" && roll > 24 && roll < 28)
                {
                    YouWin();
                }
                else if (rows == "v" && roll > 27 && roll < 31)
                {
                    YouWin();
                }
                else if (rows == "w" && roll > 30 && roll < 34)
                {
                    YouWin();
                }
                else if (rows == "x" && roll > 33 && roll < 37)
                {
                    YouWin();
                }
                else
                {
                    YouLose();
                }
                goto start;
            }

            if (userInput == "H" || userInput == "h")
            {
                Console.WriteLine("Select from double rows:  a for(1/2/3/4/5/6) b for(7/8/9/10/11/12/)  c for (13/14/15/16/17/18/)" +
                      " d for (19/20/21/22/23/24/) e for (25/26/27/28/29/30) f for (31/32/33/34/35/36");
                string doubleRows = Console.ReadLine();
                Random rando = new Random();
                int roll = rando.Next(0, 37);
                Console.WriteLine("Winning number is: " + roll);

                if (doubleRows == "a" && roll > 0 && roll < 7)
                {
                    YouWin();
                }
                if (doubleRows == "b" && roll > 6 && roll < 13)
                {
                    YouWin();
                }
                if (doubleRows == "c" && roll > 12 && roll < 19)
                {
                    YouWin();
                }
                if (doubleRows == "d" && roll > 18 && roll < 25)
                {
                    YouWin();
                }
                if (doubleRows == "e" && roll > 24 && roll < 31)
                {
                    YouWin();
                }
                if (doubleRows == "f" && roll > 30 && roll < 37)
                {
                    YouWin();
                }
                else
                {
                    YouLose();
                }
                goto start;
            }

            if (userInput == "I" || userInput == "i")
            {
                Console.WriteLine("Enter two contiguous numbers that you wnat to split your bet on.");
                Console.WriteLine("Enter your 1st number. ");
                string first = Console.ReadLine();
                int firstNumber = Convert.ToInt32(first);
                Console.WriteLine("Enter your 2nd number. ");
                string second = Console.ReadLine();
                int secondNumber = Convert.ToInt32(second);
                Random rando = new Random();
                int roll = rando.Next(0, 37);
                Console.WriteLine("Winning number is: " + roll);

                if (firstNumber == roll || secondNumber == roll)
                {
                    YouWin();
                }
                else
                {
                    YouLose();
                }

                goto start;
            }
            if (userInput == "J" || userInput == "j")
            {
                Console.WriteLine("Select from the following options: ");
                Console.WriteLine("a for 1/2/4/5    b for 2/3/5/6     c for 4/5/7/8    d for 5/6/8/9     e for 7/8/10/11    f for 8/9/11/12     g for 10/11/13/14   h for 11/12/14/15   " +
                    "i for 13/14/16/17  j for 14/15/17/18   k for 16/17/19/20   l for 17/18/20/21   m for 19/20/22/23   n for 20/21/23/24   o for 22/23/25/26   p for 23/24/26/27   q for 25/26/28/29   " +
                    "r for 26/27/29/30  s for 28/29/31/32   t for 29/30/32/33   u for 31/32/34/35   v for 32/33/35/36 ");

                string corner = Console.ReadLine();
                Random rando = new Random();
                int roll = rando.Next(0, 37);
                Console.WriteLine("Winning number is: " + roll);
                if (corner == "a" && roll > 0 && roll < 6 && roll != 3)
                {
                    YouWin();
                }

                else if (corner == "b" && roll > 1 && roll < 7 && roll != 4)
                {
                    YouWin();
                }

                else if (corner == "c" && roll > 3 && roll < 9 && roll != 6)
                {
                    YouWin();
                }
                else if (corner == "d" && roll > 4 && roll < 10 && roll != 7)
                {
                    YouWin();
                }
                else if (corner == "e" && roll > 6 && roll < 12 && roll != 9)
                {
                    YouWin();
                }
                else if (corner == "f" && roll > 7 && roll < 13 && roll != 10)
                {
                    YouWin();
                }
                else if (corner == "g" && roll > 9 && roll < 15 && roll != 12)
                {
                    YouWin();
                }
                else if (corner == "h" && roll > 10 && roll < 16 && roll != 13)
                {
                    YouWin();
                }
                else if (corner == "i"&& roll > 12 && roll < 18 && roll != 15)
                {
                    YouWin();
                }
                else if (corner == "j" && roll > 13 && roll < 19 && roll != 16)
                {
                    YouWin();
                }
                else if (corner == "k" && roll > 15 && roll < 21 && roll != 18)
                {
                    YouWin();
                }
                else if (corner == "l" && roll > 16 && roll < 22 && roll != 19)
                {
                    YouWin();
                }
                else if (corner == "m" && roll > 18 && roll < 24 && roll != 21)
                {
                    YouWin();
                }
                else if (corner == "n" && roll > 19 && roll < 25 && roll != 22)
                {
                    YouWin();
                }
                else if (corner == "o" && roll > 21 && roll < 27 && roll != 24)
                {
                    YouWin();

                }
                else if (corner == "p" && roll > 22 && roll < 28 && roll != 25)
                {
                    YouWin();
                }
                else if (corner == "q" && roll > 24 && roll < 30 && roll != 27)
                {
                    YouWin();
                }
                else if (corner == "r" && roll > 25 && roll < 31 && roll != 28)
                {
                    YouWin();
                }
                else if (corner == "s" && roll > 27 && roll < 33 && roll != 30)
                {
                    YouWin();
                }
                else if (corner == "t" && roll > 28 && roll < 34 && roll != 31)
                {
                    YouWin();
                }
                else if (corner == "u" && roll > 30 && roll < 36 && roll != 33)
                {
                    YouWin();
                }
                else if (corner == "v" && roll > 31 && roll < 38 && roll != 34)
                {
                    YouWin();
                }else
                {
                    YouLose();
                }

                goto start;

            }
        }

        static void YouWin()
        {
            Console.WriteLine("You win!");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }

       static void YouLose()
        {
            Console.WriteLine("Sorry You lose! Try again.");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }

        
    }
}