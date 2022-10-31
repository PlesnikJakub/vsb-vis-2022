using csfd.BussinessLayer.Services;

Console.WriteLine("Hello CSFD!");

var service = new CustomerService();

var result = service.GetAllCustomers();

foreach (var customer in result)
{
    Console.WriteLine($"{customer.Id} {customer.Lastname}");
}

var paymentService = new PaymentService();

var paymentDTO = paymentService.GetPaymentsForCustomer(1);

foreach (var payment in paymentDTO.Payments)
{
    Console.WriteLine($"{payment.Id} Amount: {payment.Amount}");
}

Console.WriteLine("End");