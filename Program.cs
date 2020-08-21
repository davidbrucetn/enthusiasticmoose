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

            //method call
            // Ask some AskTheMooses
            // CanadaAskTheMoose();
            // EnthusiasticAskTheMoose();
            // LoveCSharpAskTheMoose();
            // SecretAskTheMoose();

            AskTheMoose("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
            AskTheMoose("Are you enthusiastic?", "Yay!", "You should try it!");
            AskTheMoose("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
            AskTheMoose("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");

        }

        // AskTheMoose receives the question to pass to MooseAsks, and the strings that will be the answers based on the boolean response.
        static void AskTheMoose(string question, string yes, string no)
        {
            // MooseAsks ternary boolean - if true, answers yes string var, if false, answers no string var
            MooseSays(MooseAsks(question) ? yes : no);
        }

        static void CanadaAskTheMoose()
        {
            // As a AskTheMoose, stores boolean return in isTrue
            bool isTrue = MooseAsks("Is Canada real?");

            // if (MooseAsks("Is Canada real?")) // also works
            if (isTrue)
            {
                MooseSays("Really? It seems very unlikely.");
            }
            else
            {
                MooseSays("I  K N E W  I T !!!");
            }
        }

        static void EnthusiasticAskTheMoose()
        {
            bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
            if (isEnthusiastic)
            {
                MooseSays("Yay!");
            }
            else
            {
                MooseSays("You should try it!");
            }
        }

        static void LoveCSharpAskTheMoose()
        {
            bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
            if (doesLoveCSharp)
            {
                MooseSays("Good job sucking up to your instructor!");
            }
            else
            {
                MooseSays("You will...oh, yes, you will...");
            }
        }

        static void SecretAskTheMoose()
        {
            bool isEverythingFine = MooseAsks("Do you want to know a secret?");
            if (isEverythingFine)
            {
                MooseSays("ME TOO!!!! I love secrets...tell me one!");
            }
            else
            {
                MooseSays("Oh, no...secrets are the best, I love to share them!");
            }
        }

        // Make the moose ask AskTheMooses
        // MooseAsks method returns a boolean value bool,
        // and accepts a string AskTheMoose
        static bool MooseAsks(string AskTheMoose)
        {
            Console.Write($"{AskTheMoose} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            // While answer is not y or n, keep asking AskTheMoose
            while (answer != "y" && answer != "n")
            {
                Console.Write($"{AskTheMoose} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            // Received a y or n after while loop, return boolean
            // Two equal signs always used in C#
            // You can return the boolean this way or in the if/else
            return (answer == "y");
            // if (answer == "y")
            // {
            //     return true;
            // }
            // else
            // {
            //     return false;
            // }
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