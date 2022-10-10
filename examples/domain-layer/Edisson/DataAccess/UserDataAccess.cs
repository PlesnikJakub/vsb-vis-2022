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
                Password = "test"
            };
        }
    }
}
