using System;
using System.Data.Entity;
using System.Linq;

namespace WpfApp1
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }
    }
}