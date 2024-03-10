using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class CandidateA : Candidate
    {

        public CandidateA()
        {
            Candidate.Subject1 = "Math";
            Candidate.Subject2 = "Physics";
            Candidate.Subject3 = "Chemistry";
        }
        public CandidateA(int id, string name, string address, int priority) : base(id, name, address, priority)
        {
        }
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo} Type: Candidate A";
        }
    }
}
