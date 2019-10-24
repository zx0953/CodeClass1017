using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GusseNumber
    {
        int guess = -1;
        int intputNum = 0;

        public void gusseNumPlay()        
        {
            
            try
            {
                guess = new Random().Next(9);
                Console.WriteLine("0~9 猜一個數字");
                while (true)
                {
                    string inputStr = Console.ReadLine();
                    int intputNum = Int32.Parse(inputStr);
                    Int32.TryParse(inputStr,out intputNum);
                    if (guess == intputNum) 
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("猜錯了");
                    }
                }
                Console.WriteLine("恭喜 恭喜 猜對了");
                Console.ReadKey();

            }
            catch(Exception exp)
            {

                Console.WriteLine(exp);
                throw;
            }
            
        }
    }
}
