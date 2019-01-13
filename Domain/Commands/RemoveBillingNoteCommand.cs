using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public class RemoveBillingNoteCommand
    {
        public RemoveBillingNoteCommand(decimal[] ids)
        {
            this.ids = ids;
        }

        public decimal[] ids { get; set; }
        
    }
}
