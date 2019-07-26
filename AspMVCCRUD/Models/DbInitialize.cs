using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVCCRUD.Models
{
    public static class DbInitialize
    {
        public static void Inialize(StudentContext context) {
            context.Database.EnsureCreated();
            if (context.Students.Any()) {
                return;
            }
            var students = new Student[] {
                new Student{Email="saikat@gmail.com",Name="saikat"},
                new Student{ Email="saifKamal@gmail.com",Name="saif"}
            };
            foreach (var item in students) {
                context.Students.Add(item);
            }

            context.SaveChanges();

        }
    }
}
