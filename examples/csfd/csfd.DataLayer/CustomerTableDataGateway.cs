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

        public DataTable GetById(int id)
        {
            var query = "select * from customer where customer_id = @customer_id";
            var result = new DataTable();
            var connString = DBConnector.GetBuilder().ConnectionString;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("customer_id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
            }
            return result;
        }
    }
}
