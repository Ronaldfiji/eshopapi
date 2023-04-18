using DataModel.Entity;
using Microsoft.EntityFrameworkCore;


namespace DataModel.DB
{
    public static class ModelBuilderExt
    {
        // Seed school.
        public static void SeedSchool(ModelBuilder builder)
        {
            builder.Entity<School>().HasData(
                new School()
                {
                    ID = 1,Name = "Tavua College",Email = "tc@mail.com",Phone = "9988998",Code = "SS1230",Address = "Kings Road",
                    City = "Tavua",District = "Ba",Description = "School details",
                    CreatedBy = "Ronald",IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                new School()
                {
                    ID = 2,Name = "Nelson High",Email = "nh@mail.com",Phone = "7458785",Code = "SS1231",Address = "Kings Road",
                    City = "Tavua",District = "Vatukoula",Description = "School details",
                    CreatedBy = "Ronald",IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                new School()
                {
                    ID = 3,Name = "Central College",Email = "cc@mail.com",Phone = "8458785",Code = "SS1232",Address = "Drasas Avenue",
                    City = "Lautoka",District = "Ba",Description = "School details",
                    CreatedBy = "Ronald",IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                new School()
                {
                    ID = 4,Name = "Xavier College", Email = "xc@mail.com",Phone = "7788990",Code = "SS1235", Address = "Yaralevu",
                    City = "Ba",District = "Ba",Description = "School details",
                    CreatedBy = "Ronald",IPAddress = "255.255.255.89",CreatedDate = DateTime.UtcNow.AddHours(12)
                });
        }
        // Seed role 
        public static void SeedRole(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    ID = 1,//new Random().Next(),
                    Name = "User",
                    Description = "User role",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                });

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    ID = 2,//new Random().Next(),
                    Name = "Admin",
                    Description = "Admin role",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                });
            modelBuilder.Entity<Role>().HasData(
               new Role
               {
                   ID = 3,//new Random().Next(),
                   Name = "HOD",
                   Description = "HOD role",
                   CreatedDate = DateTime.UtcNow.AddHours(12)
               });
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    ID = 4,//new Random().Next(),
                    Name = "Manager",
                    Description = "Manager role",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                });

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    ID = 5,//new Random().Next(),
                    Name = "Director",
                    Description = "Director role",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                });
            modelBuilder.Entity<Role>().HasData(
              new Role
              {
                  ID = 6,//new Random().Next(),
                  Name = "Seller",
                  Description = "Seller role",
                  CreatedDate = DateTime.UtcNow.AddHours(12)
              });
        }

        //Seed user type table
        public static void SeedUserType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserType>().HasData(
                new UserType
                {
                    ID = 1,//new Random().Next(),
                    Name = "User",
                    Description = "Type is user",
                    CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new UserType
                {
                    ID = 2,//new Random().Next(),
                    Name = "Seller",
                    Description = "Type is seller",
                    CreatedDate = DateTime.UtcNow.AddHours(12),
                });

        }
        // Seed user 
        public static void SeedUser(this ModelBuilder modelBuilder)
        {
            DateTime dt ;
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    ID = 1,//new Random().Next(),                    
                    FirstName = "Admin", LastName = "Limited", Email = "admin@admin.com", DOB = DateTime.TryParse("21-07-1956", out dt) ? dt :  DateTime.Now,
                    Gender = (Genders)(3), Password = BCrypt.Net.BCrypt.HashPassword("123"), Country = "Fiji", City = "Levuka", State = "BlackWater",
                    AddressLine1 = "First Road X road", AddressLine2 = "10 , Fox Street", Phone = "9090337", PostalCode = "0123",
                    CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Manager-up",
                    IPAddress = "107.23.365.369", UserTypeID = 1,
                },
                new User()
                {
                    ID = 2,//new Random().Next(),                    
                    FirstName = "John-User", LastName = "Smith", Email = "user@mail.com", DOB = DateTime.TryParse("29-07-1979", out dt) ? dt :  DateTime.Now,
                    Gender = (Genders)(1),Password = BCrypt.Net.BCrypt.HashPassword("123"), Country = "Samoa", City = "Apia", State = "North",
                    AddressLine1 = "Fula Fula Road", AddressLine2 = "10, Black street", Phone = "74789699", PostalCode = "458",
                    CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up",
                    IPAddress = "107.23.365.369", UserTypeID = 1,
                },
                new User()
                {
                    ID = 3,//new Random().Next(),                    
                    FirstName = "Peter-Admin", LastName = "Gates", Email = "peter@mail.com", DOB = DateTime.TryParse("13-09-2001", out dt) ? dt :  DateTime.Now,
                    Gender = (Genders)(3), Password = BCrypt.Net.BCrypt.HashPassword("123"), Country = "Vanuatu", City = "Port Vila", State = "Ocean",
                    AddressLine1 = "Rock line Island", AddressLine2 = "29, Bush mount road", Phone = "8890337", PostalCode = "889",
                    CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up",
                    IPAddress = "107.23.365.369", UserTypeID = 1,
                }
                
                ); ; 

        }

        // Seed user role.
        public static void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<UserRole>().HasData(
                new UserRole() { UserId = 1, RoleId = 1, CreatedDate = DateTime.UtcNow.AddHours(12),CreatedBy = "Admin-cr",UpdatedBy = "Admin-up",IPAddress = "107.23.365.369" },
                new UserRole() { UserId = 1, RoleId = 2, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr",UpdatedBy = "Admin-up",IPAddress = "107.23.365.369"},
                new UserRole() { UserId = 2, RoleId = 1, CreatedDate = DateTime.UtcNow.AddHours(12),CreatedBy = "Admin-cr",UpdatedBy = "Admin-up",IPAddress = "107.23.365.369"},
                new UserRole() { UserId = 3, RoleId = 1, CreatedDate = DateTime.UtcNow.AddHours(12) ,CreatedBy = "Admin-cr",UpdatedBy = "Admin-up",IPAddress = "107.23.365.369"},
                new UserRole() { UserId = 3, RoleId = 2, CreatedDate = DateTime.UtcNow.AddHours(12),CreatedBy = "Admin-cr",UpdatedBy = "Admin-up",IPAddress = "107.23.365.369"},
                new UserRole() { UserId = 3, RoleId = 5, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr",UpdatedBy = "Admin-up",IPAddress = "107.23.365.369"});
        }



        // Seed school term.
        public static void SeedTerm(ModelBuilder builder)
        {
            builder.Entity<Term>().HasData(
                new Term()
                {
                    ID = 1,
                    SchTerm = 1,
                    TermName = "Term one",
                    CreatedBy = "Ronald",
                    IPAddress = "255.255.255.1",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                new Term()
                {
                    ID = 2,
                    SchTerm = 2,
                    TermName = "Term two",
                    CreatedBy = "Ronald",
                    IPAddress = "255.255.255.1",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                new Term()
                {
                    ID = 3,
                    SchTerm = 3,
                    TermName = "Term three",
                    CreatedBy = "Ronald",
                    IPAddress = "255.255.255.1",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                new Term()
                {
                    ID = 4,
                    SchTerm = 4,
                    TermName = "Term four",
                    CreatedBy = "Ronald",
                    IPAddress = "255.255.255.1",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                });
        }
        // Seed user role.
        public static void SeedSchoolYear(ModelBuilder builder)
        {
            builder.Entity<SchoolYear>().HasData(
                new SchoolYear()
                {
                    ID = 1,
                    Year = 1,
                    Code = "Y01",
                    Description = "This is year 1 student",
                    CreatedBy = "RonaldAdmin",
                    CreatedDate = DateTime.UtcNow.AddHours(12),
                    IPAddress = "20.36.323.366",
                },
                 new SchoolYear()
                 {
                     ID = 2,
                     Year = 2,
                     Code = "Y02",
                     Description = "This is year 2 student",
                     CreatedBy = "RonaldAdmin",
                     CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "20.36.323.366",
                 },
                  new SchoolYear()
                  {
                      ID = 3,
                      Year = 3,
                      Code = "Y03",
                      Description = "This is year 3 student",
                      CreatedBy = "RonaldAdmin",
                      CreatedDate = DateTime.UtcNow.AddHours(12),
                      IPAddress = "20.36.323.366",
                  },
                 new SchoolYear()
                 {
                     ID = 4,
                     Year = 4,
                     Code = "Y04",
                     Description = "This is year 4 student",
                     CreatedBy = "RonaldAdmin",
                     CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "20.36.323.366",
                 },
                 new SchoolYear()
                 {
                     ID = 5,
                     Year = 5,
                     Code = "Y05",
                     Description = "This is year 5 student",
                     CreatedBy = "RonaldAdmin",
                     CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "20.36.323.366",
                 },
                 new SchoolYear()
                 {
                     ID = 6,
                     Year = 6,
                     Code = "Y06",
                     Description = "This is year 6 student",
                     CreatedBy = "RonaldAdmin",
                     CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "20.36.323.366",
                 },
                 new SchoolYear()
                 {
                     ID = 7,
                     Year = 07,
                     Code = "Y07",
                     Description = "This is year 7 student",
                     CreatedBy = "RonaldAdmin",
                     CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "20.36.323.366",
                 },
                 new SchoolYear()
                 {
                     ID = 8,
                     Year = 08,
                     Code = "Y08",
                     Description = "This is year 8 student",
                     CreatedBy = "RonaldAdmin",
                     CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "20.36.323.366",
                 },
                 new SchoolYear()
                 {
                     ID = 9,
                     Year = 09,
                     Code = "Y09",
                     Description = "This is year 9 student",
                     CreatedBy = "RonaldAdmin",
                     CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "20.36.323.366",
                 },
                 new SchoolYear()
                 {
                     ID = 10,
                     Year = 10,
                     Code = "Y10",
                     Description = "This is year 10 student",
                     CreatedBy = "RonaldAdmin",
                     CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "20.36.323.366",
                 },
                 new SchoolYear()
                 {
                     ID = 11,
                     Year = 11,
                     Code = "Y11",
                     Description = "This is year 11 student",
                     CreatedBy = "RonaldAdmin",
                     CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "20.36.323.366",
                 },
                 new SchoolYear()
                 {
                     ID = 12,
                     Year = 12,
                     Code = "Y12",
                     Description = "This is year 12 student",
                     CreatedBy = "RonaldAdmin",
                     CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "20.36.323.366",
                 },
                 new SchoolYear()
                 {
                     ID = 13,
                     Year = 13,
                     Code = "Y13",
                     Description = "This is year 13 student",
                     CreatedBy = "RonaldAdmin",
                     CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "20.36.323.366",
                 });



        }

        //Seed school rooms(blocks).
        public static void SeedClassRoom(ModelBuilder builder)
        {
            builder.Entity<ClassRoom>().HasData(
                new ClassRoom()
                {
                    ID = 1,
                    Name = "Form 3 A",
                    Code = "3A",
                    Description = "Form 3 A block info",
                    SchoolId = 1,
                    SchoolYearId = 1,
                    SeatingCapacity = 52,
                    CreatedDate = DateTime.UtcNow.AddHours(12),
                },
               new ClassRoom()
               {
                   ID = 2,
                   Name = "Form 4 B",
                   Code = "4B",
                   Description = "Form 4 B block info",
                   SchoolId = 1,
                   SchoolYearId = 1,
                   SeatingCapacity = 52,
                   CreatedDate = DateTime.UtcNow.AddHours(12),
               });
        }



        // Seed course entity

        public static void SeedCourse(ModelBuilder builder)
        {
            builder.Entity<Course>().HasData(
                new Course()
                {
                    ID = 1,Code = "Y11SC",Name = "Y11Science",Description = "Year 11 Science", SchoolYearId = 11,
                    CreatedBy = "RonAdmin",UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                },
                new Course()
                {
                    ID = 2, Code = "Y12SC",Name = "Y12Science",Description = "Year 12 Science",SchoolYearId = 12,
                    CreatedBy = "RonAdmin", UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12),IPAddress = "255.255.255.1",
                },
                new Course()
                {
                    ID = 3,Code = "Y09CO",Name = "Y09Commercial",Description = "Year 09 Commercial",
                    SchoolYearId = 9,CreatedBy = "RonAdmin",UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12),
                    IPAddress = "255.255.255.1",
                },
                new Course()
                {
                    ID = 4,Code = "Y09EN",Name = "Y09Engineering",Description = "Year 09 Engineering",
                    SchoolYearId = 9,CreatedBy = "RonAdmin",UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12),
                    IPAddress = "255.255.255.1",
                },
                new Course()
                {
                    ID = 5,Code = "Y09SC",Name = "Y09Science",Description = "Year 09 Science",
                    SchoolYearId = 9,CreatedBy = "RonAdmin",UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12),
                    IPAddress = "255.255.255.1",
                }, 
                new Course()
                {
                    ID = 6,Code = "Y09SC2",Name = "Y09Science II",Description = "Year 09 Science II",
                    SchoolYearId = 9,CreatedBy = "RonAdmin",UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12),
                    IPAddress = "255.255.255.1",
                },
                 new Course()
                {
                    ID = 7,Code = "Y11CO",Name = "Y11Commercial",Description = "Year 11 Commercial", SchoolYearId = 11,
                    CreatedBy = "RonAdmin",UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                },
                 new Course()
                {
                    ID = 8,Code = "Y11EN",Name = "Y11Engineering",Description = "Year 11 Engineering", SchoolYearId = 11,
                    CreatedBy = "RonAdmin",UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                },
                 new Course()
                {
                    ID = 9,Code = "Y12CO",Name = "Y12Commercial",Description = "Year 12 Commercial", SchoolYearId = 12,
                    CreatedBy = "RonAdmin",UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                }
                

                );

        }

        //Seed subject table
        public static void SeedSubject(ModelBuilder builder)
        {
            builder.Entity<Subject>().HasData(
                new Subject()
                {
                    ID = 1,Name = "Biology, Year 11",ReferenceBook = "Molecular Biology",
                    Description = "Year 11 Biology",Code = "Y11BIO",CreatedBy = "RonAdmin",
                    UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12),IPAddress = "255.255.255.1",
                    
                },
                 new Subject()
                 {
                     ID = 2, Name = "English, Year 12",ReferenceBook = "Peoples English 1", Description = "English for Year 12",
                     Code = "Y12ENG",CreatedBy = "RonAdmin",UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12),
                     IPAddress = "255.255.255.1",                    
                 },new Subject()
                 {
                     ID = 3, Code = "Y11MAT", Name = "Mathmatics, Year 11",
                     Description = "Year 11 Mathmatics",ReferenceBook = "Calculus 1",                  
                     CreatedBy = "RonAdmin", UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                 },new Subject()
                 {
                     ID = 4, Code = "Y11CHM", Name = "Chemistry, Year 11",
                     Description = "Year 11 Chemistry",ReferenceBook = "Atmosphere and Reaction",                  
                     CreatedBy = "RonAdmin", UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                 },new Subject()
                 {
                     ID = 5, Code = "Y09MAT", Name = "Mathmatics, Year 09",
                     Description = "Year 09 Mathmatics",ReferenceBook = "Linear Algebra",                  
                     CreatedBy = "RonAdmin", UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                 },new Subject()
                 {
                     ID = 6, Code = "Y09ENG", Name = "English, Year 09",
                     Description = "Year 09 English",ReferenceBook = "Peoples English",                  
                     CreatedBy = "RonAdmin", UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                 },new Subject()
                 {
                     ID = 7, Code = "Y09BSC", Name = "Basic Science, Year 09",
                     Description = "Year 09 Basic Science",ReferenceBook = "Air and Water density",                  
                     CreatedBy = "RonAdmin", UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                 },new Subject()
                 {
                     ID = 8, Code = "Y09TD", Name = "Technical Drawing, Year 09",
                     Description = "Year 09 Technical Drawing",ReferenceBook = "Basic Auto cad by Ron Fiji",                  
                     CreatedBy = "RonAdmin", UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                 },new Subject()
                 {
                     ID = 9, Code = "Y09AGS", Name = "Agriculture Science, Year 09",
                     Description = "Year 09 Agriculture Science",ReferenceBook = "Plant hoticulture",                  
                     CreatedBy = "RonAdmin", UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                 },new Subject()
                 {
                     ID = 10, Code = "Y09ACC", Name = "Accounting, Year 09",
                     Description = "Year 09 Accounting",ReferenceBook = "Ledger and balance sheet",                  
                     CreatedBy = "RonAdmin", UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                 },new Subject()
                 {
                     ID = 11, Code = "Y09ECO", Name = "Economic, Year 09",
                     Description = "Year 09 Economics",ReferenceBook = "Capital and Investment by Ronald Fiji",                  
                     CreatedBy = "RonAdmin", UpdatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "255.255.255.1",
                 });

        }


        // Seed foreign key for Subject and Course
        public static void SeedCourseSubject(ModelBuilder builder)
        {
            builder.Entity<CourseSubject>().HasData(
                new CourseSubject() { CourseId = 1, SubjectId = 1, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin" , IPAddress="245.36.210.199" },
                new CourseSubject() { CourseId = 1, SubjectId = 3, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 1, SubjectId = 4, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 2, SubjectId = 2, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 3, SubjectId = 5, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 3, SubjectId = 6, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 3, SubjectId = 7, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 3, SubjectId = 10, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 3, SubjectId = 11, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 4, SubjectId = 5, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 4, SubjectId = 6, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 4, SubjectId = 7, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 4, SubjectId = 8, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 4, SubjectId = 9, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 5, SubjectId = 5, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 5, SubjectId = 6, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 5, SubjectId = 7, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 6, SubjectId = 5, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 6, SubjectId = 6, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 6, SubjectId = 7, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 6, SubjectId = 9, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 7, SubjectId = 3, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 8, SubjectId = 3, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" },
                new CourseSubject() { CourseId = 9, SubjectId = 2, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "RonAdmin", IPAddress = "245.36.210.199" }

                );
        }



        //Seed Assessment table
        public static void SeedAssessment(ModelBuilder builder)
        {
            builder.Entity<Assessment>().HasData(
                new Assessment()
                {
                    ID = 1,  Code = "Y11BIOST1",  Name = "Short Test 1, Year 11 Biology", Weight = 10,SubjectID = 1,TermID = 1,
                    CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                    ID = 2,  Code = "Y11BIOST2",  Name = "Short Test 2, Year 11 Biology", Weight = 10,SubjectID = 1,TermID = 1,
                    CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                    ID = 3,  Code = "Y11BIOST3",  Name = "Short Test 3, Year 11 Biology", Weight = 10,SubjectID = 1,TermID = 2,
                    CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                 new Assessment()
                {
                    ID = 4,  Code = "Y11BIOST4",  Name = "Short Test 4, Year 11 Biology", Weight = 10,SubjectID = 1,TermID = 2,
                    CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                  new Assessment()
                {
                    ID = 5,  Code = "Y11BIOST5",  Name = "Short Test 5, Year 11 Biology", Weight = 10,SubjectID = 1,TermID = 3,
                    CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                    ID = 6,  Code = "Y11BIOST6",  Name = "Short Test 6, Year 11 Biology", Weight = 10,SubjectID = 1,TermID = 3,
                    CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                 new Assessment()
                {
                    ID = 7,  Code = "Y11BIOPR1",  Name = "Project 1, Year 11 Biology", Weight = 20,SubjectID = 1,TermID = 2,
                    CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                  new Assessment()
                {
                    ID = 8,  Code = "Y11BIOPR2",  Name = "Project 2, Year 11 Biology", Weight = 20,SubjectID = 1,TermID = 3,
                    CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },

                new Assessment()
                {
                  ID = 9,  Code = "Y12ENGST1",  Name = "Short Test 1, Year 12 English", Weight = 10,SubjectID = 2,TermID = 1,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 10,  Code = "Y12ENGST2",  Name = "Short Test 2, Year 12 English", Weight = 10,SubjectID = 2,TermID = 1,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 11,  Code = "Y12ENGST3",  Name = "Short Test 3, Year 12 English", Weight = 10,SubjectID = 2,TermID = 1,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 12,  Code = "Y12ENGST4",  Name = "Short Test 4, Year 12 English", Weight = 10,SubjectID = 2,TermID = 2,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 13,  Code = "Y12ENGST5",  Name = "Short Test 5, Year 12 English", Weight = 10,SubjectID = 2,TermID = 2,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 14,  Code = "Y12ENGST6",  Name = "Short Test 6, Year 12 English", Weight = 10,SubjectID = 2,TermID = 2,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 15,  Code = "Y12ENGST7",  Name = "Short Test 7, Year 12 English", Weight = 10,SubjectID = 2,TermID = 3,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 16,  Code = "Y12ENGST8",  Name = "Short Test 8, Year 12 English", Weight = 15,SubjectID = 2,TermID = 3,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 17,  Code = "Y12ENGST9",  Name = "Short Test 9, Year 12 English", Weight = 15,SubjectID = 2,TermID = 3,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 18,  Code = "Y11MATST1",  Name = "Short Test 1, Year 11 Mathmatics", Weight = 10,SubjectID = 3,TermID = 1,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 19,  Code = "Y11MATST2",  Name = "Short Test 2, Year 11 Mathmatics", Weight = 15,SubjectID = 3,TermID = 1,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 20,  Code = "Y11MATST3",  Name = "Short Test 3, Year 11 Mathmatics", Weight = 20,SubjectID = 3,TermID = 2,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 21,  Code = "Y11MATST4",  Name = "Short Test 4, Year 11 Mathmatics", Weight = 15,SubjectID = 3,TermID = 2,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 22,  Code = "Y11MATST5",  Name = "Short Test 5, Year 11 Mathmatics", Weight = 20,SubjectID = 3,TermID = 3,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 23,  Code = "Y11MATST6",  Name = "Short Test 6, Year 11 Mathmatics", Weight = 20,SubjectID = 3,TermID = 3,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 24,  Code = "Y11CHMST1",  Name = "Short Test 1, Year 11 Chemistry", Weight = 10,SubjectID = 4,TermID = 1,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 25,  Code = "Y11CHMST2",  Name = "Short Test 2, Year 11 Chemistry", Weight = 20,SubjectID = 4,TermID = 1,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 26,  Code = "Y11CHMST3",  Name = "Short Test 3, Year 11 Chemistry", Weight = 10,SubjectID = 4,TermID = 2,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 27,  Code = "Y11CHMST4",  Name = "Short Test 4, Year 11 Chemistry", Weight = 20,SubjectID = 4,TermID = 2,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 28,  Code = "Y11CHMST5",  Name = "Short Test 5, Year 11 Chemistry", Weight = 20,SubjectID = 4,TermID = 3,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 29,  Code = "Y11CHMST6",  Name = "Short Test 6, Year 11 Chemistry", Weight = 20,SubjectID = 4,TermID = 3,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 30,  Code = "Y09MATST1",  Name = "Short Test 1, Year 09 Mathmatics", Weight = 10,SubjectID = 5,TermID = 1,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 31,  Code = "Y09MATST2",  Name = "Short Test 2, Year 09 Mathmatics", Weight = 10,SubjectID = 5,TermID = 1,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 32,  Code = "Y09MATST3",  Name = "Short Test 3, Year 09 Mathmatics", Weight = 10,SubjectID = 5,TermID = 1,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 33,  Code = "Y09MATST4",  Name = "Short Test 4, Year 09 Mathmatics", Weight = 10,SubjectID = 5,TermID = 2,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 34,  Code = "Y09MATST5",  Name = "Short Test 5, Year 09 Mathmatics", Weight = 10,SubjectID = 5,TermID = 2,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 35,  Code = "Y09MATST6",  Name = "Short Test 6, Year 09 Mathmatics", Weight = 10,SubjectID = 5,TermID = 2,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 36,  Code = "Y09MATST7",  Name = "Short Test 7, Year 09 Mathmatics", Weight = 10,SubjectID = 5,TermID = 3,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 37,  Code = "Y09MATPR1",  Name = "Project 1, Year 09 Mathmatics", Weight = 15,SubjectID = 5,TermID = 3,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                  ID = 38,  Code = "Y09MATPR2",  Name = "Project 2, Year 09 Mathmatics", Weight = 15,SubjectID = 5,TermID = 3,
                  CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 39,  Code = "Y09ENGST1",  Name = "Short Test 1, Year 09 English", Weight = 10,SubjectID = 6,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 40,  Code = "Y09ENGST2",  Name = "Short Test 2, Year 09 English", Weight = 10,SubjectID = 6,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 41,  Code = "Y09ENGST3",  Name = "Short Test 3, Year 09 English", Weight = 10,SubjectID = 6,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 42,  Code = "Y09ENGST4",  Name = "Short Test 4, Year 09 English", Weight = 10,SubjectID = 6,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 43,  Code = "Y09ENGST5",  Name = "Short Test 5, Year 09 English", Weight = 10,SubjectID = 6,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 44,  Code = "Y09ENGPR1",  Name = "Project 1, Year 09 English", Weight = 20,SubjectID = 6,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 45,  Code = "Y09ENGST6",  Name = "Short Test 6, Year 09 English", Weight = 10,SubjectID = 6,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 46,  Code = "Y09ENGST7",  Name = "Short Test 7, Year 09 English", Weight = 10,SubjectID = 6,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 47,  Code = "Y09ENGPR2",  Name = "Project 2, Year 09 English", Weight = 20,SubjectID = 6,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 48,  Code = "Y09BSCST1",  Name = "Short Test 1, Year 09 Basic Science", Weight = 10,SubjectID = 7,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 49,  Code = "Y09BSCST2",  Name = "Short Test 2, Year 09 Basic Science", Weight = 10,SubjectID = 7,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 50,  Code = "Y09BSCRT1",  Name = "Report 1, Year 09 Basic Science", Weight = 10,SubjectID = 7,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 51,  Code = "Y09BSCST3",  Name = "Short Test 3, Year 09 Basic Science", Weight = 10,SubjectID = 7,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 52,  Code = "Y09BSCST4",  Name = "Short Test 4, Year 09 Basic Science", Weight = 10,SubjectID = 7,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 53,  Code = "Y09BSCRT2",  Name = "Report 2, Year 09 Basic Science", Weight = 10,SubjectID = 7,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 54,  Code = "Y09BSCST5",  Name = "Short Test 5, Year 09 Basic Science", Weight = 10,SubjectID = 7,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 55,  Code = "Y09BSCST6",  Name = "Short Test 6, Year 09 Basic Science", Weight = 10,SubjectID = 7,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 56,  Code = "Y09BSCRT3",  Name = "Report 3, Year 09 Basic Science", Weight = 20,SubjectID = 7,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 57,  Code = "Y09TDST1",  Name = "Short Test 7, Year 09 Technical Drawing", Weight = 10,SubjectID = 8,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 58,  Code = "Y09TDST2",  Name = "Short Test 2, Year 09 Technical Drawing", Weight = 10,SubjectID = 8,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 59,  Code = "Y09TDST3",  Name = "Short Test 3, Year 09 Technical Drawing", Weight = 10,SubjectID = 8,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 60,  Code = "Y09TDST4",  Name = "Short Test 4, Year 09 Technical Drawing", Weight = 10,SubjectID = 8,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },

                new Assessment()
                {
                ID = 61,  Code = "Y09TDST5",  Name = "Short Test 5, Year 09 Technical Drawing", Weight = 10,SubjectID = 8,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 62,  Code = "Y09TDST6",  Name = "Short Test 6, Year 09 Technical Drawing", Weight = 10,SubjectID = 8,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 63,  Code = "Y09TDST7",  Name = "Short Test 7, Year 09 Technical Drawing", Weight = 10,SubjectID = 8,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 64,  Code = "Y09TDST8",  Name = "Short Test 8, Year 09 Technical Drawing", Weight = 10,SubjectID = 8,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 65,  Code = "Y09TDPR1",  Name = "Project 1, Year 09 Technical Drawing", Weight = 10,SubjectID = 8,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 66,  Code = "Y09TDPR2",  Name = "Project 2, Year 09 Technical Drawing", Weight = 10,SubjectID = 8,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 67,  Code = "Y09AGSST1",  Name = "Short Test 1, Year 09 Agriculture Science", Weight = 10,SubjectID = 9,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 68,  Code = "Y09AGSST2",  Name = "Short Test 2, Year 09 Agriculture Science", Weight = 10,SubjectID = 9,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 69,  Code = "Y09AGSST3",  Name = "Short Test 3, Year 09 Agriculture Science", Weight = 10,SubjectID = 9,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 70,  Code = "Y09AGSST4",  Name = "Short Test 4, Year 09 Agriculture Science", Weight = 10,SubjectID = 9,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 71,  Code = "Y09AGSST5",  Name = "Short Test 5, Year 09 Agriculture Science", Weight = 10,SubjectID = 9,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 72,  Code = "Y09AGSST6",  Name = "Short Test 6, Year 09 Agriculture Science", Weight = 10,SubjectID = 9,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 73,  Code = "Y09AGSPR1",  Name = "Project 1, Year 09 Agriculture Science", Weight = 20,SubjectID = 9,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 74,  Code = "Y09AGSPR2",  Name = "Project 2, Year 09 Agriculture Science", Weight = 20,SubjectID = 9,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 75,  Code = "Y09ACCST1",  Name = "Short Test 1, Year 09 Accounting", Weight = 10,SubjectID = 10,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 76,  Code = "Y09ACCST2",  Name = "Short Test 2, Year 09 Accounting", Weight = 10,SubjectID = 10,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 77,  Code = "Y09ACCST3",  Name = "Short Test 3, Year 09 Accounting", Weight = 10,SubjectID = 10,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 78,  Code = "Y09ACCST4",  Name = "Short Test 4, Year 09 Accounting", Weight = 10,SubjectID = 10,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 79,  Code = "Y09ACCST5",  Name = "Short Test 5, Year 09 Accounting", Weight = 10,SubjectID = 10,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 80,  Code = "Y09ACCST6",  Name = "Short Test 6, Year 09 Accounting", Weight = 10,SubjectID = 10,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 81,  Code = "Y09ACCST7",  Name = "Short Test 7, Year 09 Accounting", Weight = 10,SubjectID = 10,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },

                new Assessment()
                {
                ID = 82,  Code = "Y09ACCST8",  Name = "Short Test 8, Year 09 Accounting", Weight = 10,SubjectID = 10,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 83,  Code = "Y09ACCST9",  Name = "Short Test 9, Year 09 Accounting", Weight = 10,SubjectID = 10,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 84,  Code = "Y09ACCST10",  Name = "Short Test 10, Year 09 Accounting", Weight = 10,SubjectID = 10,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 85,  Code = "Y09ECOST1",  Name = "Short Test 1, Year 09 Economics", Weight = 10,SubjectID = 11,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 86,  Code = "Y09ECOST2",  Name = "Short Test 2, Year 09 Economics", Weight = 10,SubjectID = 11,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 87,  Code = "Y09ECOST3",  Name = "Short Test 3, Year 09 Economics", Weight = 10,SubjectID = 11,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 88,  Code = "Y09ECOST4",  Name = "Short Test 4, Year 09 Economics", Weight = 10,SubjectID = 11,TermID = 1,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 89,  Code = "Y09ECOST5",  Name = "Short Test 5, Year 09 Economics", Weight = 10,SubjectID = 11,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 90,  Code = "Y09ECOST6",  Name = "Short Test 6, Year 09 Economics", Weight = 10,SubjectID = 11,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 91,  Code = "Y09ECOPR1",  Name = "Project 1, Year 09 Economics", Weight = 10,SubjectID = 11,TermID = 2,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 92,  Code = "Y09ECOST6",  Name = "Short Test 6, Year 09 Economics", Weight = 10,SubjectID = 11,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 93,  Code = "Y09ECOST7",  Name = "Short Test 7, Year 09 Economics", Weight = 10,SubjectID = 11,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                },
                new Assessment()
                {
                ID = 94,  Code = "Y09ECOPR2",  Name = "Project 2, Year 09 Economics", Weight = 10,SubjectID = 11,TermID = 3,
                CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12), IPAddress = "230.145.124.210",
                }   
                );
                

                
        }


        //Seed Prerequisite table
        public static void SeedPrerequisite(ModelBuilder builder)
        {
            builder.Entity<Prerequisite>().HasData(
                new Prerequisite()
                {
                    ID = 1, CourseID = 2,PrerequisiteCourseId = 1,
                    CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12),IPAddress = "230.145.124.210",
                },
                new Prerequisite()
                {
                    ID = 2,CourseID = 9,PrerequisiteCourseId = 7,
                    CreatedBy = "RonAdmin",CreatedDate = DateTime.UtcNow.AddHours(12),IPAddress = "230.145.124.210",
                });
        }


    }
 }
