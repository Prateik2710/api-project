using System;
using System.Collections.Generic;

namespace HRAApplication.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int Age { get; set; }

    public string Address { get; set; } = null!;

}
