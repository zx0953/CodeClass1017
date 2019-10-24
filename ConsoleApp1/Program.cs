using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string C = Console.ReadLine();
                if (C == "1")
                {
                    GusseNumber gusseNumber = new GusseNumber();
                    gusseNumber.gusseNumPlay();
                }else if(C == "2")
                {
                    ABhowMany aBhowMany = new ABhowMany();
                    aBhowMany.abPlay();
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }            

        }
    }
}
