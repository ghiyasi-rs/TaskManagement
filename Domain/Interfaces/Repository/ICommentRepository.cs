﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface ICommentRepository : IGenericRepository <Comment>
    {
        Task<List<Comment>> GetAllBySearchTextAsync(string searchText,int dutyId);
    }
}
