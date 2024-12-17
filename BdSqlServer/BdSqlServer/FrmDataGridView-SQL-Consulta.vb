Public Class FrmDataGridView_SQL_Consulta
    Public Shared existe As FrmDataGridView_SQL_Consulta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim lc As New LCliente

            Dim dt As DataTable = lc.consultarDGV()

            dvgClientes.DataSource = dt

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try



    End Sub

    Public Function getInstancia() As FrmDataGridView_SQL_Consulta
        If existe Is Nothing Then
            existe = New FrmDataGridView_SQL_Consulta
        End If
        Return existe
    End Function

    Private Sub frmReportePrueba_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        existe = Nothing

    End Sub

End Class