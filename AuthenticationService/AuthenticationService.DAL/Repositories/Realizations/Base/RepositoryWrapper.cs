using AuthenticationService.DAL.Repositories.Interfaces.Base;
using System.Transactions;
using AuthenticationService.DAL.Repositories.Interfaces.RefreshTokens;
using AuthenticationService.DAL.Repositories.Interfaces.Users;
using AuthenticationService.DAL.Repositories.Realizations.RefreshTokens;
using AuthenticationService.DAL.Repositories.Realizations.Users;

namespace AuthenticationService.DAL.Repositories.Realizations.Base;

public class RepositoryWrapper : IRepositoryWrapper
{
    private readonly AuthenticationServiceDbContext _dbContext;

    private readonly Lazy<IUserRepository> _userRepository;
    private readonly Lazy<IRefreshTokenRepository> _refreshTokenRepository;

    public RepositoryWrapper(AuthenticationServiceDbContext dbContext)
    {
        _dbContext = dbContext;
        _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_dbContext));
        _refreshTokenRepository = new Lazy<IRefreshTokenRepository>(() => new RefreshTokenRepository(_dbContext));
    }

    public IUserRepository UserRepository => _userRepository.Value;
    public IRefreshTokenRepository RefreshTokenRepository => _refreshTokenRepository.Value;

    public int SaveChanges()
    {
        return _dbContext.SaveChanges();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }

    public TransactionScope BeginTransaction()
    {
        return new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
    }
}