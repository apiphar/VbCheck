Imports System.Data.Sql
Imports System.Data.SqlClient
Module Koneksi
    Public koneksi As SqlConnection
    Public data As DataSet
    Public baca As SqlDataReader
    Public adaptor As SqlDataAdapter
    Public cmd As SqlCommand
    Public ass As DataTable
    Public str, sql As String

    Public Sub buka()
        str = "Data Source=APIP2-PC\SQLEXPRESS;Initial Catalog=dbchecking;Persist Security Info=True;UID=sa;PWD=sasa"
        koneksi = New SqlConnection(str)
        Try
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module
