using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding.Agency
{
    public class EventPlan
    {
        public int Id { get; set; }
        public int RequestCompositionId { get; set; }
        public RequestComposition RequestComposition { get; set; }
        public int AssignedStaffId { get; set; }
        public AssignedStaff AssignedStaff { get; set; }
        public int InvolvedPartnerId { get; set; }
        public InvolvedPartner InvolvedPartner { get; set; }
    }

}
