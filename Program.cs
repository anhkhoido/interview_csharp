using studycsharp.Model;
using studycsharp.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studycsharp.Event;

namespace studycsharp
{
    class Program
    {
        /// <summary>
        /// The main method.
        /// </summary>
        /// <param name="args">The argument provided by the user at the command line.</param>
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5 };

            ShuffleArray(arr);

            foreach (int i in arr) Console.WriteLine(i);

            SelectionSort(arr);

            Console.WriteLine();
            foreach (int i in arr) Console.WriteLine(i);

            // This will keep the program open until you press any key.
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();
        }

        /// <summary>
        /// This method verifies if the number
        /// you provided as an argument is
        /// an Armstrong number.
        /// </summary>
        /// <param name="n">The number you want to analyze</param>
        /// <returns>The boolean analysis.</returns>
        public static Boolean IsArmstrongNumber(int n)
        {
            int numberBeingAnalyzed = n;
            int sumOfAllDigits = 0;
            int currentDigitBeingAnalyzed = 0;

            do
            {
                currentDigitBeingAnalyzed = numberBeingAnalyzed % 10;
                sumOfAllDigits = sumOfAllDigits + (int) Math.Pow((double)currentDigitBeingAnalyzed, 3.0);
                numberBeingAnalyzed = numberBeingAnalyzed / 10;
            } while (numberBeingAnalyzed != 0);

            return sumOfAllDigits == n;
        }

        /// <summary>
        /// This method reverses the order in which
        /// the digits of a number appear.
        /// </summary>
        /// <param name="number">The number being analyzed.</param>
        /// <returns>The version of the number with reversed digits.</returns>
        public static int ReverseDigitsOf(int number)
        {
            int reversedNumber = 0;
            int numberBeingAnalyzed = number;
            int currentDigits = 0;

            do
            {
                currentDigits = numberBeingAnalyzed % 10;
                reversedNumber = reversedNumber * 10 + currentDigits;
                numberBeingAnalyzed = numberBeingAnalyzed / 10;
            } while (numberBeingAnalyzed != 0);

            return reversedNumber;
        }

        /// <summary>
        /// This method reverses the order in which
        /// the digits of an array of type integer
        /// appears.
        /// </summary>
        /// <param name="arr">An array of integers.</param>
        /// <returns>The reversed version of that array of integers.</returns>
        public static int[] ReverseDigitsOf(int[] arr)
        {
            int[] secondArr = new int[arr.Length];

            for (var i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                secondArr[arr.Length - 1 - i] = temp;
            }

            return secondArr;
        }

        /// <summary>
        /// This method shuffles the integers within an array.
        /// </summary>
        /// <param name="arr">The array of integers.</param>
        public static void ShuffleArray(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                int swapIdx = new Random().Next(arr.Length);
                int temp = arr[i];
                arr[i] = arr[swapIdx];
                arr[swapIdx] = temp;
            }
        }

        /// <summary>
        /// This method of type String reverses
        /// the order of appearances for letters from
        /// a String you pass on as a parameter.
        /// </summary>
        /// <param name="word">The String before it is reversed.</param>
        /// <returns>The reversed version of the String you passed as a parameter.</returns>
        public static String ReverseRecursivelyLettersOf(String word)
        {
            return word.Length == 1 ? word : ReverseRecursivelyLettersOf(word.Substring(1)) + word[0];
        }

        /// <summary>
        /// This method iteratively reverses the order of appearance
        /// for the lettes of a String.
        /// </summary>
        /// <param name="word">The word you want to change.</param>
        /// <returns>The reversed version of a String.</returns>
        public static String ReverseIterativelyLettersOf(String word)
        {
            String reversedStr = String.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedStr += word[i];
            }

            return reversedStr;
        }

        /// <summary>
        /// This boolean method verifies if the word
        /// you pass as an argument of type String
        /// is an anagram.
        /// </summary>
        /// <param name="word">The word you analyze.</param>
        /// <returns>The boolean condition.</returns>
        private static Boolean IsAnagram(String word)
        {
            String reversedWord = String.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            return word.Equals(reversedWord);
        }

        /// <summary>
        /// This method takes the name of a file
        /// and reveals its extension. If a file's name
        /// contains two dots, the extension's name will
        /// be the last word that follows the second dot.
        /// </summary>
        /// <param name="fileName">The file's name.</param>
        /// <returns>The extension of the file.</returns>
        private static String RevealExtensionOfFile(String fileName)
        {
            String[] arrOfWords = fileName.Split('.');
            return arrOfWords[arrOfWords.Length - 1];
        }

        /// <summary>
        /// This method returns the product of factorials.
        /// </summary>
        /// <param name="n">The number of factorials.</param>
        /// <returns>The product of the multiplications.</returns>
        public static int CalculateFactorialRecursively(int n)
        {
            return n == 1 ? n : CalculateFactorialRecursively(n - 1) * n;
        }

        /// <summary>
        /// This method returns the product of factorials.
        /// </summary>
        /// <param name="n">The number of factorials.</param>
        /// <returns>The product of the multiplications.</returns>
        public static int CalculateFactorialIteratively(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++) result *= i;

            return result;
        }

        /// <summary>
        /// This method performs the selection sort.
        /// </summary>
        /// <param name="arr">The array of integers.</param>
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = i;
                
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[currentElement])
                    {
                        int temp = arr[currentElement];
                        arr[currentElement] = arr[j];
                        arr[j] = temp;
                    }    
                }
            }
        }

    }
}
