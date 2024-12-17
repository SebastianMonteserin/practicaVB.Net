Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Conexion
    Protected con As New SqlConnection("Data Source=DESKTOP-KHEUK86\SQLEXPRESS;Initial Catalog=VB.Net;Integrated Security=True")

    Protected Function conectar() As Boolean
        Try
            con.Open()
            MsgBox("Conexion exitosa")
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False


        End Try

    End Function
    Public Sub desconectar()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

End Class
