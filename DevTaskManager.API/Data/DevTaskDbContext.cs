using System;
using DevTaskManager.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DevTaskManager.API.Data;

public class DevTaskDbContext :DbContext
{
    public DevTaskDbContext(DbContextOptions<DevTaskDbContext> options):base(options){}

    public DbSet<TaskItem> Tasks{ get; set; }

}
