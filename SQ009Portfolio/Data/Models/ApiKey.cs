using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SQ009Portfolio.Data.Models
{
    public class ApiKey
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Key { get; set; }

    }
}
