using System;

namespace TestLibrary
{
    [Color(ConsoleColor.Black,"Black")]
    public abstract class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int ProdYear { get; }
        public bool CarStateNew { get; }

        public Car(string brand,string model,int prodYear,bool carIsNew)
        {
            Brand = brand;
            Model = model;
            ProdYear = prodYear;
            CarStateNew = carIsNew;
        }
        public int GetPriceOfCar()
        {
            if (Brand.ToLower() == "bmw" || Brand.ToLower() == "marsedes")
            {
                if (ProdYear > 2015)
                    return 25000;
                else
                    return 15000;
            }
            else
            {
                if (ProdYear > 2015)
                    return 10000;
                else
                    return 5000;
            }
        }
        public override string ToString()
        {
            return $"{Brand} {Model} {ProdYear}";
        }
    }
}
