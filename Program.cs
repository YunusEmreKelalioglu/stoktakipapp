using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoktakipapp
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
{
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Splash Screen'i modal olarak göster ve kapat
        using (frmSplashScreen splash = new frmSplashScreen())
        {
            splash.ShowDialog();
        }

        // Ana formu başlat
        Application.Run(new frmSatis());
}
    }
}
