using System;
using System.Collections.Generic;

namespace EmployeDetails.Models;

public partial class Employee
{
    public int? EmpId { get; set; }

    public string? EmpName { get; set; }

    public int? EmpSal { get; set; }

    public string? EmpLoc { get; set; }
}
