Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace ObjectDataSourceInCode
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            ShowReport(Sample1.CodeSample.CreateReport())
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
            ShowReport(Sample2.CodeSample.CreateReport())
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
            ShowReport(Sample3.CodeSample.CreateReport())
        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
            ShowReport(Sample4.CodeSample.CreateReport())
        End Sub

        Private Sub ShowReport(ByVal report As XtraReport)
            Using tool = New ReportPrintTool(report)
                tool.ShowPreviewDialog()
            End Using
        End Sub
    End Class
End Namespace
