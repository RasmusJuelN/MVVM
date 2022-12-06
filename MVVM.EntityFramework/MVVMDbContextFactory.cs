using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.EntityFramework
{
    public class MVVMDbContextFactory : IDesignTimeDbContextFactory<MVVMDbContext>
    {
        public MVVMDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<MVVMDbContext>();
                options.UseSqlServer(@"Server = 192.168.23.122, 1433; 
                                        Initial Catalog = MVVMDB; 
                                        Persist Security Info = True; 
                                        User ID = sa; Password = Rambam111;
                                        TrustServerCertificate=True");

            return new MVVMDbContext(options.Options);
        }

    }
}