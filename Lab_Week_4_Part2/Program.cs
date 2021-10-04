/// File Name:Lab_Week_4_Part2
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
///
///This is a console application that simulates the Lamp flowchart(Slide 35). 




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Week_4_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string plugIn, bulbOut;
            Console.WriteLine("Lamp doesn't work?\n Lamp plugged in?\n (yes/no)");

            plugIn = Console.ReadLine();

            Console.WriteLine(" Bulb burned out?");

            bulbOut = Console.ReadLine();


            if (plugIn.Equals("yes") && (bulbOut.Equals("no")))
            {
                Console.WriteLine("Something is wrong");

            }
            else if (plugIn.Equals("yes") && bulbOut.Equals("yes"))
            {

                Console.WriteLine("The Light bulb needs to be replaced");
            }
            else if (plugIn.Equals("no") && bulbOut.Equals("no"))
            {
                Console.WriteLine("The lamp needs to be plugged in");
            }
            else
            {
                Console.WriteLine("The bulb is out and the lamp is unplugged");
            }
            Console.ReadKey();

        }
    }
}
        
    

