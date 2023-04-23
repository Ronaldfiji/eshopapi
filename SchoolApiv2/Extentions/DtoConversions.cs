using DataModel.Entity;
using DataModel.Entity.EntityEShop;
using SchoolApiv2.Util;
using SharedModel.Models;
using SharedModel.Models.eShopModels;
using System.Data;
using System.Runtime.CompilerServices;

namespace SchoolApiv2.Extentions
{
    public static class DtoConversions
    {
        public static UserDto ConvertToDto(this User user)
        {
            var userRoles = new List<RoleDto>();
            var school = new SchoolDto();
            var userType = new UserTypeDto();
            var enrollments = new List<EnrollmentDto>();
            var course = new CourseDto();
            if(user.Enrollments != null &&  user.Enrollments.Any())
            {
                enrollments =
                (from enrollment in user.Enrollments

                 
                 select new EnrollmentDto()
                 {
                     Id = enrollment.ID,
                     UserId = enrollment.UserId,                     
                     CourseId = enrollment.CourseId,
                     SchoolId= enrollment.SchoolId,
                     DateEnrolled = enrollment.DateEnrolment,
                     DateWithdrawal = enrollment.DateWithdrawal,
                     Passed = enrollment.Passed,
                     DateCompleted= enrollment.DateCompleted,
                     CreatedDate = enrollment.CreatedDate,
                     ModifiedDate = enrollment.ModifiedDate,
                     CreatedBy = enrollment.CreatedBy,
                     UpdatedBy = enrollment.UpdatedBy,
                     IPAddress = enrollment.IPAddress,
                     CourseEnrolled = new CourseDto() { Id = enrollment.Course.ID, Code = enrollment.Course.Code, Name= enrollment.Course.Name,
                         Description= enrollment.Course.Description,
                         SchoolYear = new SchoolYearDto()   {Id = enrollment.Course.SchoolYear.ID,
                                                            Year= enrollment.Course.SchoolYear.Year, 
                                                            Code = enrollment.Course.SchoolYear.Code}
                        ,CreatedDate= enrollment.Course.CreatedDate, ModifiedDate= enrollment.Course.ModifiedDate,
                         CreatedBy= enrollment.Course.CreatedBy,UpdatedBy= enrollment.Course.UpdatedBy,
                     },
                     School = enrollment.School != null ?                
                                new SchoolDto { Id = enrollment.School.ID, Code= enrollment.School.Code, Name= enrollment.School.Name , 
                                Email= enrollment.School.Email, Phone= enrollment.School.Phone, Address = enrollment.School.Address ,
                                City = enrollment.School.City, District= enrollment.School.District,Description= enrollment.School.Description,
                                }
                                : new SchoolDto() ,
                     
                 }).ToList();                    
            }
            
            foreach (var role in user.UserRoles)
            {
                if (role.Role != null)
                {
                    userRoles.Add(new RoleDto()
                    {
                        Id = role.RoleId,
                        Name = role.Role.Name,
                        Description = role.Role.Description,
                    });
                }
            }

            if (user.UserType != null)
            {
                userType = new UserTypeDto { Id = user.UserType.ID, Name = user.UserType.Name, Description = user.UserType.Description };

            }

            return new UserDto
            {
                Id = user.ID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Gender = user.Gender.ToString(),
                Email = user.Email,
                Phone = user.Phone,
                DOB = user.DOB,
                AddressLine1 = user.AddressLine1,
                AddressLine2 = user.AddressLine2,
                City = user.City,
                State = user.State,
                PostalCode = user.PostalCode,
                Country = user.Country,
                Roles = userRoles,
                CreatedDate = user.CreatedDate,
                ModifiedDate = user.ModifiedDate,
                CreatedBy = user.CreatedBy,
                UpdatedBy = user.UpdatedBy,
                IPAddress = user.IPAddress,
                UserPictures = (from pics in user.UserPictures
                                select new UserPicturesDto()
                                {
                                    Id = pics.ID,
                                    Name = pics.Name,
                                    Description = pics.Description,
                                    Path = pics.Path,
                                }).ToList(),
                UserType = userType,   
                Enrollments =  enrollments,
                

                                                            

               

            };
        }


