<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEJO
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtIDCheck = New System.Windows.Forms.TextBox
        Me.BtnCariLead = New System.Windows.Forms.Button
        Me.BtnCariPM = New System.Windows.Forms.Button
        Me.BtnCari = New System.Windows.Forms.Button
        Me.TxtGrp = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtNoPengecekan = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtTgl = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtNoEJO = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtLead = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtIdlead = New System.Windows.Forms.TextBox
        Me.Dgv = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 43)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "EJO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtIdlead)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtLead)
        Me.Panel1.Controls.Add(Me.TxtIDCheck)
        Me.Panel1.Controls.Add(Me.BtnCariLead)
        Me.Panel1.Controls.Add(Me.BtnCariPM)
        Me.Panel1.Controls.Add(Me.BtnCari)
        Me.Panel1.Controls.Add(Me.TxtGrp)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtNoPengecekan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DtTgl)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtNoEJO)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 176)
        Me.Panel1.TabIndex = 10
        '
        'TxtIDCheck
        '
        Me.TxtIDCheck.Enabled = False
        Me.TxtIDCheck.Location = New System.Drawing.Point(283, 64)
        Me.TxtIDCheck.MaxLength = 7
        Me.TxtIDCheck.Name = "TxtIDCheck"
        Me.TxtIDCheck.Size = New System.Drawing.Size(10, 20)
        Me.TxtIDCheck.TabIndex = 25
        Me.TxtIDCheck.Visible = False
        '
        'BtnCariLead
        '
        Me.BtnCariLead.Enabled = False
        Me.BtnCariLead.Location = New System.Drawing.Point(500, 93)
        Me.BtnCariLead.Name = "BtnCariLead"
        Me.BtnCariLead.Size = New System.Drawing.Size(49, 23)
        Me.BtnCariLead.TabIndex = 24
        Me.BtnCariLead.Text = "Cari"
        Me.BtnCariLead.UseVisualStyleBackColor = True
        '
        'BtnCariPM
        '
        Me.BtnCariPM.Location = New System.Drawing.Point(500, 67)
        Me.BtnCariPM.Name = "BtnCariPM"
        Me.BtnCariPM.Size = New System.Drawing.Size(49, 23)
        Me.BtnCariPM.TabIndex = 23
        Me.BtnCariPM.Text = "Cari"
        Me.BtnCariPM.UseVisualStyleBackColor = True
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(228, 64)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(49, 23)
        Me.BtnCari.TabIndex = 21
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'TxtGrp
        '
        Me.TxtGrp.Enabled = False
        Me.TxtGrp.Location = New System.Drawing.Point(100, 119)
        Me.TxtGrp.MaxLength = 7
        Me.TxtGrp.Name = "TxtGrp"
        Me.TxtGrp.Size = New System.Drawing.Size(50, 20)
        Me.TxtGrp.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Group"
        '
        'TxtNoPengecekan
        '
        Me.TxtNoPengecekan.Enabled = False
        Me.TxtNoPengecekan.Location = New System.Drawing.Point(100, 64)
        Me.TxtNoPengecekan.MaxLength = 7
        Me.TxtNoPengecekan.Name = "TxtNoPengecekan"
        Me.TxtNoPengecekan.Size = New System.Drawing.Size(122, 20)
        Me.TxtNoPengecekan.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lead Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No Pengecekan"
        '
        'DtTgl
        '
        Me.DtTgl.Location = New System.Drawing.Point(100, 36)
        Me.DtTgl.Name = "DtTgl"
        Me.DtTgl.Size = New System.Drawing.Size(193, 20)
        Me.DtTgl.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'TxtNoEJO
        '
        Me.TxtNoEJO.Enabled = False
        Me.TxtNoEJO.Location = New System.Drawing.Point(100, 10)
        Me.TxtNoEJO.MaxLength = 7
        Me.TxtNoEJO.Name = "TxtNoEJO"
        Me.TxtNoEJO.Size = New System.Drawing.Size(193, 20)
        Me.TxtNoEJO.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No EJO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtLead
        '
        Me.TxtLead.Enabled = False
        Me.TxtLead.Location = New System.Drawing.Point(100, 90)
        Me.TxtLead.MaxLength = 7
        Me.TxtLead.Name = "TxtLead"
        Me.TxtLead.Size = New System.Drawing.Size(122, 20)
        Me.TxtLead.TabIndex = 26
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(100, 147)
        Me.TextBox2.MaxLength = 7
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(50, 20)
        Me.TextBox2.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Shift"
        '
        'txtIdlead
        '
        Me.txtIdlead.Enabled = False
        Me.txtIdlead.Location = New System.Drawing.Point(228, 90)
        Me.txtIdlead.MaxLength = 7
        Me.txtIdlead.Name = "txtIdlead"
        Me.txtIdlead.Size = New System.Drawing.Size(10, 20)
        Me.txtIdlead.TabIndex = 29
        Me.txtIdlead.Visible = False
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv.Location = New System.Drawing.Point(0, 219)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(417, 120)
        Me.Dgv.TabIndex = 33
        '
        'FrmEJO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 339)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmEJO"
        Me.Text = "FrmEJO"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtIDCheck As System.Windows.Forms.TextBox
    Friend WithEvents BtnCariLead As System.Windows.Forms.Button
    Friend WithEvents BtnCariPM As System.Windows.Forms.Button
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents TxtGrp As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtNoPengecekan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNoEJO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtLead As System.Windows.Forms.TextBox
    Friend WithEvents txtIdlead As System.Windows.Forms.TextBox
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
End Class
