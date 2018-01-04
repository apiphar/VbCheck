<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterMesinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterOperatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterPMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterLeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterEnginePartsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PengecekanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KonfigurasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.NamaUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.HakAkses = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Tanggal = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Jam = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.nip = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.KonfigurasiToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(556, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterMesinToolStripMenuItem, Me.MasterOperatorToolStripMenuItem, Me.MasterPMToolStripMenuItem, Me.MasterLeadToolStripMenuItem, Me.MasterEnginePartsToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'MasterMesinToolStripMenuItem
        '
        Me.MasterMesinToolStripMenuItem.Name = "MasterMesinToolStripMenuItem"
        Me.MasterMesinToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MasterMesinToolStripMenuItem.Text = "Master Mesin"
        '
        'MasterOperatorToolStripMenuItem
        '
        Me.MasterOperatorToolStripMenuItem.Name = "MasterOperatorToolStripMenuItem"
        Me.MasterOperatorToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MasterOperatorToolStripMenuItem.Text = "Master Operator"
        '
        'MasterPMToolStripMenuItem
        '
        Me.MasterPMToolStripMenuItem.Name = "MasterPMToolStripMenuItem"
        Me.MasterPMToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MasterPMToolStripMenuItem.Text = "Master PM"
        '
        'MasterLeadToolStripMenuItem
        '
        Me.MasterLeadToolStripMenuItem.Name = "MasterLeadToolStripMenuItem"
        Me.MasterLeadToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MasterLeadToolStripMenuItem.Text = "Master Lead"
        '
        'MasterEnginePartsToolStripMenuItem
        '
        Me.MasterEnginePartsToolStripMenuItem.Name = "MasterEnginePartsToolStripMenuItem"
        Me.MasterEnginePartsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MasterEnginePartsToolStripMenuItem.Text = "Master Engine Parts"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengecekanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PengecekanToolStripMenuItem
        '
        Me.PengecekanToolStripMenuItem.Name = "PengecekanToolStripMenuItem"
        Me.PengecekanToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PengecekanToolStripMenuItem.Text = "Pengecekan"
        '
        'KonfigurasiToolStripMenuItem
        '
        Me.KonfigurasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiPasswordToolStripMenuItem})
        Me.KonfigurasiToolStripMenuItem.Name = "KonfigurasiToolStripMenuItem"
        Me.KonfigurasiToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.KonfigurasiToolStripMenuItem.Text = "Konfigurasi"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NamaUser, Me.ToolStripStatusLabel2, Me.HakAkses, Me.ToolStripStatusLabel4, Me.Tanggal, Me.ToolStripStatusLabel6, Me.Jam, Me.ToolStripStatusLabel1, Me.nip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 365)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(556, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'NamaUser
        '
        Me.NamaUser.Enabled = False
        Me.NamaUser.Name = "NamaUser"
        Me.NamaUser.Size = New System.Drawing.Size(65, 17)
        Me.NamaUser.Text = "Nama User"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'HakAkses
        '
        Me.HakAkses.Enabled = False
        Me.HakAkses.Name = "HakAkses"
        Me.HakAkses.Size = New System.Drawing.Size(61, 17)
        Me.HakAkses.Text = "Hak Akses"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'Tanggal
        '
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(50, 17)
        Me.Tanggal.Text = "Tanggal"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel6.Text = "|"
        '
        'Jam
        '
        Me.Jam.Name = "Jam"
        Me.Jam.Size = New System.Drawing.Size(28, 17)
        Me.Jam.Text = "Jam"
        '
        'Timer1
        '
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'nip
        '
        Me.nip.Name = "nip"
        Me.nip.Size = New System.Drawing.Size(26, 17)
        Me.nip.Text = "NIP"
        Me.nip.Visible = False
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 387)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KonfigurasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterMesinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterOperatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterPMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterLeadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterEnginePartsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengecekanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents NamaUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents HakAkses As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Tanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Jam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents nip As System.Windows.Forms.ToolStripStatusLabel
End Class
