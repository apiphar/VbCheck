Imports System.Data.Sql
Imports System.Data.SqlClient
Module Koneksi
    Public cn As SqlConnection
    Public ds As DataSet
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public cmd As SqlCommand
    Public dt = New DataTable
    Public str, sql As String

    Public Sub buka()
        str = "Data Source=APIP2-PC\SQLEXPRESS;Initial Catalog=dbchecking;Persist Security Info=True;UID=sa;PWD=sasa"
        cn = New SqlConnection(str)
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Sub CloseConn()
        If Not IsNothing(cn) Then
            cn.Close()
            cn = Nothing
        End If
    End Sub
    Public Function ExecuteReader(ByVal Queri As String) As SqlDataReader
        Try
            Dim strSQL As String
            buka()
            strSQL = Queri
            cmd = New SqlCommand(strSQL, cn)
            dr = cmd.ExecuteReader(CommandBehavior.Default)
            cmd.Dispose()
            Return dr
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Warning")
        End Try
    End Function
End Module
