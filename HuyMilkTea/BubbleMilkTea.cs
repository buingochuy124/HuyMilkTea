namespace HuyMilkTea
{
    internal class BubbleMilkTea : MilkTea
    {
        public BubbleMilkTea(MilkTeaSize size)
            : base(size)
        {
            if (size == MilkTeaSize.SmallSize)
            {
                price = 32;
                calorie = 420;
            }
            else
            {
                price = 37;
                calorie = 470;
            }
        }
    }



}
