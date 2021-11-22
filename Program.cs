using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            List<char> symbols_once_arr = new List<char>();
            string str = Console.ReadLine();
            char[] str_1 = new char[str.Length];
            char[] str_2 = str.ToCharArray();
            for (int i = 0; i < str.Length & str[i] != '.'; i++)
            {
                for (int j = i + 1; j < str.Length & str[i] != '.'; j++)
                {
                    if (str_2[i] == str_2[j])
                    {
                        if (str_2[i] != ' ')
                        {
                            str_1[i] = str_2[i];
                            symbols_once_arr.Add(str_1[i]);
                        }
                    }
                }
            }
            Console.WriteLine(str_1);
            string ansver = "";
            for (int i = 0; i < symbols_once_arr.Count; i++)
            {
                ansver = ansver + symbols_once_arr[i] + "\t";
            }

            Console.Write(ansver);
        }
    }
}
