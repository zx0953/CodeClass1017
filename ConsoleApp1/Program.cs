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
                NPC npc = new NPC();
                npc.Name = "王子";
                npc.move_fang = 1;
                npc.Talk("NPC");

                Player player = new Player();
                player.Name = "0v0";
                player.Talk("Player");
                player.Atk();

                /*
                Console.WriteLine("請輸入'1'為猜數字");
                Console.WriteLine("請輸入'3'為算數");
                string C = Console.ReadLine();

                if (C == "1")//猜數字
                {
                    GusseNumber gusseNumber = new GusseNumber();
                    gusseNumber.gusseNumPlay();
                }else if(C == "2")//1A2B 遊戲(未完成)
                {
                    ABhowMany aBhowMany = new ABhowMany();
                    aBhowMany.abPlay();
                }
                else if (C == "3")//算數
                {
                    Calculator calculator = new Calculator();
                    calculator.Play();
                }
                */
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
            Console.ReadKey();
        }
    }
}
