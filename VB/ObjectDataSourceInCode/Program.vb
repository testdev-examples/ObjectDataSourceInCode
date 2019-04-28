Imports DevExpress.DataAccess.ObjectBinding
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace ObjectDataSourceInCode
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())

            'XtraReport report;

            '// parameterless constructor, data member is property
            'report = Sample1.CodeSample.CreateReport();

            '// constructor with parameters, parameter bound to report parameter, data member is property
            'report = Sample2.CodeSample.CreateReport();

            '// parameterless constructor, empty data memeber
            'report = Sample3.CodeSample.CreateReport();

            '// data member is a method with parameters
            'report = Sample4.CodeSample.CreateReport();

            'new ReportDesignTool(report).ShowDesignerDialog();
        End Sub
    End Class
End Namespace
