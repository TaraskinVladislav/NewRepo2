using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding.Agency
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }
        public ICollection<Request> Requests { get; set; }
    }


}
