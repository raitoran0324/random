using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            // 將所有號碼放入list中
            List<int> numbers = new List<int>();

            for(int i = 1 ; i <= 42 ; i++)
            {
                numbers.Add(i);
            }

            // 產生亂數物件
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                // 隨機挑選"剩下的"顯示
                int r = rand.Next(1, numbers.Count);
                Console.WriteLine(numbers[r] + " ");

                // 從list刪除
                numbers.RemoveAt(r);
            }
                
            // 防止視窗自動關閉
            Console.ReadLine();
        }
    }
}
