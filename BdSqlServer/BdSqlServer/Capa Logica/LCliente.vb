Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class LCliente


    Public Function eliminarCliente(numId As Integer) As DataTable


        Try
            Dim dc As New DClientes

            Dim dt As DataTable = dc.eliminar(numId)

            Return dt

        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        End Try
    End Function

    Public Function actualizar(nom As String, nId As Integer, tele As String, eda As Integer)

        Dim dc As New DClientes(nom, nId, tele, eda)

        If dc.actualizar(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function insertarCliente(nom As String, nId As Integer, tele As String, eda As Integer)

        Dim dc As New DClientes(nom, nId, tele, eda)
        If dc.insertarCliente(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function


    Public Function consultarDGV() As DataTable
        Try
            Dim dc As New DClientes

            Dim dt As DataTable = dc.consultarDGV

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try
    End Function

    Public Function consultarCliente(numId As Integer) As DataTable
        Try
            Dim dc As New DClientes

            Dim dt As DataTable = dc.consultarCliente(numId)

            Return dt

        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        End Try

    End Function
End Class
