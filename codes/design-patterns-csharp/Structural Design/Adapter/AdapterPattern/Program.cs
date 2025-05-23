// See https://aka.ms/new-console-template for more information
using AdapterPattern.Adapters;
using AdapterPattern.Models;
using AdapterPattern.Services;

var order1 = new Order(1, 350.75m);
var order2 = new Order(2, 89.90m);

Console.WriteLine("=== E-Commerce com Adapter Pattern ===");

var mercadoPago = new PaymentService(new MercadoPagoAdapter(new MercadoPagoAPI()));
mercadoPago.Checkout(order1);

Console.WriteLine();

var payPal = new PaymentService(new PayPalAdapter(new PayPalAPI()));
payPal.Checkout(order2);

Console.WriteLine("\n Pedidos finalizados.");
