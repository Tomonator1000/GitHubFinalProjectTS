using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFinalProjectTS.Controllers
{
    public class Latte : IDrink
    {
        public string Name => "Latte";
        public decimal BasePrice => 3.75m;

        public string GetDescription() => "Espresso with steamed milk.";
    }
}
