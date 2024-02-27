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
    public class CCMenuButton : TabItem
    {


        public static string Geticon(DependencyObject obj)
        {
            return (string)obj.GetValue(iconProperty);
        }
        public static void Seticon(DependencyObject obj, string value)
        {
            obj.SetValue(iconProperty, value);
        }
        public static readonly DependencyProperty iconProperty =
            DependencyProperty.RegisterAttached("icon", typeof(string), typeof(CCMenuButton), new PropertyMetadata(""));





        public static string GetPack(DependencyObject obj)
        {
            return (string)obj.GetValue(PackProperty);
        }
        public static void SetPack(DependencyObject obj, string value)
        {
            obj.SetValue(PackProperty, value);
        }
        public static readonly DependencyProperty PackProperty =
            DependencyProperty.RegisterAttached("Pack", typeof(string), typeof(CCMenuButton), new PropertyMetadata(""));




        public static bool GetSE(DependencyObject obj)
        {
            return (bool)obj.GetValue(SEProperty);
        }
        public static void SetSE(DependencyObject obj, bool value)
        {
            obj.SetValue(SEProperty, value);
        }
        public static readonly DependencyProperty SEProperty =
            DependencyProperty.RegisterAttached("SE", typeof(bool), typeof(CCMenuButton), new PropertyMetadata(false));







        static CCMenuButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CCMenuButton), new FrameworkPropertyMetadata(typeof(CCMenuButton)));
        }
    }
}
