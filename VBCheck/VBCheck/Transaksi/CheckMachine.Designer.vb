<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckMachine
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCari = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnTambah = New System.Windows.Forms.Button
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.Dt1 = New System.Windows.Forms.DateTimePicker
        Me.Dt2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnCari = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCari)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Dt2)
        Me.GroupBox1.Controls.Add(Me.Dt1)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 52)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian Data"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(6, 19)
        Me.txtCari.MaxLength = 50
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(136, 20)
        Me.txtCari.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnKeluar)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnTambah)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(552, 36)
        Me.Panel2.TabIndex = 10
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(171, 5)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 5
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(90, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(7, 5)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv.Location = New System.Drawing.Point(0, 88)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(552, 317)
        Me.dgv.TabIndex = 11
        '
        'Dt1
        '
        Me.Dt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dt1.Location = New System.Drawing.Point(152, 19)
        Me.Dt1.Name = "Dt1"
        Me.Dt1.Size = New System.Drawing.Size(105, 20)
        Me.Dt1.TabIndex = 9
        '
        'Dt2
        '
        Me.Dt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dt2.Location = New System.Drawing.Point(294, 19)
        Me.Dt2.Name = "Dt2"
        Me.Dt2.Size = New System.Drawing.Size(105, 20)
        Me.Dt2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "S/D"
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(405, 18)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(75, 23)
        Me.BtnCari.TabIndex = 6
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'CheckMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 359)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CheckMachine"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
