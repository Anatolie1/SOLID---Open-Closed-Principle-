using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrincipleViolation
{
    public class Wood : ICraftable
    {
        public string Type
        {
            get
            {
                return "Wood";
            }
        }
    }
}