        public static IEnumerable<UserDto> ConvertToDto(this IEnumerable<User> Users)
        {

            return (from user in Users
                    select new UserDto
                    {
                        Id = user.ID,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Gender = user.Gender.ToString(),
                        Email = user.Email,
                        Phone = user.Phone,
                        DOB = user.DOB,
                        AddressLine1 = user.AddressLine1,
                        AddressLine2 = user.AddressLine2,
                        City = user.City,
                        State = user.State,
                        PostalCode = user.PostalCode,
                        Country = user.Country,
                        Roles = (from role in user.UserRoles
                                 select new RoleDto
                                 {
                                     Id = role.RoleId,
                                     Name = role.Role.Name,
                                     Description = role.Role.Description,

                                 }).ToList(),

                        UserPictures = (from pics in user.UserPictures
                                        select new UserPicturesDto()
                                        {
                                            Id = pics.ID,
                                            Name = pics.Name,
                                            Description = pics.Description,
                                            Path = pics.Path,
                                        }).ToList(),


                        UserType = user.UserType != null ? new UserTypeDto()
                        {
                            Id = user.UserType.ID,
                            Name = user.UserType.Name,
                            Description = user.UserType.Description,
                            CreatedDate = user.CreatedDate,
                            ModifiedDate = user.ModifiedDate,
                            CreatedBy = user.CreatedBy,
                            UpdatedBy = user.UpdatedBy,
                            IPAddress = user.IPAddress,
                        } : new UserTypeDto(),


                        CreatedDate = user.CreatedDate,
                        ModifiedDate = user.ModifiedDate,
                        CreatedBy = user.CreatedBy,
                        UpdatedBy = user.UpdatedBy,
                        IPAddress = user.IPAddress,

                    }).ToList();

        }

        public static RoleDto ConvertToDto(this Role role)
        {
            return new RoleDto
            {
                Id = role.ID,
                Name = role.Name,
                Description = role.Description,
                CreatedDate = role.CreatedDate,
                CreatedBy = role.CreatedBy,
                UpdatedBy = role.UpdatedBy,
                IPAddress = role.IPAddress,
            };
        }

        public static IEnumerable<RoleDto> ConvertToDto(this IEnumerable<Role> roles)
        {
            return (
            from role in roles
            select new RoleDto
            {
                Id = role.ID,
                Name = role.Name,
                Description = role.Description,
                CreatedDate = role.CreatedDate,
                CreatedBy = role.CreatedBy,
                UpdatedBy = role.UpdatedBy,
                IPAddress = role.IPAddress
            }).ToList();

        }

        public static CourseDto ConvertToDto(this Course course)
        {

            var schoolYear = new SchoolYearDto();

            var subjectsDto = new List<SubjectDto>();
          
            foreach (var cs in course.CourseSubject)
            {
                if (cs.Subject != null)
                {
                    subjectsDto.Add(new SubjectDto()
                    {
                        Id = cs.SubjectId,
                        Name = cs.Subject.Name,
                        Description = cs.Subject.Description,
                        Code = cs.Subject.Code,
                        ReferenceBook= cs.Subject.ReferenceBook,
                        CreatedBy = cs.Subject.CreatedBy,
                        CreatedDate = cs.Subject.CreatedDate,
                        ModifiedDate = cs.Subject.ModifiedDate,
                        UpdatedBy = cs.Subject.UpdatedBy,
                        IPAddress = cs.Subject.IPAddress,
                        AssessmentDto = (from ass in cs.Subject.Assessment select new AssessmentDto()
                        {
                            Id = ass.ID,
                            Code= ass.Code,
                            Name= ass.Name,
                            Weight= ass.Weight,
                            SubjectID = ass.SubjectID,
                            CreatedDate = ass.CreatedDate,
                            ModifiedDate= ass.ModifiedDate,
                            CreatedBy= ass.CreatedBy,
                            UpdatedBy= ass.UpdatedBy,
                            IPAddress= ass.IPAddress,                            
                        }).ToList(),
                    }) ;
                }
            }


            if (course.SchoolYear != null)
            {
                schoolYear = new SchoolYearDto
                {
                    Id = course.SchoolYear.ID,
                    Year = course.SchoolYear.Year,
                    Code = course.SchoolYear.Code,
                    Description = course.SchoolYear.Description
                };
            }

            return new CourseDto
            {
                Id = course.ID,
                Code = course.Code,
                Name = course.Name,
                SchoolYear = schoolYear,
                Description = course.Description,
                CreatedDate = course.CreatedDate,
                CreatedBy = course.CreatedBy,
                ModifiedDate = course.ModifiedDate,
                UpdatedBy = course.UpdatedBy,
                IPAddress = course.IPAddress,
                Subjects = subjectsDto.ToList(),               

            };
        }

