using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace PharmacyManagementSystem
{
    public partial class PrintLayer : Form
    {
        public PrintLayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("E:\\Academic Projects\\Pharmacy Management System\\PharmacyManagementSystem\\PharmacyManagementSystem\\OrderCrystalReport.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void PrintLayer_Load(object sender, EventArgs e)
        {

        }
    }
}
