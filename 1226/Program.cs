using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _1226
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puppy DennisDOG = new Puppy();
            //設定DennisCar的屬性值.
            DennisDOG.Id = 1;
            DennisDOG.Owner = "Dennis";
            DennisDOG.Description = "真的狗";
            DennisDOG.Price = 50;
            DennisDOG.Brand = "土狗";
            DennisDOG.KG = 20;
            DennisDOG.GG = true;
            //類堆..所有屬性都要設.

            //最後,叫用DennisDOG的方法CallMyPuppyName( )印出所有屬性參數.
            DennisDOG.CallMyPuppyName();
            Console.WriteLine("\n\n");

            //===============================================
            //第二個 使用有參數的建構子設一台車MarysCar.
            //經由建構子函式2 來設定所有屬性
            Puppy MarysNas = new Puppy(2, "Nas", "疊Q專家", 100000, "納瑟斯", 30, true);

            //最後,叫用 MarysCar的方法PrintAllAttrib( )印出所有屬性參數.
            MarysNas.CallMyPuppyName();
        }
    }
}
