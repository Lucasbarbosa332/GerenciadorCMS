using System;
using System.IO;

namespace ContentManagementSystem.Utils
{
    public class LoggerService
    {
        private readonly string logFilePath = "logs.txt"; // Caminho do arquivo de log

        public LoggerService()
        {
            // Verifica se o arquivo de log já existe, caso contrário, cria um novo
            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Dispose();
            }
        }

        public void LogInfo(string message)
        {
            Log("INFO", message);
        }

        public void LogError(string message)
        {
            Log("ERROR", message);
        }

        private void Log(string level, string message)
        {
            var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }
    }
}
