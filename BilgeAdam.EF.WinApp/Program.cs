namespace BilgeAdam.EF.WinApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmCustomers());
        }
    }
}