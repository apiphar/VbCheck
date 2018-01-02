<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCheckingMachine
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
        Me.DtTgl = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtNoCheck = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtNoMC = New System.Windows.Forms.TextBox
        Me.TxtOptName = New System.Windows.Forms.TextBox
        Me.TxtPM = New System.Windows.Forms.TextBox
        Me.TxtLead = New System.Windows.Forms.TextBox
        Me.TxtSift = New System.Windows.Forms.TextBox
        Me.TxtGrp = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnCari = New System.Windows.Forms.Button
        Me.BtncariOpt = New System.Windows.Forms.Button
        Me.BtnCariPM = New System.Windows.Forms.Button
        Me.BtnCariLead = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(563, 43)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Pengecekan Mesin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnCariLead)
        Me.Panel1.Controls.Add(Me.BtnCariPM)
        Me.Panel1.Controls.Add(Me.BtncariOpt)
        Me.Panel1.Controls.Add(Me.BtnCari)
        Me.Panel1.Controls.Add(Me.TxtGrp)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtSift)
        Me.Panel1.Controls.Add(Me.TxtLead)
        Me.Panel1.Controls.Add(Me.TxtPM)
        Me.Panel1.Controls.Add(Me.TxtOptName)
        Me.Panel1.Controls.Add(Me.TxtNoMC)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DtTgl)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtNoCheck)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 162)
        Me.Panel1.TabIndex = 9
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
        'TxtNoCheck
        '
        Me.TxtNoCheck.Enabled = False
        Me.TxtNoCheck.Location = New System.Drawing.Point(100, 10)
        Me.TxtNoCheck.MaxLength = 7
        Me.TxtNoCheck.Name = "TxtNoCheck"
        Me.TxtNoCheck.Size = New System.Drawing.Size(193, 20)
        Me.TxtNoCheck.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No Check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No Mesin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Operator Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(278, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "PM Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(278, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Lead Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(278, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Sift"
        '
        'TxtNoMC
        '
        Me.TxtNoMC.Enabled = False
        Me.TxtNoMC.Location = New System.Drawing.Point(100, 64)
        Me.TxtNoMC.MaxLength = 7
        Me.TxtNoMC.Name = "TxtNoMC"
        Me.TxtNoMC.Size = New System.Drawing.Size(50, 20)
        Me.TxtNoMC.TabIndex = 14
        '
        'TxtOptName
        '
        Me.TxtOptName.Enabled = False
        Me.TxtOptName.Location = New System.Drawing.Point(100, 93)
        Me.TxtOptName.MaxLength = 7
        Me.TxtOptName.Name = "TxtOptName"
        Me.TxtOptName.Size = New System.Drawing.Size(90, 20)
        Me.TxtOptName.TabIndex = 15
        '
        'TxtPM
        '
        Me.TxtPM.Enabled = False
        Me.TxtPM.Location = New System.Drawing.Point(354, 67)
        Me.TxtPM.MaxLength = 7
        Me.TxtPM.Name = "TxtPM"
        Me.TxtPM.Size = New System.Drawing.Size(140, 20)
        Me.TxtPM.TabIndex = 16
        '
        'TxtLead
        '
        Me.TxtLead.Enabled = False
        Me.TxtLead.Location = New System.Drawing.Point(354, 95)
        Me.TxtLead.MaxLength = 7
        Me.TxtLead.Name = "TxtLead"
        Me.TxtLead.Size = New System.Drawing.Size(140, 20)
        Me.TxtLead.TabIndex = 17
        '
        'TxtSift
        '
        Me.TxtSift.Enabled = False
        Me.TxtSift.Location = New System.Drawing.Point(354, 122)
        Me.TxtSift.MaxLength = 7
        Me.TxtSift.Name = "TxtSift"
        Me.TxtSift.Size = New System.Drawing.Size(44, 20)
        Me.TxtSift.TabIndex = 18
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
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(156, 64)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(49, 23)
        Me.BtnCari.TabIndex = 21
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'BtncariOpt
        '
        Me.BtncariOpt.Location = New System.Drawing.Point(196, 91)
        Me.BtncariOpt.Name = "BtncariOpt"
        Me.BtncariOpt.Size = New System.Drawing.Size(49, 23)
        Me.BtncariOpt.TabIndex = 22
        Me.BtncariOpt.Text = "Cari"
        Me.BtncariOpt.UseVisualStyleBackColor = True
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
        'BtnCariLead
        '
        Me.BtnCariLead.Location = New System.Drawing.Point(500, 93)
        Me.BtnCariLead.Name = "BtnCariLead"
        Me.BtnCariLead.Size = New System.Drawing.Size(49, 23)
        Me.BtnCariLead.TabIndex = 24
        Me.BtnCariLead.Text = "Cari"
        Me.BtnCariLead.UseVisualStyleBackColor = True
        '
        'FrmCheckingMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 357)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCheckingMachine"
        Me.Text = "FrmCheckingMachine"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNoCheck As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtGrp As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtSift As System.Windows.Forms.TextBox
    Friend WithEvents TxtLead As System.Windows.Forms.TextBox
    Friend WithEvents TxtPM As System.Windows.Forms.TextBox
    Friend WithEvents TxtOptName As System.Windows.Forms.TextBox
    Friend WithEvents TxtNoMC As System.Windows.Forms.TextBox
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents BtnCariLead As System.Windows.Forms.Button
    Friend WithEvents BtnCariPM As System.Windows.Forms.Button
    Friend WithEvents BtncariOpt As System.Windows.Forms.Button
End Class
