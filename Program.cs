using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIIRPL2_17_TICKETING.MasterForm;


namespace XIIRPL2_17_TICKETING
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FrmLogin());
            //FormLogin.Show();
            
            FrmMasterBandara bandara = new FrmMasterBandara();
            bandara.Show();
            Application.Run();


        }
    }
}