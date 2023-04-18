using DataModel.Entity;
using SchoolApiv2.Extentions;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts
{
    public interface IAssessmentRepository : IGenericRepository<Assessment>
    {
        Task<Assessment> Get(int id);
        Task<Assessment> GetByCode(string code);
        Task<PagedList<Assessment>> GetAllAssessment(PagingRequestDto pagingRequestDto);
        Task<Assessment> CreateAssessment(AssessmentToEditDto assessmentToEditDto);     

        Task<Assessment> UpdateAssessment(AssessmentToEditDto assessmentToEditDto);
        Task<Assessment> DeleteAssessment(int id);
    }
}
