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

namespace SAR_Resid__Beta_Version_3_.CustomeControls
{
    public class CCTRLBillBox : Button
    {


        public static string GetBillID(DependencyObject obj)
        {
            return (string)obj.GetValue(BillIDProperty);
        }

        public static void SetBillID(DependencyObject obj, string value)
        {
            obj.SetValue(BillIDProperty, value);
        }

        public static readonly DependencyProperty BillIDProperty =
            DependencyProperty.RegisterAttached("BillID", typeof(string), typeof(CCTRLBillBox), new PropertyMetadata("NotFound"));



        public static string GetPaymentID(DependencyObject obj)
        {
            return (string)obj.GetValue(PaymentIDProperty);
        }
        public static void SetPaymentID(DependencyObject obj, string value)
        {
            obj.SetValue(PaymentIDProperty, value);
        }
        
        public static readonly DependencyProperty PaymentIDProperty =
            DependencyProperty.RegisterAttached("PaymentID", typeof(string), typeof(CCTRLBillBox), new PropertyMetadata(""));



        static CCTRLBillBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CCTRLBillBox), new FrameworkPropertyMetadata(typeof(CCTRLBillBox)));
        }
    }
}
