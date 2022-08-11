using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Commands
{
    public abstract class Commands
    {
        private readonly string name;
        private readonly string[] commands;
        private string nextCommand;

        public Commands(string name, string[] commands, string nextCommand)
        {
            this.name = name;
            this.commands = commands;
            this.nextCommand = nextCommand;
        }

        abstract public void run();

        public string getNextCommand()
        {
            return nextCommand;
        }

        public void setNextCommand(string nextCommand)
        {
            this.nextCommand = nextCommand;
        }

        public void printMessage(string message)
        {
            Console.WriteLine("------");
            Console.WriteLine(message);
            Console.WriteLine("------");
        }

        public void printGreeting()
        {
            Console.WriteLine($"Welcome to the {name} commands.");
        }

        public void printCommands(string[] commands)
        {
            for (int i = 0; i < commands.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {commands[i]}");
            }
        }

        public void printCommands()
        {
            printCommands(commands);
        }

        public int getIntegerInput(int limit)
        {
            int input = 0;
            bool correctInput = false;

            while (!correctInput)
            {
                Console.WriteLine("Enter a number between 1 and " + limit);
                int userinput = int.Parse(Console.ReadLine());
                if (userinput > 0 && userinput <= limit)
                {
                    correctInput = true;
                    input = userinput;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a number between 1 and " + limit);
                }
            }

            return input;
        }

        public int getIntegerInput()
        {
            return getIntegerInput(commands.Length);
        }

        public string getStringInput()
        {
            Console.WriteLine("Enter text below:");
            string userInput = Console.ReadLine();
            if (userInput == "" || userInput == null)
            {
                Console.WriteLine("Unable to understand input, please try again");
                return getStringInput();
            }
            else
            {
                return userInput;
            }
        }
    }
}
