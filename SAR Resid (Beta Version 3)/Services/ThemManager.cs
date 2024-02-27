//using SAR_Resid__Beta_Version_3_.Resources;
using SAR_Resid__Beta_Version_3_.Model.Settings;
using SAR_Resid__Beta_Version_3_.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SAR_Resid__Beta_Version_3_.Services
{
    public class ThemeManager
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        public ThemeManager(Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            this.button1 = button1;
            this.button2 = button2;
            this.button3 = button3;
            this.button4 = button4;
            this.button5 = button5;
        }
        public static bool SetDarkThem()
        {
            ResourceDictionary CurrentTheme = new ResourceDictionary()
            {
                Source = new Uri("View/ResourceDictionarys/Thems/LightResource.xaml", UriKind.Relative)
            };
            ResourceDictionary NewTheme = new ResourceDictionary()
            {
                Source = new Uri("View/ResourceDictionarys/Thems/DarkResource.xaml", UriKind.Relative)
            };
            Application.Current.Resources.MergedDictionaries.Remove(CurrentTheme);
            Application.Current.Resources.MergedDictionaries.Add(NewTheme);
            Settings1.Default.Theme = "Dark";
            Settings1.Default.Save();
            return true;
        }
        public static bool SetLightThem()
        {
            ResourceDictionary CurrentTheme = new ResourceDictionary()
            {
                Source = new Uri("View/ResourceDictionarys/Thems/DarkResource.xaml", UriKind.Relative)
            };
            ResourceDictionary NewTheme = new ResourceDictionary()
            {
                Source = new Uri("View/ResourceDictionarys/Thems/LightResource.xaml", UriKind.Relative)
            };
            Application.Current.Resources.MergedDictionaries.Remove(CurrentTheme);
            Application.Current.Resources.MergedDictionaries.Add(NewTheme);
            Settings1.Default.Theme = "Light";
            Settings1.Default.Save();
            return true;
        }
    }
}
