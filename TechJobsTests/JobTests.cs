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

            
            Job test_job3 = new Job(); //how do I initialize class data for test_job3?
            // assert that the fields of test_job3 are equal to the arguments
            
           
        }
    }
}
