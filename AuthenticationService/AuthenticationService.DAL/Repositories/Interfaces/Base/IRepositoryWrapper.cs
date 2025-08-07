using System.Transactions;
using AuthenticationService.DAL.Repositories.Interfaces.RefreshTokens;
using AuthenticationService.DAL.Repositories.Interfaces.Users;

namespace AuthenticationService.DAL.Repositories.Interfaces.Base;

public interface IRepositoryWrapper
{
    IUserRepository UserRepository { get; }
    IRefreshTokenRepository RefreshTokenRepository { get; }

    public int SaveChanges();

    public Task<int> SaveChangesAsync();

    public TransactionScope BeginTransaction();
}