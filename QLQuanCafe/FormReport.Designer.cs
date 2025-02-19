namespace QLQuanCafe
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyQuanCafeDataSet2 = new QLQuanCafe.QuanLyQuanCafeDataSet();
            this.uSPGetListBillByDateForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_GetListBillByDateForReportTableAdapter = new QLQuanCafe.QuanLyQuanCafeDataSetTableAdapters.USP_GetListBillByDateForReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateForReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLQuanCafe.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(795, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyQuanCafeDataSet2
            // 
            this.quanLyQuanCafeDataSet2.DataSetName = "QuanLyQuanCafeDataSet2";
            this.quanLyQuanCafeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPGetListBillByDateForReportBindingSource
            // 
            this.uSPGetListBillByDateForReportBindingSource.DataMember = "USP_GetListBillByDateForReport";
            this.uSPGetListBillByDateForReportBindingSource.DataSource = this.quanLyQuanCafeDataSet2;
            // 
            // uSP_GetListBillByDateForReportTableAdapter
            // 
            this.uSP_GetListBillByDateForReportTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateForReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyQuanCafeDataSet quanLyQuanCafeDataSet2;
        private System.Windows.Forms.BindingSource uSPGetListBillByDateForReportBindingSource;
        private QuanLyQuanCafeDataSetTableAdapters.USP_GetListBillByDateForReportTableAdapter uSP_GetListBillByDateForReportTableAdapter;
    }
}