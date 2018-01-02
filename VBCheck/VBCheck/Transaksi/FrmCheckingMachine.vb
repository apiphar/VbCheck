Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmCheckingMachine
    Public Function GenerateNoTrans() As Boolean
        Try
            Dim sql As String
            sql = "select [NoCheck] from TrxCheckHeader where [NoCheck] in(select max([NoCheck]) from TrxCheckHeader)order by [NoCheck] desc"
            Dim urutan As String
            Dim hitung As Integer
            dr = ExecuteReader(sql)
            dr.Read()
            If Not dr.HasRows Then
                urutan = "CHK" + Format(Now, "yyMMdd") + "0001"
                dr.Close()
                cmd.Dispose()
                CloseConn()
            Else
                If Microsoft.VisualBasic.Left(dr.Item("NoCheck"), 9) = "CHK" + Format(Now, "yyMMdd") Then
                    hitung = Microsoft.VisualBasic.Right(dr.Item("NoCheck"), 4) + 1
                    urutan = "CHK" & Format(Now, "yyMMdd") & Microsoft.VisualBasic.Right("0000" & hitung, 4)
                    dr.Close()
                    cmd.Dispose()
                    CloseConn()
                Else
                    urutan = "CHK" + Format(Now, "yyMMdd") + "0001"
                    dr.Close()
                    cmd.Dispose()
                    CloseConn()
                End If
            End If
            TxtNoCheck.Text = urutan
            dr.Close()
            Cmd.Dispose()
            CloseConn()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Peringatan")
            dr.Close()
            Cmd.Dispose()
            CloseConn()
            Return False
        End Try
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        FrmLookUp.Perintah = "Machine"
        FrmLookUp.ShowDialog()
    End Sub

    Private Sub FrmCheckingMachine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GenerateNoTrans()
    End Sub
End Class