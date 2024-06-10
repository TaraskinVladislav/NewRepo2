using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding.Agency
{
    public class RequestComposition
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public ICollection<EventPlan> EventPlans { get; set; }
    }

}
