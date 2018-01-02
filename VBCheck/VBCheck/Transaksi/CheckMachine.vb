Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class CheckMachine
    Private Sub RefreshData()
        buka()
        da = New SqlDataAdapter("select * from Vw_TrxCheckEngine", cn)
        ds = New DataSet("Vw_TrxCheckEngine")
        ds.Clear()
        da.Fill(ds, "Vw_TrxCheckEngine")
        dgv.DataSource = ds.Tables("Vw_TrxCheckEngine")
        cn.Close()
        da.Dispose()
        ds.Dispose()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        buka()
        da = New SqlDataAdapter("select * from Vw_TrxCheckEngine where [NoCheck] like '%" & txtCari.Text & "%'", cn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Vw_TrxCheckEngine")
        dgv.DataSource = ds.Tables("Vw_TrxCheckEngine")
        dgv.AutoGenerateColumns = True
        dgv.Refresh()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        buka()
        Dim checkDate1 As String
        Dim checkDate2 As String
        checkDate1 = Convert.ToDateTime(Me.Dt1.Value).ToString("yyyy-MM-dd")
        checkDate2 = Convert.ToDateTime(Me.Dt2.Value).ToString("yyyy-MM-dd")

        dt = New DataTable()
        cmd = New SqlCommand("SP_TRXCheckEgine", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@NoCheck", Me.txtCari.Text)
        cmd.Parameters.AddWithValue("@CheckDate1", checkDate1)
        cmd.Parameters.AddWithValue("@CheckDate2", checkDate2)
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        FrmCheckingMachine.Show()
        Me.Hide()
    End Sub
End Class
