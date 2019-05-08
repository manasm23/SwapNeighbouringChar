using System;
using System.Text;

namespace SwapNeighborChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string to swap neighbouring characters: ");
            string input = Console.ReadLine();
            Console.WriteLine("Result string: " + SwapNeighbourChar(input));
            Console.ReadLine();
        }

        public static string SwapNeighbourChar(string strToSwap)
        {
            char[] arraStr = strToSwap.ToCharArray();
            StringBuilder strbuild = new StringBuilder();
            for (int i = 0; i <= arraStr.Length - 1; i++)
            {
                if (i != arraStr.Length - 1)
                {
                    strbuild.Append(arraStr[i + 1]);
                }
                strbuild.Append(arraStr[i]);
                i += 1;
            }
            return strbuild.ToString();
        }
    }
}
