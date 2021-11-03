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
            var milk = MilkTeaFactory.MakeClassicMilkTea(MilkTeaSize.SmallSize);

            milk.AddToppingToMilkTea(ToppingType.GreenAppleJelly);

            milk.GetBill();


            var cacoa = MilkTeaFactory.MakeCocoaMilkTea(MilkTeaSize.BigSize);
            cacoa.GetBill();
            cacoa.AddToppingToMilkTea(ToppingType.WhilePearl);
            cacoa.GetBill();

            Console.ReadLine();
        }
    }
}
