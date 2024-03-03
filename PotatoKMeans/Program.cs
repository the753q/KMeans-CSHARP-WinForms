namespace PotatoKMeans
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Form1 form1 = new();
            Application.Run(form1);
        }
    }
}