using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week07.Entities
{
    public class DeathProbability
    {
        public Gender Gender { get; internal set; }
        public int Age { get; set; }
        public double P { get; set; }
    }
}
