using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BrickApp.Models.Admin
{
    public class TeamTask
    {
        public int TeamTaskId { get; set; }
        public string Task { get; set; }
        public List<TeamMember> Members { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
