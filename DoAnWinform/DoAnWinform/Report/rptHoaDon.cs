using DoAnWinform.Model;
using DoAnWinform.View;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform.Report
{
    public partial class rptHoaDon : Form
    {
        public rptHoaDon()
        {
            InitializeComponent();
        }

        private void rptHoaDon_Load(object sender, EventArgs e)
        {

            //string ConnectionString = "Data Source=DESKTOP-D953NPM\\SQLEXPRESS;Initial Catalog=HotelManagerSystem;Integrated Security=True";
            //SqlConnection conn = new SqlConnection(ConnectionString);
            //SqlDataAdapter da = new SqlDataAdapter("Select * from [Report_Involve]", conn);
            //DataSet1 ds = new DataSet1();
            //da.Fill(ds, "Involve");

            //ReportDataSource dataSource = new ReportDataSource("DataSet1", ds.Tables[0]);
            //reportViewer1.LocalReport.ReportPath = "Report1.rdlc";

            this.reportViewer1.RefreshReport();
            HotelDbContext db = new HotelDbContext();
            List<PriceView> priceView = new List<PriceView>();
            List<PriceDetail> priceDetails = db.PriceDetails.ToList();
            foreach (PriceDetail s in priceDetails)
            {
                PriceView view = new PriceView();
                view.IDCustomer = s.Price1.IDCustomer;
                view.ServiceName = s.Price1.Service.ServiceName;
                view.CustomerName = s.Price1.Customer.CustomerName;
                view.Quantity = s.Quantity;
                view.Price = s.Price;
                view.ToTal = tinh(s.Quantity, s.Price);
                priceView.Add(view);

            }
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\admin\\source\\repos\\DoAnWinform\\DoAnWinform\\Report\\Report1.rdlc";
            var sr = new ReportDataSource("DataSet1", priceView);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(sr);
            this.reportViewer1.RefreshReport();
        
       
            
        }
        private double tinh(int sl, double s)
        {
            return (double)sl * (double)s;

        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
