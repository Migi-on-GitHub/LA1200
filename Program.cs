using System;

namespace Zahlen_erraten
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ich heisse Sie herzlich Willkommen zum Zahlen erraten Spiel!");
                    Console.WriteLine("Bitte geben sie ihren Namen ein:");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string Name = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkCyan; 
                
                    Console.WriteLine("");
                    Console.WriteLine("Hallo " + Name + " !");
                
                    Random rand = new Random();
                    int rand_num = rand.Next(1, 100);
                    
                    Console.WriteLine("");
                    Console.WriteLine("-----  -----  -----  -----  -----");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Gerade eben wurde eine zufällige Zahl generiert!");
                    Console.WriteLine("");
                    Console.WriteLine("Bitte versuchen sie, die geheime Zahl zwischen 1 und 100 zu erraten!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("");

                
                int userEingabe = 0;
                    int versuche = 0;




                    while (userEingabe != rand_num)
                    {
                    string userZahl = Console.ReadLine();

                    if (!int.TryParse(userZahl, out userEingabe))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Das ist keine Zahl!");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                    }
                    else
                    {


                        versuche++;

                        if (userEingabe >= 101)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Das ist keine gültige Eingabe, geben Sie eine Zahl zwischen 1 und 100 ein");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                        }
                        if (userEingabe <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Das ist keine gültige Eingabe, geben Sie eine Zahl zwischen 1 und 100 ein");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                        }

                        if (userEingabe < rand_num && userEingabe >= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ihre Zahl ist zu klein, geben sie eine grössere Zahl ein !");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            


                        }

                        if (userEingabe > rand_num && userEingabe <= 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ihre Zahl ist zu gross, geben sie eine kleinere Zahl ein !");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            

                        }

                        if (userEingabe == rand_num)
                        {
                            Console.WriteLine("Gratulation " + Name + " !" + " Sie haben die geheime Zahl " + "'" + userEingabe + "'" + " erraten");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Sie haben " + versuche + " Versuche gebraucht! ");
                            Console.WriteLine("Gut gemacht!");
                            Environment.Exit(0);
                        }

                        
                        
                    }
                    }

            }
        }
    }
}


