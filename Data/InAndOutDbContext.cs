using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InAndOut.Data
{
    public class InAndOutDbContext :DbContext
    {
        public InAndOutDbContext(DbContextOptions<InAndOutDbContext> options) : base(options)
        {
                
        }
    }
}
