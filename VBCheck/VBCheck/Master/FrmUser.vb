Imports Microsoft.VisualBasic
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmUser
    Private Sub TombolAwal()
        With Me
            .btnSimpan.Enabled = True
            .btnEdit.Enabled = True
            .btnHapus.Enabled = True
            .btnKeluar.Enabled = True
            .btnKeluar.Text = "Keluar"
            .btnSimpan.Text = "Simpan"
        End With
    End Sub
    Private Sub TombolCari()
        With Me            
            .btnSimpan.Enabled = False
            .btnEdit.Enabled = True
            .btnHapus.Enabled = False
            .btnKeluar.Enabled = True
            .btnKeluar.Text = "Batal"
        End With
    End Sub
    Private Sub TombolUpdate()
        With Me
            .btnSimpan.Enabled = True
            .btnEdit.Enabled = False
            .btnHapus.Enabled = True
            .btnKeluar.Enabled = True
            .btnKeluar.Text = "Batal"
            .btnSimpan.Text = "Update"
        End With
    End Sub
    Private Sub EnabledText()
        With Me
            '.TxtKode.Enabled = True
            .txtNama.Enabled = True
            .txtPass.Enabled = True
            .cmbHakAkses.Enabled = True
        End With
    End Sub
    Private Sub DisableText()
        With Me
            '.TxtKode.Enabled = False
            .txtNama.Enabled = False
            .txtPass.Enabled = False
            .cmbHakAkses.Enabled = False
        End With
    End Sub
    Private Sub TextKosong()
        With Me
            .txtNama.Text = ""            
            .txtPass.Text = ""
            cmbHakAkses.Text = ""
        End With
    End Sub
    Private Sub GridColom()
        With Me
            .dgv.Columns(0).Width = 100
            .dgv.Columns(1).Width = 100
        End With
    End Sub
    Private Sub gridHeader()
        With Me
            .dgv.Columns(0).HeaderText = "Kode User"
            .dgv.Columns(1).HeaderText = "Nama User"
            .dgv.Columns(2).HeaderText = "Password"
            .dgv.Columns(1).HeaderText = "Hak Akses"
        End With
        GridColom()
    End Sub
    Private Sub RefresData()
        buka()
        da = New SqlDataAdapter("SELECT * FROM MasterUser where IsActive=1", cn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "user")
        dgv.DataSource = ds.Tables("user")
        cn.Close()
        da.Dispose()
        ds.Dispose()
        Call gridHeader()
    End Sub
    Private Sub TampilanAwal()
        RefresData()
        TombolAwal()
        EnabledText()
        TextKosong()
        With Me
            .cmbCari.Enabled = False
            .txtCari.Enabled = False
            .txtCari.Text = ""
            .cmbCari.Text = ""
            .dgv.ReadOnly = True
        End With
        gridHeader()
        Exit Sub
        Me.Close()
    End Sub

    Private Sub FrmUser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TampilanAwal()
    End Sub

    Private Sub txtNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbHakAkses.Focus()
        End If
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub cmbHakAkses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHakAkses.SelectedIndexChanged
        btnSimpan.Focus()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Select Case Me.btnKeluar.Text
            Case "Keluar"
                cn.Close()
                Me.Close()
            Case "Batal"
                TampilanAwal()
        End Select
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        cmbCari.Enabled = True
    End Sub

    Private Sub cmbCari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCari.SelectedIndexChanged
        txtCari.Enabled = True
        txtCari.Focus()
    End Sub

    Private Sub txtCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCari.KeyPress
        buka()
        If e.KeyChar = Chr(13) Then
            Select Case cmbCari.SelectedIndex
                Case 0
                    Dim str As String
                    str = "Select * from user where KodeUser='" & txtCari.Text & "'"
                    dr = ExecuteReader(str)
                    dr.Read()
                    If dr.HasRows Then                        
                        txtNama.Text = dr.Item(1)
                        txtPass.Text = dr.Item(2)
                        cn.Close()
                        dr.Close()
                        cmd.Dispose()
                        TombolCari()
                        DisableText()
                        txtCari.Clear()
                        btnEdit.Focus()
                    Else
                        cn.Close()
                        dr.Close()
                    End If
                Case 1
                    Dim Sstr As String
                    Sstr = "Select * from user where NamaUser='" & txtCari.Text & "'"
                    dr = ExecuteReader(Sstr)
                    dr.Read()
                    If dr.HasRows Then                        
                        txtNama.Text = dr.Item(1)
                        txtPass.Text = dr.Item(2)
                        cn.Close()
                        dr.Close()
                        cmd.Dispose()
                        TombolCari()
                        DisableText()
                        txtCari.Clear()
                        btnEdit.Focus()
                    Else
                        cn.Close()
                        dr.Close()
                    End If
            End Select
        End If
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        buka()
        Select Case cmbCari.SelectedIndex
            Case 0
                da = New SqlDataAdapter("Select * from user where KodeUser like '%" & txtCari.Text & "%'", cn)
                ds = New DataSet
                ds.Clear()
                da.Fill(ds, "user")
                dgv.DataSource = ds.Tables("user")
                dgv.AutoGenerateColumns = True
                dgv.Refresh()
            Case 1
                da = New SqlDataAdapter("Select * from user where NamaUser like '%" & txtCari.Text & "%'", cn)
                ds = New DataSet
                ds.Clear()
                da.Fill(ds, "user")
                dgv.DataSource = ds.Tables("user")
                dgv.AutoGenerateColumns = True
                dgv.Refresh()
        End Select
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.DoubleClick
        Try
            With Me                
                .txtNama.Text = dgv.SelectedCells(1).Value
                .txtPass.Text = dgv.SelectedCells(2).Value
                TombolCari()
                DisableText()
                .txtCari.Clear()
                .btnEdit.Focus()
            End With
        Catch ex As Exception
            MsgBoxError("Kesalahan klik data, silahkan coba lagi")
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        EnabledText()
        With Me
            .txtNama.Focus()
            .cmbCari.Text = ""
            .cmbCari.Enabled = False
            .txtCari.Enabled = False
            .txtCari.Clear()
        End With
        TombolUpdate()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If CheckKosongText(ErrorProvider1, Me.txtNama) Then
            Exit Sub
        ElseIf CheckKosongText(ErrorProvider1, Me.txtPass) Then
            Exit Sub
        End If

        buka()
        Try
            'Pilih Case Simpan atau Update
            Select Case Me.btnSimpan.Text
                Case "Simpan"
                    sql = "Insert into user(KodeUser,NamaUser,Pass,HakAkses,Status)"
                    sql &= "values('" & txtNama.Text & "','" & txtPass.Text & "','" & cmbHakAkses.Text & "','1')"
                    cmd = New SqlCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    MsgSimpan()
                    TampilanAwal()
                Case "Update"
                    sql = "Update user set NamaUser='" & txtNama.Text & "',Pass='" & txtPass.Text & "',HakAkses='" & cmbHakAkses.Text & "'"
                    cmd = New SqlCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    MsgUpdate()
                    TampilanAwal()
            End Select
            'cn.Close()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        buka()
        sql = "Update user set Status=0"
        cmd = New SqlCommand(sql, cn)
        cmd.ExecuteNonQuery()
        MsgUpdate()
        TampilanAwal()
    End Sub
End Class