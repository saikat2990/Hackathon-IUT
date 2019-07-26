using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspMVCCRUD.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<CourseTable>CourseTables { get; set; }
        public DbSet<runningCourse>runningCourses { get; set; }
        public DbSet<RunningCoursesList> RunningCoursesLists { get; set; }
        public DbSet<StudentsList> StudentsLists { get; set; }
        public DbSet<TeachersList> TeachersLists { get; set; }
        public DbSet<TeachersOwnList> TeachersOwnLists { get; set; }
        public DbSet<TrainerReg> TrainerRegs { get; set; }
        public DbSet<UserDoneCoursesInfo> UserDoneCoursesInfos { get; set; }
        public DbSet<UserRunningCoursesInfo> UserRunningCoursesInfos { get; set; }
        public DbSet<UserLogIn> UserLogIns { get; set; }
        public DbSet<VideoList> VideoLists { get; set; }
        public DbSet<StudentPage> StudentPages { get; set; }

    }
}
