using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrincipleViolation
{
    public class Production
    {
        public IEnumerable<ICraftable> Craftables { get; set; }

        public Production(IEnumerable<ICraftable> craftables)
        {
            Craftables = craftables;
        }

        public override string ToString()
        {
            string description = "Object is composed of\n:";
            foreach (ICraftable craftable in Craftables)
            {
                description += "\t"+ "ICraftable.Type";
            }
            return description;
        }
    }
}
