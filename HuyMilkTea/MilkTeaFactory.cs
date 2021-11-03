namespace HuyMilkTea
{
    class MilkTeaFactory
    {
        public static MilkTea MakeClassicMilkTea(MilkTeaSize size)
        {
            return new ClassicMilkTea(size);
        }
        public static MilkTea MakeThaiGreenTea(MilkTeaSize size)
        {
            return new ThaiGreenTea(size);
        }
        public  static MilkTea MakeBubbleMilkTea(MilkTeaSize size)
        {
            return new BubbleMilkTea(size);

        }
        public static MilkTea MakeCocoaMilkTea(MilkTeaSize size)
        {
            return new CocoaMilkTea(size);



        }
    }


}
