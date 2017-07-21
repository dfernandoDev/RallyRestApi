using RallyRestApi.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using RallyRestApi.Utils;
using RallyRestApi.Workspaces;
using RallyRestApi.Projects;
using RallyRestApi.Iteration;
using RallyRestApi.Artifacts;

namespace RallyRestApi
{
    public class RestClient
    {
        private string sessionID;

        public string SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }

        private string apiUrl;

        public string ApiURL
        {
            get { return apiUrl; }
            set { apiUrl = value; }
        }

        private string project;

        public string Project
        {
            get { return project; }
            set { project = value; }
        }

        private int pageSize = 200;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        private bool projectScopeUp = false;

        public bool ProjectScopeUp
        {
            get { return projectScopeUp; }
            set { projectScopeUp = value; }
        }

        private bool projectScopeDown = true;

        public bool ProjectScopeDown
        {
            get { return projectScopeDown; }
            set { projectScopeDown = value; }
        }


        private bool compactResults = true;

        public bool CompactResults
        {
            get { return compactResults; }
            set { compactResults = value; }
        }

        private async Task<string> GetCall(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // client.DefaultRequestHeaders.Add("referer", this.apiUrl);
            client.DefaultRequestHeaders.Add(RallyConstants.Rally_SessionID_Key, this.sessionID);

            string response = await client.GetStringAsync(url);
            return response;
        }
        public async Task<Subscriptions.Subscription> GetSubscriptionAsync()
        {
            string url = apiUrl + RallyConstants.RALLY_API_ENDPOINT + RallyConstants.RALLY_SUBSCRIPTION;
            string jsonSubscriptionRoot = await GetCall(url);

            SubscriptionRoot subscriptionRoot = JsonToObject.Deserialize<SubscriptionRoot>(jsonSubscriptionRoot);

            return subscriptionRoot.Subscription;
        }

        public async Task<Workspaces.QueryResult> GetWorkspacesAsync(string wkspaceUrl)
        {
            string jsonWorkspaceRoot = await GetCall(wkspaceUrl);

            WorkspaceRoot workspaceRoot = JsonToObject.Deserialize<WorkspaceRoot>(jsonWorkspaceRoot);

            return workspaceRoot.QueryResult;
        }

        public async Task<Projects.QueryResult> GetProjectsAsync(string projectUrl)
        {
            string jsonProjectRoot = await GetCall(projectUrl);

            ProjectRoot projectRoot = JsonToObject.Deserialize<ProjectRoot>(jsonProjectRoot);

            return projectRoot.QueryResult;
        }

        public async Task<Iteration.QueryResult> GetIterationsAsync()
        {

            StringBuilder url = new StringBuilder();

            url.Append(apiUrl + RallyConstants.RALLY_API_ENDPOINT + RallyConstants.RALLY_ITERATION);
            url.Append("?pagesize=" + this.pageSize);
            url.Append("&start=1&order=StartDate DESC,ObjectID");
            url.Append("&fetch=Workspace,Project,ObjectID,Name,Tags,Theme,StartDate,EndDate,PlannedVelocity,PlanEstimate,TaskEstimateTotal,Estimate,TaskRemainingTotal,ToDo,State,TaskActualTotal,Actuals,Blocked,Ready,FormattedID,VersionId");
            url.Append("&compact=" + compactResults);
            //url.Append("&project=/project/35065247868");
            url.Append("&project=" + project);
            url.Append("&projectScopeUp=" + this.projectScopeUp);
            url.Append("&projectScopeDown=" + this.projectScopeDown);

            string jsonIteration = await GetCall(url.ToString());

            IterationRoot iterationRoot = JsonToObject.Deserialize<Iteration.IterationRoot>(jsonIteration);

            return iterationRoot.QueryResult;
        }

        public async Task<RallyRestApi.Artifacts.QueryResult> GetArtifactAsync(Iteration.Result selectedIteration)
        {
            StringBuilder url = new StringBuilder();

            url.Append(apiUrl + RallyConstants.RALLY_API_ENDPOINT + RallyConstants.RALLY_ARTIFACT);
            url.Append("?pagesize=" + this.pageSize);
            url.Append("&types=hierarchicalrequirement,defect,defectsuite,testset");
            url.Append("&start=1&order=DragAndDropRank ASC,ObjectID");
            url.Append("&query = (((Iteration.Name = \"" + selectedIteration.Name + "\") AND(Iteration.StartDate = \"" + selectedIteration.StartDate + "\")) AND(Iteration.EndDate = \"" + selectedIteration.EndDate +"\")))");
            url.Append("&fetch=PlanEstimate,Release,Iteration,DisplayColor,Project,ObjectID,Name,Tags,DragAndDropRank,FormattedID,ScheduleState,Blocked,Ready,ScheduleStatePrefix,TaskActualTotal,Actuals,Owner,TimeSpent,AcceptedDate,VersionId,Defects,Tasks,TestCases,Children,TaskIndex,Parent,Requirement,DefectSuites,TestCase,sum:[PlanEstimate,TaskActualTotal]");
            url.Append("&compact=" + compactResults);
            //url.Append("&project=/project/35065247868");
            url.Append("&project=" + project);
            url.Append("&projectScopeUp=" + this.projectScopeUp);
            url.Append("&projectScopeDown=" + this.projectScopeDown);

            string jsonArtifact = await GetCall(url.ToString());

            ArtifactRoot artifactRoot = JsonToObject.Deserialize<Artifacts.ArtifactRoot>(jsonArtifact);

            return artifactRoot.QueryResult;
        }
    }
}
