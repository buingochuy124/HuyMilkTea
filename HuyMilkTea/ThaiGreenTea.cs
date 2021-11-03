namespace HuyMilkTea
{
    class ThaiGreenTea : MilkTea
    {
        public ThaiGreenTea(MilkTeaSize size)
            : base(size)
        {
            if (size == MilkTeaSize.SmallSize)
            {
                price = 25;
                calorie = 370;
            }
            else
            {
                price = 32;
                calorie = 420;
            }
        }
    } 


}
