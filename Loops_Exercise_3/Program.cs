using System;

namespace Loops_Exercise_3
{
    class Program
    {
        public static void PrintNumsLarge()
        {
            for (int i = -1000; i < 1000; i++)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine(1000);
        }
        public static void PrintNumsSmall()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        public static bool AreEqual(int num1, int num2)
        {
            return num1 == num2;
        }
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        public static bool IsPos(int num)
        {
            return num >= 0;
        }
        public static bool CanVote(int age)
        {
            return age >= 18;
        }
        public static bool InRange(int num)
        {
            return -10 <= num && num <= 10;
        }
        public static void MultiTables(int num)
        {
            for (var i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num}*{i}={i * num}");
            }
        }
        static void Main(string[] args)
        {
            PrintNumsLarge();
            PrintNumsSmall();

            Console.WriteLine("Enter two numbers");
            int equalNum1 = int.Parse(Console.ReadLine());
            int equalNum2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"It is {AreEqual(equalNum1, equalNum2)} that {equalNum1} and {equalNum2} are equal");

            Console.WriteLine("Enter a number");
            int isEvenNum = int.Parse(Console.ReadLine());
            string isEvenResult = (IsEven(isEvenNum)) ? $"{isEvenNum} is even" : $"{isEvenNum} is odd";
            Console.WriteLine($"{isEvenResult}");

            Console.WriteLine("Enter a number");
            int isPosNum = int.Parse(Console.ReadLine());
            string isPosResult = (IsPos(isPosNum)) ? $"{isPosNum} is positive" : $"{isPosNum} is negative";
            Console.WriteLine($"{isPosResult}");

            bool validInputCanVote;
            int canVoteAge;
            do
            {
                Console.WriteLine("Enter your age");
                validInputCanVote = int.TryParse(Console.ReadLine(), out canVoteAge);
            } while (validInputCanVote == false);
            string canVoteResult = (CanVote(canVoteAge)) ? "You're old enough to vote" : $"Come back in {18 - canVoteAge} years";
            Console.WriteLine(canVoteResult);

            bool validInputInRange;
            int inRangeNum;
            do
            {
                Console.WriteLine("Enter a number");
                validInputInRange = int.TryParse(Console.ReadLine(), out inRangeNum);
            } while (validInputInRange == false);
            string inRangeResult = (InRange(inRangeNum)) ? "Your number is between -10 and 10" : $"Your number is not in the range of -10 and 10";
            Console.WriteLine(inRangeResult);

            bool validInputMultiTable;
            int multiTableNum;
            do
            {
                Console.WriteLine("Enter a number");
                validInputMultiTable = int.TryParse(Console.ReadLine(), out multiTableNum);
            } while (validInputMultiTable== false);
            MultiTables(multiTableNum);
        }
    }
}