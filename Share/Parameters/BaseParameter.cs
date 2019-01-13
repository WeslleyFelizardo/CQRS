using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Parameters
{
    public class BaseParameter
    {
        private const int PageMaxSize = 20;
        private int _pageSize = 10;
        
        public int OffSet { get; set; }
        
        //public string Propriedades { get; set; }
        
        public string FilterSimple { get; set; }
        
        public string OrderBy { get; set; } = "Id";
        
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value > PageMaxSize ? PageMaxSize : value;
        }
        public bool Paginated { get; set; } = true;
    }
}
