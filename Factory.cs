using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrincipleViolation
{
    public sealed class Factory
    {
        public Production Craft(IEnumerable<ICraftable> craftables)
        {
            Production newProduction = new Production(craftables);
            return newProduction;
        }
    }
}