        public static IEnumerable<CourseDto> ConvertToDto(this IEnumerable<Course> Courses)
        {
            return (
            from course in Courses
            select new CourseDto
            {
                Id = course.ID,
                Code = course.Code,
                Name = course.Name,
                Description = course.Description,
                SchoolYear = new SchoolYearDto
                {
                    Id = course.SchoolYear.ID,
                    Year = course.SchoolYear.Year,
                    Code = course.SchoolYear.Code,
                    Description = course.SchoolYear.Description
                },
                CreatedDate = course.CreatedDate,
                ModifiedDate = course.ModifiedDate,
                CreatedBy = course.CreatedBy,
                UpdatedBy = course.UpdatedBy,
                IPAddress = course.IPAddress,
                Subjects = (from cs in course.CourseSubject
                            select new SubjectDto
                            {
                                Id = cs.SubjectId,
                                Name = cs.Subject?.Name ?? "",
                                Code = cs.Subject?.Code ?? "",
                                Description = cs.Subject?.Description ?? "",
                                ReferenceBook= cs.Subject?.ReferenceBook ?? "",
                                CreatedDate= cs.Subject?.CreatedDate,
                                ModifiedDate= cs.Subject?.ModifiedDate,
                                CreatedBy= cs.Subject?.CreatedBy,
                                UpdatedBy= cs.Subject?.UpdatedBy,
                                IPAddress= cs.Subject?.IPAddress,                             
                                AssessmentDto = (from ass in cs?.Subject?.Assessment
                                                 select new AssessmentDto
                                                 {
                                                     Id = ass.ID,
                                                     Name = ass.Name,
                                                     Code = ass.Code,
                                                     SubjectID = ass.SubjectID,
                                                     TermID = ass.TermID,
                                                     Weight = ass.Weight,
                                                     CreatedBy = ass.CreatedBy,
                                                     UpdatedBy = ass.UpdatedBy,
                                                     CreatedDate = ass.CreatedDate,
                                                     ModifiedDate = ass.ModifiedDate,
                                                     IPAddress = ass.IPAddress,
                                                 }).ToList(),

                            }).ToList()

            }).ToList();

        }


        public static UserTypeDto ConvertToDto(this UserType userType)
        {
            return new UserTypeDto
            {
                Id = userType.ID,
                Name = userType.Name,
                Description = userType.Description,
                CreatedDate = userType.CreatedDate,
                CreatedBy = userType.CreatedBy,
                UpdatedBy = userType.UpdatedBy,
                IPAddress = userType.IPAddress,
            };
        }

        public static IEnumerable<UserTypeDto> ConvertToDto(this IEnumerable<UserType> UserTypes)
        {
            return (
            from userType in UserTypes
            select new UserTypeDto
            {
                Id = userType.ID,
                Name = userType.Name,
                Description = userType.Description,
                CreatedDate = userType.CreatedDate,
                CreatedBy = userType.CreatedBy,
                UpdatedBy = userType.UpdatedBy,
                IPAddress = userType.IPAddress,

            }).ToList();

        }

        // Convert subject to subjectDto

        public static SubjectDto ConvertToDto(this Subject subject)
        {
            return new SubjectDto
            {
                Id = subject.ID,
                Code = subject.Code,
                Name = subject.Name,
                ReferenceBook = subject.ReferenceBook,
                Description = subject.Description,
                CreatedDate = subject.CreatedDate,
                CreatedBy = subject.CreatedBy,
                UpdatedBy = subject.UpdatedBy,
                IPAddress = subject.IPAddress,
                ModifiedDate = subject.ModifiedDate,                
                AssessmentDto = (from ass in subject.Assessment
                                 select new AssessmentDto
                                 {
                                     Id = ass.ID,
                                     Name = ass.Name,
                                     Code = ass.Code,
                                     SubjectID = ass.SubjectID,
                                     TermID = ass.TermID,
                                     Weight = ass.Weight,
                                     CreatedBy = ass.CreatedBy,
                                     UpdatedBy = ass.UpdatedBy,
                                     CreatedDate = ass.CreatedDate,
                                     ModifiedDate = ass.ModifiedDate,
                                     IPAddress = ass.IPAddress,
                                 }).ToList(),
            };
        }

