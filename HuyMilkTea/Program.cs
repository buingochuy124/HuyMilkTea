using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyMilkTea
{
    class Program
    {
        static void Main(string[] args)
        {
            var milk = new ClassicMilkTea(MilkTeaSize.SmallSize);

            milk.AddToppingToMilkTea(ToppingType.CreamChese);

            milk.GetBill();


            var cacoa = new CocoaMilkTea(MilkTeaSize.BigSize);
            cacoa.GetBill();
            cacoa.AddToppingToMilkTea(ToppingType.WhilePearl);
            cacoa.GetBill();

            Console.ReadLine();
        }
    }
}
