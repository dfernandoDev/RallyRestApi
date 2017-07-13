using Microsoft.VisualStudio.TestTools.UnitTesting;
using RallyRestApi.Subscriptions;
using RallyRestApi.Projects;
using RallyRestApi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyRestApi.Utils.Tests
{
    [TestClass()]
    public class JsonToObjectTests
    {
        [TestMethod()]
        public void DeserializeSubscriptionTest()
        {
            string jsonRootSubscription = "";
            SubscriptionRoot subscriptionRoot = JsonToObject.Deserialize<SubscriptionRoot>(jsonRootSubscription);
            Subscriptions.Subscription subscription = subscriptionRoot.Subscription;
            Assert.AreEqual("2", subscription._rallyAPIMajor);
        }

        [TestMethod()]
        public void DeserializeProjectTest()
        {
            string jsonProjectRoot = "";
            ProjectRoot projectRoot = JsonToObject.Deserialize<ProjectRoot>(jsonProjectRoot);
            Projects.QueryResult project = projectRoot.QueryResult;
            Assert.AreEqual("2", project.Results[0]._rallyAPIMajor);
        }
    }
}