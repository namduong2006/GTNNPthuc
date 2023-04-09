using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTNNPThuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Số phần tử của mảng là :");
            n=int.Parse(Console.ReadLine());
            int[] list1 = new int [n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập giá trị của phần tử thứ {i}");
                list1[i] = int.Parse(Console.ReadLine());
             }
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Dãy vừa nhập:");
            for (int i=0; i<n;i++)
            { Console.Write(  list1[i] + "  " ); }
            int a = MinValue(list1);
            Console.WriteLine();
            Console.WriteLine($"Vị trí giá trị nhỏ nhất là {a+1} và có giá trị là {list1[a]}");
            Console.ReadLine();
        }
        public static int MinValue(int[]list)
        {
            int min = list[0];
            int t = 0;
            for (int i = 1; i < list.Length; i++)
            {
                if (min > list[i])
                {
                    min = list[i];
                    t = i;
                }
            }
            return t;
            

        }
    }
}
