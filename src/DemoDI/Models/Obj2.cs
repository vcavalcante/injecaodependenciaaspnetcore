using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Models
{
    public class Obj2:IObj2
    {
        public Obj2()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
