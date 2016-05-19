using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BrickApp.Models.Admin
{
    public class TeamMember
    {
        [Key]
        [Required]
        public int TeamMemberId { get; set; }
        [Required]
        public string MemberName { get; set; }
        [Required]
        public Status Status { get; set; }
        public string Avatar { get; set; }
    }
}
