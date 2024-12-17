Public Class FrmConsultarCliente

    Public Shared existe As FrmConsultarCliente
    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try

            Dim lc As New LCliente

            Dim dt As DataTable = lc.consultarCliente(CInt(TxtId.Text))

            Dim dr As DataRow = dt.Rows.Item(0)

            TxtId.Text = dr.Item("ID")
            TxtNombre.Text = dr.Item("NOMBRE")
            TxtDomi.Text = dr.Item("DOMICILIO")
            TxtEdad.Text = dr.Item("EDAD")

        Catch ex As Exception
            MsgBox("El cliente ingresado no existe")
        End Try

    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtNombre.Clear()
        TxtEdad.Clear()
        TxtDomi.Clear()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Try

            If TxtNombre.Text <> "" And TxtId.Text <> "" And TxtDomi.Text <> "" And TxtEdad.Text <> "" Then
                Dim lc As New LCliente()
                lc.actualizar(TxtNombre.Text, CInt(TxtId.Text), TxtDomi.Text, TxtEdad.Text)

            Else
                MsgBox("Faltan datos de clientes")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try

            If TxtNombre.Text <> "" And TxtId.Text <> "" And TxtDomi.Text <> "" And TxtEdad.Text <> "" Then
                Dim lc As New LCliente()
                lc.eliminarCliente(CInt(TxtId.Text))

            Else
                MsgBox("Faltan datos de clientes")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function getInstancia() As FrmConsultarCliente
        If existe Is Nothing Then
            existe = New FrmConsultarCliente
        End If
        Return existe
    End Function

    Private Sub FrmConsultarCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        existe = Nothing
    End Sub
End Class