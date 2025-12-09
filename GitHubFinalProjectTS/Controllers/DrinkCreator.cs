using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFinalProjectTS.Controllers
{
    public abstract class DrinkCreator
    {
        // Factory Method: subclasses decide which concrete IDrink to create.
        public abstract IDrink CreateDrink(string type);
    }
}
