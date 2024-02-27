using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAR_Resid__Console_Edition_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String CString = "Data Source=127.0.0.1;Initial Catalog=SR_DB;Integrated Security=True";
            String CString2 = "Data Source=169.254.76.44;Initial Catalog=SR_DB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(CString);
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From TBL_WorkSheets", connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            IEnumerable<DataRow> BillList = data.AsEnumerable().ToList();
            foreach (var item in BillList)
            {
                Console.WriteLine(item[3]);
            }
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Good By!!!!!");
            }
            Console.ReadKey();
        }
    }
    public class Bill
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
