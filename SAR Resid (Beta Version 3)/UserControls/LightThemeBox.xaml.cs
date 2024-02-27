using SAR_Resid__Beta_Version_3_.Services;
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

namespace SAR_Resid__Beta_Version_3_.UserControls
{
    /// <summary>
    /// Interaction logic for LightThemeBox.xaml
    /// </summary>
    public partial class LightThemeBox : UserControl
    {
        public LightThemeBox()
        {
            InitializeComponent();
        }

        private void ApplyBTN_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.SetLightThem();
        }
    }
}
