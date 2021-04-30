using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kumarhaneV1
{
    class Program
    {
        

        
        

        static void Lobby()
        {
            int Player, House, Dice1, Dice2, Dice3, Dice4;
            double Cash, Bet, total, total2,total3,total4;
            Cash = 100;
            
            string input;
            Console.WriteLine("Welcome to the Casino");
            Console.WriteLine($"You Have {Cash}");
            Console.WriteLine("D to Play Dice Game");

            Console.WriteLine("G to Play Guess Game");

            Console.WriteLine("E to Exit Casino");

            input = Convert.ToString(Console.ReadLine());

            if (input == "D")
            {
                Console.WriteLine("Welcome to the Dice Game");
                
                Console.WriteLine("In the dice game the house and you roll 2 dice in a round.");
                Console.WriteLine("Who is going to roll first will change after every round.");
                Console.WriteLine("Press enter to continue");
                input = Console.ReadLine();

                while (Cash != 0)
                {
                    
                    do
                    {
                        Console.WriteLine("Press enter to begin or type L to go back to the Lobby ");
                        input = Convert.ToString(Console.ReadLine());
                        if (input == "L")
                        {
                            Lobby();
                        }
                        Console.WriteLine("Please Enter The Bet Amount: ");
                        Bet = double.Parse(Console.ReadLine());
                        total = Cash + Bet;
                        total2 = Cash - Bet;
                        
                        
                        
                        if (Bet > Cash)
                        {
                            Console.WriteLine("You Do Not Have Enough Cash For That Bet Amount.");
                            Console.WriteLine("Cash: {0:C}", Cash);
                            Lobby();
                        }
                        else if (input == "L")
                        {
                            Lobby();
                        }
                    }
                    while (Bet > Cash);
                    {

                        Console.WriteLine("Press Enter To Roll");
                        Console.ReadKey();

                        Random r = new Random();
                        Random p = new Random();
                        Random s = new Random();
                        Random t = new Random();
                        Dice4 = r.Next(1, 6);
                        Dice3 = r.Next(1, 6);
                        Dice1 = r.Next(1, 6);
                        Dice2 = p.Next(1, 6);
                        Console.WriteLine($"You rolled {Dice1},{Dice2}");
                        Console.WriteLine($"House rolled {Dice3},{Dice4}");
                        if (Dice1 + Dice2 > Dice3 + Dice4)
                        {
                            Console.WriteLine($"You won your total balance is {total}");
                            Cash = total;
                        }
                        else if (Dice1 + Dice2 < Dice3 + Dice4)
                        {
                            Console.WriteLine($"You lost your total balance is {total2}");
                            Cash = total2;
                        }
                        else if (Dice1 + Dice2 == Dice3 + Dice4)
                        {
                            Console.WriteLine($"Draw your total balance is {Cash}");
                        }

                        


                    }


                }
            }
            else if (input == "G")
            {
                Console.WriteLine("Welcome to the Guess Game");

                Random rand = new Random();
                int guess = 0;
                int num = rand.Next(1, 1000);
                Console.WriteLine("Guess a number between 1 and 1000");
                Console.WriteLine("Press enter to begin or type E to go back to the Lobby ");
                input = Convert.ToString(Console.ReadLine());
                if (input == "E")
                {
                    Lobby();
                }
                Console.WriteLine("Please Enter The Bet Amount: ");
                Bet = double.Parse(Console.ReadLine());

                Console.WriteLine("Guess a number");

                int i = 0;

                while (guess != num)
                {
                    try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());

                        if (guess > num)
                        {
                            Console.WriteLine("Too High");
                        }
                        else
                        {
                            Console.WriteLine("Too Low");
                        }
                    }

                    catch
                    {
                        Console.WriteLine("Guess must be a number");
                        i--;
                    }


                    i++;
                }
                Console.WriteLine("Congrats, it took you " + i + " tries");
                Console.ReadLine();
            }
            else if (input == "E")
            {
                Console.WriteLine("Bye");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Error Unknown Input");
            }

        }

        static void Main(string[] args)
        {
            
             Lobby();

        }
        
        


    }
}
