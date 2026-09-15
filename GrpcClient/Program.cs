// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcLab;

//var channel = GrpcChannel.ForAddress("https://localhost:44371/");
//var client = new Greeter.GreeterClient(channel);
//var reply = await client.SayHelloAsync(new HelloRequest { Name = "World" });
//Console.WriteLine(reply.Message);
//Console.WriteLine("Hello, World!");

var channel = GrpcChannel.ForAddress("https://localhost:44371/");
var client = new Customer.CustomerClient(channel);
var reply = await client.GetCustomerAsync(new CustomerLookupModel { Id = 1 });
Console.WriteLine($"Customer: {reply.Name}, Email: {reply.Email}");