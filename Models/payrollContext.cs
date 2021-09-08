using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PayroolAPI.Models
{
    public partial class payrollContext : DbContext
    {
        public payrollContext(DbContextOptions<payrollContext> options)
            : base(options)
        {
        }
        public virtual DbSet<DboEmpInfo> DboEmpInfo { get; set; }
    }
}
