using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wedding.Agency;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public ICollection<AssignedStaff> AssignedStaffs { get; set; }
    public ICollection<Consultant> Consultants { get; set; }
}
