using BancoAbstractFactory.Pattners.Implementation.Client;
using BancoAbstractFactory.Pattners.Implementation.Internet;
using BancoAbstractFactory.Pattners.Implementation.Mobile;
using BancoAbstractFactory.Pattners.Interfaces;

Console.WriteLine("Escolha o canal de operação (internet/mobile):");
var canal = Console.ReadLine()?.ToLower();

IBancoFactory factory = canal switch
{
    "internet" => new InternetBankingFactory(),
    "mobile" => new MobileBankingFactory(),
    _ => throw new ArgumentException("Canal inválido.")
};

var app = new BancoApp(factory);
app.Operar();

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();
