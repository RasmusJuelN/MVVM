using Microsoft.EntityFrameworkCore;
using MVVM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.EntityFramework
{
    public class MVVMDbContext : DbContext
    {
        public MVVMDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }

}
