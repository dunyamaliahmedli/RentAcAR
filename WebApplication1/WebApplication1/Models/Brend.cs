using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Brend
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int CarsiD { get; set; }
     public List<Car> Cars { get; set; }
        
    }
}
