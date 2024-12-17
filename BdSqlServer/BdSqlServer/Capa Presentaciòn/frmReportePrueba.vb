Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices.Diagnostics.Internal

Public Class frmReportePrueba

    Public Shared existe As frmReportePrueba
    Private Sub frmReportePrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReportViewer1.RefreshReport()


    End Sub


    Public Sub generarReporte()

        Try
            Dim dt As DataTable
            Dim dc As New DClientes

            dt = dc.consultarDGV

            ReportViewer1.LocalReport.DataSources.Clear()

            Dim rpt As New ReportDataSource("dsClientes", dt)

            ReportViewer1.LocalReport.DataSources.Add(rpt)

            ReportViewer1.RefreshReport()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub


    Public Sub generarReportePar(id As Integer)
        ReportViewer1.RefreshReport()
        Try
            Dim dt As DataTable
            Dim dc As New DClientes

            dt = dc.consultarCliente(id)

            ReportViewer1.LocalReport.DataSources.Clear()

            Dim rpt As New ReportDataSource("dsClientes", dt)

            ReportViewer1.LocalReport.DataSources.Add(rpt)

            ReportViewer1.RefreshReport()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub


End Class