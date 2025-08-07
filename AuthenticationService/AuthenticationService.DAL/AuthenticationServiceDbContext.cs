using AuthenticationService.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationService.DAL;

public class AuthenticationServiceDbContext : IdentityDbContext<User>
{
    public AuthenticationServiceDbContext(DbContextOptions<AuthenticationServiceDbContext> options) 
        : base(options)
    {
        
    }

    public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(AuthenticationServiceDbContext).Assembly);
    }
}