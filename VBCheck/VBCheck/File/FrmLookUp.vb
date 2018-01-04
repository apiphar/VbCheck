Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmLookUp
    Public Perintah As String
    Private Sub ClearCari()
        With Me
            .Cmb_Cari.Text = ""
            .Txt_cari.Clear()
        End With
    End Sub
    Private Sub TampilanAwal()
        ClearCari()
        Me.Txt_cari.Enabled = False
    End Sub
    Private Sub GridColumnMachine()
        With Me
            .Dgv.Columns(0).Width = 1
            .Dgv.Columns(1).Width = 100
            .Dgv.Columns(2).Width = 100
            .Dgv.Columns(3).Width = 100
            .Dgv.Columns(4).Width = 100
            .Dgv.Columns(5).Width = 100
            .Dgv.Columns(6).Width = 100
            .Dgv.Columns(7).Width = 100
            .Dgv.Columns(8).Width = 100
        End With
    End Sub
    Private Sub GridHeaderMachine()
        With Me
            .Dgv.Columns(0).HeaderText = ""
            .Dgv.Columns(1).HeaderText = "Item Code"
            .Dgv.Columns(2).HeaderText = "Deskripsi"
            .Dgv.Columns(3).HeaderText = "kategori"
            .Dgv.Columns(4).HeaderText = "Kapasitas"
            .Dgv.Columns(5).HeaderText = "Lebar Drum"
            .Dgv.Columns(6).HeaderText = "No Mesin"
            .Dgv.Columns(7).HeaderText = "For Size"
            .Dgv.Columns(8).HeaderText = "Is Use"
        End With
        GridColumnMachine()
    End Sub    
    
    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub FrmLookUp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TampilanAwal()
        Me.Cmb_cari.Focus()
        Select Case perintah
            Case "Machine"
                With Me
                    buka()
                    da = New SqlDataAdapter("select IDMachine,ItemCode,[Desc],Category,Capacity,DrumWide,NoMC,ForSize,IsUse,UseDate from MasterMachine where IsActive=1", cn)
                    ds = New DataSet
                    ds.Clear()
                    da.Fill(ds, "MasterMachine")
                    Dgv.DataSource = ds.Tables("MasterMachine")
                    cn.Close()
                    da.Dispose()
                    ds.Dispose()
                End With                
            Case "Opt"
                With Me
                    buka()
                    da = New SqlDataAdapter("select IDOpt,NIP,Name,Grp,NoBuild from MasterOperator where IsActive=1", cn)
                    ds = New DataSet
                    ds.Clear()
                    da.Fill(ds, "MasterOperator")
                    Dgv.DataSource = ds.Tables("MasterOperator")
                    cn.Close()
                    da.Dispose()
                    ds.Dispose()
                End With
            Case "PM"
                With Me
                    buka()
                    da = New SqlDataAdapter("select IDPM,NIP,Name,Grp from MasterPM where IsActive=1", cn)
                    ds = New DataSet
                    ds.Clear()
                    da.Fill(ds, "MasterPM")
                    Dgv.DataSource = ds.Tables("MasterPM")
                    cn.Close()
                    da.Dispose()
                    ds.Dispose()
                End With
            Case "Lead"
                With Me
                    buka()
                    da = New SqlDataAdapter("select IDLead,NIP,Name,Grp from MasterLead where grp = '" & FrmCheckingMachine.TxtGrp.Text & "' and IsActive=1", cn)
                    ds = New DataSet
                    ds.Clear()
                    da.Fill(ds, "MasterLead")
                    Dgv.DataSource = ds.Tables("MasterLead")
                    cn.Close()
                    da.Dispose()
                    ds.Dispose()
                End With
            Case "Part"
                With Me
                    buka()
                    da = New SqlDataAdapter("select IDPart,PartName,Category from MasterEnginePart where IsAvalaible=1", cn)
                    ds = New DataSet
                    ds.Clear()
                    da.Fill(ds, "MasterLead")
                    Dgv.DataSource = ds.Tables("MasterLead")
                    cn.Close()
                    da.Dispose()
                    ds.Dispose()
                End With
        End Select
    End Sub

    Private Sub Cmb_cari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = Chr(0)
    End Sub

   

    Private Sub Txt_cari_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_cari.TextChanged
        'Select Case perintah
        '    Case "Bahan"
        '        Select Case Me.Cmb_cari.SelectedIndex
        '            Case 0
        '                IsiBahan()
        '                Me.Dgv.DataSource = Bahan.CariById()
        '                Me.Dgv.AutoGenerateColumns = True
        '                Me.Dgv.Refresh()
        '            Case 1
        '                IsiBahan()
        '                Me.Dgv.DataSource = Bahan.CaribyNama()
        '                Me.Dgv.AutoGenerateColumns = True
        '                Me.Dgv.Refresh()
        '        End Select
        '    Case "Barang"
        '        Select Case Me.Cmb_cari.SelectedIndex
        '            Case 0
        '                Isibarang()
        '                Me.Dgv.DataSource = Barang.CariById()
        '                Me.Dgv.AutoGenerateColumns = True
        '                Me.Dgv.Refresh()
        '            Case 1
        '                Isibarang()
        '                Me.Dgv.DataSource = Barang.CaribyNama()
        '                Me.Dgv.AutoGenerateColumns = True
        '                Me.Dgv.Refresh()
        '        End Select
        'End Select
    End Sub

    Private Sub Dgv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv.DoubleClick
        Dim i As Integer
        Select Case Perintah
            Case "Machine"
                With FrmCheckingMachine
                    i = Me.Dgv.CurrentRow.Index
                    .TxtNoMC.Text = Me.Dgv.Item(6, i).Value
                    .TxtIDMc.Text = Me.Dgv.Item(0, i).Value
                    Me.Close()
                End With
            Case "Opt"
                With FrmCheckingMachine
                    i = Me.Dgv.CurrentRow.Index
                    .TxtOptName.Text = Me.Dgv.Item(2, i).Value
                    .TxtGrp.Text = Me.Dgv.Item(3, i).Value
                    .TxtIDOpt.Text = Me.Dgv.Item(0, i).Value
                    .BtnCariLead.Enabled = True
                    Me.Close()
                End With
            Case "PM"
                With FrmCheckingMachine
                    i = Me.Dgv.CurrentRow.Index
                    .TxtPM.Text = Me.Dgv.Item(2, i).Value
                    .TxtIDPM.Text = Me.Dgv.Item(0, i).Value
                    Me.Close()
                End With
            Case "Lead"
                With FrmCheckingMachine
                    i = Me.Dgv.CurrentRow.Index
                    .TxtLead.Text = Me.Dgv.Item(2, i).Value
                    .TxtIDLead.Text = Me.Dgv.Item(0, i).Value
                    Me.Close()
                End With
            Case "Part"
                With FrmCheckingMachine
                    i = Me.Dgv.CurrentRow.Index
                    .TxtPart.Text = Me.Dgv.Item(1, i).Value
                    .TxtIdPart.Text = Me.Dgv.Item(0, i).Value
                    Me.Close()
                End With
        End Select
    End Sub

    Private Sub Dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
End Class