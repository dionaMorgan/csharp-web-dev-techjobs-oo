using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();
            Assert.IsTrue(test_job1.Id != test_job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer ACME = new Employer("ACME");
            Location Desert = new Location("Desert");
            PositionType QualityControl = new PositionType("QualityControl");
            CoreCompetency Persistence = new CoreCompetency("Persistence");

            Job test_job3 = new Job("Product Tester", ACME, Desert, QualityControl, Persistence);
            // assert that the fields of test_job3 are equal to the arguments
            Assert.IsTrue("Product Tester" == test_job3.Name);
            Assert.IsTrue("ACME" == test_job3.EmployerName.Value);
            Assert.IsTrue("Desert" == test_job3.EmployerLocation.Value);
            Assert.IsTrue("QualityControl" == test_job3.JobType.Value);
            Assert.IsTrue("Persistence" == test_job3.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job1 = new Job("Web Developer", new Employer("Google"), new Location("Atlanta"), new PositionType("Entry Level"), new CoreCompetency("Communication"));
            Job test_job2 = new Job("Web Developer", new Employer("Google"), new Location("Atlanta"), new PositionType("Entry Level"), new CoreCompetency("Communication"));

            Assert.IsFalse(test_job1 == test_job2);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            Job test_job = new Job("Web Developer", new Employer("Google"), new Location("Atlanta"), new PositionType("Entry Level"), new CoreCompetency("Communication"));
            string test_input = test_job.ToString();
            string test_output = $"ID: {test_job.Id} \nName: {test_job.Name} \nEmployer: {test_job.EmployerName.Value} \nLocation: {test_job.EmployerLocation.Value} \nPosition Type: {test_job.JobType.Value} \nCore Competency: {test_job.JobCoreCompetency}";

            Assert.AreEqual(test_output, test_input);
        }
    }
}
