using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppMVC
{
    public class ClassModel : BaseModel
    {
       
        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [Required]
        [StringLength(2)]
        public string Section { get; set; }
    }
}
