using SAR_Resid__Beta_Version_3_;
using SAR_Resid__Beta_Version_3_.Model.Settings;
using SAR_Resid__Beta_Version_3_.View_Model.MainWindow_ViewModel_;
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

namespace SAR_Resid__Beta_Version_3_.View.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Services.MenuButtonManager BTNManager;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            BTNManager = new Services.MenuButtonManager(BTNHome, BTNCustomers, BTNBills, BTNWorkSheets , BTNSettings);
            BTNManager.SetButton1();
        }

        private void AppHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void BTNExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BTNMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BTNMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                this.BDRMain.CornerRadius = new CornerRadius(0);
                this.BDRMenu.CornerRadius = new CornerRadius(0);
                this.BDRRibbon.CornerRadius = new CornerRadius(0);
                this.BDRMain.BorderThickness = new Thickness(0);
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.BDRMain.CornerRadius = new CornerRadius(25);
                this.BDRMenu.CornerRadius = new CornerRadius(25, 0, 0, 25);
                this.BDRRibbon.CornerRadius = new CornerRadius(0, 25, 0, 0);
                this.BDRMain.BorderThickness = new Thickness(2.5);
                this.WindowState = WindowState.Normal;
            }
        }

        private void BTNHome_Selected(object sender, RoutedEventArgs e)
        {
            BTNManager.SetButton1();
            PageManager.Content = new Pages.HomePage();
        }

        private void BTNCustomers_Selected(object sender, RoutedEventArgs e)
        {
            BTNManager.SetButton2();
            PageManager.Content = new Pages.CustomerPage();
        }

        private void BTNBills_Selected(object sender, RoutedEventArgs e)
        {
            BTNManager.SetButton3();
        }

        private void BTNWorkSheets_Selected(object sender, RoutedEventArgs e)
        {
            BTNManager.SetButton4();
        }

        private void BTNSettings_Selected(object sender, RoutedEventArgs e)
        {
            BTNManager.SetButton5();
            PageManager.Content = new Pages.SettingsPage();
        }

        private void BTNAdd_Click(object sender, RoutedEventArgs e)
        {
            new Windows.AddWindows.AddBillWindow().ShowDialog();
        }
    }
}