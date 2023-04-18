using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SharedModel.Models;
using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SchoolApiv2.Repository
{
    public class EnrollmentRepository  : GenericRepository<Enroll>, IEnrollmentRepository
    {
        private readonly IScoreRepository scoreRepository;
        private readonly IPrerequisiteRepository prerequisiteRepository;

        public EnrollmentRepository(SchoolDBContext context, ILogger<EnrollmentRepository> logger, 
            IScoreRepository _scoreRepository, IPrerequisiteRepository _prerequisiteRepository)
        : base(context, logger)
        {
            scoreRepository = _scoreRepository;
            prerequisiteRepository= _prerequisiteRepository;
        }

        public override async Task<Enroll> Get(int id)
        {
            try
            {
                var enrollment = await _context.Enroll
                                        .Include(e => e.School)
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(s => s.ID == id);

                return enrollment!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(EnrollmentRepository));
                throw new Exception($"Failed to find enrollment with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

       

        public async Task<PagedList<Enroll>> GetAllEnrollment(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var enrollment = await _context.Enroll
                                    .Include(e => e.School) 
                                    .AsNoTracking() 
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .ToListAsync();
                

                int ItemCount = await _context.Enroll.CountAsync();
                return PagedList<Enroll>.ToPagedList( enrollment, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllEnrollment() method error", typeof(EnrollmentRepository));
                throw new Exception($"GetAllEnrollment menthod() => Failed to fetch assessment data  in database " + $": {ex.Message}");
            }
        }

        public async Task<IEnumerable<Enroll>> GetEnrollmentByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                Console.WriteLine("From date : "+ fromDate + " to date : "+ toDate);
                
                var enrollments = await _context.Enroll 
                                        .Include(e => e.School)
                                        .AsNoTracking()
                                        .Where(e => e.DateEnrolment >= fromDate && e.DateEnrolment<= toDate)
                                        .ToListAsync();
                return enrollments;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetEnrollmentByDate() method error", typeof(EnrollmentRepository));
                throw new Exception($"GetEnrollmentByDate menthod() error => Failed to fetch data  in database " + $": {ex.Message}");
            }
        }

        public async Task<Enroll> CreateEnrollment(EnrollmentToEditDto enrollmentToEditDto)
        {
            try
            {   
                var enrollment = new Enroll()
                {
                     UserId = enrollmentToEditDto.UserId,
                     CourseId = enrollmentToEditDto.CourseId,
                     SchoolId= enrollmentToEditDto.SchoolId,
                     CreatedBy= enrollmentToEditDto.CreatedBy,
                     IPAddress = enrollmentToEditDto.IPAddress,                    
                };

                var newEnrollment= await Add(enrollment);
                /* Create list of assessment associated with new course enrolled ! */
                var scores = await scoreRepository.CreateScores(newEnrollment);
                return newEnrollment;
            }
            catch (Exception ex)
            {               
                _logger.LogError(ex, "{Repo} CreateEnrollment() method error", typeof(EnrollmentRepository));
                throw new Exception($"Failed to create enrollment {nameof(EnrollmentToEditDto)} in database " + $": {ex}");
            }
        }
        public async Task<Enroll> UpdateEnrollment(EnrollmentToEditDto enrollmentToEditDto)
        {
            try
            {
                var enrollment = await Get(enrollmentToEditDto.Id);
                if (enrollment == null)
                {
                    return null!;
                }
                
                enrollment.CourseId = enrollmentToEditDto.CourseId;
                enrollment.DateEnrolment = enrollmentToEditDto.DateEnrolled;
                enrollment.DateCompleted = enrollmentToEditDto.DateCompleted;
                enrollment.DateWithdrawal = enrollmentToEditDto.DateWithdrawal;
                enrollment.Passed = enrollmentToEditDto.Passed;
                enrollment.IPAddress = enrollmentToEditDto.IPAddress;
                enrollment.UpdatedBy= enrollmentToEditDto.UpdatedBy;
                enrollment.ModifiedDate= enrollmentToEditDto.ModifiedDate;        

                return await UpdateAsync(enrollment);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateEnrollment() method error", typeof(EnrollmentRepository));
                throw new Exception($"Failed to update {nameof(EnrollmentToEditDto)} in database " + $": {ex.Message}");
            }
        }


        public async Task<Enroll> DeleteEnrollment(int id)
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
                _logger.LogError(ex, "{Repo} DeleteEnrollment() method error", typeof(EnrollmentRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

    }
}


//var model = JsonSerializer.Serialize(prerequisite, new JsonSerializerOptions
//{
//    WriteIndented = true,
//    ReferenceHandler = ReferenceHandler.IgnoreCycles
//});
//Console.WriteLine("Json data is : " + model);