using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Serviciu
    {
        public int Id { get; set; }
        public string Denumire{ get; set; }
        public string Prescurtare { get; set; }
        public bool Valid { get; set; }
    }
}