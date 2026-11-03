internal static class Program
{
    // Seção 2. Inicia o Windows Forms e abre a janela principal.
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}
