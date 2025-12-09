using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFinalProjectTS.Models
{
    public class PricingContext
    {
        private IDiscountStrategy _strategy;

        public PricingContext(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal CalculateFinalPrice(decimal basePrice)
        {
            return _strategy.ApplyDiscount(basePrice);
        }
    }
}
