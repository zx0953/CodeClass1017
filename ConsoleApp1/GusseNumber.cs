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
                    if (Int32.TryParse(inputStr, out intputNum))
                    {
                        if(intputNum <= 9 && intputNum >= 0)
                        {
                            if (guess == intputNum)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("猜錯了");
                            }
                        }
                        else { Console.WriteLine("0~9啦 艮!!"); }                       
                    }
                    else
                    {
                        Console.WriteLine("請輸入數字 0~9");
                        continue;
                    }
                }
                Console.WriteLine("恭喜 恭喜 猜對了");
                Console.ReadKey();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
        }
    }
    
}
