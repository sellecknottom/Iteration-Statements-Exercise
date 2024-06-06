using System.Reflection.Metadata.Ecma335;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Millenious()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine();
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Triples()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        public static bool FactCheck(int num1, int num2)
        {
            /*if (num1 == num2)
            {
                Console.WriteLine("Fact Checked!");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }*/
            bool result = (num1 == num2) ? true : false;

        return result;

        }
        //Write a method to check whether a given number is even or odd
        public static void OddsOrEvens(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else 
            {
                Console.WriteLine("Odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void HalfFull(int num)
        {
            if (num >= 0)
            {
                Console.WriteLine("The glass is half full.");
            }
            else
            {
                Console.WriteLine("The glass is half empty.");
            }
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void Vote(int num)
        {
            Console.WriteLine("Enter your birth year.");
            int year = int.Parse(Console.ReadLine());

            num = year;

            if (num <= 2006)
            {
                Console.WriteLine("You have the right to vote. ... Choose wisely.");
            }
            else
            {
                Console.WriteLine("Can't vote yet!");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange()
            {
            Console.WriteLine("Enter a number in the range of -10 to 10.");
            int range = int.Parse(Console.ReadLine());

            int num1 = range;

            if (num1 <= 10 && num1 >= -10)
                {
                Console.WriteLine("In Range.");
                }
             }
    //Write a method to display the multiplication table(from 1 to 12) of a given integer
    public static void Table() 
        {
        
            Console.WriteLine("Enter a Number:");
            int num1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num1} x {i} = {num1 * i}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Millenious();

            Triples();

            Console.WriteLine(FactCheck(3,9));

            OddsOrEvens(23497);

            HalfFull(-67);

            Vote(2006);

            InRange();

            Table();
        }
    }
}
