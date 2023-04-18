using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Repository.RepoExt;
using SharedModel.Models;

namespace SchoolApiv2.Repository
{
    public class AssessmentRepository : GenericRepository<Assessment>, IAssessmentRepository
    {
        public AssessmentRepository(SchoolDBContext context, ILogger<AssessmentRepository> logger)
         : base(context, logger)
        { }

        public override async Task<Assessment> Get(int id)
        {
            try
            {
                var assessment = await _context.Assessment                                        
                                        .FirstOrDefaultAsync(s => s.ID == id);

                return assessment!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(AssessmentRepository));
                throw new Exception($"Failed to find assessment with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<Assessment> GetByCode(string code)
        {
            try
            {
                var subject = await _context.Assessment                                        
                                        .FirstOrDefaultAsync(c => c.Code == code);
                return subject!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by code method error", typeof(AssessmentRepository));
                throw new Exception($"Failed to find assessment with {nameof(code)} in database " + $": {ex.Message}");
            }
        }


        public async Task<PagedList<Assessment>> GetAllAssessment(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var assessment = await _context.Assessment                             
                                   .SearchAssessment(pagingRequestDto)
                                .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                .Take(pagingRequestDto.PageSize)
                                .ToListAsync();

                int ItemCount = await _context.Assessment.CountAsync();
                return PagedList<Assessment>.ToPagedList(assessment, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllAssessments() method error", typeof(AssessmentRepository));
                throw new Exception($"GetAllAssessments menthod() => Failed to fetch assessment data  in database " + $": {ex.Message}");
            }

        }

        public async Task<Assessment> CreateAssessment(AssessmentToEditDto assessmentDto)
        {
            try
            {
                var assessment = new Assessment()
                {
                    Code = assessmentDto.Code,
                    Name = assessmentDto.Name,
                    Weight= assessmentDto.Weight,
                    SubjectID= assessmentDto.SubjectID,
                    TermID= assessmentDto.TermID,
                    IPAddress = assessmentDto.IPAddress,
                    CreatedBy = assessmentDto.CreatedBy,
                };

                var newAssessment = await Add(assessment);
                return newAssessment;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateAssessment() method error", typeof(AssessmentRepository));
                throw new Exception($"Failed to create assessment {nameof(AssessmentDto)} in database " + $": {ex.Message}");
            }
        }
        public async Task<Assessment> UpdateAssessment(AssessmentToEditDto assessmentToEditDto)
        {
            try
            {
                var assessment = await Get(assessmentToEditDto.Id);
                if (assessment == null)
                {
                    return null!;
                }
               
                assessment.Code= assessmentToEditDto.Code;
                assessment.Name = assessmentToEditDto.Name;
                assessment.Weight= assessmentToEditDto.Weight;
                assessment.SubjectID= assessmentToEditDto.SubjectID;
                assessment.IPAddress = assessmentToEditDto.IPAddress;
                assessment.UpdatedBy = assessmentToEditDto?.UpdatedBy;
                assessment.ModifiedDate= assessmentToEditDto?.ModifiedDate;              

                return await UpdateAsync(assessment);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateAssessment() method error", typeof(AssessmentRepository));
                throw new Exception($"Failed to update {nameof(assessmentToEditDto)} in database " + $": {ex.Message}");
            }
        }


        public async Task<Assessment> DeleteAssessment(int id)
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
                _logger.LogError(ex, "{Repo} DeleteAssessment() method error", typeof(AssessmentRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }
    }
}
