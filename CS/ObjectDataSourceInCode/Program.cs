using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ObjectDataSourceInCode {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //XtraReport report;

            //// parameterless constructor, data member is property
            //report = Sample1.CodeSample.CreateReport();

            //// constructor with parameters, parameter bound to report parameter, data member is property
            //report = Sample2.CodeSample.CreateReport();

            //// parameterless constructor, empty data memeber
            //report = Sample3.CodeSample.CreateReport();

            //// data member is a method with parameters
            //report = Sample4.CodeSample.CreateReport();

            //new ReportDesignTool(report).ShowDesignerDialog();
        }
    }
}
