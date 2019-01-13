using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Results
{
    public class QueryResult<T> where T : ViewModel 
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<T> Data { get; set; }
    }
}
