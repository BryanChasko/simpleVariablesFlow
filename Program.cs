// this program allows input in the console, and displays back from memory to console
using System;

namespace simpleFavoriteBand
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic variables storing/retrieving data from memory example by Eric Fisher on Pluralsight
            //ask for name of band, number of members, and announce this info to the user
            //create a variable that allows us to store the info in memory ("set") then retrieve it
            //ask and set name of band to name, set number of members to numberOfMembers
            //retrieve the variable or "get" the variable
            //first, add all the things we expect to write to our users

            Console.WriteLine("What is the name of your band?");
            string name = Console.ReadLine();

            Console.WriteLine("How Many people are in your band?");
            int numberOfMembers = 0;
            //using the try.Parse method to return true or false depending if program can parse the string
            //allowing handling invalid user input. using output parameters in our method by setting variable with "out" keyword
            //allows output if TryParse is successful in parsing the string using ! to tell us we want action if not true
            if (!int.TryParse(Console.ReadLine(), out numberOfMembers))
            {
                Console.WriteLine("input was not valid");
                Environment.Exit(0);
            }
            else if (numberOfMembers < 1)
            {
                Console.WriteLine("You must have at least 1 member");
                //ending environment with exit 0 ends program in console 
                Environment.Exit(0);
            }
            else if (numberOfMembers == 1)
                Console.WriteLine(name + " is a solo");
            else if (numberOfMembers == 2)
                Console.WriteLine(name + " is a duo");
            else
                Console.WriteLine(name + " has " + numberOfMembers + " musicians");

            //other expresions we often need include
            // is something equal to something else ==
            // is something greater than >
            // is something not true !=
            // other notes
            // declare a variable by specifying the type and what you'd like to name variable
            // dataType variableName; i.e., string name;
            // we can "set" a charater using = to set the variable to whatever is assigned ont he right of =
            // run the script using dotnet run from command line

        }
    }
}
