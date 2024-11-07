using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartDemoVisualization.Models
{
    public class DummyLogData
    {
        public DateTime TimeStamp { get; set; }
        public string Event { get; set; }
        public string Category { get; set; }
        public string LogLevel { get; set; }
        public double Value { get; set; }
        public string UserId { get; set; }
    }
}
