/// <summary>
/// Class for function on Comment entity. 
/// </summary>

///<class costractor >
/// Injection from Iconfiguration  
/// </class>

/// <class AddAsync>
/// <summary>
/// Class that add item to comment.. if true means item add and false means item cannot add to comment .
/// </summary>
/// <param name="comment">
/// Model of comment that return bool value
/// </param>
/// </class>
/// 

/// <class DeleteAsync>
/// <summary>
/// Class that delete item from comment.if true means item delete and false means item cannot delete to comment .
/// </summary>
/// <param name="Id">
/// Id from item that want to delete
/// </param>
/// </class>



/// <class GetAllAsync>
/// <summary>
/// Class that return all item in comment.
/// </summary>
/// </class>
/// 



/// <class GetByIdAsync>
/// <summary>
/// Class that return item from comment with Id.
/// </summary>
/// <param name="Id">
/// Id from item that want to select.
/// </param>
/// </class>
/// 

/// <class UpdateAsync>
/// <summary>
/// Class that update item from comment. if true means item update and false means item cannot update to comment .
/// </summary>
/// <param name="Id">
/// Id from item that want to select.
/// </param>
/// </class>
/// 




/// <class GetAllByIdAsync>
/// <summary>
/// Class that return list of item from comment with DutyId.
/// </summary>
/// <param name="Id">
/// DutyId from item that want to select.
/// </param>
/// </class>
/// 

/// <class GetAllBySearchTextAsync>
/// <summary>
/// Class that return list of item from comment with search value.
/// </summary>
/// <param name="searchText">
/// search content.
/// </param>
/// 
/// <param name="dutyId">
/// Id of duty that we want search in that's comment.
/// </param>

/// </class>
/// 





using Domain.Interfaces.Database;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Enums;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;
using Domain.Error;

namespace DataAcess.Repository
{
    public class CommentRepository : ICommentRepository
    {

        public IApplicationReadFromDb _read;
        public IApplicationWriteToDb _write;
        private readonly IConfiguration _configuration;
        public CommentRepository(IApplicationReadFromDb read, IApplicationWriteToDb write, IConfiguration configuration)
        {
            _read = read;
            _write = write;           
            _configuration = configuration;
        }
        public async Task<ServiceResult<bool>> AddAsync(Comment comment)
        {
            if (comment == null || string.IsNullOrEmpty(comment.CommentText))
            {
                return new ServiceResult<bool>(new ErrorResult { Type = ErrorType.BlankNotValid });
            }

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))

            {
                try
                {


                    int type = (int)comment.Type;

                    var addedQuery = $"INSERT INTO Comments(DutyId,AddedDate,CommentText,Type,ReminderDate) VALUES({comment.DutyId},'{comment.AddedDate}','{comment.CommentText}',{type},'{comment.ReminderDate}')";

                    var result = await _write.QueryFirstOrDefaultAsync<Comment>(addedQuery);
                    return new ServiceResult<bool>(true);

                }
                catch (Exception)
                {

                    return new ServiceResult<bool>(new ErrorResult { Type = ErrorType.RunTimeError });
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public async Task<ServiceResult<bool>> DeleteAsync(int Id)
        {
            if (Id == null || Id == 0)
            {
                return new ServiceResult<bool>(new ErrorResult { Type = ErrorType.BlankNotValid });
            }

            try
            {
                var DeleteQuery = $"Delete from   Comments  where Id={Id}";

                var result = await _write.QueryFirstOrDefaultAsync<Comment>(DeleteQuery);
                return new ServiceResult<bool>(true);

            }
            catch (Exception)
            {

                return new ServiceResult<bool>(new ErrorResult { Type = ErrorType.RunTimeError });
            }


        }

        public async Task<List<Comment>> GetAllAsync()
        {
            var query = $"SELECT * FROM Comments";
            var comments = await _read.QueryAsync<Comment>(query);

            return comments;
        }

        public async Task<Comment> GetByIdAsync(int Id)
        {
            var query = $"SELECT * FROM Comments where Id=" + Id;
            var comment = await _read.QueryFirstOrDefaultAsync<Comment>(query);

            return comment;
        }

        public async Task<ServiceResult<bool>> UpdateAsync(Comment comment)
        {
            if (comment == null || string.IsNullOrEmpty(comment.CommentText))
            {
                return new ServiceResult<bool>(new ErrorResult { Type = ErrorType.BlankNotValid });
            }



            try
            {


                int type = (int)comment.Type;

                var updateQuery = $"Update  Comments set CommentText='{comment.CommentText}',Type={type},ReminderDate='{comment.ReminderDate}' where Id={comment.Id}";

                var result = await _write.QueryFirstOrDefaultAsync<Comment>(updateQuery);
                return new ServiceResult<bool>(true);

            }
            catch (Exception)
            {

                return new ServiceResult<bool>(new ErrorResult { Type = ErrorType.RunTimeError });
            }


        }
        public async Task<List<Comment>> GetAllByIdAsync(int Id)
        {
            var query = $"SELECT * FROM Comments where DutyId=" + Id;
            var comments = await _read.QueryAsync<Comment>(query);

            return comments;
        }

        public async Task<List<Comment>> GetAllBySearchTextAsync(string searchText, int dutyId)
        {
            string term = "%" + searchText + "%";
            var query = $"SELECT Id ,CommentText FROM Comments where CommentText like '{term}' and dutyId= " + dutyId;
            var comments = await _read.QueryAsync<Comment>(query);

            return comments;
        }


    }
}
