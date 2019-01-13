using Domain.Commands;
using Domain.Filters;
using Domain.Services;
using Domain.ViewModels;
using Share.Handlers;
using Share.Parameters;
using Share.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CommandHandlers
{
    public class SendBillingNoteSapCommandHandler :
        ICommandHandlerManyWithFilter<SendBillingNoteForSapCommand, ParametersForSendSapFilter>
    {
        private readonly IServiceIntegrationSap _serviceIntegrationSap;
        public SendBillingNoteSapCommandHandler(IServiceIntegrationSap serviceIntegrationSap)
        {
            _serviceIntegrationSap = serviceIntegrationSap;
        }

        public CommandResult Handle(List<SendBillingNoteForSapCommand> commands, ParametersForSendSapFilter filterComplex)
        {
            var billingNotes = new List<BillingNoteSentForSapViewModel>();

            if (commands.Where(c => c.Status.Equals("Bloqueado")).Any()) return new CommandResult(false, "Há cadastro de cliente pendente, o processo não pode seguir");

            foreach (var item in commands)
            {
                var noteResult = new BillingNoteSentForSapViewModel(item.Id);

                noteResult.AddNotification("", "");

                if (1 == 1) noteResult.AddNotification("", "");

                if (noteResult.Valid)
                {
                    // Chamar servico que envia nota para o SAP
                    var returnSap = _serviceIntegrationSap.Send();

                    if (returnSap != null) noteResult.AddNotification("Resultado", "Nota foi enviada com sucesso");

                    else noteResult.AddNotification("Resultado", "Ocorreu um erro no retorno do SAP");
                }

                billingNotes.Add(noteResult);
            }

            return new CommandResult(true, "Operação realizada com sucesso", billingNotes);

            throw new NotImplementedException();
        }
    }
}
