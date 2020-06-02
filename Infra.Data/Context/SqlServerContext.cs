using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options)
            : base(options)
        {

        }

        public DbSet<Escola> Escola { get; set; }
        public DbSet<Turma> Turma { get; set; }
    }
}
