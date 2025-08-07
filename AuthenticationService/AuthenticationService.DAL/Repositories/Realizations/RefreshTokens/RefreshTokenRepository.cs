using AuthenticationService.DAL.Entities;
using AuthenticationService.DAL.Repositories.Interfaces.RefreshTokens;
using AuthenticationService.DAL.Repositories.Realizations.Base;

namespace AuthenticationService.DAL.Repositories.Realizations.RefreshTokens;

public class RefreshTokenRepository : RepositoryBase<RefreshToken>, IRefreshTokenRepository
{
    public RefreshTokenRepository(AuthenticationServiceDbContext dbContext)
        : base(dbContext)
    {
        
    }
}