using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyRestApi.Projects
{
    public class QueryResult
    {
        public string _rallyAPIMajor { get; set; }
        public string _rallyAPIMinor { get; set; }
        public List<object> Errors { get; set; }
        public List<object> Warnings { get; set; }
        public int TotalResultCount { get; set; }
        public int StartIndex { get; set; }
        public int PageSize { get; set; }
        public List<Result> Results { get; set; }
    }
}
