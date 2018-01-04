Imports System.Data.SqlClient

Public Class MenuUtama

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Private Sub MenuUtama_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        With Me
            .Tanggal.Text = Format(Now, "yyyy-MM-dd")
            .Timer1.Start()
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Jam.Text = TimeOfDay()
    End Sub

    Private Sub ToolStripStatusLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nip.Click

    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        Call buka()
        Try
            sql = "Select Password From MasterUser Where NIP = '" & nip.Text & "'"
            cmd = New SqlCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                FrmGantiPass.Show()
                FrmGantiPass.TxtPassOld.Text = dr.Item(0)
                CloseConn()
                dr.Close()
                cmd.Dispose()
                Me.Hide()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class