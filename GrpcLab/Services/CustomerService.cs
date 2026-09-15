using Grpc.Core;
using GrpcLab;

namespace GrpcLab.Services
{
    public class CustomerService : Customer.CustomerBase
    {
        private readonly ILogger<CustomerService> _logger;
        public CustomerService(ILogger<CustomerService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomer(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel customer = new CustomerModel();

            if (request.Id == 1)
            {
                customer.Id = 1;
                customer.Name = "John Doe";
                customer.Email = "johndoe@example.com";
            }
            else if (request.Id == 2)
            {
                customer.Id = 2;
                customer.Name = "Jane Smith";
                customer.Email = "janesmith@example.com";
            }
            else
            {
                customer.Id = 0;
                customer.Name = "Unknown";
                customer.Email = "";
            }

                return Task.FromResult(customer);
        }
    }
}
