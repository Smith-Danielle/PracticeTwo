using System;

namespace PracticeTwo
{
    class Program
    {
        /*Practicing Methods
        public static string Add(int one, int two)
        {
            if (one < two)
            {
                return "Your 2nd number is the largest";
            }
            else
            {
                return "Your 1st number is the largest";
            }
            


        }

        static void Main(string[] args)
        {
            string name = Add(1, 2);
            Console.WriteLine(name);

       
       public static int Add(int one, int two)
       {
            return one + two;



       }

       static void Main(string[] args)
       {
           int name = Convert.ToInt32(Add(1, 2));
           Console.WriteLine(name);*/

        static void Main(string[] args)
        {


            /*Practicing Selection Statements if else if switch
            Console.WriteLine("Try to guess my favorite number.");
            Console.WriteLine("Enter your first guess to begin.");

            string guess = Console.ReadLine();
            var myNum = 8;
            string statement = "help";

            do
            {
                if (guess == statement)
                {
                    Console.WriteLine("Lower than 50, but higher than 5.");
                }
                else if (Convert.ToInt32(guess) >= 1000)
                {
                    Console.WriteLine("Way too high!!");
                    Console.WriteLine("Consider typing 'help' to get a hint.");
                }
                else if (Convert.ToInt32(guess) >= 13)
                {
                    Console.WriteLine("Try reducing your number!");
                }
                else if (Convert.ToInt32(guess) <= 12 && Convert.ToInt32(guess) >= 9)
                {
                    Console.WriteLine("You are really close! A little lower.");
                }
                else if (Convert.ToInt32(guess) <= 7 && Convert.ToInt32(guess) >= 4)
                {
                    Console.WriteLine("You are really close! A little higher.");
                }
                else if (Convert.ToInt32(guess) <= 3)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Excellent! You guessed my favorite number!!");
                    break;
                }

                Console.WriteLine("Enter your next guess:");
                guess = Console.ReadLine();

               switch (guess)
                {
                    case "help" :
                        break;
                    case "8":
                        Console.WriteLine("Excellent! You guessed my favorite number!!");
                        break;
                }


            }
            while (guess == statement || Convert.ToInt32(guess) != myNum);*/

            /* array assignment
             int[] num = new int[5];

             num[0] = 10;

             foreach (int dan in num)
             {
                 Console.WriteLine(dan);
             }*/

            
        }

        
    }

}
