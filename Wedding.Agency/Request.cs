using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding.Agency
{
    public class Request
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
        public ICollection<RequestComposition> RequestCompositions { get; set; }
        public ICollection<EventPlan> EventPlans { get; set; }
    }

}
