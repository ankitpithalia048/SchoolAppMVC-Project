using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppMVC
{
    public class StudentModel : BaseModel
    {
        [StringLength(20)]
        [Required]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]

        public string LastName { get; set; }

        [Required]
        [MinLength(10)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(10)]
        public string Class { get; set; }

        [Required]
        [StringLength(2)]
        public string Section { get; set; }
    }
}
