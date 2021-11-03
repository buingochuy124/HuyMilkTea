namespace HuyMilkTea
{
    class Topping
    {
        private double _price;
        private double _calorie;
        private ToppingType _type;

        public double Calorie
        {
            get
            {
                return _calorie;
            }
            private set { }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            private set { }
        }
        public Topping(ToppingType type)
        {
            _type = type;
            switch (type)
            {
                case ToppingType.CreamChese:
                    _price = 5;
                    _calorie = 70;
                    break;
                case ToppingType.GreenAppleJelly:
                    _price = 5;
                    _calorie = 35;
                    break;
                case ToppingType.WhilePearl:
                    _price = 7;
                    _calorie = 60;
                    break;
            }
        }

    }

}
