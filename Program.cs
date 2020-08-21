using System;

namespace EnthusiasticMoose
{
    //Class is container for methods
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            //Let the moose speak by calling the function
            // passing literal string as parameter
            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("I really am enthusiastic");

            // As a question, stores boolean return in isTrue
            bool isTrue = MooseAsks("Is Canada real?");

            // Prints boolean return
            Console.WriteLine(isTrue);
        }

        // Make the moose ask questions
        // MooseAsks method returns a boolean value bool,
        // and accepts a string question
        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            // While answer is not y or n, keep asking question
            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            // Received a y or n after while loop, return boolean
            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void MooseSays(string message)
        {
            // $ sign for string interpolation and @ symbol for blank lines
            Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
        ");
        }
    }
}