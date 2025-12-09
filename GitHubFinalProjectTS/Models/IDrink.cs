using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFinalProjectTS.Models
{
    public interface IDrink
    {
        string Name { get; }
        decimal BasePrice { get; }

        string GetDescription();
    }
}
