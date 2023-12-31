﻿using Store.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities.Results
{
    public class Result:BaseEntity
    {
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string?   Value { get; set; }
        public string? CssClass { get; set; }
        public bool IsActive { get; set; }
    }
}
