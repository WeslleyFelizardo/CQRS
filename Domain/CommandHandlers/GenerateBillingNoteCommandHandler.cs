using Domain.Commands;
using Domain.ViewModels;
using Share.Handlers;
using Share.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CommandHandlers
{
    public class GenerateBillingNoteCommandHandler :
        ICommandHandlerSingle<CreateBillingNoteCommand>
    {
        public GenerateBillingNoteCommandHandler()
        {

        }

        public CommandResult Handle(CreateBillingNoteCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
