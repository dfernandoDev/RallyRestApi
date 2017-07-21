using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyRestApi.Iteration
{
    public class Result
    {
        public string _ref { get; set; }
        public string _refObjectUUID { get; set; }
        public string _refObjectName { get; set; }
        public string _p { get; set; }
        public object ObjectID { get; set; }
        public string VersionId { get; set; }
        public Workspace Workspace { get; set; }
        public string EndDate { get; set; }
        public string Name { get; set; }
        public double? PlanEstimate { get; set; }
        public double? PlannedVelocity { get; set; }
        public Project Project { get; set; }
        public string StartDate { get; set; }
        public string State { get; set; }
        public double? TaskActualTotal { get; set; }
        public double? TaskEstimateTotal { get; set; }
        public double? TaskRemainingTotal { get; set; }
        public string Theme { get; set; }
        public string _type { get; set; }
    }
}
