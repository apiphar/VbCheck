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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtIDLead = New System.Windows.Forms.TextBox
        Me.TxtIDPM = New System.Windows.Forms.TextBox
        Me.TxtIDOpt = New System.Windows.Forms.TextBox
        Me.TxtIDMc = New System.Windows.Forms.TextBox
        Me.BtnCariLead = New System.Windows.Forms.Button
        Me.BtnCariPM = New System.Windows.Forms.Button
        Me.BtncariOpt = New System.Windows.Forms.Button
        Me.BtnCari = New System.Windows.Forms.Button
        Me.TxtGrp = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtSift = New System.Windows.Forms.TextBox
        Me.TxtLead = New System.Windows.Forms.TextBox
        Me.TxtPM = New System.Windows.Forms.TextBox
        Me.TxtOptName = New System.Windows.Forms.TextBox
        Me.TxtNoMC = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtTgl = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtNoCheck = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtPart = New System.Windows.Forms.TextBox
        Me.BtnCaripart = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnSimpanAll = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Dt2 = New System.Windows.Forms.DateTimePicker
        Me.Dt1 = New System.Windows.Forms.DateTimePicker
        Me.TxtIdPart = New System.Windows.Forms.TextBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.TxtLosses = New System.Windows.Forms.TextBox
        Me.Txtkon2 = New System.Windows.Forms.TextBox
        Me.TxtKon1 = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtDuration = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtActSemen = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtObst = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtStatPart = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtPrtNeed = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtActionPlan = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtDamagedPart = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtProbMC = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Dgv = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(804, 43)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Pengecekan Mesin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TxtIDLead)
        Me.Panel1.Controls.Add(Me.TxtIDPM)
        Me.Panel1.Controls.Add(Me.TxtIDOpt)
        Me.Panel1.Controls.Add(Me.TxtIDMc)
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
        Me.Panel1.Size = New System.Drawing.Size(804, 162)
        Me.Panel1.TabIndex = 9
        '
        'TxtIDLead
        '
        Me.TxtIDLead.Enabled = False
        Me.TxtIDLead.Location = New System.Drawing.Point(370, 39)
        Me.TxtIDLead.MaxLength = 7
        Me.TxtIDLead.Name = "TxtIDLead"
        Me.TxtIDLead.Size = New System.Drawing.Size(10, 20)
        Me.TxtIDLead.TabIndex = 28
        Me.TxtIDLead.Visible = False
        '
        'TxtIDPM
        '
        Me.TxtIDPM.Enabled = False
        Me.TxtIDPM.Location = New System.Drawing.Point(354, 39)
        Me.TxtIDPM.MaxLength = 7
        Me.TxtIDPM.Name = "TxtIDPM"
        Me.TxtIDPM.Size = New System.Drawing.Size(10, 20)
        Me.TxtIDPM.TabIndex = 27
        Me.TxtIDPM.Visible = False
        '
        'TxtIDOpt
        '
        Me.TxtIDOpt.Enabled = False
        Me.TxtIDOpt.Location = New System.Drawing.Point(251, 90)
        Me.TxtIDOpt.MaxLength = 7
        Me.TxtIDOpt.Name = "TxtIDOpt"
        Me.TxtIDOpt.Size = New System.Drawing.Size(10, 20)
        Me.TxtIDOpt.TabIndex = 26
        Me.TxtIDOpt.Visible = False
        '
        'TxtIDMc
        '
        Me.TxtIDMc.Enabled = False
        Me.TxtIDMc.Location = New System.Drawing.Point(211, 64)
        Me.TxtIDMc.MaxLength = 7
        Me.TxtIDMc.Name = "TxtIDMc"
        Me.TxtIDMc.Size = New System.Drawing.Size(10, 20)
        Me.TxtIDMc.TabIndex = 25
        Me.TxtIDMc.Visible = False
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
        'BtncariOpt
        '
        Me.BtncariOpt.Location = New System.Drawing.Point(196, 91)
        Me.BtncariOpt.Name = "BtncariOpt"
        Me.BtncariOpt.Size = New System.Drawing.Size(49, 23)
        Me.BtncariOpt.TabIndex = 22
        Me.BtncariOpt.Text = "Cari"
        Me.BtncariOpt.UseVisualStyleBackColor = True
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
        'TxtSift
        '
        Me.TxtSift.Location = New System.Drawing.Point(354, 122)
        Me.TxtSift.MaxLength = 7
        Me.TxtSift.Name = "TxtSift"
        Me.TxtSift.Size = New System.Drawing.Size(44, 20)
        Me.TxtSift.TabIndex = 18
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
        'TxtPM
        '
        Me.TxtPM.Enabled = False
        Me.TxtPM.Location = New System.Drawing.Point(354, 67)
        Me.TxtPM.MaxLength = 7
        Me.TxtPM.Name = "TxtPM"
        Me.TxtPM.Size = New System.Drawing.Size(140, 20)
        Me.TxtPM.TabIndex = 16
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
        'TxtNoMC
        '
        Me.TxtNoMC.Enabled = False
        Me.TxtNoMC.Location = New System.Drawing.Point(100, 64)
        Me.TxtNoMC.MaxLength = 7
        Me.TxtNoMC.Name = "TxtNoMC"
        Me.TxtNoMC.Size = New System.Drawing.Size(50, 20)
        Me.TxtNoMC.TabIndex = 14
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 15)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Part"
        '
        'TxtPart
        '
        Me.TxtPart.Enabled = False
        Me.TxtPart.Location = New System.Drawing.Point(102, 5)
        Me.TxtPart.MaxLength = 7
        Me.TxtPart.Name = "TxtPart"
        Me.TxtPart.Size = New System.Drawing.Size(90, 20)
        Me.TxtPart.TabIndex = 30
        '
        'BtnCaripart
        '
        Me.BtnCaripart.Location = New System.Drawing.Point(198, 3)
        Me.BtnCaripart.Name = "BtnCaripart"
        Me.BtnCaripart.Size = New System.Drawing.Size(49, 23)
        Me.BtnCaripart.TabIndex = 29
        Me.BtnCaripart.Text = "Cari"
        Me.BtnCaripart.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnSimpanAll)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Dt2)
        Me.Panel2.Controls.Add(Me.Dt1)
        Me.Panel2.Controls.Add(Me.TxtIdPart)
        Me.Panel2.Controls.Add(Me.BtnAdd)
        Me.Panel2.Controls.Add(Me.TxtLosses)
        Me.Panel2.Controls.Add(Me.Txtkon2)
        Me.Panel2.Controls.Add(Me.TxtKon1)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.TxtDuration)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.TxtActSemen)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.TxtObst)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.TxtStatPart)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.TxtPrtNeed)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.TxtActionPlan)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.TxtDamagedPart)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TxtProbMC)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TxtPart)
        Me.Panel2.Controls.Add(Me.BtnCaripart)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 205)
        Me.Panel2.TabIndex = 31
        '
        'BtnSimpanAll
        '
        Me.BtnSimpanAll.Enabled = False
        Me.BtnSimpanAll.Location = New System.Drawing.Point(685, 174)
        Me.BtnSimpanAll.Name = "BtnSimpanAll"
        Me.BtnSimpanAll.Size = New System.Drawing.Size(55, 23)
        Me.BtnSimpanAll.TabIndex = 64
        Me.BtnSimpanAll.Text = "Save All"
        Me.BtnSimpanAll.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(651, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 23)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Dt2
        '
        Me.Dt2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Dt2.Location = New System.Drawing.Point(573, 76)
        Me.Dt2.Name = "Dt2"
        Me.Dt2.Size = New System.Drawing.Size(104, 20)
        Me.Dt2.TabIndex = 62
        '
        'Dt1
        '
        Me.Dt1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Dt1.Location = New System.Drawing.Point(463, 77)
        Me.Dt1.Name = "Dt1"
        Me.Dt1.Size = New System.Drawing.Size(108, 20)
        Me.Dt1.TabIndex = 61
        '
        'TxtIdPart
        '
        Me.TxtIdPart.Location = New System.Drawing.Point(253, 5)
        Me.TxtIdPart.MaxLength = 7
        Me.TxtIdPart.Name = "TxtIdPart"
        Me.TxtIdPart.Size = New System.Drawing.Size(10, 20)
        Me.TxtIdPart.TabIndex = 60
        Me.TxtIdPart.Visible = False
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(618, 174)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(31, 23)
        Me.BtnAdd.TabIndex = 59
        Me.BtnAdd.Text = "+"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtLosses
        '
        Me.TxtLosses.Location = New System.Drawing.Point(464, 155)
        Me.TxtLosses.MaxLength = 1000
        Me.TxtLosses.Name = "TxtLosses"
        Me.TxtLosses.Size = New System.Drawing.Size(121, 20)
        Me.TxtLosses.TabIndex = 58
        '
        'Txtkon2
        '
        Me.Txtkon2.Location = New System.Drawing.Point(464, 128)
        Me.Txtkon2.MaxLength = 1000
        Me.Txtkon2.Name = "Txtkon2"
        Me.Txtkon2.Size = New System.Drawing.Size(121, 20)
        Me.Txtkon2.TabIndex = 57
        '
        'TxtKon1
        '
        Me.TxtKon1.Location = New System.Drawing.Point(464, 102)
        Me.TxtKon1.MaxLength = 1000
        Me.TxtKon1.Name = "TxtKon1"
        Me.TxtKon1.Size = New System.Drawing.Size(121, 20)
        Me.TxtKon1.TabIndex = 56
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(466, 183)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 55
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(336, 182)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 15)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "Is EJO"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(336, 156)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 15)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Losses"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(336, 130)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 15)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "Kondisi 2"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(716, 78)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(27, 15)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "Jam"
        '
        'TxtDuration
        '
        Me.TxtDuration.Enabled = False
        Me.TxtDuration.Location = New System.Drawing.Point(688, 76)
        Me.TxtDuration.MaxLength = 7
        Me.TxtDuration.Name = "TxtDuration"
        Me.TxtDuration.Size = New System.Drawing.Size(25, 20)
        Me.TxtDuration.TabIndex = 50
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(336, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 15)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Kondisi 1"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(336, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 15)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Problem Time"
        '
        'TxtActSemen
        '
        Me.TxtActSemen.Location = New System.Drawing.Point(463, 52)
        Me.TxtActSemen.MaxLength = 1000
        Me.TxtActSemen.Name = "TxtActSemen"
        Me.TxtActSemen.Size = New System.Drawing.Size(186, 20)
        Me.TxtActSemen.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(334, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 15)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Tindakan sementara"
        '
        'TxtObst
        '
        Me.TxtObst.Location = New System.Drawing.Point(462, 27)
        Me.TxtObst.MaxLength = 1000
        Me.TxtObst.Name = "TxtObst"
        Me.TxtObst.Size = New System.Drawing.Size(186, 20)
        Me.TxtObst.TabIndex = 43
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(334, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 15)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Kendala"
        '
        'TxtStatPart
        '
        Me.TxtStatPart.Location = New System.Drawing.Point(133, 158)
        Me.TxtStatPart.MaxLength = 1000
        Me.TxtStatPart.Name = "TxtStatPart"
        Me.TxtStatPart.Size = New System.Drawing.Size(186, 20)
        Me.TxtStatPart.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 15)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Status part"
        '
        'TxtPrtNeed
        '
        Me.TxtPrtNeed.Location = New System.Drawing.Point(133, 132)
        Me.TxtPrtNeed.MaxLength = 1000
        Me.TxtPrtNeed.Name = "TxtPrtNeed"
        Me.TxtPrtNeed.Size = New System.Drawing.Size(186, 20)
        Me.TxtPrtNeed.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 15)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Part yang dibutuhkan"
        '
        'TxtActionPlan
        '
        Me.TxtActionPlan.Location = New System.Drawing.Point(133, 106)
        Me.TxtActionPlan.MaxLength = 1000
        Me.TxtActionPlan.Name = "TxtActionPlan"
        Me.TxtActionPlan.Size = New System.Drawing.Size(186, 20)
        Me.TxtActionPlan.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 15)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Action Plan"
        '
        'TxtDamagedPart
        '
        Me.TxtDamagedPart.Location = New System.Drawing.Point(133, 80)
        Me.TxtDamagedPart.MaxLength = 1000
        Me.TxtDamagedPart.Name = "TxtDamagedPart"
        Me.TxtDamagedPart.Size = New System.Drawing.Size(186, 20)
        Me.TxtDamagedPart.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 15)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Part yang rusak"
        '
        'TxtProbMC
        '
        Me.TxtProbMC.Location = New System.Drawing.Point(102, 31)
        Me.TxtProbMC.MaxLength = 1000
        Me.TxtProbMC.Multiline = True
        Me.TxtProbMC.Name = "TxtProbMC"
        Me.TxtProbMC.Size = New System.Drawing.Size(218, 43)
        Me.TxtProbMC.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 15)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Problem Mesin"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(743, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv.Location = New System.Drawing.Point(0, 410)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(804, 172)
        Me.Dgv.TabIndex = 32
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmCheckingMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 582)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCheckingMachine"
        Me.Text = "FrmCheckingMachine"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TxtIDLead As System.Windows.Forms.TextBox
    Friend WithEvents TxtIDPM As System.Windows.Forms.TextBox
    Friend WithEvents TxtIDOpt As System.Windows.Forms.TextBox
    Friend WithEvents TxtIDMc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtPart As System.Windows.Forms.TextBox
    Friend WithEvents BtnCaripart As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TxtProbMC As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtStatPart As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtPrtNeed As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtActionPlan As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtDamagedPart As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtDuration As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtActSemen As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtObst As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtLosses As System.Windows.Forms.TextBox
    Friend WithEvents Txtkon2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtKon1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtIdPart As System.Windows.Forms.TextBox
    Friend WithEvents Dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnSimpanAll As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