        public static IEnumerable<SubjectDto> ConvertToDto(this IEnumerable<Subject> Subjects)
        {
            return (
            from subject in Subjects
            select new SubjectDto
            {
                Id = subject.ID,
                Code = subject.Code,
                Name = subject.Name,
                ReferenceBook = subject.ReferenceBook,
                Description = subject.Description,
                CreatedDate = subject.CreatedDate,
                CreatedBy = subject.CreatedBy,
                UpdatedBy = subject.UpdatedBy,
                IPAddress = subject.IPAddress,
                ModifiedDate = subject.ModifiedDate,             
                AssessmentDto = (from ass in subject.Assessment
                                 select new AssessmentDto
                                 {
                                     Id = ass.ID,
                                     Name = ass.Name,
                                     Code = ass.Code,
                                     SubjectID = ass.SubjectID,
                                     TermID = ass.TermID,
                                     Weight = ass.Weight,
                                     CreatedBy = ass.CreatedBy,
                                     UpdatedBy = ass.UpdatedBy,
                                     CreatedDate = ass.CreatedDate,
                                     ModifiedDate = ass.ModifiedDate,
                                     IPAddress = ass.IPAddress,
                                 }).ToList(),

            }).ToList();

        }

        // Convert Assessment object to AssessmentDto

        public static AssessmentDto ConvertToDto(this Assessment assessment)
        {
            return new AssessmentDto
            {
                Id = assessment.ID,
                Code = assessment.Code,
                Name = assessment.Name,
                Weight = assessment.Weight,
                SubjectID = assessment.SubjectID,
                TermID = assessment.TermID,
                CreatedDate = assessment.CreatedDate,
                ModifiedDate = assessment.ModifiedDate,
                CreatedBy = assessment.CreatedBy,
                UpdatedBy = assessment.UpdatedBy,
                IPAddress = assessment.IPAddress,
            };
        }

        public static IEnumerable<AssessmentDto> ConvertToDto(this IEnumerable<Assessment> Assessments)
        {
            return (
            from assessment in Assessments
            select new AssessmentDto
            {
                Id = assessment.ID,
                Code = assessment.Code,
                Name = assessment.Name,
                Weight = assessment.Weight,
                SubjectID = assessment.SubjectID,
                TermID = assessment.TermID,
                CreatedDate = assessment.CreatedDate,
                ModifiedDate = assessment.ModifiedDate,
                CreatedBy = assessment.CreatedBy,
                UpdatedBy = assessment.UpdatedBy,
                IPAddress = assessment.IPAddress,
            }).ToList();
        }

        // Convert Enrollment object to EnrollmentDto
        public static EnrollmentDto ConvertToDto(this Enroll enrollment)
        {
            return new EnrollmentDto
            {
                Id = enrollment.ID,
                UserId= enrollment.UserId,
                CourseId= enrollment.CourseId,
                SchoolId= enrollment.SchoolId,
                DateEnrolled = enrollment.DateEnrolment,
                DateCompleted = enrollment.DateCompleted,
                DateWithdrawal = enrollment.DateWithdrawal,
                Passed = enrollment.Passed,
                CreatedDate = enrollment.CreatedDate,
                ModifiedDate= enrollment.ModifiedDate,
                CreatedBy= enrollment.CreatedBy,
                UpdatedBy= enrollment.UpdatedBy,
                IPAddress= enrollment.IPAddress,
                School = enrollment.School != null ?                
                 new SchoolDto { Id = enrollment.School.ID, Code= enrollment.School.Code, Name= enrollment.School.Name , 
                Email= enrollment.School.Email, Phone= enrollment.School.Phone, Address = enrollment.School.Address ,
                City = enrollment.School.City, District= enrollment.School.District,Description= enrollment.School.Description,
                CreatedDate= enrollment.CreatedDate, ModifiedDate= enrollment.ModifiedDate, CreatedBy= enrollment.CreatedBy,
                UpdatedBy= enrollment.UpdatedBy, IPAddress= enrollment.IPAddress}
                 : new SchoolDto() ,
            };
        }
        public static IEnumerable<EnrollmentDto> ConvertToDto(this IEnumerable<Enroll> Enrollments)
        {
            return (
            from enrollment in Enrollments
            select new EnrollmentDto
            {
                Id = enrollment.ID,
                UserId = enrollment.UserId,
                CourseId = enrollment.CourseId,
                SchoolId= enrollment.SchoolId,
                DateEnrolled = enrollment.DateEnrolment,
                DateCompleted = enrollment.DateCompleted,
                DateWithdrawal = enrollment.DateWithdrawal,
                Passed = enrollment.Passed,
                School = enrollment.School != null ?                
                new SchoolDto { Id = enrollment.School.ID, Code= enrollment.School.Code, Name= enrollment.School.Name , 
                Email= enrollment.School.Email, Phone= enrollment.School.Phone, Address = enrollment.School.Address ,
                City = enrollment.School.City, District= enrollment.School.District,Description= enrollment.School.Description,
                CreatedDate= enrollment.CreatedDate, ModifiedDate= enrollment.ModifiedDate, CreatedBy= enrollment.CreatedBy,
                UpdatedBy= enrollment.UpdatedBy, IPAddress= enrollment.IPAddress}
                    : new SchoolDto() ,
                CreatedDate = enrollment.CreatedDate,
                ModifiedDate = enrollment.ModifiedDate,
                CreatedBy = enrollment.CreatedBy,
                UpdatedBy = enrollment.UpdatedBy,
                IPAddress = enrollment.IPAddress,
            }).ToList();
        }

