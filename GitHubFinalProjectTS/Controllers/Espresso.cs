using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFinalProjectTS.Controllers
{
    public class Espresso : IDrink
    {
        public string Name => "Espresso";
        public decimal BasePrice => 2.50m;

        public string GetDescription() => "A single shot of espresso.";
    }
}
