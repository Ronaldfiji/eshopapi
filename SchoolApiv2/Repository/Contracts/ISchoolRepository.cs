using DataModel.Entity;
using SchoolApiv2.Extentions;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts
{
    public interface ISchoolRepository : IGenericRepository<School>
    {
        Task<School> Get(int id);
        Task<PagedList<School>> GetAllSchools(PagingRequestDto pagingRequestDto);
        Task<School> CreateSchool(SchoolToEditDto schoolToEditDto);
    }
}
