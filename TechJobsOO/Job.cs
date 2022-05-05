using System;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string output;
            output = $"ID: {Id}\n";

            if (Name == "")
            {
                output += "Name: Data Not Available\n";
            }
            else
            {
                output += $"Name: {Name}\n";
            }
            if (EmployerName.Value == "")
            {
                output += "Employer: Data Not Available\n";
            }
            else
            {
                output += $"Employer: {EmployerName.Value}\n";
            }
            if (EmployerLocation.Value == "")
            {
                output += "Location: Data Not Available\n";
            }
            else
            {
                output += $"Location: {EmployerLocation.Value}\n";
            }
            if (JobType.Value == "")
            {
                output += "Position Type: Data Not Available\n";
            }
            else
            {
                output += $"Position Type: {JobType.Value}\n";
            }
            if (JobCoreCompetency.Value == "")
            {
                output += "Core Competency: Data Not Available\n";
            }
            else
            {
                output += $"Core Competency: {JobCoreCompetency.Value}\n";
            }

            return output;

            //return $"ID: {Id} \nName: {Name} \nEmployer: {EmployerName.Value} \nLocation: {EmployerLocation.Value} \nPosition Type: {JobType.Value} \nCore Competency: {JobCoreCompetency}";
        }


    }
}
