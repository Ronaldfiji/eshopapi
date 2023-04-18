using DataModel.Entity;
using SchoolApiv2.Extentions;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts
{
    public interface ISchoolYearRepository
    {
        Task<SchoolYear> Get(int id);
        Task<PagedList<SchoolYear>> GetAllSchoolYear(PagingRequestDto pagingRequestDto);
        Task<SchoolYear> CreateSchoolYear(SchoolYearToEditDto schoolYearDto);
    }
}
