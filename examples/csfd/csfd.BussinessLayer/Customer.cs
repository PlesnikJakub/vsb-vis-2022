using System.Data;

namespace csfd.BussinessLayer
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public static Customer BuildFrom(DataRow row)
        {
            return new Customer
            {
                Id = Convert.ToInt32(row["customer_id"]),
                Firstname = row["first_name"].ToString(),
                Lastname = row["last_name"].ToString()
            };
        }
    }
}
