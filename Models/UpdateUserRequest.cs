using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cdc.Models
{
    public class UpdateUserRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }    

        [Required]
        public string Username { get; set; }
    }
}
