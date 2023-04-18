using DataModel.Entity;
using SchoolApiv2.Extentions;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts
{
    public interface ICourseRepository
    {
        Task<Course> Get(int id);
        Task<Course> GetByCode(string code);
        Task<PagedList<Course>> GetAllCourse(PagingRequestDto pagingRequestDto);
        Task<Course> CreateCourse(CourseToEditDto courseToEditDto);
        Task<Course> UpdateCourse(int id, CourseToEditDto courseToEditDto);
        Task<Course> DeleteCourse(int id);
        Task<bool> DeleteCourses(List<CourseToEditDto> coursesDto);
    }
}
