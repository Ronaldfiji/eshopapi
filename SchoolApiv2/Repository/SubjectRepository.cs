using DataModel.DB;
using DataModel.Entity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Repository.RepoExt;
using SharedModel.Models;

namespace SchoolApiv2.Repository
{
    public class SubjectRepository : GenericRepository<Subject>, ISubjectRepository
    {

        public SubjectRepository(SchoolDBContext context, ILogger<SubjectRepository> logger)
            : base(context, logger)
        { }

        public override async Task<Subject> Get(int id)
        {
            try
            {
                var subject = await _context.Subject
                                        .Include(s => s.Assessment)                                       
                                        .FirstOrDefaultAsync(s => s.ID == id);

                return subject!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(SubjectRepository));
                throw new Exception($"Failed to find subject with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<Subject> GetByCode(string code)
        {
            try
            {
                var subject = await _context.Subject
                                        .Include(s => s.Assessment)                                        
                                        .FirstOrDefaultAsync(c => c.Code == code);
                return subject!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by code method error", typeof(SubjectRepository));
                throw new Exception($"Failed to find subject with {nameof(code)} in database " + $": {ex.Message}");
            }
        }


        public async Task<PagedList<Subject>> GetAllSubjects(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var subjects = await _context.Subject
                                .Include(s => s.Assessment)                                   
                                 .SearchSubject(pagingRequestDto)
                                .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                .Take(pagingRequestDto.PageSize)
                                .ToListAsync();

                int ItemCount = await _context.Subject.CountAsync();
                return PagedList<Subject>.ToPagedList(subjects, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllSubjects() method error", typeof(SubjectRepository));
                throw new Exception($"GetAllSubjects menthod() => Failed to fetch subject data  in database " + $": {ex.Message}");
            }

        }

        public async Task<Subject> CreateSubject(SubjectToEditDto subjectToEditDto)
        {
            try
            {
                var subject = new Subject()
                {
                    Code = subjectToEditDto.Code,
                    Name = subjectToEditDto.Name,                  
                    Description = subjectToEditDto.Description,
                    ReferenceBook= subjectToEditDto.ReferenceBook,
                    IPAddress = subjectToEditDto.IPAddress,
                    CreatedBy = subjectToEditDto.CreatedBy,
                };

                subject.CourseSubject.Add(new CourseSubject()
                {
                    CourseId = subjectToEditDto.CourseID,
                    CreatedBy = subjectToEditDto.CreatedBy,
                    IPAddress= subjectToEditDto.IPAddress,
                });               

                var newSubject = await Add(subject);
                return newSubject;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateSubject() method error", typeof(SubjectRepository));
                throw new Exception($"Failed to create subject {nameof(SubjectToEditDto)} in database " + $": {ex.Message}");
            }
        }
        public async Task<Subject> UpdateSubject(SubjectToEditDto subjectToEditDto)
        {
            try
            {
                var subject = await Get(subjectToEditDto.Id);
                if (subject == null)
                {
                    return null!;
                }
                subject.Code= subjectToEditDto.Code;
                subject.Name = subjectToEditDto.Name;
                subject.Description = subjectToEditDto.Description;
                subject.ReferenceBook = subjectToEditDto.ReferenceBook;
                
                subject.IPAddress = subjectToEditDto.IPAddress;
                subject.UpdatedBy= subjectToEditDto.UpdatedBy;
                subject.ModifiedDate= subjectToEditDto.ModifiedDate;          
              
                // add relationship
                if(subjectToEditDto.CourseID > 0 )
                {
                    subject.CourseSubject.Add(new CourseSubject{ CourseId=  subjectToEditDto.CourseID, SubjectId= subject.ID });
                }
                return await UpdateAsync(subject);

            }            
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateSubject() method error", typeof(SubjectRepository));
                throw new Exception($"Failed to update {nameof(subjectToEditDto)} in database " + $": {ex.Message}");
            }
            
        }


        public async Task<Subject> DeleteSubject(int id)
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
                _logger.LogError(ex, "{Repo} DeleteSubject() method error", typeof(SubjectRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<bool> DeleteSubjects(List<Subject> subjects)
        {
            try
            {
                var deletedItemsStatus= await DeleteRangeAsync(subjects);
                return deletedItemsStatus;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteSubjects() method error", typeof(SubjectRepository));
                throw new Exception($"Failed to delete {nameof(subjects)} in database " + $": {ex.Message}");
            }
        }

    }
}
