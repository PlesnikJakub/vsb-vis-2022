using System.Data;
using System.Data.SqlClient;

namespace csfd.DataLayer
{
    public class PaymentTableDataGateway
    {
        public DataTable GetByCustomerId(int customerId)
        {
            DataTable result = new DataTable();

            var query = "select * from payment where customer_id = @customerId";

            var connString = DBConnector.GetBuilder().ConnectionString;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("customerId", customerId);
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
