using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SAR_Resid__Beta_Version_3_.Services
{
    public static class ApplicationBasicServices
    {
        public static void MaximizerService(this Window window , Border BDRMain, Border BDRMenu, Border BDRRibbon)
        {
            if (window.WindowState == WindowState.Normal)
            {
                BDRMain.CornerRadius = new CornerRadius(0);
                BDRMenu.CornerRadius = new CornerRadius(0);
                BDRRibbon.CornerRadius = new CornerRadius(0);
                BDRMain.BorderThickness = new Thickness(0);
                window.WindowState = WindowState.Maximized;
            }
            else
            {
                BDRMain.CornerRadius = new CornerRadius(25);
                BDRMenu.CornerRadius = new CornerRadius(25, 0, 0, 25);
                BDRRibbon.CornerRadius = new CornerRadius(0, 25, 0, 0);
                BDRMain.BorderThickness = new Thickness(2.5);
                window.WindowState = WindowState.Normal;
            }
        }
    }
}
