<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLookUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLookUp))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cmb_Cari = New System.Windows.Forms.ComboBox
        Me.BtnKeluar = New System.Windows.Forms.Button
        Me.Txt_cari = New System.Windows.Forms.TextBox
        Me.Dgv = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmb_Cari)
        Me.GroupBox1.Controls.Add(Me.BtnKeluar)
        Me.GroupBox1.Controls.Add(Me.Txt_cari)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 63)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian Data"
        '
        'Cmb_Cari
        '
        Me.Cmb_Cari.FormattingEnabled = True
        Me.Cmb_Cari.Items.AddRange(New Object() {"No Pendaftaran", "Nama Pemilik"})
        Me.Cmb_Cari.Location = New System.Drawing.Point(12, 19)
        Me.Cmb_Cari.Name = "Cmb_Cari"
        Me.Cmb_Cari.Size = New System.Drawing.Size(177, 21)
        Me.Cmb_Cari.TabIndex = 4
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKeluar.Location = New System.Drawing.Point(537, 9)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(98, 48)
        Me.BtnKeluar.TabIndex = 3
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKeluar.UseVisualStyleBackColor = False
        '
        'Txt_cari
        '
        Me.Txt_cari.Enabled = False
        Me.Txt_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cari.Location = New System.Drawing.Point(195, 19)
        Me.Txt_cari.MaxLength = 50
        Me.Txt_cari.Name = "Txt_cari"
        Me.Txt_cari.Size = New System.Drawing.Size(336, 22)
        Me.Txt_cari.TabIndex = 2
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dgv.Location = New System.Drawing.Point(0, 63)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(649, 234)
        Me.Dgv.TabIndex = 2
        '
        'FrmLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 299)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLookUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pencarian data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents Txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Cmb_Cari As System.Windows.Forms.ComboBox
End Class
