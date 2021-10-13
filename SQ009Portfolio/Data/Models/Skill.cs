using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQ009Portfolio.Data.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int AppUserId { get; set; }
        public AppUser MyProperty { get; set; }
    }
}
