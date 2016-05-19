using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BrickApp.Models.Admin
{
    public class TeamTask
    {
        [Key]
        [Required]
        public int TeamTaskId { get; set; }
        [Required]
        public string Task { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public List<TeamMember> TeamMembers { get; set; }
    }
}
