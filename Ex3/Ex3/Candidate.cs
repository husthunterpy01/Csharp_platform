using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    abstract internal class Candidate
    {
        public static string Subject1 { get; set; }
        public static string Subject2 { get; set; }
        public static string Subject3 { get; set; }
        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }

        public int Priority { get; set; }

        public Candidate()
        {
        }

        public Candidate(int id, string name, string address, int priority)
        {
            Id = id;
            Name = name;
            Address = address;
            Priority = priority;
        }
        // We have to override here because it's defined as an object method so if write in the ManagerCandidate so it will use the default method as the override method hasn't been called here
        public override string ToString()
        {
            return string.Format($"The id : {Id} The name: {Name} The address:{Address} The priority:{Priority} with the subject {Subject1} {Subject2} {Subject3}");
        }
    }
}
