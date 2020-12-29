using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

       
        // there is a way to assert the variable up here but i am too lazy to look it up.
        
        [TestMethod]
        public void A1TestSettingJobIDAreEqual()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            var actually = testJob.Id;
            var given = 1;
            Assert.AreEqual(given, actually);
        }

        [TestMethod]
        public void A2TestSettingJobIDAreNotEqual()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            var actually = testJob.Id;
            var given = 5;
            Assert.AreNotEqual(given, actually);
        } 
       
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //Job testJob = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(testJob.Name, "Product tester");
            Assert.AreEqual(testJob.EmployerName.Value, "ACME");
            Assert.AreEqual(testJob.EmployerLocation.Value, "Desert");
            Assert.AreEqual(testJob.JobType.Value, "Quality control");
            Assert.AreEqual(testJob.JobCoreCompetency.Value, "Persistence");
            //Assert.AreEqual(testJob.Id, ???);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreNotEqual(testJob, testJob2);
        }

        [TestMethod]
        public void TestToString()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            var expected = $"ID: __{testJob.Id}__ \n Name: __{testJob.Name}__ \n Employer: __{testJob.EmployerName}__ \n Location: __{testJob.EmployerLocation}__ \n PositionType: __{testJob.JobType}__ \n CoreCompentency: __{testJob.JobCoreCompetency}__";
            Assert.AreEqual(testJob.ToString(), expected);
        }
       
    }
}