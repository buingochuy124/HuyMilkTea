using System;
using System.Collections.Generic;

namespace HuyMilkTea
{
    abstract class MilkTea
    {
        protected double price;
        protected double calorie;
        protected MilkTeaSize size;
        public MilkTea(MilkTeaSize size)
        {
            this.size = size;
            toppings = new Dictionary<ToppingType, List<Topping>>();
        }
        protected Dictionary<ToppingType, List<Topping>> toppings;

        public double GetMilkTeaPrice()
        {
            return price;
        }
        public double GetMilkTeaCalorie()
        {
            return calorie;
        }
        public void AddToppingToMilkTea(ToppingType type)
        {
            if (!toppings.ContainsKey(type))
            {
                toppings.Add(type, new List<Topping>());
                toppings[type].Add(new Topping(type));
            }
            else
            {
                toppings[type].Add(new Topping(type));
            }
        }
        public double GetToppingPrice()
        {
            double result = 0;
            foreach (var items in toppings)
            {
                foreach (var item in items.Value)
                {
                    result = result + item.Price;
                }
            }
            return result;
        }

        public double GetToppingCalorie()
        {
            double result = 0;
            foreach (var items in toppings)
            {
                foreach (var item in items.Value)
                {
                    result = result + item.Calorie;
                }
            }
            return result;
        }
        public double GetTotalPrice()
        {
            return GetMilkTeaPrice() + GetToppingPrice();
        }
        public double GetTotalCalorie()
        {
            return GetMilkTeaCalorie() + GetToppingCalorie();
        }
        public void GetBill()
        {
            Console.WriteLine("-------- Print bill --------");
            Console.WriteLine($"Price: {GetTotalPrice()} ");
            Console.WriteLine($"Calorie: {GetTotalCalorie()} ");
            Console.WriteLine("Thank you for coming !!! See ya later");

        }
    }



}
