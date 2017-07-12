using Microsoft.VisualStudio.TestTools.UnitTesting;
using RallyRestApi.Subscriptions;
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
            Subscription subscription = subscriptionRoot.Subscription;
            Assert.AreEqual("2", subscription._rallyAPIMajor);
        }
    }
}