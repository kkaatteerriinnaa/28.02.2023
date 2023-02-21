using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        delegate void Delarr(int[] arr);
        delegate void Text(string message);
        static void Main(string[] args)
        {
            Random n = new Random();
            string S = "String Int";
            string s = "Int";
            Delarr seven = (int[] arr) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = n.Next(1,100);
                    if (arr[i] % 7 == 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            };
            Delarr possitive = (int[] arr) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = n.Next(-100, 100);
                    if (arr[i] > 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            };
            Delarr negative = (int[] arr) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = n.Next(-100, 1);
                    if (arr[i] != arr[i+1])
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            };
            Text obj = delegate (string message)
            {
                if (s == S)
                {
                    Console.WriteLine("Есть слово " + s);
                }
            };
        }
    }
}
