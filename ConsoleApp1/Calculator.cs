using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        public void Play()
        {
            try
            {                           
                Console.WriteLine("請輸入第一個數字");
                string s1 = Console.ReadLine();
                Console.WriteLine("請輸入第二個數字");
                string s2 = Console.ReadLine();
                if(Int32.TryParse(s1,out int n1) && Int32.TryParse(s2, out int n2))
                {
                    Console.WriteLine($"加法運算:{Add(n1, n2)}");
                    Console.WriteLine($"減法運算:{Sub(n1, n2)}");
                    Console.WriteLine($"相乘運算:{Mul(n1, n2)}");
                    Console.WriteLine($"相除運算:{Div(n1, n2)}");
                }
                else
                {
                    Console.WriteLine("輸入數字啦 艮!");
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp);
                throw;
            }
        }
        private int Add(int x,int y)
        {
            int ans = x + y;
            return ans;
        }
        private int Sub(int x, int y)
        {
            int ans = x - y;
            return ans;
        }
        private int Mul(int x, int y)
        {
            int ans = x * y;
            return ans;
        }
        private float Div(int x, int y)
        {
            float ans = -1;
            try
            {                
                ans = (float)x / (float)y;                
            }
            catch (DivideByZeroException exp)
            {
                Console.WriteLine("還想除零?");
                throw;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            return ans;
        }
    }
}
