using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyRestApi.Projects
{
    public class Result
    {
        public string _rallyAPIMajor { get; set; }
        public string _rallyAPIMinor { get; set; }
        public string _ref { get; set; }
        public string _refObjectUUID { get; set; }
        public string _objectVersion { get; set; }
        public string _refObjectName { get; set; }
        public string CreationDate { get; set; }
        public string _CreatedAt { get; set; }
        public object ObjectID { get; set; }
        public string ObjectUUID { get; set; }
        public string VersionId { get; set; }
        public Subscription Subscription { get; set; }
        public BuildDefinitions BuildDefinitions { get; set; }
        public Children Children { get; set; }
        public string Description { get; set; }
        public Editors Editors { get; set; }
        public Iterations Iterations { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public Owner Owner { get; set; }
        public Releases Releases { get; set; }
        public string SchemaVersion { get; set; }
        public string State { get; set; }
        public TeamMembers TeamMembers { get; set; }
        public Workspace Workspace { get; set; }
        public string _type { get; set; }
        public RevisionHistory RevisionHistory { get; set; }
    }
}
