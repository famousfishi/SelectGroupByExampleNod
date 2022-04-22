using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectGroupByExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class ProfileData
        {
            public int JobId { get; set; }
            public string Name { get; set; }
            public bool JobStatus { get; set; }
            public string PropertyLease { get; set; }
        }

        public class ProfileDataGroup
        {
            public int JobId { get; set; }
            public List<ProfileData> ProfileDatas { get; set; }
        }

        private static void RetunGroupdByData()
        {
            List<ProfileData> profileDatas = new()
            {
                new ProfileData() { JobId = 1, JobStatus = true, Name = "Fisayo", PropertyLease = "Maitama" },
                new ProfileData() { JobId = 1, JobStatus = true, Name = "Fisayo Nathan", PropertyLease = "Gwarimpa" },
                new ProfileData() { JobId = 1, JobStatus = true, Name = "Doyin", PropertyLease = "Asokoro" },
                new ProfileData() { JobId = 2, JobStatus = true, Name = "Codeease", PropertyLease = "Kubwa" },
                new ProfileData() { JobId = 2, JobStatus = true, Name = "Emmannuel", PropertyLease = "Arab Road" },
            };

            List<ProfileDataGroup> groupedData = profileDatas.GroupBy(x => x.JobId).Select(x => new ProfileDataGroup()
            {
                JobId = x.Key,
                ProfileDatas = x.ToList()
            }).ToList();


            foreach (ProfileDataGroup data in groupedData)
            {
                //do anything with the data (JobId )

                foreach (ProfileData profileData in data.ProfileDatas)
                {
                    //do anything with prodile data
                }
            }

        }
    }
}
