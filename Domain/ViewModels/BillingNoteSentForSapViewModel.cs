using Share.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class BillingNoteSentForSapViewModel : ViewModel
    {
        public BillingNoteSentForSapViewModel(decimal id)
        {
            Id = id;
        }

        public decimal Id { get; private set; }

        
    }
}
