using GitHubFinalProjectTS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFinalProjectTS.Services
{
    
    public abstract class DrinkDecorator : IDrink
    {
        protected readonly IDrink _innerDrink;

        protected DrinkDecorator(IDrink innerDrink)
        {
            _innerDrink = innerDrink;
        }

        public virtual string Name => _innerDrink.Name;
        public virtual decimal BasePrice => _innerDrink.BasePrice;

        public virtual string GetDescription() => _innerDrink.GetDescription();
    }
}
