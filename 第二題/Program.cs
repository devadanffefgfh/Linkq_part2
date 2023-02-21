using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入:");
            var input = Console.ReadLine();
           
            var odd_num = input.Split(',').Where(x => int.Parse(x) % 2 != 0).OrderBy(x=> int.Parse(x));
            List<int> list2 = new List<int>();
            var even_num = input.Split(',').Where(x => int.Parse(x) % 2 == 0).OrderBy(x => int.Parse(x));
            var n =1;
            foreach (var x in odd_num)
            {
                Console.Write(x);
                if(n<odd_num.Count())
                {
                    Console.Write(",");
                }
                n++;
                
            }
            Console.WriteLine();
            n = 1;
            foreach (var x in even_num)
            {
                Console.Write(x);
                if(n<even_num.Count())
                {
                    Console.Write(",");
                }
                n++;
            }
        }
    }
}
