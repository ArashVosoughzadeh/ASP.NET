using ItShop.Models;

namespace ItShop.Data.Repositories
{
    public interface IUserRepository
    {
        bool IsExistUserByEmail(string email);
        void AddUser(Users user);
        Users GetUsersForLogin(string email, string password);
    }

    partial class UserRepository : IUserRepository
    {
        private ITShopContext _context;

        public UserRepository(ITShopContext context)
        {
            _context = context;
        }

        public bool IsExistUserByEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }
        public void AddUser(Users user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }
         public Users GetUsersForLogin(string email, string password)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
        }

       
    }
}
