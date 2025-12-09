using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFinalProjectTS.Models
{
    public class Tea : IDrink
    {
        public string Name => "Tea";
        public decimal BasePrice => 2.00m;

        public string GetDescription() => "A hot brewed tea.";
    }
}
