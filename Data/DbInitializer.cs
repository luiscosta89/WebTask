using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTask.Models; 

namespace WebTask.Data
{
    public static class DbInitializer
    {
        public static void Initialize(UserContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{Name="Carson Alexander", Email="carson_alex@gmail.com", BirthDate="02/03/1992", City="Porto Alegre", State="RS"},
                new User{Name="Meredith Alonso", Email="meredith_al@gmail.com", BirthDate="10/01/1991", City="Porto Alegre", State="RS"},
                new User{Name="Arturo Anand", Email="arturo_an@gmail.com", BirthDate="15/03/1992", City="Porto Alegre", State="RS"},
                new User{Name="Gytis Barzdukas", Email="gytis_barz@gmail.com", BirthDate="21/06/1995", City="Porto Alegre", State="RS"},
                new User{Name="Yan Li", Email="yan_li@gmail.com", BirthDate="04/11/1994", City="Porto Alegre", State="RS"},
                new User{Name="Peggy Justice", Email="peggy_jus@gmail.com", BirthDate="28/12/1991", City="Porto Alegre", State="RS"},
                new User{Name="Laura Norman", Email="laura_nor@gmail.com", BirthDate="13/10/1996", City="Porto Alegre", State="RS"}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
        }
    }
}
