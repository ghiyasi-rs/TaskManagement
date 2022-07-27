

/// <summary>
/// Class for function on Duty entity. 
/// </summary>

///<class costractor >
/// Injection from Iconfiguration  
/// </class>

/// <class AddAsync>
/// <summary>
/// Class that add item to duty that return bool value. if true means item add and false means item cannot add to duty .
/// </summary>
/// <param name="duty">
/// Model of duty .
/// </param>
/// </class>
/// 

/// <class DeleteAsync>
/// <summary>
/// Class that delete item from duty that return bool value.if true means item delete and false means item cannot delete to duty .
/// </summary>
/// <param name="Id">
/// Id from item that want to delete
/// </param>
/// </class>



/// <class GetAllAsync>
/// <summary>
/// Class that return all item in duty.
/// </summary>
/// </class>
/// 



/// <class GetByIdAsync>
/// <summary>
/// Class that return item from duty with Id.
/// </summary>
/// <param name="Id">
/// Id from item that want to select.
/// </param>
/// </class>
/// 

/// <class UpdateAsync>
/// <summary>
/// Class that update item from duty that return bool value. if true means item update and false means item cannot update to duty .
/// </summary>
/// <param name="Id">
/// Id from item that want to select.
/// </param>
/// </class>
/// 




/// <class GetAllByIdAsync>
/// <summary>
/// Class that return list of item from duty with DutyId.
/// </summary>
/// <param name="Id">
/// DutyId from item that want to select.
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
using NToastNotify;

namespace DataAcess.Repository
{

    public class DutyRepository : IDutyRepository
    {
     
        public IApplicationReadFromDb _read;
        public IApplicationWriteToDb _write;
        private readonly IConfiguration _configuration;
        private readonly IToastNotification _toastNotification;
        public DutyRepository(IApplicationReadFromDb read, IApplicationWriteToDb write,  IConfiguration configuration, IToastNotification toastNotification)
        {
            _read = read;
            _write = write;
            _configuration = configuration;
            _toastNotification = toastNotification;
        }
        public async Task<ServiceResult<bool>> AddAsync(Duty duty)
        {
            if (duty == null || string.IsNullOrEmpty(duty.Title) || string.IsNullOrEmpty(duty.Description))
            {

                return new ServiceResult<bool>(new ErrorResult { Type = ErrorType.BlankNotValid });
            }

            try
            {
                int type = (int)duty.Type;
                int status = (int)duty.Status;
                int userId = (int)duty.AssignedTo;
                var addedQuery = $"INSERT INTO Duties(Title,Description,CreatedDate,RequiredBy,Status,Type,NextActionDate,AssignedTo) VALUES('{duty.Title}','{duty.Description}','{duty.CreatedDate}','{duty.RequiredBy}',{type},{status},'{duty.NextActionDate}',{userId})";
                var tasks = await _write.QueryFirstOrDefaultAsync<Duty>(addedQuery);

                return new ServiceResult<bool>(true);

            }
            catch (Exception)
            {

                return new ServiceResult<bool>(new ErrorResult { Type = ErrorType.RunTimeError });


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
                var DeleteQuery = $"Delete from   Duties  where Id={Id}";
                var result = await _write.QueryFirstOrDefaultAsync<Duty>(DeleteQuery);

                return new ServiceResult<bool>(true);

            }
            catch (Exception)
            {

                return new ServiceResult<bool>(new ErrorResult { Type = ErrorType.RunTimeError });
            }

        }

        public async Task<List<Duty>> GetAllAsync()
        {
            var query = $"SELECT * FROM Duties";
            var tasks = await _read.QueryAsync<Duty>(query);

            return tasks;

        }

        public async Task<Duty> GetByIdAsync(int Id)
        {
            var query = $"SELECT * FROM Duties Where Id=" + Id;
            var tasks = await _read.QueryFirstOrDefaultAsync<Duty>(query);

            return tasks;
        }

        public async Task<ServiceResult<bool>> UpdateAsync(Duty duty)
        {
            if (duty == null || string.IsNullOrEmpty(duty.Title) || string.IsNullOrEmpty(duty.Description))
            {
                return new ServiceResult<bool>(new ErrorResult { Type = ErrorType.BlankNotValid });
            }

            try
            {

                int type = (int)duty.Type;
                int status = (int)duty.Status;
                string updateQuery = $"UPDATE [dbo].[Duties] SET Title = {duty.Title} WHERE Id = {duty.Id}";
                var result = await _write.QueryFirstOrDefaultAsync<Duty>(updateQuery);
                return new ServiceResult<bool>(true);

            }
            catch (Exception)
            {

                return new ServiceResult<bool>(new ErrorResult { Type = ErrorType.RunTimeError });
            }



        }

        public Task<List<Duty>> GetAllByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }


    }
}
