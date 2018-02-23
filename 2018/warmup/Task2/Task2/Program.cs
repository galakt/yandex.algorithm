using System;
using System.IO;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(GetPalindrome(input));
        }
        public static char[] GetPalindrome(string input2)
        {
            var inputArray = input2.ToCharArray();
            char[] result = null;

            for (int len = 2; len <= 3; len++)
            {
                for (int i = 0; i <= inputArray.Length - len; i++)
                {
                    if (IsPol(inputArray, i, len))
                    {
                        if (result == null)
                        {
                            result = new char[len];
                            Array.Copy(sourceArray: inputArray, sourceIndex:i, destinationArray: result, destinationIndex: 0, length: len);
                        }
                        else
                        {
                            for (int j = 0; j <= result.Length/2; j++)
                            {
                                if (result[j] > inputArray[i + j])
                                {
                                    Array.Copy(sourceArray: inputArray, sourceIndex: i, destinationArray: result, destinationIndex: 0, length: len);
                                    break;
                                }
                                else if (result[j] == inputArray[i + j])
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }

                if (result != null)
                {
                    break;
                }
            }
            
            if (result == null)
            {
                return new char[]{'-', '1'};
            }
            else
            {
                return result;
            }
        }

        public static bool IsPol(char[] input, int start, int len)
        {
            for (int i = 0; i < len / 2; i++)
            {
                var currentInputChar = input[start + i];
                if (currentInputChar != input[start + len - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
