using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace typeracer
{
    public class Program : Texts
    {
        static void Main(string[] args)
        {
            // simple factory - creating an object for other objects, calling objects, methods to new();
            Texts texts = new Texts();

            // behavioural - strategy, real time selection of algorithm
            texts.GenerateStartingTexts();
            while (true)
            {
                Console.WriteLine("Choose an option from menu");
                Console.WriteLine("Choose command:\n"
                + "\n0: - Look at possible texts\n"
                + "1: - Choose from possible texts\n"
                + "2: - Play the game\n"
                + "3: - Add a new text\n"
                + "4: - Exit program\n"
                + "Enter your choice: ");
                try
                {
                    int i = int.Parse(System.Console.ReadLine());
                    switch (i)
                    {
                        case 0:
                            {
                                texts.WriteStrings();
                                break;
                            }
                        case 1:
                            {
                                texts.ChooseString();
                                break;
                            }
                        case 2:
                            {
                                texts.Play();
                                break;
                            }
                        case 3:
                            {
                                texts.AddText();
                                break;
                            }
                        case 4:
                            {
                                Environment.Exit(0);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong input, try again");
                                break;
                            }
                    }
                }
                catch
                {
                }
            }
        

    }
    }
}