        // Convert Score object to ScoreDto
        public static ScoreDto ConvertToDto(this Score score)
        {
            return new ScoreDto
            {
                Id = score.ID,
                EnrollmentID = score.EnrollmentID,
                AssessmentID = score.AssessmentID,
                Weight = score.Weight,
                Grade = score.Grade,
                AssessmentDate = score.AssessmentDate,
                AssessedBy = score.AssessedBy,
                CreatedDate = score.CreatedDate,
                ModifiedDate = score.ModifiedDate,
                CreatedBy = score.CreatedBy,
                UpdatedBy = score.UpdatedBy,
                IPAddress = score.IPAddress,

                AssessmentDto = score.Assessment != null ?

                new AssessmentDto
                {
                    Id = score.Assessment.ID,
                    Code = score.Assessment.Code,
                    Name = score.Assessment.Name,
                    Weight = score.Assessment.Weight,
                    CreatedDate = score.CreatedDate,
                    ModifiedDate = score.ModifiedDate,
                    CreatedBy = score.CreatedBy,
                    UpdatedBy = score.UpdatedBy,
                    IPAddress = score.IPAddress,
                    SubjectID = score.Assessment.SubjectID,
                        Subject = score.Assessment.Subject != null ? new SubjectDto
                        {
                            Id = score.Assessment.Subject.ID,
                            Name = score.Assessment.Subject.Name,
                            Description = score.Assessment.Subject.Description,
                            Code = score.Assessment.Subject.Code,
                            ReferenceBook = score.Assessment.Subject.ReferenceBook,
                        } : new SubjectDto(),
                    TermID = score.Assessment.TermID,
                        Term = score.Assessment.Term != null ?  new TermDto
                        {
                            Id = score.Assessment.Term.ID,
                            SchTerm = score.Assessment.Term.SchTerm,
                            TermName = score.Assessment.Term.TermName,
                            CreatedDate = score.Assessment.Term.CreatedDate,
                            ModifiedDate = score.Assessment.Term.ModifiedDate,
                            CreatedBy = score.Assessment.Term.CreatedBy,
                            UpdatedBy = score.Assessment.Term.UpdatedBy,
                            IPAddress = score.Assessment.Term.IPAddress,
                        } : new TermDto(),

                } : new AssessmentDto(),
            };
        }
        public static IEnumerable<ScoreDto> ConvertToDto(this IEnumerable<Score> Scores)
        {
            return (
            from score in Scores
            select new ScoreDto
            {
                Id = score.ID,
                EnrollmentID = score.EnrollmentID,
                AssessmentID = score.AssessmentID,
                Weight = score.Weight,
                Grade = score.Grade,
                AssessmentDate = score.AssessmentDate,
                AssessedBy = score.AssessedBy,
                CreatedDate = score.CreatedDate,
                ModifiedDate = score.ModifiedDate,
                CreatedBy = score.CreatedBy,
                UpdatedBy = score.UpdatedBy,
                IPAddress = score.IPAddress,
                AssessmentDto = score.Assessment != null ?

                new AssessmentDto
                {
                    Id = score.Assessment.ID,
                    Code = score.Assessment.Code,
                    Name = score.Assessment.Name,
                    Weight = score.Assessment.Weight,
                    CreatedDate = score.CreatedDate,
                    ModifiedDate = score.ModifiedDate,
                    CreatedBy = score.CreatedBy,
                    UpdatedBy = score.UpdatedBy,
                    IPAddress = score.IPAddress,
                    SubjectID = score.Assessment.SubjectID,
                    Subject = score.Assessment.Subject != null ? new SubjectDto
                    {
                        Id = score.Assessment.Subject.ID,
                        Name = score.Assessment.Subject.Name,
                        Description = score.Assessment.Subject.Description,
                        Code = score.Assessment.Subject.Code,
                        ReferenceBook = score.Assessment.Subject.ReferenceBook,
                    } : new SubjectDto(),
                    TermID = score.Assessment.TermID,
                    Term = score.Assessment.Term != null ? new TermDto
                    {
                        Id = score.Assessment.Term.ID,
                        SchTerm = score.Assessment.Term.SchTerm,
                        TermName = score.Assessment.Term.TermName,
                        CreatedDate = score.Assessment.Term.CreatedDate,
                        ModifiedDate = score.Assessment.Term.ModifiedDate,
                        CreatedBy = score.Assessment.Term.CreatedBy,
                        UpdatedBy = score.Assessment.Term.UpdatedBy,
                        IPAddress = score.Assessment.Term.IPAddress,
                    } : new TermDto(),

                } : new AssessmentDto(),

            }).ToList();
        }

