using System;
using System.IO;

namespace BibliotecaEscola.Servicos
{
    // Classe que gerencia o registro de logs em um arquivo
    public class Log
    {
        private string caminhoLog = "E:\\Facul\\POO-E2\\log.txt"; // Caminho do arquivo de log

        // Método para gravar uma mensagem de log no arquivo
        public void GravarLog(string mensagem)
        {
            using (StreamWriter escritor = new StreamWriter(caminhoLog, true))
            {
                escritor.WriteLine($"{DateTime.Now}: {mensagem}");
            }
        }
    }
}
