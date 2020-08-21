using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            //Let the moose speak by calling the function
            MooseSays();
        }

        static void MooseSays()
        {
            // @ sign lets you add blank lines
            Console.WriteLine(@"
                                       _.--^^^--,
                                    .'           `\
  .-^^^^^^-.                      .'               |
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
                    |   / \   |    H I, I'M  E N T H U S I A S T I C !
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