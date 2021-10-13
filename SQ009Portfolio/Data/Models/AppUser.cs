using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SQ009Portfolio.Data.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<EducationHistory> EducationHistory { get; set; }
        public ICollection<WorkHistory> WorkHistory { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
