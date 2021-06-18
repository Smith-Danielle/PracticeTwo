using System;
using System.Collections.Generic;

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

        //static void Main(string[] args)
        //{


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

        /* Continue practice
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)

                continue;
                Console.WriteLine(i);
        }*/

        /* Lists practice
        List<int> name = new List<int>();
        for (int i = 0; i < 50; i++)
        {
            name.Add(i);
        }
        foreach (int num in name)
        {
            Console.WriteLine(num);
        }
        name.Remove(name[4]);
        foreach (int num in name)
        {
            Console.WriteLine(num);
        }*/
        /* CodeWars
        Average double[] name = new double[] { 2, 3, 7, 6 };
        Console.WriteLine(FindAverage(name));

    }
    public static double FindAverage(double[] array)
    {
        double sum = 0;
        if (array.Length > 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum = array[i] + sum;
            }
            return sum / array.Length;
        }
        else
        {
            return 0;
        }
    }
        static void Main(string[] args)
        {
            string[] names = new string[] { "danielle", "doesnt", "like", "eggs" };
            Console.WriteLine(Smash(names));
        }
        public static string Smash(string[] words)
        {
            string combine = string.Join(" ", words);
            return combine;

        }

        static void Main(string[] args)
        {

        }
        public static float Combat(float health, float damage)
        {
            var healthNew = health - damage;
            if (healthNew > 0)
            {
                return healthNew;
            }
            else
            {
                return 0;
            }

                
        }
        static void Main(string[] args)
        {
            string names = "3.50 like eggs";
            Console.WriteLine(IsLockNessMonster(names));
        }
        public static bool IsLockNessMonster(string sentence)
        {
           
            if (sentence.ToLower().Contains("tree fiddy") == true)
            {
                return true;
            }
            else if (sentence.ToLower().Contains("three fifty") == true)
            {
                return true;
            }
            else if (sentence.Contains("3.50") == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        /*static void Main(string[] args)
        {
            
        }
        public static class SpacesRemover
        {
            public static string NoSpace(string input)
            {
                input = input.Replace(" ", "");
                return input;
            }
        }*/
        /* CodeWars
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatStr(3, "Danielle"));
        }
        public static string RepeatStr(int n, string s)
        {
            string newString = "";
            for (int i = 0; i < n; i++)
            {
                newString += s;
            }
            return newString;
        }*/
        /* SoloLearn Lesson 23
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            int[] threes = new int[number];
            for (int i = 0; i < threes.Length; i++)
            {
                threes[i] = i + 1;
            }
            foreach (int num in threes)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }*/

    }
}



