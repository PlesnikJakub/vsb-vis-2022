using Edisson.DataAccess;

namespace Edisson.Domain.Domain
{
    public class UserDomainModel
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public static bool Login(string name, string password)
        {
            var user = UserDataAccess.GetUserByName(name);

            return user.Password == password;
        }
    }
}
