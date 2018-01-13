Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Detail

    Private Sub TxtNocheck_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNocheck.TextChanged
        buka()
        da = New SqlDataAdapter("select PartName,ProblemDecription,DamagedPart,ActionPlan,PartsNeeded,PartsStatus,Obstacle,Action,ProblemTime,UntilTime,Duration,Condition1,Condition2,Losses,IsEJO from Vw_CheckDetail where [NoCheck] like '%" & TxtNocheck.Text & "%'", cn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Vw_TrxCheckEngine")
        dgv.DataSource = ds.Tables("Vw_TrxCheckEngine")
        dgv.AutoGenerateColumns = True
        dgv.Refresh()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class