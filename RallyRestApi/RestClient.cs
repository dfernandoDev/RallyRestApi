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


        private async Task<string> GetCall(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add(RallyConstants.Rally_SessionID_Key, this.sessionID);

            string response = await client.GetStringAsync(url);
            return response;
        }
        public async Task<Subscriptions.Subscription> GetSubscriptionAsync()
        {
            string url = apiUrl + RallyConstants.RALLY_SUBSCRIPTION;
            string jsonSubscriptionRoot = await GetCall(url);

            SubscriptionRoot subscriptionRoot= JsonToObject.Deserialize<SubscriptionRoot>(jsonSubscriptionRoot);

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
    }
}
