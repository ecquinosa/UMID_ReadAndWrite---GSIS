<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main2
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main2))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElementName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElementValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecurityLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAuthentication2 = New System.Windows.Forms.Button()
        Me.btnAuthentication1 = New System.Windows.Forms.Button()
        Me.btnSelectApplet = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtFingerStatus = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pbRB = New System.Windows.Forms.PictureBox()
        Me.pbRP = New System.Windows.Forms.PictureBox()
        Me.pbLB = New System.Windows.Forms.PictureBox()
        Me.pbLP = New System.Windows.Forms.PictureBox()
        Me.btnRewrite = New System.Windows.Forms.Button()
        Me.txtMachineName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.rtb = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtQualityThreshold = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnResetFingerprints = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtLPQuality = New System.Windows.Forms.TextBox()
        Me.txtLPStatus = New System.Windows.Forms.TextBox()
        Me.txtLBStatus = New System.Windows.Forms.TextBox()
        Me.txtLBQuality = New System.Windows.Forms.TextBox()
        Me.txtRPStatus = New System.Windows.Forms.TextBox()
        Me.txtRPQuality = New System.Windows.Forms.TextBox()
        Me.txtRBStatus = New System.Windows.Forms.TextBox()
        Me.txtRBQuality = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.pbRB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(4, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(895, 843)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnReset)
        Me.TabPage1.Controls.Add(Me.btnRead)
        Me.TabPage1.Controls.Add(Me.grid)
        Me.TabPage1.Controls.Add(Me.btnAuthentication2)
        Me.TabPage1.Controls.Add(Me.btnAuthentication1)
        Me.TabPage1.Controls.Add(Me.btnSelectApplet)
        Me.TabPage1.ImageIndex = 1
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(887, 800)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "READ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(443, 14)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(432, 57)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(11, 14)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(432, 57)
        Me.btnRead.TabIndex = 7
        Me.btnRead.Text = "READ"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.ElementName, Me.ElementValue, Me.SecurityLevel})
        Me.grid.Location = New System.Drawing.Point(11, 135)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(864, 659)
        Me.grid.TabIndex = 6
        '
        'Code
        '
        Me.Code.DataPropertyName = "Code"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.Code.DefaultCellStyle = DataGridViewCellStyle9
        Me.Code.HeaderText = "CODE"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        Me.Code.Visible = False
        Me.Code.Width = 5
        '
        'ElementName
        '
        Me.ElementName.DataPropertyName = "ElementName"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray
        Me.ElementName.DefaultCellStyle = DataGridViewCellStyle10
        Me.ElementName.HeaderText = "ELEMENT"
        Me.ElementName.Name = "ElementName"
        Me.ElementName.ReadOnly = True
        Me.ElementName.Width = 200
        '
        'ElementValue
        '
        Me.ElementValue.DataPropertyName = "ElementValue"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementValue.DefaultCellStyle = DataGridViewCellStyle11
        Me.ElementValue.HeaderText = "VALUE"
        Me.ElementValue.Name = "ElementValue"
        Me.ElementValue.ReadOnly = True
        Me.ElementValue.Width = 400
        '
        'SecurityLevel
        '
        Me.SecurityLevel.DataPropertyName = "SecurityLevel"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SecurityLevel.DefaultCellStyle = DataGridViewCellStyle12
        Me.SecurityLevel.HeaderText = "SECURITY LEVEL"
        Me.SecurityLevel.Name = "SecurityLevel"
        Me.SecurityLevel.ReadOnly = True
        '
        'btnAuthentication2
        '
        Me.btnAuthentication2.Location = New System.Drawing.Point(587, 72)
        Me.btnAuthentication2.Name = "btnAuthentication2"
        Me.btnAuthentication2.Size = New System.Drawing.Size(288, 57)
        Me.btnAuthentication2.TabIndex = 4
        Me.btnAuthentication2.Text = "AUTHENTICATION LV2"
        Me.btnAuthentication2.UseVisualStyleBackColor = True
        '
        'btnAuthentication1
        '
        Me.btnAuthentication1.Location = New System.Drawing.Point(299, 72)
        Me.btnAuthentication1.Name = "btnAuthentication1"
        Me.btnAuthentication1.Size = New System.Drawing.Size(288, 57)
        Me.btnAuthentication1.TabIndex = 3
        Me.btnAuthentication1.Text = "AUTHENTICATION LV1"
        Me.btnAuthentication1.UseVisualStyleBackColor = True
        '
        'btnSelectApplet
        '
        Me.btnSelectApplet.Location = New System.Drawing.Point(11, 72)
        Me.btnSelectApplet.Name = "btnSelectApplet"
        Me.btnSelectApplet.Size = New System.Drawing.Size(288, 57)
        Me.btnSelectApplet.TabIndex = 2
        Me.btnSelectApplet.Text = "SELECT APPLET"
        Me.btnSelectApplet.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.txtRBStatus)
        Me.TabPage2.Controls.Add(Me.txtRBQuality)
        Me.TabPage2.Controls.Add(Me.txtRPStatus)
        Me.TabPage2.Controls.Add(Me.txtRPQuality)
        Me.TabPage2.Controls.Add(Me.txtLBStatus)
        Me.TabPage2.Controls.Add(Me.txtLBQuality)
        Me.TabPage2.Controls.Add(Me.txtLPStatus)
        Me.TabPage2.Controls.Add(Me.txtLPQuality)
        Me.TabPage2.Controls.Add(Me.btnResetFingerprints)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtQualityThreshold)
        Me.TabPage2.Controls.Add(Me.txtFingerStatus)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.pbRB)
        Me.TabPage2.Controls.Add(Me.pbRP)
        Me.TabPage2.Controls.Add(Me.pbLB)
        Me.TabPage2.Controls.Add(Me.pbLP)
        Me.TabPage2.Controls.Add(Me.btnRewrite)
        Me.TabPage2.Controls.Add(Me.txtMachineName)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtUserID)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.ImageIndex = 0
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(887, 800)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "WRITE"
        '
        'txtFingerStatus
        '
        Me.txtFingerStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFingerStatus.Enabled = False
        Me.txtFingerStatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFingerStatus.Location = New System.Drawing.Point(21, 505)
        Me.txtFingerStatus.Name = "txtFingerStatus"
        Me.txtFingerStatus.Size = New System.Drawing.Size(848, 19)
        Me.txtFingerStatus.TabIndex = 10
        Me.txtFingerStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 616)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(420, 57)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "CAPTURE FINGERPRINTS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pbRB
        '
        Me.pbRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbRB.Location = New System.Drawing.Point(676, 218)
        Me.pbRB.Name = "pbRB"
        Me.pbRB.Size = New System.Drawing.Size(191, 267)
        Me.pbRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRB.TabIndex = 8
        Me.pbRB.TabStop = False
        '
        'pbRP
        '
        Me.pbRP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbRP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbRP.Location = New System.Drawing.Point(458, 218)
        Me.pbRP.Name = "pbRP"
        Me.pbRP.Size = New System.Drawing.Size(191, 267)
        Me.pbRP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRP.TabIndex = 7
        Me.pbRP.TabStop = False
        '
        'pbLB
        '
        Me.pbLB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbLB.Location = New System.Drawing.Point(240, 218)
        Me.pbLB.Name = "pbLB"
        Me.pbLB.Size = New System.Drawing.Size(191, 267)
        Me.pbLB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLB.TabIndex = 6
        Me.pbLB.TabStop = False
        '
        'pbLP
        '
        Me.pbLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbLP.Location = New System.Drawing.Point(21, 218)
        Me.pbLP.Name = "pbLP"
        Me.pbLP.Size = New System.Drawing.Size(191, 267)
        Me.pbLP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLP.TabIndex = 5
        Me.pbLP.TabStop = False
        '
        'btnRewrite
        '
        Me.btnRewrite.Location = New System.Drawing.Point(21, 697)
        Me.btnRewrite.Name = "btnRewrite"
        Me.btnRewrite.Size = New System.Drawing.Size(288, 57)
        Me.btnRewrite.TabIndex = 4
        Me.btnRewrite.Text = "REWRITE FINGERPRINTS"
        Me.btnRewrite.UseVisualStyleBackColor = True
        '
        'txtMachineName
        '
        Me.txtMachineName.Enabled = False
        Me.txtMachineName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMachineName.Location = New System.Drawing.Point(336, 81)
        Me.txtMachineName.Name = "txtMachineName"
        Me.txtMachineName.Size = New System.Drawing.Size(375, 26)
        Me.txtMachineName.TabIndex = 3
        Me.txtMachineName.Text = "10001"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MACHINE NAME"
        '
        'txtUserID
        '
        Me.txtUserID.Enabled = False
        Me.txtUserID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(336, 49)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(375, 26)
        Me.txtUserID.TabIndex = 1
        Me.txtUserID.Text = "user10001"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER ID"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.rtb)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(887, 816)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "LOG"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'rtb
        '
        Me.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb.Location = New System.Drawing.Point(0, 0)
        Me.rtb.Name = "rtb"
        Me.rtb.Size = New System.Drawing.Size(887, 816)
        Me.rtb.TabIndex = 0
        Me.rtb.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 27)
        Me.Panel1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 882)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(902, 31)
        Me.TextBox1.TabIndex = 4
        '
        'txtQualityThreshold
        '
        Me.txtQualityThreshold.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQualityThreshold.Location = New System.Drawing.Point(201, 156)
        Me.txtQualityThreshold.Name = "txtQualityThreshold"
        Me.txtQualityThreshold.Size = New System.Drawing.Size(56, 26)
        Me.txtQualityThreshold.TabIndex = 12
        Me.txtQualityThreshold.Text = "80"
        Me.txtQualityThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "QUALITY THRESHOLD"
        '
        'btnResetFingerprints
        '
        Me.btnResetFingerprints.Location = New System.Drawing.Point(447, 616)
        Me.btnResetFingerprints.Name = "btnResetFingerprints"
        Me.btnResetFingerprints.Size = New System.Drawing.Size(420, 57)
        Me.btnResetFingerprints.TabIndex = 14
        Me.btnResetFingerprints.Text = "RESET"
        Me.btnResetFingerprints.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Device%20and%20Hardware3.png")
        Me.ImageList1.Images.SetKeyName(1, "Device%20and%20Hardware5.png")
        '
        'txtLPQuality
        '
        Me.txtLPQuality.BackColor = System.Drawing.Color.White
        Me.txtLPQuality.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLPQuality.Enabled = False
        Me.txtLPQuality.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLPQuality.Location = New System.Drawing.Point(21, 193)
        Me.txtLPQuality.Name = "txtLPQuality"
        Me.txtLPQuality.Size = New System.Drawing.Size(80, 16)
        Me.txtLPQuality.TabIndex = 15
        '
        'txtLPStatus
        '
        Me.txtLPStatus.BackColor = System.Drawing.Color.White
        Me.txtLPStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLPStatus.Enabled = False
        Me.txtLPStatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLPStatus.Location = New System.Drawing.Point(116, 193)
        Me.txtLPStatus.Name = "txtLPStatus"
        Me.txtLPStatus.Size = New System.Drawing.Size(96, 16)
        Me.txtLPStatus.TabIndex = 16
        Me.txtLPStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLBStatus
        '
        Me.txtLBStatus.BackColor = System.Drawing.Color.White
        Me.txtLBStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLBStatus.Enabled = False
        Me.txtLBStatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLBStatus.Location = New System.Drawing.Point(335, 193)
        Me.txtLBStatus.Name = "txtLBStatus"
        Me.txtLBStatus.Size = New System.Drawing.Size(96, 16)
        Me.txtLBStatus.TabIndex = 18
        Me.txtLBStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLBQuality
        '
        Me.txtLBQuality.BackColor = System.Drawing.Color.White
        Me.txtLBQuality.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLBQuality.Enabled = False
        Me.txtLBQuality.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLBQuality.Location = New System.Drawing.Point(240, 193)
        Me.txtLBQuality.Name = "txtLBQuality"
        Me.txtLBQuality.Size = New System.Drawing.Size(80, 16)
        Me.txtLBQuality.TabIndex = 17
        '
        'txtRPStatus
        '
        Me.txtRPStatus.BackColor = System.Drawing.Color.White
        Me.txtRPStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRPStatus.Enabled = False
        Me.txtRPStatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPStatus.Location = New System.Drawing.Point(553, 193)
        Me.txtRPStatus.Name = "txtRPStatus"
        Me.txtRPStatus.Size = New System.Drawing.Size(96, 16)
        Me.txtRPStatus.TabIndex = 20
        Me.txtRPStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRPQuality
        '
        Me.txtRPQuality.BackColor = System.Drawing.Color.White
        Me.txtRPQuality.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRPQuality.Enabled = False
        Me.txtRPQuality.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPQuality.Location = New System.Drawing.Point(458, 193)
        Me.txtRPQuality.Name = "txtRPQuality"
        Me.txtRPQuality.Size = New System.Drawing.Size(80, 16)
        Me.txtRPQuality.TabIndex = 19
        '
        'txtRBStatus
        '
        Me.txtRBStatus.BackColor = System.Drawing.Color.White
        Me.txtRBStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRBStatus.Enabled = False
        Me.txtRBStatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRBStatus.Location = New System.Drawing.Point(771, 193)
        Me.txtRBStatus.Name = "txtRBStatus"
        Me.txtRBStatus.Size = New System.Drawing.Size(96, 16)
        Me.txtRBStatus.TabIndex = 22
        Me.txtRBStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRBQuality
        '
        Me.txtRBQuality.BackColor = System.Drawing.Color.White
        Me.txtRBQuality.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRBQuality.Enabled = False
        Me.txtRBQuality.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRBQuality.Location = New System.Drawing.Point(676, 193)
        Me.txtRBQuality.Name = "txtRBQuality"
        Me.txtRBQuality.Size = New System.Drawing.Size(80, 16)
        Me.txtRBQuality.TabIndex = 21
        '
        'Main2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(902, 913)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Main2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UMID DLL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pbRB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnAuthentication2 As Button
    Friend WithEvents btnAuthentication1 As Button
    Friend WithEvents btnSelectApplet As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents grid As DataGridView
    Friend WithEvents btnRead As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbRB As PictureBox
    Friend WithEvents pbRP As PictureBox
    Friend WithEvents pbLB As PictureBox
    Friend WithEvents pbLP As PictureBox
    Friend WithEvents btnRewrite As Button
    Friend WithEvents txtMachineName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rtb As RichTextBox
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents ElementName As DataGridViewTextBoxColumn
    Friend WithEvents ElementValue As DataGridViewTextBoxColumn
    Friend WithEvents SecurityLevel As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFingerStatus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQualityThreshold As TextBox
    Friend WithEvents btnResetFingerprints As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txtLPQuality As TextBox
    Friend WithEvents txtLPStatus As TextBox
    Friend WithEvents txtRBStatus As TextBox
    Friend WithEvents txtRBQuality As TextBox
    Friend WithEvents txtRPStatus As TextBox
    Friend WithEvents txtRPQuality As TextBox
    Friend WithEvents txtLBStatus As TextBox
    Friend WithEvents txtLBQuality As TextBox
End Class
