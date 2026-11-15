namespace CEIBIO.Presentacion
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new CEIBIO.Presentacion.Seguridad.FrmLogin());
        }
    }
}