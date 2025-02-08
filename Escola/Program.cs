using Escola.Core.Infrastructure;

namespace Escola
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            BancoDeDados bd = new BancoDeDados(); // cria banco de dados
            Application.Run(new F_Principal());
        }
    }
}