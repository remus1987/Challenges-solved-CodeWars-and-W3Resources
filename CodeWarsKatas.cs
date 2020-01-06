using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace PracticeInLab
{
    public class CodeWarsKatas
    {

        #region HighestAndLowest
        public static string HighAndLow(string numbers)
        {

            var minim = int.MaxValue;
            var maxim = int.MinValue;
            foreach (var number in numbers.Split(' '))
            {
                var n = int.Parse(number);
                minim = Math.Min(minim, n);
                maxim = Math.Max(maxim, n);
            }

            // Code here or
            return maxim + " " + minim;
        }
        #endregion

        #region Replace_With_Alphabet_Position
        // In this kata you are required to,
        //given a string, replace every letter with its position in the alphabet.
        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
        #endregion

        #region Multiples_of_3_or_5
        //Your task is to write function findSum. Upto and including n,
        //this function will return the sum of all multiples of 3 and 5.
        public int findSum(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        #endregion

        #region Bit_Counting
        //Write a function that takes an integer as input, and returns the number of bits
        //that are equal to one in the binary representation of that number. You can guarantee that input is non-negative.
        public int CountBits(int n)
        {
            // base case 
            if (n == 0)
                return 0;

            else

                // if last bit set 
                // add 1 else add 0 
                return (n & 1) + CountBits(n >> 1); //shift from right to left
        }
        #endregion

        #region WeIrD_StRiNg_CaSe
        public string ToWeirdCase(string s)
        {
            //Shorter solution:
            //public static string ToWeirdCase(string s) 
            //=> String.Join(" ", s.Split(null).Select(w => new string(w.ToCharArray().Select((c, i) => i % 2 == 0 ? Char.ToUpper(c) : Char.ToLower(c)).ToArray())).ToArray());
            string word = "";
            string[] characters = s.Split(' ');
            if (String.IsNullOrWhiteSpace(s))
            {
                return s;
            }

            foreach (var item in characters)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        word += item[i].ToString().ToUpper();
                    }
                    else
                    {
                        word += item[i].ToString().ToLower();
                    }
                }
                word += " ";
            }
            return word.TrimEnd();
        }
        #endregion

        #region IQ_Test
        public static int TestIQ(string numbers)
        {
            var nums = numbers.Split(' ').Select(n => int.Parse(n));
            var isEven = nums.Count(n => n % 2 == 0) == 1;
            return nums.Select(n => n % 2 == (isEven ? 0 : 1)).ToList().IndexOf(true) + 1;
            //return 0;
        }
        #endregion

        #region YourOrderPlease
        public string Order(string words)
        {
            // Shorter solution:
            //if (string.IsNullOrEmpty(words)) return words;
            //return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));

            var input = words.Split(' ');

            var orderedWords = input.Select(w => new
            {
                Word = w,
                Order = Regex.Match(w, @"(\d)").Value
            })
            .OrderBy(p => p.Order)
            .Select(p => p.Word);
            return string.Join(" ", orderedWords);
        }
        #endregion

        #region Roman_Numerals_Encoder
        //function taking a positive integer as its parameter and returning a string
        //containing the Roman Numeral representation of that integer.
        public static string Solution(int n)
        {
            StringBuilder result = new StringBuilder();
            int[] digitsValues = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] romanDigits = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            while (n > 0)
            {
                for (int i = digitsValues.Count() - 1; i >= 0; i--)
                    if (n / digitsValues[i] >= 1)
                    {
                        n -= digitsValues[i];
                        result.Append(romanDigits[i]);
                        break;
                    }
            }
            return result.ToString();
        }
        #endregion

        #region Roman_Numerals_Decoder
        public static int DecodeRomanNum(string roman)
        {
            // Dictionary to hold our numerals and their values.
            Dictionary<char, int> RomanDictionary = new Dictionary<char, int>
            {
               {'I', 1},
               {'V', 5},
               {'X', 10},
               {'L', 50},
               {'C', 100},
               {'D', 500},
               {'M', 1000}
            };

            /* Make the input string upper-case,
           * because the dictionary doesn't support lower-case characters. */
            roman = roman.ToUpper();

            /* total = the current total value that will be returned.
             * minus = value to subtract from next numeral. */
            int total = 0, minus = 0;

            for (int i = 0; i < roman.Length; i++) // Iterate through characters.
            {
                // Get the value for the current numeral. Takes subtraction into account.
                int thisNumeral = RomanDictionary[roman[i]] - minus;

                /* Checks if this is the last character in the string, or if the current numeral
                 * is greater than or equal to the next numeral. If so, we will reset our minus
                 * variable and add the current numeral to the total value. Otherwise, we will
                 * subtract the current numeral from the next numeral, and continue. */
                if (i >= roman.Length - 1 ||
                    thisNumeral + minus >= RomanDictionary[roman[i + 1]])
                {
                    total += thisNumeral;
                    minus = 0;
                }
                else
                {
                    minus = thisNumeral;
                }
            }

            return total; // Return the total.
        }
        #endregion

        #region LoveVsFriendship
        public int WordsToMarks(string str)
        {
            //Shorter solution and implemented:
            //return str.Where(c => char.IsLetter(c)).Sum(c => char.ToUpperInvariant(c) - 64);

            Dictionary<char, int> dict = new Dictionary<char, int>
            {
                {'a', 1 }, {'b', 2 }, {'c', 3 }, {'d', 4 }, {'e', 5 }, {'f', 6 }, {'g', 7 }, {'h', 8 }
                , {'i', 9 }, {'j', 10 }, {'k', 11 }, {'l', 12 }, {'m', 13 }, {'n', 14 }, {'o', 15 }, {'p', 16 }
                , {'q', 17 }, {'r', 18 }, {'s', 19 }, {'t', 20 }, {'u', 21 }, {'v', 22 }, {'w', 23 }, {'x', 24 }, {'y', 25 }, {'z', 26 }
            };
            int sum = 0;
            foreach (char item in str)
            {
                foreach (var d in dict)
                {
                    if (item == d.Key)
                    {
                        sum += d.Value;
                    }
                }
            }
            return sum;

        }
        #endregion

        #region VasyaClerk_DollarChange
        public static string Tickets(int[] peopleInLine)
        {
            //Each of them has a single 100, 50 or 25 dollar bill. Ticket costs 25 dollars.
            //Sell a ticket to every single person in this line.
            //Return YES, if Vasya can sell a ticket to every person and give change with the bills
            //he has at hand at that moment. Otherwise return NO?
            int dollar25 = 0;
            int dollar50 = 0;
            int dollar100 = 0;
            for (int i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] == 100)
                {
                    if (dollar25 > 0 && dollar50 > 0)
                    {
                        dollar100++;
                        dollar50--;
                        dollar25--;
                    }
                    else if (dollar25 > 2)
                    {
                        dollar100++;
                        dollar25 -= 3;
                    }
                    else
                    {
                        return "NO";
                    }
                }
                if (peopleInLine[i] == 25)
                {
                    dollar25 = dollar25 + 1;
                }
                if (peopleInLine[i] == 50)
                {
                    if (dollar25 > 0)
                    {
                        dollar50++;
                        dollar25--;
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }
            return "YES";
        }
        #endregion

        #region Categorize_New_Member

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        // Short Solution:
        // => data.Select(x => { return (x[0] >= 55 && x[1] > 7) ? "Senior" : "Open"; });

        {
            var category = new List<string>();
            foreach (int[] member in data)
            {
                if (member[0] >= 55 && member[1] > 7)
                {
                    category.Add("Senior");
                }
                else
                {
                    category.Add("Open");
                }
            }
            return category;
        }
        #endregion

        #region PigLatin
        public static string PigIt(string str)
        {
            // Move the first letter of each word to the end of it, then add "ay" to 
            //the end of the word. Leave punctuation marks untouched
            return string.Join(" ", str.Split(' ').ToList().Select(x =>
            x.Substring(1, x.Length - 1) + x.Substring(0, 1) + "ay"));

            //Long solution raw C#

            //var words = str.Split(' ');
            //string rev = "";
            //foreach (var w in words)
            //{
            //    var frstLetter = w[0];
            //    var otherLetter = w.Substring(1);
            //    string newWord;
            //    if (w.Length == 1)
            //        newWord = w + "ay ";
            //    else
            //    {
            //        newWord = otherLetter + frstLetter + "ay" + " ";
            //    }
            //    rev += newWord;
            //}
            //rev = rev.TrimEnd();
            //return rev;
        }
        #endregion

        #region Descending_Order
        //Shorter 2 solutions :
        // char[] descending = num.ToString().OrderByDescending(x => x).ToArray();
        // return int.Parse(new string (descending));

        //return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));

        // Using proper Exception Handling as well
        public static int DescendingOrder(int num)
        {
            try
            {
                var digits = new List<int>();

                // Bust a move right here
                try
                {
                    for (; num != 0; num /= 10)
                    {
                        digits.Add(num % 10);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error has occured. Invalid input detected. Program will now terminate");
                }


                var arr = digits.ToArray();
                Array.Reverse(arr);

                Array.Sort(arr, (x, y) => y.CompareTo(x));

                int final_num = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    final_num += arr[i] * Convert.ToInt32(Math.Pow(10, arr.Length - i - 1));
                }
                return final_num;
            }
            catch (Exception)
            {
                Console.WriteLine("Error occured. Invalid input detected. Program will now terminate...");
                return 0;
            }
        }
    #endregion

        #region Find_The_Parity_Outlier
        public static int Find(int[] integers)
        {
            //Shorter solution:
            //return (integers.Where(x => x % 2 != 0).Count() == 1) ? integers.Where(x => x % 2 != 0).First() : integers.Where(x => x % 2 == 0).First();

            int evenCount = 0;
            int oddCount = 0;
            int evenN = 0;
            int oddN = 0;
            foreach (int integer in integers)
            {
                if (integer % 2 == 1)
                {
                    oddCount++;
                    oddN = integer;
                }
                else
                {
                    evenCount++;
                    evenN = integer;
                }
            }
            return (oddCount > evenCount) ? evenN : oddN;
        }
        #endregion
    }
}
