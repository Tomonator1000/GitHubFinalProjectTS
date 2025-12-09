using GitHubFinalProjectTS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFinalProjectTS.Services
{
    public class SugarDecorator : DrinkDecorator
    {
        public SugarDecorator(IDrink inner) : base(inner) { }

        public override decimal BasePrice => _innerDrink.BasePrice + 0.20m;

        public override string GetDescription() =>
            _innerDrink.GetDescription() + " + sugar";
    }
}
