using System;
using System.Media;

namespace EASbrowse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            easSelect();
            for (int i = 1; i == 1;) {
                Console.WriteLine(" ");
                Console.WriteLine("Would you like to select a new EAS?");
                Console.WriteLine("y/n");
                String ans = Console.ReadLine();
                if (ans == "y")
                {
                    Console.WriteLine(" ");
                    easSelect();
                    i = 1;
                }
                else {
                    i = 0;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press Enter to close the program");
            Console.ReadLine();
        }

        public static void easSelect() {

            // init sounds
            SoundPlayer easCreature = new SoundPlayer("easCreature.wav");
            SoundPlayer easLights = new SoundPlayer("easLights.wav");
            SoundPlayer easSilent = new SoundPlayer("easSilent.wav");
            SoundPlayer easParanoia = new SoundPlayer("easParanoia.wav");

            String[] easList = {"The Creature", "Keep the Lights On", "Keep Silent", "Paranoia"};

            Console.WriteLine("Welcome To EASbrowse, a command-line collection of various real and fabricated, you can select any EAS from the list below");
            Console.WriteLine("1. " + easList[0]);
            Console.WriteLine("2. " + easList[1]);
            Console.WriteLine("3. " + easList[2]);
            Console.WriteLine("4. " + easList[3]);
            Console.WriteLine("Please type the number of the alert you wish to listen to: ");
            String input = Console.ReadLine();

            if (input == "1")
            {
                easCreature.Load();
                Console.WriteLine("Now Playing: The Creature...  Press enter to stop");
                easCreature.PlayLooping();
            }
            else if (input == "2")
            {
                easLights.Load();
                Console.WriteLine("Now Playing: Keep the Lights On...  Press enter to stop");
                easLights.PlayLooping();
                // play sound
            }
            else if (input == "3")
            {
                easSilent.Load();
                Console.WriteLine("Now Playing: Keep Silent...  Press enter to stop");
                easSilent.PlayLooping();
                // play sound
            }
            else if (input == "4")
            {
                easParanoia.Load();
                Console.WriteLine("Now Playing: Paranoia...  Press enter to stop");
                easParanoia.PlayLooping();
                // play sound
            }
            else {
                Console.WriteLine("Invalid input, please press enter and try again");
                Console.ReadLine();
            }
            Console.ReadLine();
            easCreature.Stop();
            easLights.Stop();
            easSilent.Stop();
            easParanoia.Stop();
            Console.WriteLine("Sound stopped.");

        }
    }
}