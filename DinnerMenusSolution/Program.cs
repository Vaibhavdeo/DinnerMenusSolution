using System;
using DinnerMax3000.Business;

namespace DinnerMenusSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu superMenu = new FoodMenu();
            superMenu.name = "Super name";
            superMenu.AddMenuItem("dssg","sd",50);
            superMenu.AddMenuItem("dssg", "sd", 50);
            superMenu.AddMenuItem("dssg", "sd", 50);

            DrinkMenu drinkMenu = new DrinkMenu();
            drinkMenu.name = "Super Drink";
            drinkMenu.AddMenuItem("dssg", "sd", 50);
            drinkMenu.AddMenuItem("dssg", "sd", 50);
        }
    }
}