        // Convert Prerequisite object to PrerequisiteDto
        public static PrerequisiteDto ConvertToDto(this Prerequisite prerequisite)
        {
            return new PrerequisiteDto
            {
                Id = prerequisite.ID,
                CourseID= prerequisite.CourseID,
                PrerequisiteCourseId= prerequisite.PrerequisiteCourseId,
                CreatedDate = prerequisite.CreatedDate,
                ModifiedDate = prerequisite.ModifiedDate,
                CreatedBy = prerequisite.CreatedBy,
                UpdatedBy = prerequisite.UpdatedBy,
                IPAddress = prerequisite.IPAddress,
            };
        }
        public static IEnumerable<PrerequisiteDto> ConvertToDto(this IEnumerable<Prerequisite> Prerequisites)
        {
            return (
            from prerequisite in Prerequisites
            select new PrerequisiteDto
            {
                Id = prerequisite.ID,
                CourseID = prerequisite.CourseID,
                PrerequisiteCourseId = prerequisite.PrerequisiteCourseId,
                CreatedDate = prerequisite.CreatedDate,
                ModifiedDate = prerequisite.ModifiedDate,
                CreatedBy = prerequisite.CreatedBy,
                UpdatedBy = prerequisite.UpdatedBy,
                IPAddress = prerequisite.IPAddress,

            }).ToList();
        }

        // Convert School object to SchoolDto
        public static SchoolDto ConvertToDto(this School school)
        {
            return new SchoolDto
            {
                Id= school.ID,
                Code= school.Code,
                Name= school.Name,
                Description= school.Description,
                Phone= school.Phone,
                Email= school.Email,
                City= school.City,
                Address= school.Address,
                District= school.District,
                CreatedDate= school.CreatedDate,
                ModifiedDate= school.ModifiedDate,
                CreatedBy= school.CreatedBy,
                UpdatedBy = school.UpdatedBy,
                IPAddress= school.IPAddress,                
            };
        }
        public static IEnumerable<SchoolDto> ConvertToDto(this IEnumerable<School> Schools)
        {
            return (
            from school in Schools
            select new SchoolDto
            {
                Id = school.ID,
                Code = school.Code,
                Name = school.Name,
                Description = school.Description,
                Phone = school.Phone,
                Email = school.Email,
                City = school.City,
                Address = school.Address,
                District = school.District,
                CreatedDate = school.CreatedDate,
                ModifiedDate = school.ModifiedDate,
                CreatedBy = school.CreatedBy,
                UpdatedBy = school.UpdatedBy,
                IPAddress = school.IPAddress,
            }).ToList();
        }



        // Convert SchoolYear object to SchoolYearDto
        public static SchoolYearDto ConvertToDto(this SchoolYear schoolYear)
        {
            return new SchoolYearDto
            {            
                Id = schoolYear.ID,
                Code = schoolYear.Code,
                Description= schoolYear.Description,
                Year = schoolYear.Year,
                CreatedDate= schoolYear.CreatedDate,
                ModifiedDate= schoolYear.ModifiedDate,
                CreatedBy = schoolYear.CreatedBy,
                UpdatedBy= schoolYear.UpdatedBy,
                IPAddress= schoolYear.IPAddress,
                

            };
        }
        public static IEnumerable<SchoolYearDto> ConvertToDto(this IEnumerable<SchoolYear> SchoolYears)
        {
            return (
            from schoolYear in SchoolYears
            select new SchoolYearDto
            {
                Id = schoolYear.ID,
                Code = schoolYear.Code,
                Description = schoolYear.Description,
                Year = schoolYear.Year,
                CreatedDate = schoolYear.CreatedDate,
                ModifiedDate = schoolYear.ModifiedDate,
                CreatedBy = schoolYear.CreatedBy,
                UpdatedBy = schoolYear.UpdatedBy,
                IPAddress = schoolYear.IPAddress,

            }).ToList();
        }


