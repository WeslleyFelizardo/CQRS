using Domain.Filters;
using Share.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public class CreateBillingNoteCommand : Command
    {
        public BillingNoteFilter BillingNoteFilter { get; set; }
        public List<BillingItemForCreationBillingNoteCommand> Items { get; set; }
    }
}
