using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQ009Portfolio.Data.Dtos
{
    public class EducationHistoryToReturnDto
    {
        public int Id { get; set; }
        public string InstitutionName { get; set; }
        public string DegreeOptained { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
