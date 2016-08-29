using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Models
{
    public class Obj1:IObj1
    {
        public Obj1()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
