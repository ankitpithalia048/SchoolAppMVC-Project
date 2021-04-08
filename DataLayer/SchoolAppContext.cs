using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolAppMVC;


namespace SchoolAppMVC
{
    public class SchoolAppContext : DbContext
    {
        
    
        public SchoolAppContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<StudentModel> StudentModel { get; set; }
        public DbSet<ClassModel> ClassModel { get; set; }
        public DbSet<SubjectModel> SubjectModel { get; set; }

        
    }
}
