using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Repository.RepoExt;
using SharedModel.Models;

namespace SchoolApiv2.Repository
{
    public class SchoolRepository : GenericRepository<School>, ISchoolRepository
    {
      
        public SchoolRepository(SchoolDBContext context, ILogger<SchoolRepository> logger) : base(context, logger)
        {           
        }

        public override async Task<School> Get(int id)
        {
            try
            {
                var school = await _context.School
                    .AsNoTracking()
                    .FirstOrDefaultAsync(s => s.ID == id);

                return school!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get school method error", typeof(SchoolRepository));
                throw new Exception($"Failed to find School with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<School>> GetAllSchools(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var  schools = await _context.School                                   
                                .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                .OrderBy(s => s.ID)
                                .Take(pagingRequestDto.PageSize)
                                .ToListAsync();

                int ItemCount = await _context.School.CountAsync();
                return PagedList<School>.ToPagedList(schools, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllSchools() method error", typeof(SchoolRepository));
                throw new Exception($"Failed to find Schools in database " + $": {ex.Message}");
            }
        }

        public async Task<School> CreateSchool(SchoolToEditDto schoolToEditDto)
        {
            try
            {
                var school = new School()
                {
                   Code= schoolToEditDto.Code,
                   Name= schoolToEditDto.Name,
                   Description= schoolToEditDto.Description,
                   Phone= schoolToEditDto.Phone,
                   Email= schoolToEditDto.Email,
                   Address= schoolToEditDto.Address,
                   City= schoolToEditDto.City,
                   District= schoolToEditDto.District,
                   CreatedBy= schoolToEditDto.CreatedBy,
                   IPAddress= schoolToEditDto.IPAddress,                   
                };

                var newSchool = await Add(school);
                return newSchool;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateSchool() method error", typeof(SchoolRepository));
                throw new Exception($"Failed to create School {nameof(SchoolToEditDto)} in database " + $": {ex}");
            }
        }
    }
}
