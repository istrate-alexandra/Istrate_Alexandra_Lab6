using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Istrate_Alexandra_Lab6.Models;

namespace Istrate_Alexandra_Lab6.Data
{
    public class Istrate_Alexandra_Lab6Context : DbContext
    {
        public Istrate_Alexandra_Lab6Context (DbContextOptions<Istrate_Alexandra_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Istrate_Alexandra_Lab6.Models.Book> Book { get; set; }
    }
}
