using SQ009Portfolio.Data.Models;
using System.Collections.Generic;

namespace SQ009Portfolio.Data.Dtos
{
    public class UserToReturnDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<EducationHistoryToReturnDto> EducationHistory { get; set; }
        public ICollection<WorkHistoryToReturnDto> WorkHistory { get; set; }
        public ICollection<SkillToReturnDto> Skills { get; set; }
        public ICollection<ProjectToReturnDto> Projects { get; set; }
    }
}
