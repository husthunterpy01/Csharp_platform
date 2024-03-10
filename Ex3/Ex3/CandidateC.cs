using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class CandidateC : Candidate
    {
        public CandidateC()
        {
            Candidate.Subject1 = "Literature";
            Candidate.Subject2 = "History";
            Candidate.Subject3 = "Geography";
        }
        public CandidateC(int id, string name, string address, int priority) : base(id, name, address, priority)
        {
        }
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo} Type: Candidate C";
        }
    }
}
 