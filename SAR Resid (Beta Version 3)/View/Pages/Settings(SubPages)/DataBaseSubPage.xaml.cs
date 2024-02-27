using SAR_Resid__Beta_Version_3_.View.Windows.DataSettingsWindows;
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

namespace SAR_Resid__Beta_Version_3_.View.Pages.Settings_SubPages_
{
    /// <summary>
    /// Interaction logic for DataBaseSubPage.xaml
    /// </summary>
    public partial class DataBaseSubPage : Page
    {
        public DataBaseSubPage()
        {
            InitializeComponent();
        }

        private void BTNGeneratingManage_Click(object sender, RoutedEventArgs e)
        {
            GenratingWindow genratingWindow = new GenratingWindow();
            genratingWindow.Show();
        }
    }
}
