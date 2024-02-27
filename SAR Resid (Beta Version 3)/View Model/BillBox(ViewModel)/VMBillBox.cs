using SAR_Resid__Beta_Version_3_.View.Windows.DetaileWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SAR_Resid__Beta_Version_3_.View_Model.BillBox_ViewModel_
{
    public class VMBillBox:ViewModelBase
    {
        private ICommand openCommand;

        public ICommand OpenCommand 
        {
            get { return openCommand; }
            set { openCommand = value; }
        }

        public VMBillBox()
        {
            OpenCommand = new ViewModelCommandBase(new Action<object>(OnClick) , new Predicate<object>(CanOnClick));
        }

        private bool CanOnClick(object obj)
        {
            return true;
        }

        private void OnClick(object obj)
        {
            BillDetailWindow detailWindow = new BillDetailWindow();
            detailWindow.ShowDialog();
        }
    }
}
