using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementDomain
{
    public class Batches
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime TentativeEndDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Fees { get; set; }
        public double FeesPaid { get; set; }
        public double Duration { get; set; }
        public double HoursTaken { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }
        public string Remarks { get; set; }
    }
}
