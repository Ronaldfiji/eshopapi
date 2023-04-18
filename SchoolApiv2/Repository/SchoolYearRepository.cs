using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Repository.RepoExt;
using SharedModel.Models;

namespace SchoolApiv2.Repository
{
    public class SchoolYearRepository : GenericRepository<SchoolYear>, ISchoolYearRepository
    {
        public SchoolYearRepository(SchoolDBContext context, ILogger<SchoolYearRepository> logger) : base(context, logger)
        {
        }

        public override async Task<SchoolYear> Get(int id)
        {
            try
            {
                var schoolYear = await _context.SchoolYear
                    .AsNoTracking()
                    .FirstOrDefaultAsync(s => s.ID == id);

                return schoolYear!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get SchoolYear method error", typeof(SchoolYearRepository));
                throw new Exception($"Failed to find SchoolYear with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<SchoolYear>> GetAllSchoolYear(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var schoolYears = await _context.SchoolYear                                    
                                .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                .OrderBy(s => s.ID)
                                .Take(pagingRequestDto.PageSize)
                                .ToListAsync();

                int ItemCount = await _context.SchoolYear.CountAsync();
                return PagedList<SchoolYear>.ToPagedList(schoolYears, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllSchoolYear() method error", typeof(SchoolYearRepository));
                throw new Exception($"Failed to find SchoolYear in database " + $": {ex.Message}");
            }
        }

        public async Task<SchoolYear> CreateSchoolYear(SchoolYearToEditDto schoolYearDto)
        {
            try
            {
                var schoolYear = new SchoolYear()
                {
                    Year= schoolYearDto.Year,
                    Code= schoolYearDto.Code,
                    Description= schoolYearDto.Description,  
                    IPAddress = schoolYearDto.IPAddress,
                    CreatedBy = schoolYearDto.CreatedBy,
                };

                var newSchoolYear = await Add(schoolYear);
                return newSchoolYear;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateSchoolYear() method error", typeof(SchoolYearRepository));
                throw new Exception($"Failed to create SchoolYear {nameof(SchoolYearToEditDto)} in database " + $": {ex.Message}");
            }
        }

    }
}
