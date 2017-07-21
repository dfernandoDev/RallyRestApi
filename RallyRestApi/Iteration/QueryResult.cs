using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyRestApi.Iteration
{
    public class QueryResult
    {
        public int TotalResultCount { get; set; }
        public int StartIndex { get; set; }
        public int PageSize { get; set; }
        public List<Result> Results { get; set; }
    }
}
