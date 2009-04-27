<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmHydrology
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdSave As System.Windows.Forms.Button
    Public WithEvents InitialSoilMoistureConstant As System.Windows.Forms.TextBox
    Public WithEvents cboInitial_Soil_Moisture As System.Windows.Forms.ComboBox
    Public WithEvents PictureA5dCNCurve As System.Windows.Forms.PictureBox
    Public WithEvents bCNNonGrow As System.Windows.Forms.TextBox
    Public WithEvents aCNNonGrow As System.Windows.Forms.TextBox
    Public WithEvents aCNGrow As System.Windows.Forms.TextBox
    Public WithEvents bCNGrow As System.Windows.Forms.TextBox
    Public WithEvents optFieldCapacity As System.Windows.Forms.RadioButton
    Public WithEvents optConstSoilMoisture As System.Windows.Forms.RadioButton
    Public WithEvents InitialAccuSnowConstant As System.Windows.Forms.TextBox
    Public WithEvents HydroP2Rainfall As System.Windows.Forms.TextBox
    Public WithEvents P2Map As System.Windows.Forms.Button
    Public WithEvents optInputSoilMoisture As System.Windows.Forms.RadioButton
    Public WithEvents btnInitial_Soil_Moisture As System.Windows.Forms.Button
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents Label63 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label62 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label65 As System.Windows.Forms.Label
    Public WithEvents Label101 As System.Windows.Forms.Label
    Public WithEvents framehydro As System.Windows.Forms.GroupBox
    Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents InitialShallowGWConstant As System.Windows.Forms.TextBox
    Public WithEvents HydroGWSeepageCoeff As System.Windows.Forms.TextBox
    Public WithEvents HydroGWRecessionCoeff As System.Windows.Forms.TextBox
    Public WithEvents Label107 As System.Windows.Forms.Label
    Public WithEvents fraGroundWater As System.Windows.Forms.GroupBox
    Public WithEvents HgLandUnsaturatedSoilDepth As System.Windows.Forms.TextBox
    Public WithEvents HgLandBedrockDepth As System.Windows.Forms.TextBox
    Public WithEvents Label111 As System.Windows.Forms.Label
    Public WithEvents Label64 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents HydroManningCoeff As System.Windows.Forms.TextBox
    Public WithEvents listRegions As System.Windows.Forms.ComboBox
    Public WithEvents AlphaDepth As System.Windows.Forms.TextBox
    Public WithEvents BetaDepth As System.Windows.Forms.TextBox
    Public WithEvents AlphaWidth As System.Windows.Forms.TextBox
    Public WithEvents BetaWidth As System.Windows.Forms.TextBox
    Public WithEvents CrossSectionSlope1 As System.Windows.Forms.TextBox
    Public WithEvents CrossSectionSlope2 As System.Windows.Forms.TextBox
    Public WithEvents PictureChannel As System.Windows.Forms.PictureBox
    Public WithEvents Label102 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Label66 As System.Windows.Forms.Label
    Public WithEvents Label67 As System.Windows.Forms.Label
    Public WithEvents FrameStreamParam As System.Windows.Forms.GroupBox
    Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents HydroOrificeDepth As System.Windows.Forms.TextBox
    Public WithEvents HydroHydraulicCond As System.Windows.Forms.TextBox
    Public WithEvents BankFullDepth As System.Windows.Forms.TextBox
    Public WithEvents InitWaterDepth As System.Windows.Forms.TextBox
    Public WithEvents LakesThreshold As System.Windows.Forms.TextBox
    Public WithEvents HydroOrificeDia As System.Windows.Forms.TextBox
    Public WithEvents HydroOrificeDischargeCoeff As System.Windows.Forms.TextBox
    Public WithEvents HydroWeirCrestLength As System.Windows.Forms.TextBox
    Public WithEvents HydroWeirDischargeCoeff As System.Windows.Forms.TextBox
    Public WithEvents HydroEvapoCoeff As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents Label31 As System.Windows.Forms.Label
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents LakeAttributes As System.Windows.Forms.GroupBox
    Public WithEvents _SSTab1_TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents SSTab1 As System.Windows.Forms.TabControl
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHydrology))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.SSTab1 = New System.Windows.Forms.TabControl
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage
        Me.framehydro = New System.Windows.Forms.GroupBox
        Me.InitialSoilMoistureConstant = New System.Windows.Forms.TextBox
        Me.cboInitial_Soil_Moisture = New System.Windows.Forms.ComboBox
        Me.PictureA5dCNCurve = New System.Windows.Forms.PictureBox
        Me.bCNNonGrow = New System.Windows.Forms.TextBox
        Me.aCNNonGrow = New System.Windows.Forms.TextBox
        Me.aCNGrow = New System.Windows.Forms.TextBox
        Me.bCNGrow = New System.Windows.Forms.TextBox
        Me.optFieldCapacity = New System.Windows.Forms.RadioButton
        Me.optConstSoilMoisture = New System.Windows.Forms.RadioButton
        Me.InitialAccuSnowConstant = New System.Windows.Forms.TextBox
        Me.HydroP2Rainfall = New System.Windows.Forms.TextBox
        Me.P2Map = New System.Windows.Forms.Button
        Me.optInputSoilMoisture = New System.Windows.Forms.RadioButton
        Me.btnInitial_Soil_Moisture = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label101 = New System.Windows.Forms.Label
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.fraGroundWater = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.InitialShallowGWConstant = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.HydroGWSeepageCoeff = New System.Windows.Forms.TextBox
        Me.HydroGWRecessionCoeff = New System.Windows.Forms.TextBox
        Me.Label107 = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.HgLandUnsaturatedSoilDepth = New System.Windows.Forms.TextBox
        Me.HgLandBedrockDepth = New System.Windows.Forms.TextBox
        Me.Label111 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage
        Me.FrameStreamParam = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.HydroManningCoeff = New System.Windows.Forms.TextBox
        Me.listRegions = New System.Windows.Forms.ComboBox
        Me.AlphaDepth = New System.Windows.Forms.TextBox
        Me.BetaDepth = New System.Windows.Forms.TextBox
        Me.AlphaWidth = New System.Windows.Forms.TextBox
        Me.BetaWidth = New System.Windows.Forms.TextBox
        Me.CrossSectionSlope1 = New System.Windows.Forms.TextBox
        Me.CrossSectionSlope2 = New System.Windows.Forms.TextBox
        Me.PictureChannel = New System.Windows.Forms.PictureBox
        Me.Label102 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me._SSTab1_TabPage3 = New System.Windows.Forms.TabPage
        Me.LakeAttributes = New System.Windows.Forms.GroupBox
        Me.HydroOrificeDepth = New System.Windows.Forms.TextBox
        Me.HydroHydraulicCond = New System.Windows.Forms.TextBox
        Me.BankFullDepth = New System.Windows.Forms.TextBox
        Me.InitWaterDepth = New System.Windows.Forms.TextBox
        Me.LakesThreshold = New System.Windows.Forms.TextBox
        Me.HydroOrificeDia = New System.Windows.Forms.TextBox
        Me.HydroOrificeDischargeCoeff = New System.Windows.Forms.TextBox
        Me.HydroWeirCrestLength = New System.Windows.Forms.TextBox
        Me.HydroWeirDischargeCoeff = New System.Windows.Forms.TextBox
        Me.HydroEvapoCoeff = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me.framehydro.SuspendLayout()
        CType(Me.PictureA5dCNCurve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage1.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraGroundWater.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me._SSTab1_TabPage2.SuspendLayout()
        Me.FrameStreamParam.SuspendLayout()
        CType(Me.PictureChannel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage3.SuspendLayout()
        Me.LakeAttributes.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(589, 407)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(54, 24)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(529, 407)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.Size = New System.Drawing.Size(54, 24)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'SSTab1
        '
        Me.SSTab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage2)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage3)
        Me.SSTab1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 19)
        Me.SSTab1.Location = New System.Drawing.Point(12, 12)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Size = New System.Drawing.Size(625, 385)
        Me.SSTab1.TabIndex = 0
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.framehydro)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 23)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(617, 358)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Overland"
        '
        'framehydro
        '
        Me.framehydro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.framehydro.BackColor = System.Drawing.SystemColors.Control
        Me.framehydro.Controls.Add(Me.InitialSoilMoistureConstant)
        Me.framehydro.Controls.Add(Me.cboInitial_Soil_Moisture)
        Me.framehydro.Controls.Add(Me.PictureA5dCNCurve)
        Me.framehydro.Controls.Add(Me.bCNNonGrow)
        Me.framehydro.Controls.Add(Me.aCNNonGrow)
        Me.framehydro.Controls.Add(Me.aCNGrow)
        Me.framehydro.Controls.Add(Me.bCNGrow)
        Me.framehydro.Controls.Add(Me.optFieldCapacity)
        Me.framehydro.Controls.Add(Me.optConstSoilMoisture)
        Me.framehydro.Controls.Add(Me.InitialAccuSnowConstant)
        Me.framehydro.Controls.Add(Me.HydroP2Rainfall)
        Me.framehydro.Controls.Add(Me.P2Map)
        Me.framehydro.Controls.Add(Me.optInputSoilMoisture)
        Me.framehydro.Controls.Add(Me.btnInitial_Soil_Moisture)
        Me.framehydro.Controls.Add(Me.Label8)
        Me.framehydro.Controls.Add(Me.Label7)
        Me.framehydro.Controls.Add(Me.Label27)
        Me.framehydro.Controls.Add(Me.Label63)
        Me.framehydro.Controls.Add(Me.Label25)
        Me.framehydro.Controls.Add(Me.Label62)
        Me.framehydro.Controls.Add(Me.Label2)
        Me.framehydro.Controls.Add(Me.Label1)
        Me.framehydro.Controls.Add(Me.Label65)
        Me.framehydro.Controls.Add(Me.Label101)
        Me.framehydro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.framehydro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.framehydro.Location = New System.Drawing.Point(58, 10)
        Me.framehydro.Name = "framehydro"
        Me.framehydro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.framehydro.Size = New System.Drawing.Size(505, 332)
        Me.framehydro.TabIndex = 0
        Me.framehydro.TabStop = False
        Me.framehydro.Text = "Define Constants for Hydrology"
        '
        'InitialSoilMoistureConstant
        '
        Me.InitialSoilMoistureConstant.AcceptsReturn = True
        Me.InitialSoilMoistureConstant.BackColor = System.Drawing.SystemColors.Window
        Me.InitialSoilMoistureConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.InitialSoilMoistureConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitialSoilMoistureConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.InitialSoilMoistureConstant.Location = New System.Drawing.Point(248, 32)
        Me.InitialSoilMoistureConstant.MaxLength = 0
        Me.InitialSoilMoistureConstant.Name = "InitialSoilMoistureConstant"
        Me.InitialSoilMoistureConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InitialSoilMoistureConstant.Size = New System.Drawing.Size(44, 20)
        Me.InitialSoilMoistureConstant.TabIndex = 2
        Me.InitialSoilMoistureConstant.Text = "30.0"
        '
        'cboInitial_Soil_Moisture
        '
        Me.cboInitial_Soil_Moisture.BackColor = System.Drawing.SystemColors.Window
        Me.cboInitial_Soil_Moisture.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboInitial_Soil_Moisture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInitial_Soil_Moisture.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInitial_Soil_Moisture.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboInitial_Soil_Moisture.Location = New System.Drawing.Point(248, 56)
        Me.cboInitial_Soil_Moisture.Name = "cboInitial_Soil_Moisture"
        Me.cboInitial_Soil_Moisture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboInitial_Soil_Moisture.Size = New System.Drawing.Size(210, 22)
        Me.cboInitial_Soil_Moisture.TabIndex = 4
        Me.cboInitial_Soil_Moisture.Tag = "Raster"
        '
        'PictureA5dCNCurve
        '
        Me.PictureA5dCNCurve.BackColor = System.Drawing.SystemColors.Control
        Me.PictureA5dCNCurve.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureA5dCNCurve.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureA5dCNCurve.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PictureA5dCNCurve.Image = CType(resources.GetObject("PictureA5dCNCurve.Image"), System.Drawing.Image)
        Me.PictureA5dCNCurve.Location = New System.Drawing.Point(312, 112)
        Me.PictureA5dCNCurve.Name = "PictureA5dCNCurve"
        Me.PictureA5dCNCurve.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PictureA5dCNCurve.Size = New System.Drawing.Size(182, 130)
        Me.PictureA5dCNCurve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureA5dCNCurve.TabIndex = 62
        Me.PictureA5dCNCurve.TabStop = False
        '
        'bCNNonGrow
        '
        Me.bCNNonGrow.AcceptsReturn = True
        Me.bCNNonGrow.BackColor = System.Drawing.SystemColors.Window
        Me.bCNNonGrow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bCNNonGrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCNNonGrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bCNNonGrow.Location = New System.Drawing.Point(248, 264)
        Me.bCNNonGrow.MaxLength = 0
        Me.bCNNonGrow.Name = "bCNNonGrow"
        Me.bCNNonGrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bCNNonGrow.Size = New System.Drawing.Size(44, 20)
        Me.bCNNonGrow.TabIndex = 19
        Me.bCNNonGrow.Text = "2.8"
        '
        'aCNNonGrow
        '
        Me.aCNNonGrow.AcceptsReturn = True
        Me.aCNNonGrow.BackColor = System.Drawing.SystemColors.Window
        Me.aCNNonGrow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.aCNNonGrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aCNNonGrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.aCNNonGrow.Location = New System.Drawing.Point(248, 236)
        Me.aCNNonGrow.MaxLength = 0
        Me.aCNNonGrow.Name = "aCNNonGrow"
        Me.aCNNonGrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.aCNNonGrow.Size = New System.Drawing.Size(44, 20)
        Me.aCNNonGrow.TabIndex = 16
        Me.aCNNonGrow.Text = "1.3"
        '
        'aCNGrow
        '
        Me.aCNGrow.AcceptsReturn = True
        Me.aCNGrow.BackColor = System.Drawing.SystemColors.Window
        Me.aCNGrow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.aCNGrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aCNGrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.aCNGrow.Location = New System.Drawing.Point(248, 172)
        Me.aCNGrow.MaxLength = 0
        Me.aCNGrow.Name = "aCNGrow"
        Me.aCNGrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.aCNGrow.Size = New System.Drawing.Size(44, 20)
        Me.aCNGrow.TabIndex = 12
        Me.aCNGrow.Text = "3.6"
        '
        'bCNGrow
        '
        Me.bCNGrow.AcceptsReturn = True
        Me.bCNGrow.BackColor = System.Drawing.SystemColors.Window
        Me.bCNGrow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bCNGrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCNGrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bCNGrow.Location = New System.Drawing.Point(248, 200)
        Me.bCNGrow.MaxLength = 0
        Me.bCNGrow.Name = "bCNGrow"
        Me.bCNGrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bCNGrow.Size = New System.Drawing.Size(44, 20)
        Me.bCNGrow.TabIndex = 14
        Me.bCNGrow.Text = "5.3"
        '
        'optFieldCapacity
        '
        Me.optFieldCapacity.AutoSize = True
        Me.optFieldCapacity.BackColor = System.Drawing.SystemColors.Control
        Me.optFieldCapacity.Checked = True
        Me.optFieldCapacity.Cursor = System.Windows.Forms.Cursors.Default
        Me.optFieldCapacity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFieldCapacity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optFieldCapacity.Location = New System.Drawing.Point(48, 80)
        Me.optFieldCapacity.Name = "optFieldCapacity"
        Me.optFieldCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optFieldCapacity.Size = New System.Drawing.Size(128, 18)
        Me.optFieldCapacity.TabIndex = 6
        Me.optFieldCapacity.TabStop = True
        Me.optFieldCapacity.Text = "Field Capacity (cm/m)"
        Me.optFieldCapacity.UseVisualStyleBackColor = False
        '
        'optConstSoilMoisture
        '
        Me.optConstSoilMoisture.AutoSize = True
        Me.optConstSoilMoisture.BackColor = System.Drawing.SystemColors.Control
        Me.optConstSoilMoisture.Cursor = System.Windows.Forms.Cursors.Default
        Me.optConstSoilMoisture.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optConstSoilMoisture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optConstSoilMoisture.Location = New System.Drawing.Point(48, 32)
        Me.optConstSoilMoisture.Name = "optConstSoilMoisture"
        Me.optConstSoilMoisture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optConstSoilMoisture.Size = New System.Drawing.Size(138, 18)
        Me.optConstSoilMoisture.TabIndex = 1
        Me.optConstSoilMoisture.TabStop = True
        Me.optConstSoilMoisture.Text = "Constant Value (cm/m):"
        Me.optConstSoilMoisture.UseVisualStyleBackColor = False
        '
        'InitialAccuSnowConstant
        '
        Me.InitialAccuSnowConstant.AcceptsReturn = True
        Me.InitialAccuSnowConstant.BackColor = System.Drawing.SystemColors.Window
        Me.InitialAccuSnowConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.InitialAccuSnowConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitialAccuSnowConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.InitialAccuSnowConstant.Location = New System.Drawing.Point(248, 112)
        Me.InitialAccuSnowConstant.MaxLength = 0
        Me.InitialAccuSnowConstant.Name = "InitialAccuSnowConstant"
        Me.InitialAccuSnowConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InitialAccuSnowConstant.Size = New System.Drawing.Size(39, 20)
        Me.InitialAccuSnowConstant.TabIndex = 8
        Me.InitialAccuSnowConstant.Text = "0"
        '
        'HydroP2Rainfall
        '
        Me.HydroP2Rainfall.AcceptsReturn = True
        Me.HydroP2Rainfall.BackColor = System.Drawing.SystemColors.Window
        Me.HydroP2Rainfall.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HydroP2Rainfall.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HydroP2Rainfall.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HydroP2Rainfall.Location = New System.Drawing.Point(248, 296)
        Me.HydroP2Rainfall.MaxLength = 0
        Me.HydroP2Rainfall.Name = "HydroP2Rainfall"
        Me.HydroP2Rainfall.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HydroP2Rainfall.Size = New System.Drawing.Size(44, 20)
        Me.HydroP2Rainfall.TabIndex = 21
        Me.HydroP2Rainfall.Text = "10"
        '
        'P2Map
        '
        Me.P2Map.BackColor = System.Drawing.SystemColors.Control
        Me.P2Map.Cursor = System.Windows.Forms.Cursors.Default
        Me.P2Map.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2Map.ForeColor = System.Drawing.SystemColors.ControlText
        Me.P2Map.Location = New System.Drawing.Point(312, 294)
        Me.P2Map.Name = "P2Map"
        Me.P2Map.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.P2Map.Size = New System.Drawing.Size(65, 25)
        Me.P2Map.TabIndex = 22
        Me.P2Map.Text = "P2 Map ..."
        Me.P2Map.UseVisualStyleBackColor = False
        '
        'optInputSoilMoisture
        '
        Me.optInputSoilMoisture.AutoSize = True
        Me.optInputSoilMoisture.BackColor = System.Drawing.SystemColors.Control
        Me.optInputSoilMoisture.Cursor = System.Windows.Forms.Cursors.Default
        Me.optInputSoilMoisture.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optInputSoilMoisture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optInputSoilMoisture.Location = New System.Drawing.Point(48, 56)
        Me.optInputSoilMoisture.Name = "optInputSoilMoisture"
        Me.optInputSoilMoisture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optInputSoilMoisture.Size = New System.Drawing.Size(107, 18)
        Me.optInputSoilMoisture.TabIndex = 3
        Me.optInputSoilMoisture.TabStop = True
        Me.optInputSoilMoisture.Text = "Input Grid (cm/m)"
        Me.optInputSoilMoisture.UseVisualStyleBackColor = False
        '
        'btnInitial_Soil_Moisture
        '
        Me.btnInitial_Soil_Moisture.AutoSize = True
        Me.btnInitial_Soil_Moisture.BackColor = System.Drawing.SystemColors.Control
        Me.btnInitial_Soil_Moisture.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnInitial_Soil_Moisture.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInitial_Soil_Moisture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInitial_Soil_Moisture.Image = Global.atcGBMM.My.Resources.Resources.openHS
        Me.btnInitial_Soil_Moisture.Location = New System.Drawing.Point(464, 54)
        Me.btnInitial_Soil_Moisture.Name = "btnInitial_Soil_Moisture"
        Me.btnInitial_Soil_Moisture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnInitial_Soil_Moisture.Size = New System.Drawing.Size(30, 24)
        Me.btnInitial_Soil_Moisture.TabIndex = 5
        Me.btnInitial_Soil_Moisture.Tag = "Raster"
        Me.btnInitial_Soil_Moisture.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInitial_Soil_Moisture.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(180, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(41, 14)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "a (cm):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(180, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(41, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "a (cm):"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(180, 203)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(41, 14)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "b (cm):"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.SystemColors.Control
        Me.Label63.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label63.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label63.Location = New System.Drawing.Point(180, 267)
        Me.Label63.Name = "Label63"
        Me.Label63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label63.Size = New System.Drawing.Size(41, 14)
        Me.Label63.TabIndex = 18
        Me.Label63.Text = "b (cm):"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(42, 175)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(114, 14)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "For Growing Season: "
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.SystemColors.Control
        Me.Label62.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label62.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label62.Location = New System.Drawing.Point(42, 239)
        Me.Label62.Name = "Label62"
        Me.Label62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label62.Size = New System.Drawing.Size(134, 14)
        Me.Label62.TabIndex = 15
        Me.Label62.Text = "For Non-Growing Season:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(195, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Define Break Points for CN Modification"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(134, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial Soil Moisture Content"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.SystemColors.Control
        Me.Label65.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label65.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label65.Location = New System.Drawing.Point(24, 114)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label65.Size = New System.Drawing.Size(201, 14)
        Me.Label65.TabIndex = 7
        Me.Label65.Text = "Initial Accumulated Snow (cm of water):"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.BackColor = System.Drawing.SystemColors.Control
        Me.Label101.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label101.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label101.Location = New System.Drawing.Point(24, 299)
        Me.Label101.Name = "Label101"
        Me.Label101.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label101.Size = New System.Drawing.Size(166, 14)
        Me.Label101.TabIndex = 20
        Me.Label101.Text = "P2, 2 Year-24 Hour Rainfall (cm):"
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.Image1)
        Me._SSTab1_TabPage1.Controls.Add(Me.fraGroundWater)
        Me._SSTab1_TabPage1.Controls.Add(Me.Frame1)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 23)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(617, 358)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Groundwater"
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(328, 56)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(289, 252)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 0
        Me.Image1.TabStop = False
        '
        'fraGroundWater
        '
        Me.fraGroundWater.BackColor = System.Drawing.SystemColors.Control
        Me.fraGroundWater.Controls.Add(Me.Label10)
        Me.fraGroundWater.Controls.Add(Me.InitialShallowGWConstant)
        Me.fraGroundWater.Controls.Add(Me.Label9)
        Me.fraGroundWater.Controls.Add(Me.HydroGWSeepageCoeff)
        Me.fraGroundWater.Controls.Add(Me.HydroGWRecessionCoeff)
        Me.fraGroundWater.Controls.Add(Me.Label107)
        Me.fraGroundWater.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraGroundWater.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraGroundWater.Location = New System.Drawing.Point(8, 56)
        Me.fraGroundWater.Name = "fraGroundWater"
        Me.fraGroundWater.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraGroundWater.Size = New System.Drawing.Size(313, 105)
        Me.fraGroundWater.TabIndex = 0
        Me.fraGroundWater.TabStop = False
        Me.fraGroundWater.Text = "Groundwater Parameters"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(244, 14)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Ground Water Seepage Coefficient, Sr (per day):"
        '
        'InitialShallowGWConstant
        '
        Me.InitialShallowGWConstant.AcceptsReturn = True
        Me.InitialShallowGWConstant.BackColor = System.Drawing.SystemColors.Window
        Me.InitialShallowGWConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.InitialShallowGWConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitialShallowGWConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.InitialShallowGWConstant.Location = New System.Drawing.Point(270, 24)
        Me.InitialShallowGWConstant.MaxLength = 0
        Me.InitialShallowGWConstant.Name = "InitialShallowGWConstant"
        Me.InitialShallowGWConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InitialShallowGWConstant.Size = New System.Drawing.Size(34, 20)
        Me.InitialShallowGWConstant.TabIndex = 1
        Me.InitialShallowGWConstant.Text = "30"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(253, 14)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Ground Water Recession Coefficient, Gr (per day):"
        '
        'HydroGWSeepageCoeff
        '
        Me.HydroGWSeepageCoeff.AcceptsReturn = True
        Me.HydroGWSeepageCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.HydroGWSeepageCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HydroGWSeepageCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HydroGWSeepageCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HydroGWSeepageCoeff.Location = New System.Drawing.Point(270, 72)
        Me.HydroGWSeepageCoeff.MaxLength = 0
        Me.HydroGWSeepageCoeff.Name = "HydroGWSeepageCoeff"
        Me.HydroGWSeepageCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HydroGWSeepageCoeff.Size = New System.Drawing.Size(34, 20)
        Me.HydroGWSeepageCoeff.TabIndex = 3
        Me.HydroGWSeepageCoeff.Text = "0"
        '
        'HydroGWRecessionCoeff
        '
        Me.HydroGWRecessionCoeff.AcceptsReturn = True
        Me.HydroGWRecessionCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.HydroGWRecessionCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HydroGWRecessionCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HydroGWRecessionCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HydroGWRecessionCoeff.Location = New System.Drawing.Point(269, 47)
        Me.HydroGWRecessionCoeff.MaxLength = 0
        Me.HydroGWRecessionCoeff.Name = "HydroGWRecessionCoeff"
        Me.HydroGWRecessionCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HydroGWRecessionCoeff.Size = New System.Drawing.Size(34, 20)
        Me.HydroGWRecessionCoeff.TabIndex = 2
        Me.HydroGWRecessionCoeff.Text = "0.1"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.BackColor = System.Drawing.SystemColors.Control
        Me.Label107.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label107.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label107.Location = New System.Drawing.Point(10, 27)
        Me.Label107.Name = "Label107"
        Me.Label107.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label107.Size = New System.Drawing.Size(185, 14)
        Me.Label107.TabIndex = 0
        Me.Label107.Text = " Initial Shallow Ground Water (cm/m):"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.HgLandUnsaturatedSoilDepth)
        Me.Frame1.Controls.Add(Me.HgLandBedrockDepth)
        Me.Frame1.Controls.Add(Me.Label111)
        Me.Frame1.Controls.Add(Me.Label64)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 192)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(313, 121)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Soil Properties"
        '
        'HgLandUnsaturatedSoilDepth
        '
        Me.HgLandUnsaturatedSoilDepth.AcceptsReturn = True
        Me.HgLandUnsaturatedSoilDepth.BackColor = System.Drawing.SystemColors.Window
        Me.HgLandUnsaturatedSoilDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HgLandUnsaturatedSoilDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HgLandUnsaturatedSoilDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HgLandUnsaturatedSoilDepth.Location = New System.Drawing.Point(269, 32)
        Me.HgLandUnsaturatedSoilDepth.MaxLength = 0
        Me.HgLandUnsaturatedSoilDepth.Name = "HgLandUnsaturatedSoilDepth"
        Me.HgLandUnsaturatedSoilDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HgLandUnsaturatedSoilDepth.Size = New System.Drawing.Size(34, 20)
        Me.HgLandUnsaturatedSoilDepth.TabIndex = 1
        Me.HgLandUnsaturatedSoilDepth.Text = "1"
        '
        'HgLandBedrockDepth
        '
        Me.HgLandBedrockDepth.AcceptsReturn = True
        Me.HgLandBedrockDepth.BackColor = System.Drawing.SystemColors.Window
        Me.HgLandBedrockDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HgLandBedrockDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HgLandBedrockDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HgLandBedrockDepth.Location = New System.Drawing.Point(269, 64)
        Me.HgLandBedrockDepth.MaxLength = 0
        Me.HgLandBedrockDepth.Name = "HgLandBedrockDepth"
        Me.HgLandBedrockDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HgLandBedrockDepth.Size = New System.Drawing.Size(34, 20)
        Me.HgLandBedrockDepth.TabIndex = 3
        Me.HgLandBedrockDepth.Text = "1.5"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.BackColor = System.Drawing.SystemColors.Control
        Me.Label111.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label111.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label111.Location = New System.Drawing.Point(10, 35)
        Me.Label111.Name = "Label111"
        Me.Label111.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label111.Size = New System.Drawing.Size(139, 14)
        Me.Label111.TabIndex = 0
        Me.Label111.Text = "Unsaturated Soil Depth (m):"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.BackColor = System.Drawing.SystemColors.Control
        Me.Label64.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label64.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label64.Location = New System.Drawing.Point(10, 67)
        Me.Label64.Name = "Label64"
        Me.Label64.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label64.Size = New System.Drawing.Size(112, 14)
        Me.Label64.TabIndex = 2
        Me.Label64.Text = "Depth to Bedrock (m):"
        '
        '_SSTab1_TabPage2
        '
        Me._SSTab1_TabPage2.Controls.Add(Me.FrameStreamParam)
        Me._SSTab1_TabPage2.Location = New System.Drawing.Point(4, 23)
        Me._SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        Me._SSTab1_TabPage2.Size = New System.Drawing.Size(617, 358)
        Me._SSTab1_TabPage2.TabIndex = 2
        Me._SSTab1_TabPage2.Text = "Streams"
        '
        'FrameStreamParam
        '
        Me.FrameStreamParam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FrameStreamParam.BackColor = System.Drawing.SystemColors.Control
        Me.FrameStreamParam.Controls.Add(Me.Label14)
        Me.FrameStreamParam.Controls.Add(Me.Label12)
        Me.FrameStreamParam.Controls.Add(Me.Label11)
        Me.FrameStreamParam.Controls.Add(Me.Label13)
        Me.FrameStreamParam.Controls.Add(Me.HydroManningCoeff)
        Me.FrameStreamParam.Controls.Add(Me.listRegions)
        Me.FrameStreamParam.Controls.Add(Me.AlphaDepth)
        Me.FrameStreamParam.Controls.Add(Me.BetaDepth)
        Me.FrameStreamParam.Controls.Add(Me.AlphaWidth)
        Me.FrameStreamParam.Controls.Add(Me.BetaWidth)
        Me.FrameStreamParam.Controls.Add(Me.CrossSectionSlope1)
        Me.FrameStreamParam.Controls.Add(Me.CrossSectionSlope2)
        Me.FrameStreamParam.Controls.Add(Me.PictureChannel)
        Me.FrameStreamParam.Controls.Add(Me.Label102)
        Me.FrameStreamParam.Controls.Add(Me.Label24)
        Me.FrameStreamParam.Controls.Add(Me.Label66)
        Me.FrameStreamParam.Controls.Add(Me.Label67)
        Me.FrameStreamParam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameStreamParam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameStreamParam.Location = New System.Drawing.Point(32, 63)
        Me.FrameStreamParam.Name = "FrameStreamParam"
        Me.FrameStreamParam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameStreamParam.Size = New System.Drawing.Size(548, 233)
        Me.FrameStreamParam.TabIndex = 0
        Me.FrameStreamParam.TabStop = False
        Me.FrameStreamParam.Text = "Define Stream Parameters"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(335, 195)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 14)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "βw:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(335, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 14)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "βd:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 14)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Channel Depth, D = αd * Drainage Area ^ βd:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(230, 14)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Channel Width, W = αw * Drainage Area ^ βw:"
        '
        'HydroManningCoeff
        '
        Me.HydroManningCoeff.AcceptsReturn = True
        Me.HydroManningCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.HydroManningCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HydroManningCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HydroManningCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HydroManningCoeff.Location = New System.Drawing.Point(274, 24)
        Me.HydroManningCoeff.MaxLength = 0
        Me.HydroManningCoeff.Name = "HydroManningCoeff"
        Me.HydroManningCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HydroManningCoeff.Size = New System.Drawing.Size(54, 20)
        Me.HydroManningCoeff.TabIndex = 1
        Me.HydroManningCoeff.Text = "0.014"
        '
        'listRegions
        '
        Me.listRegions.BackColor = System.Drawing.SystemColors.Window
        Me.listRegions.Cursor = System.Windows.Forms.Cursors.Default
        Me.listRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listRegions.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listRegions.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listRegions.Location = New System.Drawing.Point(274, 128)
        Me.listRegions.Name = "listRegions"
        Me.listRegions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.listRegions.Size = New System.Drawing.Size(136, 22)
        Me.listRegions.TabIndex = 7
        '
        'AlphaDepth
        '
        Me.AlphaDepth.AcceptsReturn = True
        Me.AlphaDepth.BackColor = System.Drawing.SystemColors.Window
        Me.AlphaDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AlphaDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlphaDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AlphaDepth.Location = New System.Drawing.Point(274, 160)
        Me.AlphaDepth.MaxLength = 0
        Me.AlphaDepth.Name = "AlphaDepth"
        Me.AlphaDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AlphaDepth.Size = New System.Drawing.Size(47, 20)
        Me.AlphaDepth.TabIndex = 8
        '
        'BetaDepth
        '
        Me.BetaDepth.AcceptsReturn = True
        Me.BetaDepth.BackColor = System.Drawing.SystemColors.Window
        Me.BetaDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BetaDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BetaDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BetaDepth.Location = New System.Drawing.Point(363, 160)
        Me.BetaDepth.MaxLength = 0
        Me.BetaDepth.Name = "BetaDepth"
        Me.BetaDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BetaDepth.Size = New System.Drawing.Size(47, 20)
        Me.BetaDepth.TabIndex = 9
        '
        'AlphaWidth
        '
        Me.AlphaWidth.AcceptsReturn = True
        Me.AlphaWidth.BackColor = System.Drawing.SystemColors.Window
        Me.AlphaWidth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AlphaWidth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlphaWidth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AlphaWidth.Location = New System.Drawing.Point(274, 192)
        Me.AlphaWidth.MaxLength = 0
        Me.AlphaWidth.Name = "AlphaWidth"
        Me.AlphaWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AlphaWidth.Size = New System.Drawing.Size(47, 20)
        Me.AlphaWidth.TabIndex = 10
        '
        'BetaWidth
        '
        Me.BetaWidth.AcceptsReturn = True
        Me.BetaWidth.BackColor = System.Drawing.SystemColors.Window
        Me.BetaWidth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BetaWidth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BetaWidth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BetaWidth.Location = New System.Drawing.Point(363, 192)
        Me.BetaWidth.MaxLength = 0
        Me.BetaWidth.Name = "BetaWidth"
        Me.BetaWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BetaWidth.Size = New System.Drawing.Size(47, 20)
        Me.BetaWidth.TabIndex = 11
        '
        'CrossSectionSlope1
        '
        Me.CrossSectionSlope1.AcceptsReturn = True
        Me.CrossSectionSlope1.BackColor = System.Drawing.SystemColors.Window
        Me.CrossSectionSlope1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CrossSectionSlope1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrossSectionSlope1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CrossSectionSlope1.Location = New System.Drawing.Point(274, 56)
        Me.CrossSectionSlope1.MaxLength = 0
        Me.CrossSectionSlope1.Name = "CrossSectionSlope1"
        Me.CrossSectionSlope1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CrossSectionSlope1.Size = New System.Drawing.Size(54, 20)
        Me.CrossSectionSlope1.TabIndex = 3
        Me.CrossSectionSlope1.Text = "1.0"
        '
        'CrossSectionSlope2
        '
        Me.CrossSectionSlope2.AcceptsReturn = True
        Me.CrossSectionSlope2.BackColor = System.Drawing.SystemColors.Window
        Me.CrossSectionSlope2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CrossSectionSlope2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrossSectionSlope2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CrossSectionSlope2.Location = New System.Drawing.Point(274, 88)
        Me.CrossSectionSlope2.MaxLength = 0
        Me.CrossSectionSlope2.Name = "CrossSectionSlope2"
        Me.CrossSectionSlope2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CrossSectionSlope2.Size = New System.Drawing.Size(54, 20)
        Me.CrossSectionSlope2.TabIndex = 5
        Me.CrossSectionSlope2.Text = "1.0"
        '
        'PictureChannel
        '
        Me.PictureChannel.BackColor = System.Drawing.SystemColors.Control
        Me.PictureChannel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureChannel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureChannel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PictureChannel.Image = CType(resources.GetObject("PictureChannel.Image"), System.Drawing.Image)
        Me.PictureChannel.Location = New System.Drawing.Point(352, 16)
        Me.PictureChannel.Name = "PictureChannel"
        Me.PictureChannel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PictureChannel.Size = New System.Drawing.Size(186, 92)
        Me.PictureChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureChannel.TabIndex = 9
        Me.PictureChannel.TabStop = False
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.BackColor = System.Drawing.SystemColors.Control
        Me.Label102.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label102.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label102.Location = New System.Drawing.Point(16, 27)
        Me.Label102.Name = "Label102"
        Me.Label102.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label102.Size = New System.Drawing.Size(247, 14)
        Me.Label102.TabIndex = 0
        Me.Label102.Text = "Manning's Roughness Coefficient for Channel (n):"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(16, 131)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(236, 14)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Select Region to Compute Channel Depth/Width:"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.SystemColors.Control
        Me.Label66.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label66.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label66.Location = New System.Drawing.Point(16, 59)
        Me.Label66.Name = "Label66"
        Me.Label66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label66.Size = New System.Drawing.Size(187, 14)
        Me.Label66.TabIndex = 2
        Me.Label66.Text = "Cross-Sectional Left Slope, Z1 (H:V):"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.SystemColors.Control
        Me.Label67.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label67.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label67.Location = New System.Drawing.Point(16, 91)
        Me.Label67.Name = "Label67"
        Me.Label67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label67.Size = New System.Drawing.Size(192, 14)
        Me.Label67.TabIndex = 4
        Me.Label67.Text = "Cross-Sectional Right Slope, Z2 (H:V):"
        '
        '_SSTab1_TabPage3
        '
        Me._SSTab1_TabPage3.Controls.Add(Me.LakeAttributes)
        Me._SSTab1_TabPage3.Location = New System.Drawing.Point(4, 23)
        Me._SSTab1_TabPage3.Name = "_SSTab1_TabPage3"
        Me._SSTab1_TabPage3.Size = New System.Drawing.Size(617, 358)
        Me._SSTab1_TabPage3.TabIndex = 3
        Me._SSTab1_TabPage3.Text = "Lakes"
        '
        'LakeAttributes
        '
        Me.LakeAttributes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LakeAttributes.BackColor = System.Drawing.SystemColors.Control
        Me.LakeAttributes.Controls.Add(Me.HydroOrificeDepth)
        Me.LakeAttributes.Controls.Add(Me.HydroHydraulicCond)
        Me.LakeAttributes.Controls.Add(Me.BankFullDepth)
        Me.LakeAttributes.Controls.Add(Me.InitWaterDepth)
        Me.LakeAttributes.Controls.Add(Me.LakesThreshold)
        Me.LakeAttributes.Controls.Add(Me.HydroOrificeDia)
        Me.LakeAttributes.Controls.Add(Me.HydroOrificeDischargeCoeff)
        Me.LakeAttributes.Controls.Add(Me.HydroWeirCrestLength)
        Me.LakeAttributes.Controls.Add(Me.HydroWeirDischargeCoeff)
        Me.LakeAttributes.Controls.Add(Me.HydroEvapoCoeff)
        Me.LakeAttributes.Controls.Add(Me.Label4)
        Me.LakeAttributes.Controls.Add(Me.Label29)
        Me.LakeAttributes.Controls.Add(Me.Label3)
        Me.LakeAttributes.Controls.Add(Me.Label6)
        Me.LakeAttributes.Controls.Add(Me.Label5)
        Me.LakeAttributes.Controls.Add(Me.Label30)
        Me.LakeAttributes.Controls.Add(Me.Label31)
        Me.LakeAttributes.Controls.Add(Me.Label32)
        Me.LakeAttributes.Controls.Add(Me.Label33)
        Me.LakeAttributes.Controls.Add(Me.Label28)
        Me.LakeAttributes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LakeAttributes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LakeAttributes.Location = New System.Drawing.Point(132, 33)
        Me.LakeAttributes.Name = "LakeAttributes"
        Me.LakeAttributes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LakeAttributes.Size = New System.Drawing.Size(353, 281)
        Me.LakeAttributes.TabIndex = 0
        Me.LakeAttributes.TabStop = False
        Me.LakeAttributes.Text = "Define Lake/Reservoir Parameters"
        '
        'HydroOrificeDepth
        '
        Me.HydroOrificeDepth.AcceptsReturn = True
        Me.HydroOrificeDepth.BackColor = System.Drawing.SystemColors.Window
        Me.HydroOrificeDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HydroOrificeDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HydroOrificeDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HydroOrificeDepth.Location = New System.Drawing.Point(267, 121)
        Me.HydroOrificeDepth.MaxLength = 0
        Me.HydroOrificeDepth.Name = "HydroOrificeDepth"
        Me.HydroOrificeDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HydroOrificeDepth.Size = New System.Drawing.Size(60, 20)
        Me.HydroOrificeDepth.TabIndex = 9
        Me.HydroOrificeDepth.Text = "0"
        '
        'HydroHydraulicCond
        '
        Me.HydroHydraulicCond.AcceptsReturn = True
        Me.HydroHydraulicCond.BackColor = System.Drawing.SystemColors.Window
        Me.HydroHydraulicCond.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HydroHydraulicCond.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HydroHydraulicCond.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HydroHydraulicCond.Location = New System.Drawing.Point(267, 241)
        Me.HydroHydraulicCond.MaxLength = 0
        Me.HydroHydraulicCond.Name = "HydroHydraulicCond"
        Me.HydroHydraulicCond.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HydroHydraulicCond.Size = New System.Drawing.Size(60, 20)
        Me.HydroHydraulicCond.TabIndex = 19
        Me.HydroHydraulicCond.Text = "0.001"
        '
        'BankFullDepth
        '
        Me.BankFullDepth.AcceptsReturn = True
        Me.BankFullDepth.BackColor = System.Drawing.SystemColors.Window
        Me.BankFullDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BankFullDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankFullDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BankFullDepth.Location = New System.Drawing.Point(267, 73)
        Me.BankFullDepth.MaxLength = 0
        Me.BankFullDepth.Name = "BankFullDepth"
        Me.BankFullDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BankFullDepth.Size = New System.Drawing.Size(60, 20)
        Me.BankFullDepth.TabIndex = 5
        Me.BankFullDepth.Text = "0.5"
        '
        'InitWaterDepth
        '
        Me.InitWaterDepth.AcceptsReturn = True
        Me.InitWaterDepth.BackColor = System.Drawing.SystemColors.Window
        Me.InitWaterDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.InitWaterDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitWaterDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.InitWaterDepth.Location = New System.Drawing.Point(267, 49)
        Me.InitWaterDepth.MaxLength = 0
        Me.InitWaterDepth.Name = "InitWaterDepth"
        Me.InitWaterDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InitWaterDepth.Size = New System.Drawing.Size(60, 20)
        Me.InitWaterDepth.TabIndex = 3
        Me.InitWaterDepth.Text = "0.5"
        '
        'LakesThreshold
        '
        Me.LakesThreshold.AcceptsReturn = True
        Me.LakesThreshold.BackColor = System.Drawing.SystemColors.Window
        Me.LakesThreshold.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LakesThreshold.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LakesThreshold.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LakesThreshold.Location = New System.Drawing.Point(267, 25)
        Me.LakesThreshold.MaxLength = 0
        Me.LakesThreshold.Name = "LakesThreshold"
        Me.LakesThreshold.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LakesThreshold.Size = New System.Drawing.Size(60, 20)
        Me.LakesThreshold.TabIndex = 1
        Me.LakesThreshold.Text = "1000000"
        '
        'HydroOrificeDia
        '
        Me.HydroOrificeDia.AcceptsReturn = True
        Me.HydroOrificeDia.BackColor = System.Drawing.SystemColors.Window
        Me.HydroOrificeDia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HydroOrificeDia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HydroOrificeDia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HydroOrificeDia.Location = New System.Drawing.Point(267, 145)
        Me.HydroOrificeDia.MaxLength = 0
        Me.HydroOrificeDia.Name = "HydroOrificeDia"
        Me.HydroOrificeDia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HydroOrificeDia.Size = New System.Drawing.Size(60, 20)
        Me.HydroOrificeDia.TabIndex = 11
        Me.HydroOrificeDia.Text = "0"
        '
        'HydroOrificeDischargeCoeff
        '
        Me.HydroOrificeDischargeCoeff.AcceptsReturn = True
        Me.HydroOrificeDischargeCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.HydroOrificeDischargeCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HydroOrificeDischargeCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HydroOrificeDischargeCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HydroOrificeDischargeCoeff.Location = New System.Drawing.Point(267, 169)
        Me.HydroOrificeDischargeCoeff.MaxLength = 0
        Me.HydroOrificeDischargeCoeff.Name = "HydroOrificeDischargeCoeff"
        Me.HydroOrificeDischargeCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HydroOrificeDischargeCoeff.Size = New System.Drawing.Size(60, 20)
        Me.HydroOrificeDischargeCoeff.TabIndex = 13
        Me.HydroOrificeDischargeCoeff.Text = "0.6"
        '
        'HydroWeirCrestLength
        '
        Me.HydroWeirCrestLength.AcceptsReturn = True
        Me.HydroWeirCrestLength.BackColor = System.Drawing.SystemColors.Window
        Me.HydroWeirCrestLength.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HydroWeirCrestLength.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HydroWeirCrestLength.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HydroWeirCrestLength.Location = New System.Drawing.Point(267, 193)
        Me.HydroWeirCrestLength.MaxLength = 0
        Me.HydroWeirCrestLength.Name = "HydroWeirCrestLength"
        Me.HydroWeirCrestLength.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HydroWeirCrestLength.Size = New System.Drawing.Size(60, 20)
        Me.HydroWeirCrestLength.TabIndex = 15
        Me.HydroWeirCrestLength.Text = "30"
        '
        'HydroWeirDischargeCoeff
        '
        Me.HydroWeirDischargeCoeff.AcceptsReturn = True
        Me.HydroWeirDischargeCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.HydroWeirDischargeCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HydroWeirDischargeCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HydroWeirDischargeCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HydroWeirDischargeCoeff.Location = New System.Drawing.Point(267, 217)
        Me.HydroWeirDischargeCoeff.MaxLength = 0
        Me.HydroWeirDischargeCoeff.Name = "HydroWeirDischargeCoeff"
        Me.HydroWeirDischargeCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HydroWeirDischargeCoeff.Size = New System.Drawing.Size(60, 20)
        Me.HydroWeirDischargeCoeff.TabIndex = 17
        Me.HydroWeirDischargeCoeff.Text = "1.84"
        '
        'HydroEvapoCoeff
        '
        Me.HydroEvapoCoeff.AcceptsReturn = True
        Me.HydroEvapoCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.HydroEvapoCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HydroEvapoCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HydroEvapoCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HydroEvapoCoeff.Location = New System.Drawing.Point(267, 97)
        Me.HydroEvapoCoeff.MaxLength = 0
        Me.HydroEvapoCoeff.Name = "HydroEvapoCoeff"
        Me.HydroEvapoCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HydroEvapoCoeff.Size = New System.Drawing.Size(60, 20)
        Me.HydroEvapoCoeff.TabIndex = 7
        Me.HydroEvapoCoeff.Text = "0.10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(126, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Orifice Depth to Bed (m):"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(6, 246)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(142, 14)
        Me.Label29.TabIndex = 18
        Me.Label29.Text = "Lake Infiltration rate (cm/hr):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(118, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Initial Water Depth (m) :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(6, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(101, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Bankfull Depth (m) :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(160, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Threshold Area for Lakes (m²) :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(6, 147)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(106, 14)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Orifice Diameter (m):"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(6, 171)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(149, 14)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "Orifice Discharge Coefficient:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(6, 195)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(116, 14)
        Me.Label32.TabIndex = 14
        Me.Label32.Text = "Weir Crest Length (m):"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(6, 222)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(139, 14)
        Me.Label33.TabIndex = 16
        Me.Label33.Text = "Weir Discharge Coefficient:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(6, 99)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(122, 14)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "Evaporation Coefficient:"
        '
        'frmHydrology
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(655, 443)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.SSTab1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHydrology"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Hydrology & Hydraulic Input"
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me.framehydro.ResumeLayout(False)
        Me.framehydro.PerformLayout()
        CType(Me.PictureA5dCNCurve, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraGroundWater.ResumeLayout(False)
        Me.fraGroundWater.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me._SSTab1_TabPage2.ResumeLayout(False)
        Me.FrameStreamParam.ResumeLayout(False)
        Me.FrameStreamParam.PerformLayout()
        CType(Me.PictureChannel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage3.ResumeLayout(False)
        Me.LakeAttributes.ResumeLayout(False)
        Me.LakeAttributes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
#End Region
End Class