// Obtém a instância única do Logger
using LoggerSingleton.Logger;

var logger1 = Logger.Instance;
var logger2 = Logger.Instance;

// Verifica se são a mesma instância
Console.WriteLine($"logger1 e logger2 são a mesma instância? {ReferenceEquals(logger1, logger2)}");

// Registra mensagens
logger1.Log("Iniciando o sistema de e-commerce.");
logger2.Log("Processando pedido do cliente.");
logger1.Log("Pedido processado com sucesso.");