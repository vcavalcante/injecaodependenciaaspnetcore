﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Models
{
    public class Obj3
    {
        public Obj3()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
