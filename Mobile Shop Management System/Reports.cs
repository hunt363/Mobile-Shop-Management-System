using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Shop_Management_System {
    public partial class Reports : Form {
        public Reports() {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e) {
        }

        private void Btn_Sales_Report_Click(object sender, EventArgs e) {
            Sales_Report report = new Sales_Report();
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Visible = true;
        }

        private void Btn_Purchase_Report_Click(object sender, EventArgs e) {
            Purchase_Report report = new Purchase_Report();
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Visible = true;
        }

        private void Btn_Phone_Report_Click(object sender, EventArgs e) {
            Phones_Report report = new Phones_Report();
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Visible = true;
        }

        private void Btn_Accessory_Report_Click(object sender, EventArgs e) {
            Accessory_Report report = new Accessory_Report();
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Visible = true;
        }
    }
}
