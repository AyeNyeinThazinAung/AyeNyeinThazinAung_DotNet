using DotNetTrainingBatch3.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch3.WebApi;

public class AddDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "TestDb",
            UserID = "sa",
            Password = "sa@123",
            TrustServerCertificate = true
        };
        optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString);
    }
    public DbSet<BlogModel> Blogs { get; set; }
}
