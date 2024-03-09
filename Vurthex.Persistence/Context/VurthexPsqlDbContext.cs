using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Domain.Mappings;
using Vurthex.Domain.Models;
using Vurthex.Domain.Models.BaseModels;

namespace Vurthex.Persistence.Context
{
    public class VurthexPsqlDbContext:DbContext
    {
        public VurthexPsqlDbContext(DbContextOptions<VurthexPsqlDbContext> options):base(options) 
        { 
        
        }

        public virtual DbSet<Accordion> Accordions { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<SocialMedia> SocialMedia { get; set; }
        public virtual DbSet<Technology> Technology { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserMedia> UserMedia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BaseModel>().UseTpcMappingStrategy();
            modelBuilder.ApplyConfiguration(new AccordionMap());
            modelBuilder.ApplyConfiguration(new BlogMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.ApplyConfiguration(new ProjectMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new ServiceMap());
            modelBuilder.ApplyConfiguration(new SocialMediaMap());
            modelBuilder.ApplyConfiguration(new TechnologyMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserMediaMap());




        }
    }
}
