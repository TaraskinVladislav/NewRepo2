using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding.Agency
{
    public class Partner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ServiceType { get; set; }
        public ICollection<InvolvedPartner> InvolvedPartners { get; set; }
    }

}
