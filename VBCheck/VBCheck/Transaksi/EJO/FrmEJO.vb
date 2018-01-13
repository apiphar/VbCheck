Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmEJO
    Private Sub RefreshData()
        buka()
        da = New SqlDataAdapter("select * from Vw_TrxCheckEngine where [NoCheck] ='" & Me.TxtNoPengecekan.Text & "'", cn)
        ds = New DataSet("Vw_TrxCheckEngine")
        ds.Clear()
        da.Fill(ds, "Vw_TrxCheckEngine")
        Dgv.DataSource = ds.Tables("Vw_TrxCheckEngine")
        cn.Close()
        da.Dispose()
        ds.Dispose()
    End Sub
    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        FrmLookUp.Perintah = "IsEJO"
        FrmLookUp.ShowDialog()
    End Sub

    Private Sub TxtNoPengecekan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNoPengecekan.TextChanged
        RefreshData()
    End Sub
End Class