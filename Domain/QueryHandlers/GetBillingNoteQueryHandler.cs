using Domain.ViewModels;
using Flunt.Notifications;
using Share.Handlers;
using Share.Parameters;
using Share.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.QueryHandlers
{
    public class GetBillingNoteQueryHandler : Notifiable,
        IQueryHandlerPaginationWithFilterComplex<BillingNoteViewModel>
    {
        public GetBillingNoteQueryHandler()
        {

        }

        public QueryResult<BillingNoteViewModel> Handle(BaseParameter baseParameter, FilterComplex filterComplex)
        {
            throw new NotImplementedException();
        }
    }
}
