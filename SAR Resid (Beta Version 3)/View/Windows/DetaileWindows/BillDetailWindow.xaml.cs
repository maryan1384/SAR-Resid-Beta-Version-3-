﻿using System;
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

namespace SAR_Resid__Beta_Version_3_.View.Windows.DetaileWindows
{
    /// <summary>
    /// Interaction logic for BillDetailWindow.xaml
    /// </summary>
    public partial class BillDetailWindow : Window
    {
        public BillDetailWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void BTNExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
