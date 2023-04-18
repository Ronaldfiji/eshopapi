using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Repository.RepoExt;
using SharedModel.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SchoolApiv2.Repository
{
    public class ScoreRepository : GenericRepository<Score>, IScoreRepository
    {
        private readonly ICourseRepository courseRepository;

        public ScoreRepository(SchoolDBContext context, ILogger<ScoreRepository> logger, ICourseRepository _courseRepository) : base(context, logger)
        {     
            courseRepository = _courseRepository;
        }

        public override async Task<Score> Get(int id)
        {
            try
            {
                var score = await _context.Score
                    .AsNoTracking()
                    .FirstOrDefaultAsync(s => s.ID == id);

                return score!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get score method error", typeof(ScoreRepository));
                throw new Exception($"Failed to find score with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<IEnumerable<Score>> GetByEnrollment(int enrollId)
        {
            try
            {
                var score = await _context.Score
                    .Include(s => s.Assessment)
                        .ThenInclude(a => a.Subject)
                    .Include(s => s.Assessment)
                        .ThenInclude(s => s.Term)                    
                    .AsNoTracking()
                    .Where(s => s.EnrollmentID == enrollId)
                    .ToListAsync();               

                return score;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo}  GetByEnrollment method error", typeof(ScoreRepository));
                throw new Exception($"Failed to find score with {nameof(enrollId)} in database " + $": {ex.Message}");
            }
        }


        //public async Task<IEnumerable<Score>> GetScoreByEnrollment(int enrollmentId)
        //{
        //    try
        //    {
        //        var score = await _context.Score
        //                                  .AsNoTracking()
        //                                  .Where(s => s.EnrollmentID == enrollmentId)
        //                                  .ToListAsync();
        //        return score;
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "{Repo} GetScoreByEnrollment() method error", typeof(ScoreRepository));
        //        throw new Exception($"GetScoreByEnrollment menthod() => Failed to fetch assessment data  in database " + $": {ex.Message}");
        //    }
        //}

       

        public async Task<PagedList<Score>> GetAllScores(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var scores = await _context.Score                                
                                    .SearchScore(pagingRequestDto)
                                .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                .OrderBy(s => s.ID)
                                .Take(pagingRequestDto.PageSize)
                                .ToListAsync();

                int ItemCount = await _context.Score.CountAsync();
                return PagedList<Score>.ToPagedList(scores, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllScores() method error", typeof(ScoreRepository));
                throw new Exception($"Failed to find score in database " + $": {ex.Message}");
            }
        }

        public async Task<Score> CreateScore(ScoreToEditDto scoreToEditDto)
        {
            try
            {
                var score = new Score()
                {
                    EnrollmentID= scoreToEditDto.EnrollmentID,
                    AssessmentID= scoreToEditDto.AssessmentID,
                    IPAddress= scoreToEditDto.IPAddress,
                    CreatedBy= scoreToEditDto.CreatedBy,
                };

                var newScore = await Add(score);
                return newScore;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateScore() method error", typeof(ScoreRepository));
                throw new Exception($"Failed to create score {nameof(ScoreToEditDto)} in database " + $": {ex}");
            }
        }

        public async Task<List<Score>> CreateScores(Enroll enrollment)
        {
            try
            {
                var scores = new List<Score>();
                var course = await courseRepository.Get(enrollment.CourseId);
                var courseSubjects = course.CourseSubject.ToList();
                foreach ( var subject in courseSubjects )
                {
                    var assessment = subject?.Subject?.Assessment;
                    assessment?.ForEach(a =>
                                scores.Add(new Score
                                {
                                    EnrollmentID = enrollment.ID,
                                    AssessmentID = a.ID,
                                    Weight = a.Weight,
                                    CreatedBy = enrollment.CreatedBy,
                                    IPAddress = enrollment.IPAddress
                                })
                    );
                }               
                await AddRange(scores);
                return scores;
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateScores() method error", typeof(ScoreRepository));
                throw new Exception($"Failed to create scores {nameof(ScoreDto)} in database " + $": {ex}");
            }
        }

        public async Task<Score> UpdateScore(ScoreToEditDto scoreToEditDto)
        {
            try
            {
                var score = await Get(scoreToEditDto.Id);
                if (score == null)
                {
                    return null!;
                }

                score.Grade= scoreToEditDto.Grade;
                score.AssessmentDate = scoreToEditDto.AssessmentDate;
                score.AssessedBy = scoreToEditDto.AssessedBy;                
                score.UpdatedBy= scoreToEditDto.UpdatedBy;
                score.ModifiedDate= scoreToEditDto.ModifiedDate;
                score.IPAddress= scoreToEditDto.IPAddress;
                return await UpdateAsync(score);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateScore() method error", typeof(ScoreRepository));
                throw new Exception($"Failed to update {nameof(ScoreToEditDto)} in database " + $": {ex.Message}");
            }
        }

        public async Task<Score> DeleteScore(int id)
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
                _logger.LogError(ex, "{Repo} DeleteScore() method error", typeof(ScoreRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<bool> DeleteScores(int enrollmentId)
        {
            try
            {
                var items = await _context.Score
                                        .Where(s => s.EnrollmentID == enrollmentId)
                                        .ToListAsync();
                if (items.Any())
                {
                    var deletedItem = await DeleteRangeAsync(items);
                    return deletedItem;
                }
                return false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteScores() method error", typeof(ScoreRepository));
                throw new Exception($"Failed to delete {nameof(enrollmentId)} in database " + $": {ex.Message}");
            }
        }


    }
}


//var model = JsonSerializer.Serialize(assessment, new JsonSerializerOptions
//{
//    WriteIndented = true,
//    ReferenceHandler = ReferenceHandler.IgnoreCycles
//});
//Console.WriteLine("Json data is : " + model);