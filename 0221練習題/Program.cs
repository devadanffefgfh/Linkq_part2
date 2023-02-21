using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0221練習題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的字串，並將其反向顯示");
            Console.Write("輸入: ");
            string input_str=Console.ReadLine();
            var words = input_str.Split(',').ToList();
            //var list = new List<string>();
            var count= words.Count();
            for(int i =0; i<count; i++)
            {
                words. = i;
            }
            
            
            
        }
    }
}
