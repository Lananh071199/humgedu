using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiTap.Models
{
    public partial class LTQLdbContext : DbContext
    {
        public LTQLdbContext()
            : base("name=LTQLdbContext")
        {
        }

        public virtual DbSet<Person> PerSons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
