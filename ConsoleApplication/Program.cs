using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            // 2
            string name = "Kevin Cook";
            string location = "Rexburg, ID";
            string yourName, yourLocation; 

            //3.
            Console.WriteLine($"Hello, My name is {name}");
            Console.WriteLine($"I am from {location}");
            Console.WriteLine($"What is your name: ");
            yourName = Console.ReadLine();
            Console.WriteLine($"Where are you from: ");
            yourLocation = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {yourName} from {yourLocation}");
            Console.WriteLine();

            //4
            var currentDate = DateTime.Now;
            Console.WriteLine($"The Current Date is: {currentDate.ToString("D")}");
            Console.WriteLine();

            //5.
            var christmas = new DateTime(currentDate.Year, 12, 25);
            var daysLeft = christmas - currentDate;
            double hoursLeft = daysLeft.TotalHours;
           
            Console.WriteLine($"There is {daysLeft.Days} Days, or {Math.Round(hoursLeft, 2)} Hours, or {Math.Round(daysLeft.TotalSeconds, 2)} Seconds til Christmas, HO, HO, HO!!!");
            Console.WriteLine();

            //6.
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("How wide is the frame (in feet):");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("How high is the frame (in feet):");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters");


            //7
            Console.ReadKey();

        }
    }
}
