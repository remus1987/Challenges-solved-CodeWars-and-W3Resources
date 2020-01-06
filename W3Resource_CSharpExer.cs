using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PracticeInLab
{
    public class W3Resource_CSharpExer
    {
        #region ComputeSumOfTwo
        // Compute the sum of the two given integer values.
        //If the two values are the same, then return triple their sum.
        public int ComputeSumOfTwo(int x, int y)
        {
            if (x == y)
            {
                return (x + y) * 3;
            }
            else
            {
                return x + y;
            }
        }
        #endregion

        #region AbsoluteDifference_Nto51
        //get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference
        public int GetAbsolDifference(int n)
        {
            const int x = 51;
            if (n > 51)
            {
                return (x - n) * 3;
            }
            else
            {
                return x - n;
            }
        }
        #endregion

        #region Check_TwoIntegers
        public static bool CheckIntegers(int num1, int num2)
        {
            int sum = num1 + num2;
            if (num1 == 30 || num2 == 30 || sum == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region StringBeginWithIf
        public string BeginWithIf(string firstString)
        {
            if (firstString[0] == 'i' && firstString[1] == 'f')
            {
                return firstString;
            }
            else
            {
                return "if " + firstString;
            }
        }
        #endregion

        #region NewString_4Copy2FrontChars
        public static string CopyStringSpecificChars(string firstString)
        {
            try
            {
                return firstString.Length < 2 ? firstString : firstString.Substring(0, 2) + firstString.Substring(0, 2) + firstString.Substring(0, 2) + firstString.Substring(0, 2);
            }
            catch (ArgumentNullException)
            {
                return "Argument can't be null";
            }
            catch (ArgumentOutOfRangeException)
            {
                return "Try other argument. This one is out of range";
            }
        }
        #endregion

        #region TriangleWithStarSymbol
        public static bool CreateTriangleWithStar()
        {
            Console.WriteLine("How many number of rows do you want to print?");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numberOfRows; i++)
            {
                int starCount = 0;
                for (int j = 1; j <= numberOfRows - i; j++)
                {
                    Console.Write(" ");
                    if (i == 10)
                    {
                        i--;
                    }
                }
                while (2 * i - 1 != starCount)
                {
                    Console.Write("*");
                    starCount++;
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
            return true;
        }
        #endregion

        #region Remove_Char_At_Given_String_Position
        public static string RemoveChar(string str,int n)
        {
            return str.Remove(n, 1);
        }
        #endregion

        #region CheckIfStringStartsWithC#
        public static bool Check_StartWith(string str)
        {
            return (str.Equals("C#")) || (str.StartsWith("C#"));
        }

        #endregion

        #region Test_QualityGateC#
        public static string CategorizeBoxes(int height, int length, int width, int mass)
        {
            int volume = height * length * width;
            if (volume >= 1000000 || height >= 150 || length >= 150 || width >= 150)
            {
                if (mass >= 20)
                {
                    return "REJECTED";
                }
                else
                {
                    return "SPECIAL";
                }
            }
            else if (volume < 1000000 && height < 150 && length < 150 && width < 150)
            {
                if (mass < 20)
                {
                    return "STANDARD";
                }
                else
                {
                    return "SPECIAL";
                }
            }
            else
            {
                return "STANDARD";
            }
        }
        #endregion

        #region CheckMultiples_Of_3And7
        public static bool CheckMultiples(int number)
        {
            while (true)
            {
                if (number % 3 == 0)
                {
                    return true;
                }
                else if (number % 7 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

        #region Check_Largest_Number
        public int CheckLargestNumber(int n1, int n2, int n3)
        {
            if (n1 > n2 && n2 > n3)
            {
                return n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }
        #endregion

        #region Check_Range_OfTwoIntegers
        public bool CheckRangeOfNumbers(int n1, int n2)
        {
            if (n1 >= 40 && n1 <= 50 || n2 >= 40 && n2 <= 50)
            {
                return true;
            }
            else if (n1 >= 50 && n1 <= 60 || n2 >= 50 && n2 <= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Check_IF_yt_appears_at_Index1
        public string CheckYT (string str)
        {
            //Shorter solution with ternary operator:
            // return Substring(1,2).Equals("yt") ? str.Remove(1,2) : str;
            if (str.Substring(1, 2) == "yt")
            {
                string newString =  str.Remove(1, 2);
                return newString;
            }
            else
            {
                return str;
            } 
        }
        #endregion

        #region Nearest_To_100
        // Which number is nearest 100 from two given integers. Return 0 if are equal
        public int CheckNearestTo100(int n1, int n2)
        {
            try
            {
                if (n1 == n2)
                {
                    return 0;
                }
                else if (n1 > n2 && n1 < 100)
                {
                    Console.WriteLine("First number is closer to 100");
                    return n1;
                }
                else
                {
                    Console.WriteLine("Second number is closer to 100");
                    return n2;
                }
            }
            catch (IndexOutOfRangeException)
            {
               return int.Parse("Input has to be numbers less than or equal to 100");
            }
        }
        #endregion

        #region Check_If_Same_Last_Digit
        public bool CheckLastDigit(int n1, int n2)
        {
            int lastDigitN1 = n1 % 10;
            int lastDigitN2 = n2 % 10;
            if (n1 >= 0 && n2>= 0)
            {
                return lastDigitN1 == lastDigitN2 ? true : false;
            }
            return bool.Parse("Input only non-negative numbers");
        }
        #endregion

        #region Input_And_Swap_two_Numbers
        public void SwapTwoNumbers()
        {
            Console.WriteLine("Input first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping: ");
            Console.WriteLine("Number 1 is: " + num1);
            Console.WriteLine("Number 2 is: " + num2);
        }
        #endregion

        #region Display_Rectangle_From_A_Number
        public void DisplayRectangleFromNumber(int n)
        {
            Console.WriteLine("{0}{0}{0}", n);
            Console.WriteLine("{0} {0}", n);
            Console.WriteLine("{0} {0}", n);
            Console.WriteLine("{0} {0}", n);
            Console.WriteLine("{0}{0}{0}", n);
        }
        #endregion

        #region Hexadecimal_To_Decimal_Number
        public int ConvertToDecimal()
        {
            Console.WriteLine("Please Input a hexadecimal value: ");
            string hex = Console.ReadLine();
            int decValue = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Convert to decimal number: ");
            return decValue;
        }
        #endregion

        #region Compare_Array_Elements
        public void CompareArrayElements()
        {
            int[] arr1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("\nArr1: [{0}]", string.Join(", ",arr1));
            int[] arr2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine("\nArr2: [{0}]", string.Join(", ", arr2));
            Console.WriteLine("\nCheck if the first element or the last element of the two arrays ( length 1 or more) are equal.");
            if (arr1[0] == arr2[0] || arr1[arr1.Length - 1] == arr2[arr2.Length -1])
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        #endregion

        #region Sort_Integers_In_Ascending_Order
        // Without moving the number -5
        public static int[] Sort_Integers(int[] arry)
        {
            int[] num = arry.Where(x => x != -5).OrderBy(x => x).ToArray();
            int ctr = 0;
            return arry.Select(x => x > 0 ? num[ctr++] : -5).ToArray();
        }
        #endregion
    }
}
