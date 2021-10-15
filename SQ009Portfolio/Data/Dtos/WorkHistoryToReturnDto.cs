using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQ009Portfolio.Data.Dtos
{
    public class WorkHistoryToReturnDto
    {
        public int Id { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
