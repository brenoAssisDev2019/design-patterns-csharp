namespace LoggerSingleton.Logger
{
    public sealed class Logger
    {
        private static Logger _instance = null;
        private static readonly object _lock = new object();
        private readonly string logFilePath;

        // Construtor privado para evitar instanciação externa
        private Logger()
        {
            logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
        }

        // Propriedade pública para obter a instância única (thread-safe)
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new Logger();
                    }
                }
                return _instance;
            }
        }

        // Método para escrever mensagens no log
        public void Log(string message)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            Console.WriteLine(logMessage);
            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
        }
    }
}
