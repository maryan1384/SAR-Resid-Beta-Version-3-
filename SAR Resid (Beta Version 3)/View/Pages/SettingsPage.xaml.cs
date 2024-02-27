using SAR_Resid__Beta_Version_3_.Services;
using SAR_Resid__Beta_Version_3_.View.Pages.Settings_SubPages_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SAR_Resid__Beta_Version_3_.View.Pages
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        MenuButtonManager MenuButtonManager;
        public SettingsPage()
        {
            InitializeComponent();
            MenuButtonManager = new MenuButtonManager(BTNThems , BTNLanguage , BTNDataBase , BTNAbout);
            MenuButtonManager.SettingsPage = true;
        }

        private void TBC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (TBC.SelectedIndex == 3)
            //{
            //    BTNSupport.Visibility = Visibility.Visible;
            //    BTNUpdate.Visibility = Visibility.Visible;
            //}
            //else
            //{
            //    BTNSupport.Visibility = Visibility.Hidden;
            //    BTNUpdate.Visibility = Visibility.Hidden;
            //}
        }

        private void BTNThems_Click(object sender, RoutedEventArgs e)
        {
            MenuButtonManager.SetButton1();
            PageManager.Content = new ThemsSubPage();
        }

        private void BTNLanguage_Click(object sender, RoutedEventArgs e)
        {
            MenuButtonManager.SetButton2();
            PageManager.Content = new LanguageSubPage();
        }

        private void BTNDataBase_Click(object sender, RoutedEventArgs e)
        {
            MenuButtonManager.SetButton3();
            PageManager.Content = new DataBaseSubPage();
        }

        private void BTNAbout_Click(object sender, RoutedEventArgs e)
        {
            MenuButtonManager.SetButton4();
            PageManager.Content = new AboutSubPage();
        }
    }
}
