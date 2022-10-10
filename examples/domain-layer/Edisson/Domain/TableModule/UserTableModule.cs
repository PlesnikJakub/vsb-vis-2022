using Edisson.DataAccess;

namespace Edisson.Domain.TableModule
{
    public class UserTableModule
    {
        public bool Login(string name, string password)
        {
            var user = UserDataAccess.GetUserByName(name);

            return user.PasswordHash == password;
        }

        public void Logout()
        {
            // TODO
        }

        public void Register()
        {
            // TODO
        }

        public void ChangePassword()
        {
            // TODO
        }
    }
}
