using System;
using System.Windows.Forms;

namespace Test135
{
    internal static class Program
    {
        public delegate void TransportDelegate(ITransport Transport);

        /// <summary> Главная точка входа для приложения. </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormParking());
        }
    }
}