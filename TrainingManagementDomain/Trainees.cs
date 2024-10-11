using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementDomain
{
    public class Trainees
    {
        public int TraineeId { get; set; }
        public int BatchId { get; set; }
        public int CollegeId { get; set; }
        public string TraineeName { get; set; }
        public string TraineeLocation { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public char Discontinue { get; set; }
        public string CollegeName { get; set; }
        public string BatchName { get; set; }

    }
}
