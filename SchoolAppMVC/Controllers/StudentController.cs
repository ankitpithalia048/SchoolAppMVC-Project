using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolAppMVC;
using SchoolAppMVC.Models;

namespace SchoolAppMVC.Controllers
{
    public class StudentController : BaseController<StudentModel>
    {
        public StudentController(IBaseRepository<StudentModel> repo ): base(repo)
        {

        }
        
    }
}
