using Edisson.DataAccess;

namespace Edisson.Domain.TransactionScript
{
    public class LoginTransactionScript
    {
        public bool Login(string name, string password)
        {
            var user = UserDataAccess.GetUserByName(name);

            return user.Password == password;
        }
    }
}
