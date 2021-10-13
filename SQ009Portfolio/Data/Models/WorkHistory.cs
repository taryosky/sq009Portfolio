using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SQ009Portfolio.Data.Models
{
    public class WorkHistory
    {
        public int Id { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public string EndDate { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
