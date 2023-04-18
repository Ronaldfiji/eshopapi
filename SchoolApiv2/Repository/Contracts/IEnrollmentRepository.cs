using DataModel.Entity;
using SchoolApiv2.Extentions;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts
{
    public interface IEnrollmentRepository : IGenericRepository<Enroll>
    {
        Task<Enroll> Get(int id);
        Task<PagedList<Enroll>> GetAllEnrollment(PagingRequestDto pagingRequestDto);
        Task<IEnumerable<Enroll>> GetEnrollmentByDate(DateTime fromDate, DateTime toDate);
        Task<Enroll> CreateEnrollment(EnrollmentToEditDto enrollmentToEditDto);
        Task<Enroll> UpdateEnrollment(EnrollmentToEditDto enrollmentToEditDto);
        Task<Enroll> DeleteEnrollment(int id);

     
    }
}
