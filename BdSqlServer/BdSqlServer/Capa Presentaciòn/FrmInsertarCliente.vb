Public Class FrmInsertarCliente

    Public Shared existe As FrmInsertarCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            If nombre.Text <> "" And id.Text <> "" And domicilio.Text <> "" And edad.Text <> "" Then
                Dim lc As New LCliente()
                lc.insertarCliente(nombre.Text, id.Text, domicilio.Text, edad.Text)
                blanquearCampos()
            Else
                MsgBox("Faltan datos de clientes")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub blanquearCampos()
        nombre.Clear()
        id.Clear()
        domicilio.Clear()
        edad.Clear()
    End Sub
    Public Function getInstancia() As FrmInsertarCliente
        If existe Is Nothing Then
            existe = New FrmInsertarCliente
        End If
        Return existe
    End Function

    Private Sub FrmInsertarCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        existe = Nothing
    End Sub
End Class