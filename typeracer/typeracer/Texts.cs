using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace typeracer
{
    
   public class Texts
    {
        string realText;
        List<string> text = new List<string>();


        public void GenerateStartingTexts()
        {
            text.Add(" A day or two passed and there was great activity aboard the pequod, not only were the old sails being mended, but new sails were coming on board and bolts of canvas and coils");
            text.Add("My journey was very melancholy, at first I wanted to hurry on, for I longed to console and sympathise with my loved and sorrowing friends, but when I drew near my native town I slackened my progress");
            text.Add("The village of Longbourn was only one mile from Meryton, a most convenient distance for the young ladies who were usually tempted thither three or four times a week");
        }


        //  string[] text = { "Vienas, du, trys keturi penki, sesi.", "Septyni, astuoni, devyni, desimt", "Vienuolika, dvylika, trylika, keturiolika" };

        public void WriteStrings()
        {
            for (int i = 0; i < text.Count; i++)
            {
                Console.WriteLine(i + ". " + text[i]);
            }

        }

        public void ChooseString()
        {
            Console.WriteLine("Write the number of your wanted text");
            int stringInput = int.Parse(System.Console.ReadLine());


            while(stringInput < 0 || stringInput >= text.Count)
            {
                Console.WriteLine("There is no text with this number, try again");
                stringInput = int.Parse(System.Console.ReadLine());
            }
            
                Console.WriteLine("Text has been successfully selected");
                realText = text[stringInput];
            
                
        }
        public void Play()
        {
            char input;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (realText == null)
            {
                Console.WriteLine("There is no text selected, please select a text via previous commands");
            }
            else
            {
                Console.WriteLine(realText);
                for (int i = 0; i < realText.Length; i++)
                {

                    input = Console.ReadKey(true).KeyChar;

                    while (input != realText[i])
                    {
                        input = Console.ReadKey(true).KeyChar;
                    }
                    Console.Write(realText[i]);
                }
                watch.Stop();
                Console.WriteLine("\nYou successfully completed the text!");
                Console.WriteLine("Your time: " + watch.Elapsed.TotalSeconds + " seconds!");
            }


        }

        public void AddText()
        {

            Console.WriteLine("Please enter your text");
            string newText = Console.ReadLine();
            /*  Array.Resize(ref text, text.Length + 1);
              text[text.Length - 1] = newText; */
            text.Add(newText);
            Console.WriteLine("You've successfully added a text!");

        }

            

    }
}
