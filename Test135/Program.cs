using System;
using System.Windows.Forms;

namespace Test135
{
    public delegate void TransportDelegate(ITransport Transport);

    static class Program
    {
        /// <summary> Главная точка входа для приложения. </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Parking());
        }
    }
}