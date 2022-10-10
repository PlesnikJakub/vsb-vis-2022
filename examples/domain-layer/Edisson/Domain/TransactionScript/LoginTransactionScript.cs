using Edisson.DataAccess;
using System.Security.Cryptography;
using System.Text;

namespace Edisson.Domain.TransactionScript
{
    public class LoginTransactionScript
    {
        public bool Login(string name, string password)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            var user = UserDataAccess.GetUserByName(name);

            if(user is null)
            {
                return false;
            }

            return user.PasswordHash == HashPassword(password);
        }

        private static string HashPassword(string input)
        {
            using (SHA256 hashFunction = SHA256.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = hashFunction.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
    }
}
