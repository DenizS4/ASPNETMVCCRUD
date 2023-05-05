using CRUDMVC.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ASP.NETCoreEFCRUD.Data;

public class MVCDemoDbContext : DbContext
{
    public MVCDemoDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
}