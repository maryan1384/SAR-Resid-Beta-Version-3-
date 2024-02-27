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
using System.Windows.Shapes;

namespace SAR_Resid__Beta_Version_3_.View.Windows.DataSettingsWindows
{
    /// <summary>
    /// Interaction logic for GenratingWindow.xaml
    /// </summary>
    public partial class GenratingWindow : Window
    {
        public GenratingWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
