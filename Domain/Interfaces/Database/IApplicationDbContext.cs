using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;


namespace Domain.Interfaces.Database
{
    public interface IApplicationDbContext
    {
        public IDbConnection Connection { get; }
        DatabaseFacade Database { get; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
