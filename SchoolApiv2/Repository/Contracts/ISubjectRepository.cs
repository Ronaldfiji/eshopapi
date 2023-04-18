using DataModel.Entity;
using SchoolApiv2.Extentions;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts
{
    public interface ISubjectRepository : IGenericRepository<Subject>
    {
        Task<Subject> Get(int id);
        Task<Subject> GetByCode(string code);
        Task<PagedList<Subject>> GetAllSubjects(PagingRequestDto pagingRequestDto);
        Task<Subject> CreateSubject(SubjectToEditDto subjectToEditDto);
        Task<Subject> UpdateSubject(SubjectToEditDto subjectToEditDto);
        Task<Subject> DeleteSubject(int id);
        Task<bool> DeleteSubjects(List<Subject> subjects);

    }
}
