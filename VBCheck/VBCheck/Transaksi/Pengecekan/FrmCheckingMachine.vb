Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmCheckingMachine
    Private intbaris As Integer
    Dim MyFormat As String = "h:mm:ss"
    Private Sub LebarKolomDetail()
        With Me
            .Dgv.Columns(0).Width = 100
            .Dgv.Columns(1).Width = 100
            .Dgv.Columns(2).Width = 100
            .Dgv.Columns(3).Width = 100
            .Dgv.Columns(4).Width = 100
            .Dgv.Columns(5).Width = 100
            .Dgv.Columns(6).Width = 100
            .Dgv.Columns(7).Width = 100
            .Dgv.Columns(8).Width = 100
            .Dgv.Columns(9).Width = 100
            .Dgv.Columns(10).Width = 100
            .Dgv.Columns(11).Width = 100
            .Dgv.Columns(12).Width = 100
            .Dgv.Columns(13).Width = 100
            .Dgv.Columns(14).Width = 100
            .Dgv.Columns(15).Visible = False
        End With
    End Sub
    Private Sub GridDetail()
        With Me
            
            .Dgv.Columns.Add(0, "Part Name")
            .Dgv.Columns.Add(1, "Problem Mesin")
            .Dgv.Columns.Add(2, "Part yang rusak")
            .Dgv.Columns.Add(3, "Action Plan")
            .Dgv.Columns.Add(4, "Parts needed")
            .Dgv.Columns.Add(5, "Status Sparepart")
            .Dgv.Columns.Add(6, "Kendala")
            .Dgv.Columns.Add(7, "Action")
            .Dgv.Columns.Add(8, "Problem time")
            .Dgv.Columns.Add(9, "Until time")
            .Dgv.Columns.Add(10, "Duration")
            .Dgv.Columns.Add(11, "Kondisi 1")
            .Dgv.Columns.Add(12, "Kondisi 2")
            .Dgv.Columns.Add(13, "Losses")
            .Dgv.Columns.Add(14, "Is EJO")
            .Dgv.Columns.Add(15, "IDPart")
        End With
        LebarKolomDetail()
    End Sub
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
            cmd.Dispose()
            CloseConn()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Peringatan")
            dr.Close()
            cmd.Dispose()
            CloseConn()
            Return False
        End Try
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        FrmLookUp.Perintah = "Machine"
        FrmLookUp.ShowDialog()
    End Sub
    Private Sub TampilanAwal()
        GenerateNoTrans()
        GridDetail()        
    End Sub
    Private Sub FrmCheckingMachine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TampilanAwal()
    End Sub

    Private Sub BtncariOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtncariOpt.Click
        FrmLookUp.Perintah = "Opt"
        FrmLookUp.ShowDialog()
    End Sub

    Private Sub BtnCariPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariPM.Click
        FrmLookUp.Perintah = "PM"
        FrmLookUp.ShowDialog()
    End Sub

    Private Sub BtnCariLead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariLead.Click
        FrmLookUp.Perintah = "Lead"
        FrmLookUp.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        CheckMachineList.Show()
    End Sub

    Private Sub BtnCaripart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCaripart.Click
        FrmLookUp.Perintah = "Part"
        FrmLookUp.ShowDialog()
        TxtProbMC.Focus()
    End Sub

    Private Sub TxtProbMC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProbMC.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtDamagedPart.Focus()
        End If
    End Sub

    Private Sub TxtProbMC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProbMC.TextChanged

    End Sub

    Private Sub TxtDamagedPart_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDamagedPart.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtActionPlan.Focus()
        End If
    End Sub

    Private Sub TxtDamagedPart_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDamagedPart.TextChanged

    End Sub

    Private Sub TxtActionPlan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtActionPlan.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPrtNeed.Focus()
        End If
    End Sub

    Private Sub TxtActionPlan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtActionPlan.TextChanged

    End Sub

    Private Sub TxtPrtNeed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrtNeed.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtStatPart.Focus()
        End If
    End Sub

    Private Sub TxtPrtNeed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPrtNeed.TextChanged

    End Sub

    Private Sub TxtStatPart_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStatPart.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtObst.Focus()
        End If
    End Sub

    Private Sub TxtStatPart_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStatPart.TextChanged

    End Sub

    Private Sub TxtObst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtObst.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtActSemen.Focus()
        End If
    End Sub

    Private Sub TxtObst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtObst.TextChanged

    End Sub

    Private Sub Dt2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ts As TimeSpan = Dt1.Value.TimeOfDay
    End Sub

    Private Sub TxtKon1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKon1.KeyPress
        If e.KeyChar = Chr(13) Then
            Txtkon2.Focus()
        End If
    End Sub

    Private Sub TxtKon1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKon1.TextChanged

    End Sub

    Private Sub Txtkon2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtkon2.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtLosses.Focus()
        End If
    End Sub

    Private Sub Txtkon2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtkon2.TextChanged

    End Sub

    Private Sub TxtLosses_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLosses.KeyPress
        If e.KeyChar = Chr(13) Then
            BtnAdd.Focus()
        End If
    End Sub

    Private Sub TxtLosses_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLosses.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        BtnAdd.Focus()
    End Sub

    Private Sub TxtActSemen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtActSemen.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtKon1.Focus()
        End If
    End Sub

    Private Sub TxtActSemen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtActSemen.TextChanged

    End Sub

    Private Sub FrmCheckingMachine_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Dt1.Format = DateTimePickerFormat.Custom
        'Dt1.CustomFormat = MyFormat
        'Dt1.ShowUpDown = True

        'Dt2.Format = DateTimePickerFormat.Custom
        'Dt2.CustomFormat = MyFormat
        'Dt2.ShowUpDown = True
    End Sub

    Private Sub Dt1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''TxtDuration.Text = Dt1.Value.ToString(MyFormat)

        'Dim ts As TimeSpan = Dt1.Value.TimeOfDay
    End Sub
    Sub ClearDetail()
        With Me
            .TxtIdPart.Clear()
            .TxtPart.Clear()
            .TxtProbMC.Clear()
            .TxtDamagedPart.Clear()
            .TxtActionPlan.Clear()
            .TxtPrtNeed.Clear()
            .TxtStatPart.Clear()
            .TxtObst.Clear()
            .TxtActSemen.Clear()
            .TxtKon1.Clear()
            .Txtkon2.Clear()
            .TxtLosses.Clear()
            .CheckBox1.Checked = False
        End With
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        TxtDuration.Text = DateDiff(DateInterval.Hour, Dt1.Value, Dt2.Value)

        Dim EJO As String
        If CheckBox1.Checked Then
            EJO = "Yes"
        Else
            EJO = "No"
        End If

        If TxtPart.Text = "" Then
            MsgBox("Pilih Part", MsgBoxStyle.Critical, "Warning")
            ClearDetail()
        End If

        Dim cek As Integer
        For cek = 0 To Me.Dgv.Rows.Count - 1
            If Me.Dgv.Rows(cek).Cells(0).Value = Me.TxtPart.Text Then
                MsgBox("Data sudah ada didalam list", MsgBoxStyle.Critical, "warning")
                ClearDetail()
                Exit Sub
            End If
        Next
        Try
            With Me
                .Dgv.Rows.Add()
                .Dgv.Item(0, intbaris).Value = .TxtPart.Text
                .Dgv.Item(1, intbaris).Value = .TxtProbMC.Text
                .Dgv.Item(2, intbaris).Value = .TxtDamagedPart.Text
                .Dgv.Item(3, intbaris).Value = .TxtActionPlan.Text
                .Dgv.Item(4, intbaris).Value = .TxtPrtNeed.Text
                .Dgv.Item(5, intbaris).Value = .TxtStatPart.Text
                .Dgv.Item(6, intbaris).Value = .TxtObst.Text
                .Dgv.Item(7, intbaris).Value = .TxtActSemen.Text
                .Dgv.Item(8, intbaris).Value = .Dt1.Value
                .Dgv.Item(9, intbaris).Value = .Dt2.Value
                .Dgv.Item(10, intbaris).Value = .TxtDuration.Text
                .Dgv.Item(11, intbaris).Value = .TxtKon1.Text
                .Dgv.Item(12, intbaris).Value = .Txtkon2.Text
                .Dgv.Item(13, intbaris).Value = TxtLosses.Text
                .Dgv.Item(14, intbaris).Value = EJO
                .Dgv.Item(15, intbaris).Value = .TxtIdPart.Text
            End With
            intbaris = intbaris + 1
        Catch ex As Exception
            Exit Sub
            MsgBox("error")
        End Try
        'Me.TxtKdBrg.Focus()
        Call ClearDetail()
        BtnSimpanAll.Enabled = True
    End Sub
    Private Sub Hapus()
        Me.Dgv.Rows.RemoveAt(Me.Dgv.CurrentCell.RowIndex)
        intbaris = intbaris - 1
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim delete As String
        delete = MsgBox("yakin data akan dihapus?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "PESAN")
        If delete = MsgBoxResult.Yes Then
            Hapus()
        End If
    End Sub
    Public Function Simpan() As Boolean
        Dim Result As Boolean = False
        Dim SqlHeader As String
        Dim SqlDetail As String
        Dim UpdateMachine As String
        Dim detail As Integer
        Dim Trans As SqlTransaction
        Dim CMD1 As SqlCommand
        Dim CMD2 As SqlCommand
        Dim MC As SqlCommand
        Dim CheckDate As String
        Dim IsEJo As Boolean

        CheckDate = Convert.ToDateTime(DtTgl.Value).ToString("yyyy-MM-dd")

        Try
            buka()
            Trans = cn.BeginTransaction
            SqlHeader = "Insert into TrxCheckHeader([NoCheck],IDMachine,IDOpt,IDPM,IDLead,CheckDate,Shift)Values('" & TxtNoCheck.Text & "'" & _
                        ",'" & TxtIDMc.Text & "','" & TxtIDOpt.Text & "','" & TxtIDPM.Text & "','" & TxtIDLead.Text & "','" & CheckDate & "','" & TxtSift.Text & "')"
            CMD1 = New SqlCommand(SqlHeader, cn, Trans)
            CMD1.ExecuteNonQuery()

            For detail = 0 To Dgv.Rows.Count - 2
                If Dgv.Rows(detail).Cells(14).Value = "Yes" Then
                    IsEJo = True
                Else
                    IsEJo = False
                End If

                SqlDetail = "Insert into TrxCheckDetail([Nocheck],IDPart,ProblemDecription,DamagedPart,ActionPlan,PartsNeeded,PartsStatus,Obstacle,Action,ProblemTime,UntilTime,Duration,Condition1,Condition2,Losses,IsEJO)Values('" & TxtNoCheck.Text & "'" & _
                            ",'" & Dgv.Rows(detail).Cells(15).Value & "','" & Dgv.Rows(detail).Cells(1).Value & "','" & Dgv.Rows(detail).Cells(2).Value & "','" & Dgv.Rows(detail).Cells(3).Value & "','" & Dgv.Rows(detail).Cells(4).Value & "'" & _
                            ",'" & Dgv.Rows(detail).Cells(5).Value & "','" & Dgv.Rows(detail).Cells(6).Value & "','" & Dgv.Rows(detail).Cells(7).Value & "','" & Dgv.Rows(detail).Cells(8).Value & "','" & Dgv.Rows(detail).Cells(9).Value & "'" & _
                            ",'" & Dgv.Rows(detail).Cells(10).Value & "','" & Dgv.Rows(detail).Cells(11).Value & "','" & Dgv.Rows(detail).Cells(12).Value & "','" & Dgv.Rows(detail).Cells(13).Value & "','" & IsEJo & "')"
                CMD2 = New SqlCommand(SqlDetail, cn, Trans)
                CMD2.ExecuteNonQuery()
            Next

            UpdateMachine = "Update MasterMachine set CheckDate='" & CheckDate & "',StatusCheck='" & IsEJo & "' Where IDMachine='" & TxtIDMc.Text & "'"
            MC = New SqlCommand(UpdateMachine, cn, Trans)
            MC.ExecuteNonQuery()

            CMD1.Dispose()
            CMD2.Dispose()
            MC.Dispose()
        Catch ex As Exception
            Trans.Rollback()
            MsgBoxError(ex.Message)
            Result = False
        Finally
            Trans.Commit()
            Trans.Dispose()
            CloseConn()
            Result = True
        End Try
        Return Result

    End Function
    Private Sub BtnSimpanAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanAll.Click
        If CheckKosongText(ErrorProvider1, Me.TxtNoMC) Then
            Exit Sub
        ElseIf CheckKosongText(ErrorProvider1, Me.TxtOptName) Then
            Exit Sub
        ElseIf CheckKosongText(ErrorProvider1, Me.TxtPM) Then
            Exit Sub
        ElseIf CheckKosongText(ErrorProvider1, Me.TxtLead) Then
            Exit Sub
        ElseIf CheckKosongText(ErrorProvider1, Me.TxtSift) Then
            Exit Sub
        End If

        Simpan()
        Dgv.Rows.Clear()
        TampilanAwal()
    End Sub
End Class