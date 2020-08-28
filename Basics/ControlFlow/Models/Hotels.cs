using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Models
{
    public enum Categories 
    { 
        OneStar = 1,
        TwoStar = 2,
        ThreeStar = 3,
        FourStar = 4,
        FiveStar = 5
    }

    public class Hotels
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set;}
        public Categories Category { get; set; } 
    }
}
