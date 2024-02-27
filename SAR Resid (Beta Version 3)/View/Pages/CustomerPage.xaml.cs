using SAR_Resid__Beta_Version_3_.CustomeControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        public CustomerPage()
        {
            InitializeComponent();
            for (int i = 1; i <= 24; i++)
            {
                CCTRLBillBox billBox = new CCTRLBillBox();
                CCTRLBillBox.SetBillID(billBox, $"{i}");
                WPLDataManager.Children.Add(billBox);
            }
        }
    }
}
