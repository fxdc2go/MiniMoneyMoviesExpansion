Option Explicit On
Option Compare Text
Imports System.Data.SqlClient
Public Class clsDataAccess
    Dim cnSQL As New SqlConnection
    Private Sub cnInit()
        If cnSQL.State <> ConnectionState.Open Then
            With cnSQL
                .ConnectionString = My.Settings.cnSQL
                Try
                    .Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End With
        End If
    End Sub
    Private Sub cnClose()
        If cnSQL.State <> ConnectionState.Closed Then
            Try
                cnSQL.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Friend Function GetAccounts() As DataTable
        cnInit()
        Dim strSQL As String = "Select * from CustomerAccount order by AccountName ASC;"
        Dim com As New SqlCommand
        With com
            .Connection = cnSQL
            .CommandType = CommandType.Text
            .CommandText = strSQL
        End With
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message & " GetAccounts")
            dt.Clear()
        Finally
            GetAccounts = dt
            dt.Dispose()
            da.Dispose()
            com.Dispose()
        End Try
    End Function
    Friend Function GetCustomerAccountByID(intID As Int64) As DataTable
        cnInit()
        Dim strSQL As String = "Select * from CustomerAccount where CustAccountID = " & intID & ";"
        Dim com As New SqlCommand
        With com
            .Connection = cnSQL
            .CommandType = CommandType.Text
            .CommandText = strSQL
        End With
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message & " GetCustomerAccountByID")
            dt.Clear()
        Finally
            GetCustomerAccountByID = dt
            dt.Dispose()
            da.Dispose()
            com.Dispose()
        End Try
    End Function
End Class
