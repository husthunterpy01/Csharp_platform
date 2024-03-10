using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class CandidateB : Candidate
    {
        public CandidateB()
        {
            Candidate.Subject1 = "Math";
            Candidate.Subject2 = "Biology";
            Candidate.Subject3 = "Chemistry";
        }
        public CandidateB(int id, string name, string address, int priority) : base(id, name, address, priority)
        {
        }
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo} Type: Candidate B";
        }
    }
}