        // eShop DTO Conversion

        public static CategoryDto ConvertToDto(this Category category)
        {
            return new CategoryDto
            {
                ID = category.ID,
                Name = category.Name,
                Code = category.Code,
                Description = category.Description,
                Icon = category.Icon,
                CreatedDate = category.CreatedDate,
                ModifiedDate = category.ModifiedDate,
                IPAddress = category.IPAddress,

            };
        }

        public static IEnumerable<CategoryDto> ConvertToDto(this IEnumerable<Category> categorys)
        {
            return (from category in categorys
                    select new CategoryDto
                    {
                        ID = category.ID,
                        Code = category.Code,
                        Name = category.Name,
                        Description = category.Description,
                        Icon = category.Icon,
                        CreatedDate = category.CreatedDate,
                        ModifiedDate = category.ModifiedDate,
                        IPAddress = category.IPAddress,
                    }).ToList();
        }

        // Supplier object conversion

        public static SupplierDto ConvertToDto(this Supplier supplier)
        {
            return new SupplierDto
            {
                ID = supplier.ID,
                Code = supplier.Code,
                Name = supplier.Name,
                Phone = supplier.Phone,
                Email = supplier.Email,
                Address = supplier.Address,
                City = supplier.City,
                CreatedDate = supplier.CreatedDate,
                ModifiedDate = supplier.ModifiedDate,
                IPAddress = supplier.IPAddress,

            };
        }

        public static IEnumerable<SupplierDto> ConvertToDto(this IEnumerable<Supplier> suppliers)
        {
            return (from supplier in suppliers
                    select new SupplierDto
                    {
                        ID = supplier.ID,
                        Code = supplier.Code,
                        Name = supplier.Name,
                        Phone = supplier.Phone,
                        Email = supplier.Email,
                        Address = supplier.Address,
                        City = supplier.City,
                        CreatedDate = supplier.CreatedDate,
                        ModifiedDate = supplier.ModifiedDate,
                        IPAddress = supplier.IPAddress,
                    }).ToList();
        }


        // product object conversion

