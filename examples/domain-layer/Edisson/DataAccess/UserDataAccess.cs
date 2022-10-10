using Edisson.Domain;

namespace Edisson.DataAccess
{
    public class UserDataAccess
    {
        // TODO
        public static UserDTO GetUserByName(string name)
        {
            if (name != "jakub")
                return null;

            return new UserDTO
            {
                Name = name,
                PasswordHash = "1A67CDDC45360C1964D5A01421B027F884934C6B07AD7A0547AE9CD5AD0B4FC3"
            };
        }
    }
}
