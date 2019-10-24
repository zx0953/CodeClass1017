using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ABhowMany
    {

        public void abPlay()
        {
            int inputNum = 0;

            try
            {

                Console.WriteLine("請輸入四個數字不重複");

                while (true)
                {
                    inputNum = CheakNum();
                    if (inputNum == 0) { continue; }
                    Console.WriteLine(inputNum);
                    inputNum = CheakRepeat(inputNum);
                    if (inputNum == 0) { continue; }
                    Console.WriteLine(inputNum);
                }
                Console.ReadKey();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
        }
        public int CheakNum()   //檢測否為4位數 數字
        {
            int inputNum; //轉換為輸入的數字用
            string inputStr = Console.ReadLine();   //接收使用者輸入的字
            if (Int32.TryParse(inputStr, out inputNum)) //轉換為輸入的數字 & 檢查是否為數字
            {
                if (inputNum / 1000 >= 1 && inputNum / 1000 <= 9) { return inputNum; }
                else
                {
                    Console.WriteLine("請輸入四個數字 謝謝");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("請輸入四個數字 謝謝");
                return 0;
            }
        }
        public int CheakRepeat(int inputNum)   //檢測有沒有重複
        {

            int[] arrayNum = { inputNum / 1000, inputNum / 100 % 10, inputNum / 10 % 10, inputNum % 10 };
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (arrayNum[i] == arrayNum[j])
                    {
                        Console.WriteLine($"第{i + 1}和第{j+1}個重複了");
                        return 0;
                    }                    
                }
            }
            return inputNum;
        }
    }
}
