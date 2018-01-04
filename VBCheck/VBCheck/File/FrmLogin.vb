Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmLogin
    
    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Call buka()
        Dim HakAkses As String
        Try
            sql = "Select NIP,Nama,HakAkses,Password From MasterUser where NIP = '" & TxtNip.Text & "' and Password= '" & TxtPass.Text & "'"
            cmd = New SqlCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("Login sukses", MsgBoxStyle.Information, "Informasi")

                If dr.Item(2) = 1 Then
                    HakAkses = "Admin"
                ElseIf dr.Item(2) = 2 Then
                    HakAkses = "Admin Group"
                ElseIf dr.Item(2) = 3 Then
                    HakAkses = "PM"
                Else
                    HakAkses = "Pimpinan"
                End If

                MenuUtama.Show()
                MenuUtama.nip.Text = dr.Item(0)
                MenuUtama.NamaUser.Text = dr.Item(1)
                MenuUtama.HakAkses.Text = HakAkses
                CloseConn()
                dr.Close()
                cmd.Dispose()
                Me.Hide()
                TxtNip.Clear()
                TxtPass.Clear()
            Else
                MsgBox("Nama dan password yang anda masukan salah,silahkan coba lagi", MsgBoxStyle.Exclamation, "Peringatan")
                CloseConn()
                dr.Close()
                cmd.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        End Try
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Me.Close()
    End Sub

    Private Sub TxtNip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNip.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPass.Focus()
        End If
    End Sub

    Private Sub TxtNip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNip.TextChanged

    End Sub

    Private Sub TxtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPass.KeyPress
        If e.KeyChar = Chr(13) Then
            btnTambah.Focus()
        End If
    End Sub

    Private Sub TxtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPass.TextChanged

    End Sub

    Private Sub FrmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TxtNip.Focus()
    End Sub
End Class