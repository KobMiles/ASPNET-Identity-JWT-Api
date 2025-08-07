using Ardalis.Specification;

namespace AuthenticationService.DAL.Entities.Specifications.RefreshTokens;

public sealed class GetByTokenWithUserSpec : Specification<RefreshToken>
{
    public GetByTokenWithUserSpec(string token)
    {
        Query
            .Where(rt => rt.Token == token)
            .Include(rt => rt.User);
    }
}