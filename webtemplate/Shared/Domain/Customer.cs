using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webtemplate.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(10, MinimumLength = 2,  ErrorMessage = "Name is too long.")]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Address { get; set; }

       
    }
}
