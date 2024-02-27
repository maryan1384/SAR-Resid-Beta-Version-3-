using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAR_Resid__Beta_Version_3_.Model.DataBaseModels
{
    public class TBL_Bills
    {
        public int BillCode { get; set; }
        public string BillID { get; set; }
        public string PaymentID { get; set; }
        public string MeterNumber { get; set; }
        public string BillAmount { get; set; }
        public string PaymentDeadline { get; set; }
        public string TrackingNumber { get; set; }
        public string PaymentDate { get; set; }
    }
}
