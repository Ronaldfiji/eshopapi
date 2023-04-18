using AutoMapper;
using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Repository.RepoExt;
using SharedModel.Models;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SchoolApiv2.Repository
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        private readonly ISubjectRepository subjectRepository;
        private readonly IMapper mapper;

        public CourseRepository(SchoolDBContext context, ILogger<CourseRepository> logger, IWebHostEnvironment _env,
            ISubjectRepository _subjectRepository, IMapper _mapper) 
            : base(context, logger)
        {
            subjectRepository= _subjectRepository;
            mapper= _mapper;
        }

        public override async Task<Course> Get(int id)
        {
            try
            {
                var course = await _context.Course
                                           .Include(c => c.CourseSubject)
                                               .ThenInclude(c => c.Subject)                                      
                                               .ThenInclude(s => s.Assessment)                                       
                                        .Include(c => c.SchoolYear)
                                        .FirstOrDefaultAsync( c => c.ID == id);              

                return course!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(CourseRepository));
                throw new Exception($"Failed to find course with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<Course> GetByCode(string code)
        {
            try
            {
                var course = await _context.Course
                                         .Include(c => c.CourseSubject)
                                            .ThenInclude(c => c.Subject)
                                            .ThenInclude(s => s.Assessment)
                                        .Include(c => c.SchoolYear)
                                        .FirstOrDefaultAsync(c => c.Code == code);

                var model = JsonSerializer.Serialize(course, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
                Console.WriteLine("New Roles are: " + model);

                return course!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by code method error", typeof(CourseRepository));
                throw new Exception($"Failed to find course with {nameof(code)} in database " + $": {ex.Message}");
            }
        }


        public async Task<PagedList<Course>> GetAllCourse(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var courses = await _context.Course
                                        .Include(c => c.CourseSubject)
                                            .ThenInclude(c => c.Subject)
                                            .ThenInclude(s => s.Assessment)
                                        .Include(c => c.SchoolYear)
                                 .SearchCourse(pagingRequestDto)
                                .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                .Take(pagingRequestDto.PageSize)
                                .ToListAsync();

                int ItemCount = await _context.Course.CountAsync();
                return PagedList<Course>.ToPagedList(courses, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllCourses() method error", typeof(CourseRepository));
                throw new Exception($"Failed to fetch course data  in database " + $": {ex.Message}");
            }

        }

        public async Task<Course> CreateCourse(CourseToEditDto courseToEditDto)
        {
            try
            {
                var course = new Course()
                {
                    Code = courseToEditDto.Code,
                    Name= courseToEditDto.Name,
                    SchoolYearId= courseToEditDto.SchoolYearId,                    
                    Description = courseToEditDto.Description,
                    IPAddress = courseToEditDto.IPAddress,
                    CreatedBy= courseToEditDto.CreatedBy,                    
                };

                var newCourse = await Add(course);
                return newCourse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateCourse() method error", typeof(CourseRepository));
                throw new Exception($"Failed to create course {nameof(CourseToEditDto)} in database " + $": {ex.Message}");
            }
        }

        public async Task<Course> UpdateCourse(int id, CourseToEditDto courseToEditDto)
        {
            try
            {
                var course = await Get(courseToEditDto.Id);
                if (course == null)
                {
                    return null!;
                }
                course.Code = courseToEditDto.Code;
                course.Name = courseToEditDto.Name;
                course.Description= courseToEditDto.Description;
                course.SchoolYearId = courseToEditDto.SchoolYearId;
                course.IPAddress = courseToEditDto.IPAddress;
                course.ModifiedDate = courseToEditDto.ModifiedDate;
                course.UpdatedBy = courseToEditDto.UpdatedBy;
                return await UpdateAsync(course);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateCourse() method error", typeof(CourseRepository));
                throw new Exception($"Failed to update {nameof(courseToEditDto)} in database " + $": {ex.Message}");
            }
        }

        public async Task<Course> DeleteCourse(int id)
        {
            try
            {
               var item = await Get(id);                   
                if (item != null)
                {
                    var deletedItem = await DeleteAsync(item);                   
                    return deletedItem;
                }
                return item!; 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteCourse() method error", typeof(CourseRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<bool> DeleteCourses(List<CourseToEditDto> coursesDto)
        {
            try
            {
                var courses  = mapper.Map<List<Course>>(coursesDto);                
                var deletedItemsStatus = await DeleteRangeAsync(courses);
                return deletedItemsStatus;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteCourses() method error", typeof(CourseRepository));
                throw new Exception($"Failed to delete {nameof(Course)} in database " + $": {ex.Message}");
            }
        }

       
    }
}



//var model = JsonSerializer.Serialize(newUser, new JsonSerializerOptions
//{
//    WriteIndented = true,
//    ReferenceHandler = ReferenceHandler.IgnoreCycles
//});
//Console.WriteLine("New Roles are: " + model);