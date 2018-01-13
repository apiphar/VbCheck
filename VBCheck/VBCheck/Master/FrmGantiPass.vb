Public Class FrmGantiPass

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Me.Close()
        MenuUtama.Show()
    End Sub

    Private Sub TxtConfPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtConfPass.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtConfPass.Text <> TxtPassNew.Text Then
                MsgBoxError("Password tidak sesuai")
                TxtConfPass.Focus()
            ElseIf TxtConfPass.Text.Count < 6 Then
                MsgBoxError("panjang Password minimal 6 karakter")
            Else
                btnTambah.Focus()
            End If
        End If
    End Sub

    Private Sub TxtConfPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtConfPass.TextChanged

    End Sub

    Private Sub TxtPassNew_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassNew.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtPassNew.Text.Count < 6 Then
                MsgBoxError("Panjang Password minimal 6 karakter")
            Else
                TxtConfPass.Focus()
            End If
        End If

       
    End Sub

    Private Sub TxtPassNew_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPassNew.TextChanged

    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If CheckKosongText(ErrorProvider1, Me.TxtPassNew) Then
            Exit Sub
        ElseIf CheckKosongText(ErrorProvider1, Me.TxtConfPass) Then
            Exit Sub
        ElseIf TxtPassNew.Text.Count < 6 Then
            MsgBoxError("Panjang Password minimal 6 karakter")
        ElseIf TxtConfPass.Text <> TxtPassNew.Text Then
            MsgBoxError("Password tidak sesuai")
            TxtConfPass.Focus()
        ElseIf TxtConfPass.Text.Count < 6 Then
            MsgBoxError("panjang Password minimal 6 karakter")
        End If
    End Sub
End Class