namespace HuyMilkTea
{
    class ClassicMilkTea : MilkTea
    {
        public ClassicMilkTea(MilkTeaSize size)
            : base(size)
        {
            if (size == MilkTeaSize.SmallSize)
            {
                price = 20;
                calorie = 350;
            }
            else
            {
                price = 25;
                calorie = 400;
            }

        }
    }



}
