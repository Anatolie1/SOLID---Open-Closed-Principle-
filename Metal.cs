using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrincipleViolation
{
    public class Metal : ICraftable
    {
        public string Type
        {
            get
            {
                return "Metal";
            }
        }
    }
}
