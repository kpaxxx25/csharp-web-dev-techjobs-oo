using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobIDAreEqual()
        {
            Job job = new Job();
            var actually = job.Id;
            var given = 1;
            Assert.AreEqual(given, actually);
        }

        [TestMethod]
        public void TestSettingJobIDAreNotEqual()
        {
            Job job = new Job();
            var actually = job.Id;
            var given = 5;
            Assert.AreEqual(given, actually);
        }
    }
}
