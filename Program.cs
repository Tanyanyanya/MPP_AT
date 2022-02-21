using System;
using System.Collections.Generic;

namespace MP_dop2
{
    class Program
    {
        static void Main(string[] args)
        {
            IterateThruDictionary();
        }

        private static void IterateThruDictionary()
        {
            Dictionary<string, StudentInfo> elements = BuildDictionary();

            foreach (KeyValuePair<string, StudentInfo> kvp in elements)
            {
                StudentInfo theElement = kvp.Value;

                Console.WriteLine("key: " + kvp.Key);
                Console.WriteLine("values: " + theElement.Faculty + " " +
                    theElement.FullName + " " + theElement.Group + " " + theElement.Telephone + " " + theElement.Address);
            }
        }
        private static Dictionary<string, StudentInfo> BuildDictionary()
        {
            var infos = new Dictionary<string, StudentInfo>();

            AddToList(infos, "IPI", "Joann Parker", "IT-05", 0872349866, "Honey Arbor");
            AddToList(infos, "IPT", "Frank Rogers", "IC-02", 0872349869, "Broad Circle");
            AddToList(infos, "MMM", "Ella Reyes", "IS-02", 0872349869, "Sleepy Acres");
            AddToList(infos, "MWM", "John Williams", "IM-08", 0872349869, "Hazy Oak Avenue");

            return infos;
        }

        private static void AddToList(Dictionary<string, StudentInfo> infos,
            string faculty, string name, string group, int telephone, string address)
        {
            StudentInfo theStudent = new StudentInfo();

            theStudent.Faculty = faculty;
            theStudent.FullName = name;
            theStudent.Group = group;
            theStudent.Telephone = telephone;
            theStudent.Address = address;

            infos.Add(key: theStudent.FullName, value: theStudent);
        }

        public class StudentInfo
        {
            public string Faculty { get; set; }
            public string FullName { get; set; }
            public string Group { get; set; }
            public int Telephone { get; set; }
            public string Address { get; set; }
        }

        private static Dictionary<string, StudentInfo> BuildList2()
        {
            return new Dictionary<string, StudentInfo>
    {
        {"Joann Parker",
            new StudentInfo() { Faculty ="IPI", FullName="Student", Group="IT-05", Telephone=0872349866, Address="Honey Arbor"}},
        {"Frank Rogers",
            new StudentInfo() { Faculty ="IPT", FullName="Student", Group="IC-02", Telephone=0872349869, Address="Broad Circle"}},
        {"Ella Reyes",
            new StudentInfo() { Faculty ="MMM", FullName="Student", Group="IS-05", Telephone=0872349861, Address="Sleepy Acres"}},
        {"John Williams",
            new StudentInfo() { Faculty ="MWM", FullName="Student", Group="IM-01", Telephone=0872349862, Address="Hazy Oak Avenue"}}
    };
        }

        private static void FindInList(string name)
        {
            Dictionary<string, StudentInfo> elements = BuildDictionary();

            if (elements.ContainsKey(name) == false)
            {
                Console.WriteLine(name + " not found");
            }
            else
            {
                StudentInfo theElement = elements[name];
                Console.WriteLine("found: " + theElement.Telephone);
            }
        }

        private static void FindInList2(string name)
        {
            Dictionary<string, StudentInfo> elements = BuildDictionary();

            StudentInfo theStudent = null;
            if (elements.TryGetValue(name, out theStudent) == false)
                Console.WriteLine(name + " not found");
            else
                Console.WriteLine("found: " + theStudent.Telephone);
        }
    }
}
