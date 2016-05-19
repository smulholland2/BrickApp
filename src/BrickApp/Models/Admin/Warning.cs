using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrickApp.Models.Admin
{
    public class Warning
    {
        [Key]
        [Required]
        public int WarningId { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime WarningDate { get; set; }
        [Required]
        public bool Status { get; set; }

    }
}
