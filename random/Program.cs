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

            Console.ReadLine();
        }
    }
}
