
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Form1

    Private conexion As New SqlConnection("Data Source=BDT-NTB-LMONTES;Initial Catalog=Prueba;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conexion.Open()
            MsgBox("Conexion exitosa!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


End Class
