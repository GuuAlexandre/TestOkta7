using TestOkta7.Data;

namespace TestOkta7.Authentication
{
    public class UserService
    {
        private readonly TestOkta7Context _context;

        public UserService()
        {
            _context = new();
        }

        public User? GetByEmail(string email)
        {
            return _context.User.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }
    }
}
