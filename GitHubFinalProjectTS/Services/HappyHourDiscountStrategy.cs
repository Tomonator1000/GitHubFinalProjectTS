using GitHubFinalProjectTS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFinalProjectTS.Services
{
    public class HappyHourDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal originalPrice) =>
            originalPrice * 0.80m; // 20% off
    }
}
