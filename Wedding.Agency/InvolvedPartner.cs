using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding.Agency
{
    public class InvolvedPartner
    {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }
        public ICollection<EventPlan> EventPlans { get; set; }
    }

}
