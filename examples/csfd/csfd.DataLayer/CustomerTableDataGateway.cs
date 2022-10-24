using System.Data;
using System.Data.SqlClient;

namespace csfd.DataLayer
{
    public class CustomerTableDataGateway
    {
        public DataTable GetAll()
        {
            // write down query
            var query = "select * from customer;";

            // objet for results
            var result = new DataTable();

            // get connection string 
            var connString = DBConnector.GetBuilder().ConnectionString;

            // Connect
            using (SqlConnection connection = new SqlConnection(connString))
            {
                // Open connection
                connection.Open();

                // prepare command
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // execute command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // read data from result
                        result.Load(reader);
                    }
                }
            }
            return result;
        }
    }
}
