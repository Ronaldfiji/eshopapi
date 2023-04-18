using DataModel.Entity;
using SchoolApiv2.Extentions;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts
{
    public interface IPrerequisiteRepository
    {
        Task<Prerequisite> Get(int id);
        Task<Prerequisite?> GetByCourse(int courseId);
        Task<PagedList<Prerequisite>> GetAllPrerequisite(PagingRequestDto pagingRequestDto);
        Task<Prerequisite> CreatePrerequisite(PrerequisiteToEditDto prerequisiteToEditDto);
        Task<Prerequisite> UpdatePrerequisite(PrerequisiteToEditDto prerequisiteToEditDto);
        Task<Prerequisite> DeletePrerequisite(int id);
    }
}
