﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class AdminModel : EmployeeModel
    {
        public bool privileges { get; set; }
    }
}
