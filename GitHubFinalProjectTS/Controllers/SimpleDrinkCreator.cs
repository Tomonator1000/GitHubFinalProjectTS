using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFinalProjectTS.Controllers
{
    public class SimpleDrinkCreator : DrinkCreator
    {
        // Factory Method
        public override IDrink CreateDrink(string type)
        {
            switch (type.ToLower())
            {
                case "espresso":
                    return new Espresso();
                case "latte":
                    return new Latte();
                case "tea":
                    return new Tea();
                default:
                    throw new ArgumentException($"Unknown drink type: {type}");
            }
        }
    }
}
