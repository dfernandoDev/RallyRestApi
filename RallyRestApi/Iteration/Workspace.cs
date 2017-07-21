using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyRestApi.Iteration
{
    public class Workspace
    {
        public string _ref { get; set; }
        public string _refObjectUUID { get; set; }
        public string _refObjectName { get; set; }
        public string _p { get; set; }
        public int ObjectID { get; set; }
        public string VersionId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string _type { get; set; }
    }
}
