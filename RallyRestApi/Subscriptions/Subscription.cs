using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyRestApi.Subscriptions
{
    public class Subscription
    {
        public string _rallyAPIMajor { get; set; }
        public string _rallyAPIMinor { get; set; }
        public string _ref { get; set; }
        public string _refObjectUUID { get; set; }
        public string _objectVersion { get; set; }
        public string _refObjectName { get; set; }
        public string CreationDate { get; set; }
        public string _CreatedAt { get; set; }
        public int ObjectID { get; set; }
        public string ObjectUUID { get; set; }
        public string VersionId { get; set; }
        public bool ApiKeysEnabled { get; set; }
        public bool EmailEnabled { get; set; }
        public object ExpirationDate { get; set; }
        public bool JSONPEnabled { get; set; }
        public int MaximumCustomUserFields { get; set; }
        public int MaximumProjects { get; set; }
        public string Modules { get; set; }
        public string Name { get; set; }
        public int PasswordExpirationDays { get; set; }
        public int PreviousPasswordCount { get; set; }
        public bool ProjectHierarchyEnabled { get; set; }
        public object SessionTimeoutSeconds { get; set; }
        public SSOUserExceptions SSOUserExceptions { get; set; }
        public bool StoryHierarchyEnabled { get; set; }
        public string StoryHierarchyType { get; set; }
        public int SubscriptionID { get; set; }
        public string SubscriptionType { get; set; }
        public bool WebhooksEnabled { get; set; }
        public Workspaces Workspaces { get; set; }
        public string ZuulID { get; set; }
        public List<object> Errors { get; set; }
        public List<object> Warnings { get; set; }
    }
}
