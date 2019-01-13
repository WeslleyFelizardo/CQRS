using Share.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Filters
{
    public class ParametersForSendSapFilter : FilterComplex
    {
        public bool Term { get; set; }
        public bool Substitutive { get; set; }
    }
}
