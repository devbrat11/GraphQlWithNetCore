﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphQlWithNetCore.Data
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tester { get; set; }
        public string Description { get; set; }
        public List<TestResult> Results { get; set; }
    }

  
}
