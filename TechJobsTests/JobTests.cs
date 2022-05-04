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
            Employer ACME = new Employer();
            Location Desert = new Location();
            PositionType QualityControl = new PositionType();
            CoreCompetency Persistence = new CoreCompetency();

            Job test_job3 = new Job("Product Tester", ACME, Desert, QualityControl, Persistence);
            // assert that the fields of test_job3 are equal to the arguments
            Assert.AreEqual("Product Tester", test_job3.Name);
            Assert.AreEqual(ACME, test_job3.EmployerName);
            Assert.AreEqual(Desert, test_job3.EmployerLocation);
            Assert.AreEqual(QualityControl, test_job3.JobType);
            Assert.AreEqual(Persistence, test_job3.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job1 = new Job("Web Developer", new Employer("Google"), new Location("Atlanta"), new PositionType("Entry Level"), new CoreCompetency("Communication"));
            Job test_job2 = new Job("Web Developer", new Employer("Google"), new Location("Atlanta"), new PositionType("Entry Level"), new CoreCompetency("Communication"));

            Assert.IsFalse(test_job1 == test_job2);
        }
    }
}
