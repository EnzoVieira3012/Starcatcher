using Starcatcher.Api.Common.Exceptions;
using Starcatcher.Api.Domain.Entities;
using Starcatcher.Api.Domain.Repositories;
using System.Security.Claims;

namespace Starcatcher.Api.Common
{
    public class UserUtils(IHttpContextAccessor httpContextAccessor, IUserRepository userRepository)
    {
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
        private readonly IUserRepository _userRepository = userRepository;

        public User? GetAuthenticatedUser()
        {
            var user = _httpContextAccessor.HttpContext?.User;

            if (user == null || user.Identity == null || !user.Identity.IsAuthenticated) throw new UnauthorizedException();

            var email = user.FindFirst(ClaimTypes.Email)?.Value;

            if (email == null) return null;

            User? authenticatedUser = _userRepository.GetUserByEmail(email) ?? throw new UserNotFoundException();

            Console.WriteLine(authenticatedUser);

            return authenticatedUser;
        }
    }
}