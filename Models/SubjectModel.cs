using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppMVC
{
    public class SubjectModel : BaseModel
    {
        [StringLength(20)]
        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]

        public string Teacher { get; set; }

       
    }
}
