Public Class frmGenerarReporte

    Public Shared existe As frmGenerarReporte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim frmRp As New frmReportePrueba


            If (txtID.Text Is "") Then

                frmRp.generarReporte()
            Else
                frmRp.generarReportePar(Integer.Parse(txtID.Text))
            End If



            frmRp.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmGenerarReporte_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        existe = Nothing
    End Sub

    Public Function getInstancia() As frmGenerarReporte
        If existe Is Nothing Then
            existe = New frmGenerarReporte
        End If
        Return existe
    End Function





End Class