        public static ProductDto ConvertToDto(this Product product)
        {            
            return new ProductDto
            {
                ID = product.ID,
                Name = product.Name,
                Code = product.Code,
                Description = product.Description,
                Quantity = product.Quantity,
                UnitPrice = product.UnitPrice,
                Rating = product.Rating,
                //ImageURL = GlobalData.HostBaseAddress + "/" + product.ProductImages.ToList().FirstOrDefault()?.Path ?? string.Empty,
                ImageURL = product.ProductImages.ToList().FirstOrDefault()?.Path ?? string.Empty,
                ProductUnitID = product.ProductUnitID,                
                IsOnPromotion = product.IsOnPromotion,
                UserID= product?.UserID,
                CategoryDto = product?.Category != null ? new CategoryDto {
                    ID = product.Category.ID, Code = product.Category.Code, Name = product.Category.Name,
                    Description = product.Category.Description, CreatedBy = product.Category.CreatedBy,UpdatedBy = product.Category.UpdatedBy,
                    CreatedDate = product.Category.CreatedDate,ModifiedDate = product.Category.ModifiedDate,IPAddress = product.Category.IPAddress,
                } : new CategoryDto(),

                SupplierDto = product?.Supplier != null ? new SupplierDto
                {
                    ID = product.Supplier.ID,
                    Name = product.Supplier.Name,
                    Address = product.Supplier.Address,
                    City = product.Supplier.City,
                    Code = product.Supplier.Code,
                    Phone = product.Supplier.Phone,
                    Email = product.Supplier.Email,
                    CreatedBy = product.Supplier.CreatedBy,
                    UpdatedBy = product.Supplier.UpdatedBy,
                    IPAddress = product.Supplier.IPAddress,
                    CreatedDate = product.Supplier.CreatedDate,
                    ModifiedDate = product.Supplier.ModifiedDate,

                } : new SupplierDto(),

                ProductImagesDto = (from prodImg in product?.ProductImages
                                    select new ProductImageDto
                                    {
                                        ID = prodImg.ID,
                                        Name = prodImg.Name,
                                        Path = prodImg.Path,
                                        Description = prodImg.Description,
                                    }).ToList(),
                CreatedDate = product?.CreatedDate,
                ModifiedDate = product?.ModifiedDate,
                CreatedBy= product?.CreatedBy,
                UpdatedBy= product?.UpdatedBy,
                IPAddress = product?.IPAddress,
            };
        }

        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products)
        {

            return (from product in products
                    select new ProductDto
                    {
                        ID = product.ID,
                        Name = product.Name,
                        Code = product.Code,
                        Description = product.Description,
                        Quantity = product.Quantity,
                        UnitPrice = product.UnitPrice,
                        Rating = product.Rating,
                        //ImageURL = GlobalData.HostBaseAddress + "/" + product.ProductImages.ToList().FirstOrDefault()?.Path ?? string.Empty,
                        ImageURL = product.ProductImages.ToList().FirstOrDefault()?.Path ?? string.Empty,
                        ProductUnitID = product?.ProductUnitID,
                        IsOnPromotion = product.IsOnPromotion,
                        CreatedDate = product.CreatedDate,
                        ModifiedDate = product.ModifiedDate,
                        CreatedBy = product.CreatedBy,
                        UpdatedBy = product.UpdatedBy,
                        IPAddress = product.IPAddress,
                        UserID = product?.UserID,
                        CategoryDto = product.Category != null ? new CategoryDto {
                            ID = product.Category.ID,
                            Code = product.Category.Code,
                            Name = product.Category.Name,
                            Description = product.Category.Description,
                            IPAddress = product.Category.IPAddress,
                        } : new CategoryDto(),
                        SupplierDto = product.Supplier != null ? new SupplierDto {
                            ID = product.Supplier.ID,
                            Name = product.Supplier.Name,
                            Address = product.Supplier.Address,
                            City = product.Supplier.City,
                            Code = product.Supplier.Code,
                            Phone = product.Supplier.Phone,
                            Email = product.Supplier.Email,
                            IPAddress = product.Supplier.IPAddress,
                            CreatedDate = product.Supplier.CreatedDate,
                            ModifiedDate = product.Supplier.ModifiedDate,
                        } : new SupplierDto(),
                        
                        ProductImagesDto = (from pImg in product.ProductImages
                                            select new ProductImageDto
                                            {
                                                ID = pImg.ID,
                                                Name = pImg.Name,
                                                Path = pImg.Path, //GlobalData.HostBaseAddress + "/" + pImg.Path,
                                                Description = pImg.Description,
                                            }).ToList(),
                        //ImageURL = (from pImg in product.ProductImages select new string( pImg.Path)).First(),
                    }).ToList();

        }

        public static CustomerDto ConvertToDto(this Customer customer)
        {
            return new CustomerDto
            {
                Id = customer.ID,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Phone = customer.Phone,
                AddressLine1 = customer.AddressLine1,
                AddressLine2 = customer.AddressLine2,
                State = customer.State,
                PostalCode = customer.PostalCode,
                City = customer.City,
                Country = customer.Country,
                PictureUrl = customer.PictureUrl,
                CreatedBy= customer.CreatedBy,
                UpdatedBy= customer.UpdatedBy,
                CreatedDate = customer.CreatedDate,
                ModifiedDate = customer.ModifiedDate,
                IPAddress = customer.IPAddress,


            };
        }

        public static IEnumerable<CustomerDto> ConvertToDto(this IEnumerable<Customer> Customers)
        {
            return (from customer in Customers
                    select new CustomerDto
                    {
                        Id = customer.ID,
                        FirstName = customer.FirstName,
                        LastName = customer.LastName,
                        Email = customer.Email,
                        Phone = customer.Phone,
                        AddressLine1 = customer.AddressLine1,
                        AddressLine2 = customer.AddressLine2,
                        State = customer.State,
                        PostalCode = customer.PostalCode,
                        City = customer.City,
                        Country = customer.Country,
                        PictureUrl = customer.PictureUrl,
                        CreatedBy = customer.CreatedBy,
                        UpdatedBy = customer.UpdatedBy,
                        CreatedDate = customer.CreatedDate,
                        ModifiedDate = customer.ModifiedDate,
                        IPAddress = customer.IPAddress,

                    }).ToList();

        }


    }
}
