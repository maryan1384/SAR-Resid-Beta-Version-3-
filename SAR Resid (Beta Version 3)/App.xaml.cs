using SAR_Resid__Beta_Version_3_.Model.Settings;
using SAR_Resid__Beta_Version_3_.Services;
using System.Windows;

namespace SAR_Resid__Beta_Version_3_
{
    
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            if (Settings1.Default.Theme == "Light")
            {
                ThemeManager.SetLightThem();
            }
            else if (Settings1.Default.Theme == "Dark")
            {
                ThemeManager.SetDarkThem();
            }

        }
    }

}
