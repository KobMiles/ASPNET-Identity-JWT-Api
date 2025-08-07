using AuthenticationService.DAL.Entities;
using AuthenticationService.DAL.Repositories.Interfaces.Users;
using AuthenticationService.DAL.Repositories.Realizations.Base;

namespace AuthenticationService.DAL.Repositories.Realizations.Users;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(AuthenticationServiceDbContext dbContext)
        : base(dbContext)
    {

    }
}