using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SharedModel.Models;

namespace SchoolApiv2.Repository
{
    public class PrerequisiteRepository : GenericRepository<Prerequisite>, IPrerequisiteRepository
    {
        
        public PrerequisiteRepository(SchoolDBContext context, ILogger<EnrollmentRepository> logger): base(context, logger)
        {}

        public override async Task<Prerequisite> Get(int id)
        {
            try
            {
                var prerequisite = await _context.Prerequisite
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(s => s.ID == id);

                return prerequisite;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(PrerequisiteRepository));
                throw new Exception($"Failed to find Prerequisite with {nameof(id)} in database " + $": {ex.Message}");
            }
        }
        public async Task<Prerequisite?> GetByCourse(int id)
        {
            try
            {
                var prerequisite = await _context.Prerequisite
                                        .AsNoTracking()                                       
                                        .FirstOrDefaultAsync(p => p.CourseID == id);              
                return prerequisite;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by course id method error", typeof(PrerequisiteRepository));
                throw new Exception($"Failed to find Prerequisite with {nameof(id)} in database " + $": {ex.Message}");
            }
        }
        public async Task<PagedList<Prerequisite>> GetAllPrerequisite(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var prerequisites = await _context.Prerequisite
                                    .AsNoTracking()
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .ToListAsync();


                int ItemCount = await _context.Prerequisite.CountAsync();
                return PagedList<Prerequisite>.ToPagedList(prerequisites, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllPrerequisite() method error", typeof(PrerequisiteRepository));
                throw new Exception($"GetAllPrerequisite() menthod => Failed to fetch prerequisite data  in database " + $": {ex.Message}");
            }
        }


        public async Task<Prerequisite> CreatePrerequisite(PrerequisiteToEditDto prerequisiteToEditDto)
        {
            try
            {  
                var prerequisite = new Prerequisite()
                {
                  CourseID= prerequisiteToEditDto.CourseID,
                  PrerequisiteCourseId= prerequisiteToEditDto.CourseID,
                  CreatedBy= prerequisiteToEditDto.CreatedBy,
                  IPAddress= prerequisiteToEditDto.IPAddress,
                };

                var newPrerequisite = await Add(prerequisite);
                
                return newPrerequisite;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreatePrerequisite() method error", typeof(PrerequisiteRepository));
                throw new Exception($"Failed to create prerequisite {nameof(PrerequisiteToEditDto)} in database " + $": {ex}");
            }
        }
        public async Task<Prerequisite> UpdatePrerequisite(PrerequisiteToEditDto prerequisiteToEditDto)
        {
            try
            {
                var prerequisite = await Get(prerequisiteToEditDto.Id);
                if (prerequisite == null)
                {
                    return null!;
                }

                prerequisite.CourseID = prerequisiteToEditDto.CourseID;
                prerequisite.PrerequisiteCourseId = prerequisiteToEditDto.PrerequisiteCourseId;
                prerequisite.ModifiedDate = prerequisiteToEditDto.ModifiedDate;
                prerequisite.IPAddress= prerequisiteToEditDto.IPAddress;
                prerequisite.UpdatedBy = prerequisiteToEditDto.UpdatedBy;
                
                return await UpdateAsync(prerequisite);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdatePrerequisite() method error", typeof(PrerequisiteRepository));
                throw new Exception($"Failed to update {nameof(PrerequisiteToEditDto)} in database " + $": {ex.Message}");
            }
        }


        public async Task<Prerequisite> DeletePrerequisite(int id)
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
                _logger.LogError(ex, "{Repo} DeletePrerequisite() method error", typeof(PrerequisiteRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

    }
}
