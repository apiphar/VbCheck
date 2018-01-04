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
#Region "MessageBox"
    Public Sub MsgBoxError(ByVal Msg As String)
        MsgBox(Msg, MsgBoxStyle.Critical, "Peringatan")
    End Sub

    Public Sub MsgSimpan()
        MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
    End Sub

    Public Sub MsgUpdate()
        MsgBox("Data berhasil di update", MsgBoxStyle.Information, "Informasi")
    End Sub

    Public Sub MsgHapus()
        MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
    End Sub

    Public Sub MsgCari()
        MsgBox("Data ditemukan", MsgBoxStyle.Information, "Informasi")
    End Sub

    Public Sub MsgErrorSimpan()
        MsgBox("Data gagal di simpan,silahkan coba lagi", MsgBoxStyle.Critical, "Peringatan")
    End Sub

    Public Sub MsgErrorcari()
        MsgBox("Data tidak ditemukan", MsgBoxStyle.Critical, "Peringatan")
    End Sub

    Public Sub MsgInputanAngka()
        MsgBox("Inputan hanya boleh angka", MsgBoxStyle.Critical, "Peringatan")
    End Sub
    Public Sub MsgTextKosong()
        MsgBox("Data masih ada yg kosong,silahkan di lengkapi", MsgBoxStyle.Exclamation, "Peringatan")
    End Sub
#End Region
#Region "Validasi"
    Public Function CheckKosongText(ByVal err As ErrorProvider, ByVal ParamArray ct() As Control) As Boolean
        Dim b As Boolean
        Dim i As Integer
        Dim str As String
        For i = 0 To ct.Length - 1
            If TypeOf ct(i) Is TextBox Then
                If ct(i).Text = "" Then
                    str = ct(i).Name
                    str = str.Remove(0, 3)
                    err.SetError(ct(i), "Silahkan isi terlebih dahulu " & str & " sebelum di simpan.")
                    ct(i).Focus()
                    b = True
                Else
                    err.SetError(ct(i), Nothing)
                    b = False
                End If
            End If
        Next
        Return b
    End Function
    Public Function CheckKosongCombo(ByVal err As ErrorProvider, ByVal ParamArray ct() As Control) As Boolean
        Dim b As Boolean
        Dim i As Integer
        Dim str As String
        For i = 0 To ct.Length - 1
            If TypeOf ct(i) Is ComboBox Then
                If ct(i).Text = "" Then
                    str = ct(i).Name
                    str = str.Remove(0, 3)
                    err.SetError(ct(i), "Silahkan isi terlebih dahulu " & str & " sebelum di simpan.")
                    ct(i).Focus()
                    b = True
                Else
                    err.SetError(ct(i), Nothing)
                    b = False
                End If
            End If
        Next
        Return b
    End Function
#End Region
End Module
