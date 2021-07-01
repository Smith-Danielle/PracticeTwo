using System;
using System.Collections.Generic;
using System.Linq;

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
        /* CodeWars
        static void Main(string[] args)
        {
            Console.WriteLine(OddCount(7));
        }
        public static ulong OddCount(ulong n)
        {
            //This works but CodeWars didnt like it!!!!!!!!!!!!
            List<ulong> odds = new List<ulong>();
            
            
            for (ulong i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                  odds.Add(i);
                }
            }
            ulong oddsAnswer = Convert.ToUInt64(odds.Count);
            return oddsAnswer;

            //But they want this one! 
            return n / 2;

        }*/
        /* CodeWars
        static void Main(string[] args)
        {
            Console.WriteLine(MakeNegative(-5));
            Console.WriteLine(MakeUpperCase("until"));
            Console.WriteLine(ReverseSeq(8));
            object[] myArray = new object[] { "danielle", "danica", "marrissa", "smith" };
            object[] numbers = new object[] { 1, 2, 3, 4, 5 };
            object[] chars = new object[] { 'a', '2', '3', 'h', 'y' };
            Console.WriteLine(Check(myArray, "danielle"));
            Console.WriteLine(Check(numbers, 5));
            Console.WriteLine(Check(chars, '1'));
        }
        public static int MakeNegative(int number)
        {
            int answer;
            if (number > 0)
            {
                answer = number - number - number;
                return answer;
            }
            else
            {
                return number;
            }

        }
        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }
        public static int[] ReverseSeq(int n)
        {
            int[] numArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                numArray[i] = i + 1;
            }
            Array.Reverse(numArray);
            return numArray;

        }
        public static bool Check(object[] a, object x)
        {
            List<object> newList = new List<object>();
            foreach (object item in a)
            {
                newList.Add(item);
            }
            return newList.Contains(x);

            
            
        }*/
        /* Classes practice 
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Subaru";
            myCar.Model = "BRZ";
            myCar.Year = 2018;

            Car hisCar = new Car()
            {
                Make = "Mercedes",
                Model = "C350",
                Year = 2008
            };

            Car herCar = new Car() { Make = "Chevy", Model = "Camaro", Year = 2000 };

            Car theirCar = new Car("Ford", "Focus", 2020);

            myCar.StateCar();
            hisCar.CarAge(2021);
        }*/
        /*static void Main(string[] args)
        {
            Console.WriteLine(Remove_char("Danielle"));
            Console.WriteLine(NumberToString(1230));
            bool[] sheepCount = new bool[] { true, true, true, false, true, true, true, true, true, false, true, false, true, false, false, true, true, true, true, true, false, false, true, true };
            Console.WriteLine(CountSheeps(sheepCount));
            Console.WriteLine(Quote("Conor McGregor"));
        }
        public static string Remove_char(string s)
        {
            
            string sNew = s.Remove(s.Length - 1);
            string sNewest = sNew.Remove(0, 1);
            return sNewest;
        }
        public static string NumberToString(int num)
        {
            string intString = Convert.ToString(num);
            return intString;
        }
        public static int CountSheeps(bool[] sheeps)
        {
            List<int> trueSheep = new List<int>();
            foreach (bool sheep in sheeps)
            {
                if (sheep == true)
                {
                    trueSheep.Add(1);
                }
            }
            return trueSheep.Count;
        }
        public static string Quote(string fighter)
        {
            string fighterFinal = fighter.ToLower();
            if (fighterFinal == "George Saint Pierre")
            {
                return "I am not impressed by your performance.";
            }
            else 
            {
                return "I'd like to take this chance to apologize.. To absolutely NOBODY!";
            }
           
        */
        /* CodeWars
        static void Main(string[] args)
        {
            Console.WriteLine(NthEven(100));
        }
        public static int NthEven(int n)
        {
            int[] numbers = new int[n * 2];
            for (int i = 0; i < n * 2; i++)
            {
                if (i % 2 == 0 )
                {
                    numbers[i] = i;
                    
                }
                
            }
            return numbers[n + 1];
        }*/
        /* SoloLearn Recursion
        static int Points(int levels)
        {

            if (levels == 1)
            {
                return 1;
            }
            
                return levels + Points(levels - 1);
            
            
        }
        static void Main(string[] args)
        {

            int levels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Points(levels));
        }*/
        /*static void Main(string[] args)
        {
            Car danielle = new Car();
            danielle.Name = "Smith";

        }*/
        /* SoloLearn 
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }*/
        /*CodeWars
        static void Main(string[] args)
        {
            /*string[] websites = new string[1000];
            for(int i = 0; i < 1000; i++)
            {
                websites[i] = "codewars";

            }
            foreach (var items in websites)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine(websites.Length);

        }*/
        /*CodeWars
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
        }
        public static int Solution(int value)
        {
            List<int> numbers = new List<int>();
            int sum = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    numbers.Add(i);
                    
                }
            }
            foreach (int item in numbers)
            {
                sum += item;
            }
            return sum;
        }*/

        /* SoloLearn
        static void Main(string[] args)
        {
            string name = "Danielle";
            string newName = name.Insert(1, "Hello, My name is");
            Console.WriteLine(newName);
        }*/
        /* SoloLearn
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(letter))
                {
                    count++;
                    Console.WriteLine(words[i]);

                }
                
            }
            if (count == 0)
            {
                Console.WriteLine("No match");
            }

        }*/
        //CodeWars
        /*static void Main(string[] args)
        {
            //int[] array = new int[] { 0, 1, 1, 1, 2, 1, 2, 0, 9, 1, 8, 2, 0 };
            //Console.WriteLine(MoveZeroes(array));
            string dan = "12";
            string smi = "3";
            Console.WriteLine(sumStrings(dan, smi));
            
        }
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> numbers = new List<int>();
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    numbers.Add(item);

                }
            }
            foreach (var item in arr)
            {
                if (item == 0)
                {
                    numbers.Add(item);

                }
            }
            var newArray = numbers.ToArray();

            return newArray;
        }
        public static string sumStrings(string a, string b)
        {
            int num = Convert.ToInt32(a);
            int num1 = Convert.ToInt32(b);
            int sum = num + num1;
            
           
            return sum.ToString();
        }*/
        /* Codewars / SoloLearn
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCount("abracadabra"));
            Interpret("9");
            Console.WriteLine(Math.Sqrt(9));
            string name = "danielle";
            string last = " smith not hall";
            Console.WriteLine(String.Concat(name, last));
            char index = name[4];

        }
        public static int PositiveSum(int[] arr)
        {
            int postives = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    postives += item;
                }
            }
            return postives;
        }
        public static int GetVowelCount(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    count++;
                }

            }
            return count;

        }
        public static void Interpret(string code)
        {

            if (code == "H")
            {
                Console.WriteLine("Hello World");
            }
            else if (code == "Q")
            {
                Console.WriteLine("Q");
            }
            else if (code == "9")
            {
                for (int i = 99; i > 1; i--)
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.

                        $"Take one down and pass it arround, {i - 1} bottles of beer on the wall.");
                }
                Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer. n/" +
                        "Take one down and pass it arround, no more bottles of beer on the wall. n/" +
                        "No more bottles of beer on the wall, no more bottles of beer. n/" +
                        "Go to the store and buy some more, 99 bottles of beer on the wall.");
            }


        }*/
        /*Codewars find the differnt int.
        public static int Find(int[] integers)
        {
            int answer1 = 0;
            int answer2 = 0;
            int evenCount = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    evenCount++;
                }
            }
            if (evenCount == 1)
            {
                foreach (var item in integers)
                {
                    if (item % 2 == 0)
                    {
                        answer1 = item;
                    }
                }
            }
            else
            {
                foreach (var item in integers)
                {
                    if (item % 2 != 0)
                    {
                        answer2 = item;
                    }
                }
            }
            return Math.Max(answer1, answer2);
        }*/
        /* CodeWars
        static void Main(string[] args)
        {
            Console.WriteLine(Disemvowel("Hello, my name is Danielle."));
            Console.WriteLine(Solution("Danielle"));
        }
        public static string Disemvowel(string str)
        {
            
            string newString = "";
           
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != 'a' && str[i] != 'e' && str[i] != 'i' && str[i] != 'o' && str[i] != 'u' && str[i] != 'A' && str[i] != 'E' && str[i] != 'I' && str[i] != 'O' && str[i] != 'U')
                {
                    newString += str[i];
                }
            }
            return newString;
        }
        public static string Solution(string str)
        {
            string newString = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
                newString += str[i];
            }
            return newString;
        }
        public static bool IsSquare(int n)
        {
            if (n < 0)
            {
                return false;
            }
            double answer = Math.Sqrt(n);
            if (n % 1 == 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }*/

        /* Codewars
        public static string SquareDigits(int n)
        {
            string newN = Convert.ToString(n);
            string numbers = "";
            for (int i = 0; i < newN.Length; i++)
            {
                char indexing = newN[i];
                int convert = int.Parse(indexing.ToString());
                numbers += (convert * convert);
            }
            return numbers;



        }
        public static int PositiveSum(int[] arr)
        {
            var numbers = arr.Where(digits => digits > 0).Sum();
            return numbers;
        }
        public static List<int> Odds(List<int> values)
        {
            var odds = values.Where(num => (num % 2) != 0);
            List<int> answer = odds.ToList();
            return answer;
        }
        public static string HighAndLow(string numbers)
        {
            List<char> numList = new List<char>();
            foreach (var item in numbers)
            {
                numList.Add(item);
            }
            numList.Sort();
            var highest = numList[numList.Count - 1];
            var lowest = numList[0];
            string max = Convert.ToString(highest);
            string min = Convert.ToString(lowest);
            return $"{max} {min}";
        }
        static void Main(string[] args)
        {
            int[] newOne = new int[] { 1, 2, 3, 4, 5, 6, 8, 9 };
            Console.WriteLine(FirstNonConsecutive(newOne));

        }
        public static object FirstNonConsecutive(int[] arr)
        {
            object findNon = arr.Find(1, 0) 

        }*/
        /* Codewars
        static void Main(string[] args)
        {
            var squares = Enumerable.Range(1, 100).Average(x => x * x);
            Console.WriteLine(squares);
            Console.WriteLine(AlphabetPosition("My name is Danielle"));
        }

        public static double basicOp(char operation, double value1, double value2)
        {
            double answer = 0;
            if (operation == '+')
            {
                answer = value1 + value2;
            }
            else if (operation == '-')
            {
                answer = value1 - value2;
            }
            else if (operation == '*')
            {
                answer = value1 * value2;
            }
            else if (operation == '/')
            {
                answer = value1 / value2;
            }
            else if (operation == '%')
            {
                answer = value1 % value2;
            }
            return answer;
        }
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            var num = numbers.Take(2).Sum();
            return num;


        }
        public static string AlphabetPosition(string text)
        {
            string answer = string.Empty;
            string lower = text.ToLower();
            foreach (var item in lower)
            {
                if (item == 'a')
                {
                    answer += '1';
                    answer += ' ';
                }
                else if (item == 'b')
                {
                    answer += '2';
                    answer += ' ';
                }
                else if (item == 'c')
                {
                    answer += '3';
                    answer += ' ';
                }
                else if (item == 'd')
                {
                    answer += '4';
                    answer += ' ';
                }
                else if (item == 'e')
                {
                    answer += '5';
                    answer += ' ';
                }
                else if (item == 'f')
                {
                    answer += '6';
                    answer += ' ';
                }
                else if (item == 'g')
                {
                    answer += '7';
                    answer += ' ';
                }
                else if (item == 'h')
                {
                    answer += '8';
                    answer += ' ';
                }
                else if (item == 'i')
                {
                    answer += '9';
                    answer += ' ';
                }
                else if (item == 'j')
                {
                    answer += '1';
                    answer += '0';
                    answer += ' ';
                }
                else if (item == 'k')
                {
                    answer += '1';
                    answer += '1';
                    answer += ' ';
                }
                else if (item == 'l')
                {
                    answer += '1';
                    answer += '2';
                    answer += ' ';
                }
                else if (item == 'm')
                {
                    answer += '1';
                    answer += '3';
                    answer += ' ';
                }
                else if (item == 'n')
                {
                    answer += '1';
                    answer += '4';
                    answer += ' ';
                }
                else if (item == 'o')
                {
                    answer += '1';
                    answer += '5';
                    answer += ' ';
                }
                else if (item == 'p')
                {
                    answer += '1';
                    answer += '6';
                    answer += ' ';
                }
                else if (item == 'q')
                {
                    answer += '1';
                    answer += '7';
                    answer += ' ';
                }
                else if (item == 'r')
                {
                    answer += '1';
                    answer += '8';
                    answer += ' ';
                }
                else if (item == 's')
                {
                    answer += '1';
                    answer += '9';
                    answer += ' ';
                }
                else if (item == 't')
                {
                    answer += '2';
                    answer += '0';
                    answer += ' ';
                }
                else if (item == 'u')
                {
                    answer += '2';
                    answer += '1';
                    answer += ' ';
                }
                else if (item == 'v')
                {
                    answer += '2';
                    answer += '2';
                    answer += ' ';
                }
                else if (item == 'w')
                {
                    answer += '2';
                    answer += '3';
                    answer += ' ';
                }
                else if (item == 'x')
                {
                    answer += '2';
                    answer += '4';
                    answer += ' ';
                }
                else if (item == 'y')
                {
                    answer += '2';
                    answer += '5';
                    answer += ' ';
                }
                else if (item == 'z')
                {
                    answer += '2';
                    answer += '6';
                    answer += ' ';
                }
            
                
            }
            var newAnswer = answer.Remove(answer.Length - 1);
            return answer;
        }
        public static string AlphabetPosition(string text)
        {
            string lower = text.ToLower();
            string alpha = " abcdefghijklmnopqrstuvwxyz";
            string newString = string.Empty;
            foreach (var item in text)
            {
                var index = alpha.IndexOf(item);
                if (index > -1)
                {
                    newString += index;
                }
            }
            
            return newString;
        }*/
        //Unique In Order
        /* CodeWars
        public static bool Solution(string str, string ending)
        {
            bool answer = str.EndsWith(ending);
            return answer;
        }
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var newList = new List<T>();
            foreach (var item in iterable)
            {
                if (newList.Count == 0 || !newList.Last().Equals(item))
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Hello World !"));
        }
        public static string PigIt(string str)
        {
            List<string> temp = new List<string>();
            List<string> lastPart = new List<string>();
            List<string> allTogether = new List<string>();
            var strNew = str.Split(" ");
            foreach (var item in strNew)
            {
                temp.Add(item.Substring(0, 1));
                lastPart.Add(item.Substring(1));

                allTogether.Add(String.Concat(lastPart.Last(), temp.Last()));
            }
            List<string> final = new List<string>();
            foreach (var item in allTogether)
            {
                if (item == "!" || item == "." || item == "?")
                {
                    final.Add(item);
                }
                else
                {
                    final.Add(item.Insert(item.Length, "ay"));
                }
            }
            
            //var newString = allTogether.Select(item => item.Insert(item.Length, "ay"));
            var answerString = string.Join(" ", final);

            
            return answerString;
            
        }
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            List<string> newString= new List<string>();
            
            foreach (var item in birds)
            {
                if (item != "African" || item != "Roman Tufted" || item != "Toulouse" || item != "Pilgrim" || item != "Steinbacher")
                {
                    newString.Add(item);
                }
            }
            return newString;
        }*/
        /* CodeWars
        static void Main(string[] args)
        {
            FindShort("Danielle danica Marrissa smith");
        }

        public static void HighAndLow(string numbers)
        {
            var newString = numbers.Split(" ");
            List<int> num = new List<int>();
            foreach (var item in newString)
            {
                num.Add(Convert.ToInt32(item));

            }
            var max = num.Max();
            var min = num.Min();
            Console.WriteLine($"{max} {min}");
           
            
            

                }
        public static void FindShort(string s)
        {
            var newString = s.Split(" ");
            var sorted = newString.OrderBy(item => item.Length);
            var first = sorted.First().Count();

                Console.WriteLine(first);
            
        }*/

    }
}



