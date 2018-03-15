using System;

namespace YasmaniManager
{
    class HRProgram
    {
        static void Main(string[] args)
        {
            //Initial variables
            int rootMenuChoice;
            bool isValidNum = true;
            //Loop to make sure correct number is pressed
            do
            {
                rootQuestions();
                while(!int.TryParse(Console.ReadLine(), out rootMenuChoice))
                {
                    Console.WriteLine("Plese Enter a valid numerical value!");
                }
                isValidNum = isValidMenuNum(rootMenuChoice);
            } while (isValidNum == false);
            


        }

        //This is the root menu of questions
        static void rootQuestions()
        {
            Console.WriteLine("Press the number of the item you wish to use. Then press 'Enter'\n");
            Console.WriteLine("1 - Create Employee\n");
            Console.WriteLine("2 - Edit Employee\n");
            Console.WriteLine("3 - Delete Employee\n");
            Console.WriteLine("4 - View Employees\n");
        }

        //This number check is for the root meneu
        private static bool isValidMenuNum(int numToCheck)
        {
            if(numToCheck >= 1 && numToCheck <= 4)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please Enter a Valid Number");
                return false;
            }
        }
    }
}
