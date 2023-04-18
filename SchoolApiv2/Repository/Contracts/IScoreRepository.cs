using DataModel.Entity;
using SchoolApiv2.Extentions;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts
{
    public interface IScoreRepository : IGenericRepository<Score>
    {
        Task<Score> Get(int id);
        //Task<IEnumerable<Score>> GetScoreByEnrollment(int enrollmentId);
        Task<IEnumerable<Score>> GetByEnrollment(int enrollId);
        Task<PagedList<Score>> GetAllScores(PagingRequestDto pagingRequestDto);
        Task<Score> CreateScore(ScoreToEditDto scoreToEditDto);
        Task<List<Score>> CreateScores(Enroll enrollmentDto);
        Task<Score> UpdateScore(ScoreToEditDto scoreToEditDto);
        Task<Score> DeleteScore(int id);
        Task<bool> DeleteScores(int enrollmentId);

    }
}
