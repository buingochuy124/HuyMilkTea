namespace HuyMilkTea
{
    internal class CocoaMilkTea : MilkTea
    {
        public CocoaMilkTea(MilkTeaSize size)
            : base(size)
        {
            if (size == MilkTeaSize.SmallSize)
            {
                price = 40;
                calorie = 250;
            }
            else
            {
                price = 48;
                calorie = 300;
            }
        }
    }



}
