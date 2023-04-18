using DataModel.Entity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharedModel.Models;

namespace SchoolApiv2.Repository.RepoExt
{
    public static class RepositoryUserExtensions
    {
        public static IQueryable<User> SearchUser(this IQueryable<User> users, PagingRequestDto pagedRequestDto)
        {
            if (string.IsNullOrWhiteSpace(pagedRequestDto.ColumnName) || string.IsNullOrWhiteSpace(pagedRequestDto.SearchTerm))
                return users;

            var searchText = pagedRequestDto.SearchTerm.Trim().ToLower();
            var columnName = pagedRequestDto.ColumnName.Trim().ToLower();

            if (columnName == "firstname")
            {
                return users.Where(c => c.FirstName.Contains(searchText));
            }
            if (columnName == "lastname")
            {
                return users.Where(c => c.LastName.Contains(searchText));
            }
            if (columnName == "email")
            {
                return users.Where(c => c.Email.Contains(searchText));
            }
            return users;
        }

        public static IQueryable<Role> SearchRole(this IQueryable<Role> roles, PagingRequestDto pagedRequestDto)
        {
            if (string.IsNullOrWhiteSpace(pagedRequestDto.ColumnName) || string.IsNullOrWhiteSpace(pagedRequestDto.SearchTerm))
                return roles;

            var searchText = pagedRequestDto.SearchTerm.Trim().ToLower();
            var columnName = pagedRequestDto.ColumnName.Trim().ToLower();

            if (columnName == "name")
            {
                return roles.Where(c => c.Name.Contains(searchText));
            }
            if (columnName == "description")
            {
                return roles.Where(c => c.Description.Contains(searchText));
            }            
            return roles;
        }

        public static IQueryable<Course> SearchCourse(this IQueryable<Course> courses, PagingRequestDto pagedRequestDto)
        {
            if (string.IsNullOrWhiteSpace(pagedRequestDto.ColumnName) || string.IsNullOrWhiteSpace(pagedRequestDto.SearchTerm))
                return courses;

            var searchText = pagedRequestDto.SearchTerm.Trim().ToLower();
            var columnName = pagedRequestDto.ColumnName.Trim().ToLower();

            if (columnName == "name")
            {
                return courses.Where(c => c.Name.Contains(searchText));
            }
            if (columnName == "code")
            {
                return courses.Where(c => c.Description.Contains(searchText));
            }
            return courses;
        }

        public static IQueryable<Subject> SearchSubject(this IQueryable<Subject> subjects, PagingRequestDto pagedRequestDto)
        {
            if (string.IsNullOrWhiteSpace(pagedRequestDto.ColumnName) || string.IsNullOrWhiteSpace(pagedRequestDto.SearchTerm))
                return subjects;

            var searchText = pagedRequestDto.SearchTerm.Trim().ToLower();
            var columnName = pagedRequestDto.ColumnName.Trim().ToLower();

            if (columnName == "name")
            {
                return subjects.Where(c => c.Name.Contains(searchText));
            }
            if (columnName == "code")
            {
                return subjects.Where(c => c.Code.Contains(searchText));
            }
            return subjects;
        }

        public static IQueryable<Assessment> SearchAssessment(this IQueryable<Assessment> assessments, PagingRequestDto pagedRequestDto)
        {
            if (string.IsNullOrWhiteSpace(pagedRequestDto.ColumnName) || string.IsNullOrWhiteSpace(pagedRequestDto.SearchTerm))
                return assessments;

            var searchText = pagedRequestDto.SearchTerm.Trim().ToLower();
            var columnName = pagedRequestDto.ColumnName.Trim().ToLower();

            if (columnName == "name")
            {
                return assessments.Where(c => c.Name.Contains(searchText));
            }
            if (columnName == "code")
            {
                return assessments.Where(c => c.Code.Contains(searchText));
            }
            return assessments;
        }


        public static IQueryable<Score> SearchScore(this IQueryable<Score> scores, PagingRequestDto pagedRequestDto)
        {
            if (string.IsNullOrWhiteSpace(pagedRequestDto.ColumnName) || string.IsNullOrWhiteSpace(pagedRequestDto.SearchTerm))
                return scores;            

            var searchText = pagedRequestDto.SearchTerm.Trim().ToLower();

            var columnName = pagedRequestDto.ColumnName.Trim().ToLower();           

            if (columnName == "assessmentdate")
            {
                //DateTime assessDate = DateTime.ParseExact(pagedRequestDto.SearchTerm, "d", null);
                DateTime assessDate =  DateTime.Parse(pagedRequestDto.SearchTerm); // This format adds flexibility to search.              
                return scores.Where(s => s.AssessmentDate == assessDate);
            }
            if (columnName == "assessedby")
            {                
                return scores.Where(s => s.AssessedBy.Contains(searchText));
            }
            return scores;
        }

    }
}
