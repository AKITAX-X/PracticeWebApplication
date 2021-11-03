using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class PijplijnContext : DbContext
    {
        public PijplijnContext(DbContextOptions ConnectPls) : base(ConnectPls) { }
        public DbSet<Person> Personindedb { get; set; }
    }
}
