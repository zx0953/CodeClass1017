using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NPC:Avatar
    {
        public void Talk(String s)
        {
            Console.WriteLine(""+ s + "啦艮!");
        }
        //public new string Name = "123";
    }
}
