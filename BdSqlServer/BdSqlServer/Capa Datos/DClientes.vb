
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Drawing.Text


Public Class DClientes
    Inherits Conexion

    Private nombre As String
    Private idCliente As Integer
    Private domicilio As String
    Private edad As Integer

    Private cmd As SqlCommand

    Public Sub New()

    End Sub

    Public Sub New(nom As String, id As Integer, dom As String, ed As Integer)
        nombre = nom
        idCliente = id
        domicilio = dom
        edad = ed



    End Sub


    Property nombreCliente As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Property edadCliente As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property

    Property domCliente As String
        Get
            Return domicilio
        End Get
        Set(value As String)
            domicilio = value
        End Set
    End Property

    Public Function eliminar(idCliente As Integer)
        Try
            conectar()
            Dim sql As String = ("DELETE FROM CLIENTES WHERE  ID='" & idCliente & "'")
            cmd = New SqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El cliente " & idCliente & " se ha eliminado exitosamente")
                Return True
            Else
                MsgBox("Cliente inexistente")
                Return False

            End If

        Catch ex As Exception
            MsgBox("Error eliminando cliente: Cliente inexistente ")
            Return False


        End Try


    End Function




    Public Function actualizar(dc As DClientes)
        Try
            conectar()
            Dim sql As String = ("UPDATE CLIENTES SET NOMBRE ='" & dc.nombreCliente & "',
            ID='" & dc.idCliente & "',DOMICILIO='" & dc.domicilio & "',EDAD='" & dc.edadCliente & "' WHERE ID='" & dc.idCliente & "'")

            cmd = New SqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El cliente se ha actualziado exitosamente")
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox("Error actualziando cliente")
            Return False


        End Try


    End Function

    Public Function consultarDGV() As DataTable

        Try
            conectar()

            cmd = New SqlCommand("SELECT * FROM CLIENTES")

            cmd.Connection = con

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New SqlDataAdapter(cmd)

                adp.Fill(dt)

                Return dt
            Else
                Return Nothing


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            con.Close()


        End Try

    End Function


    Public Function consultarCliente(idCliente As Integer) As DataTable

        Try

            conectar()
            cmd = New SqlCommand("SELECT NOMBRE, ID, DOMICILIO, EDAD FROM CLIENTES WHERE ID='" & idCliente & "'")

            cmd.Connection = con

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New SqlDataAdapter(cmd)

                adp.Fill(dt)

                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function

    Public Function insertarCliente(dc As DClientes) As Boolean

        Try
            conectar()
            Dim sql As String = "INSERT INTO CLIENTES(NOMBRE, ID, DOMICILIO, EDAD)VALUES('" & dc.nombreCliente &
                               "','" & dc.idCliente & "','" & dc.domicilio & "','" & dc.edadCliente & "')"

            cmd = New SqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El cliente se ha ingresado exitosamente")
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function
End Class
