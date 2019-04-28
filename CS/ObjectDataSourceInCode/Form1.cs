using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectDataSourceInCode {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        void button1_Click(object sender, EventArgs e) {
            ShowReport(Sample1.CodeSample.CreateReport());
        }

        void button2_Click(object sender, EventArgs e) {
            ShowReport(Sample2.CodeSample.CreateReport());
        }

        void button3_Click(object sender, EventArgs e) {
            ShowReport(Sample3.CodeSample.CreateReport());
        }

        void button4_Click(object sender, EventArgs e) {
            ShowReport(Sample4.CodeSample.CreateReport());
        }

        void ShowReport(XtraReport report) {
            using(var tool = new ReportPrintTool(report))
                tool.ShowPreviewDialog();
        }
    }
}
