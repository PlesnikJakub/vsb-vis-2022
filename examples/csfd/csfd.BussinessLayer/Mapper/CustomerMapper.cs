using csfd.BussinessLayer.Models;
using System.Data;

namespace csfd.BussinessLayer.Mapper
{
    public static class CustomerMapper
    {
        public static Customer Map(DataRow row)
        {
            return new Customer()
            {
                Id = Convert.ToInt32(row["customer_id"]),
                Firstname = row["first_name"]?.ToString() ?? "",
                Lastname = row["last_name"]?.ToString() ?? ""
            };
        }
    }
}
