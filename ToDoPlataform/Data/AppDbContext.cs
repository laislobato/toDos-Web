using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoPlataform.Models;

namespace ToDoPlataform.Data;
public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {
    }    
    public DbSet<AppUser> AppUsers { get; set; }

    public DbSet<ToDo> ToDos { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Configuração das Tabelas do Identity
            builder.Entity<AppUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("user_roless");
            builder.Entity<IdentityUserClaim<string>>().ToTable("user_calims");
            builder.Entity<IdentityUserToken<string>>().ToTable("user_tokens");
            builder.Entity<IdentityUserLogin<string>>().ToTable("user_logins");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("role_calims");
        #endregion

    }

    
    
}