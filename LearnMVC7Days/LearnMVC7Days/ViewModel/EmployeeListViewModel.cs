﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnMVC7Days.ViewModel
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string UserName { get; set; }
}
}