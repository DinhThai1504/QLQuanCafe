using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;




namespace QLQuanCafe
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            string reportPath = Path.Combine(Application.StartupPath,"Report3.rdlc");
            reportViewer1.LocalReport.ReportPath = reportPath;
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLQuanCafe.Report3.rdlc";

            // Đường dẫn report

            DataTable dt = GetData();
            
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }// Lấy dữ liệu từ database hoặc danh sách
            ReportDataSource rds = new ReportDataSource("DataSet1", dt); // "DataSet1" phải trùng tên trong RDLC

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
           

        }


        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=THUYVY;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT idTable, totalPrice, discount, DateCheckIn, DateCheckOut FROM dbo.Bill"; // Thay YourTable bằng tên bảng thực tế
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                conn.Open();
                adapter.Fill(dt);
            }

            return dt;
        }
    }

    
}
