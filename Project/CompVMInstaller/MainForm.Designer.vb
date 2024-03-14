<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TabControlMenus = New System.Windows.Forms.TabControl()
        Me.Advanced = New System.Windows.Forms.TabPage()
        Me.CheckboxItemtest = New System.Windows.Forms.CheckBox()
        Me.LabelPath = New System.Windows.Forms.Label()
        Me.PictureBoxGuide = New System.Windows.Forms.PictureBox()
        Me.BtnUninstall = New System.Windows.Forms.Button()
        Me.TabControlClasses = New System.Windows.Forms.TabControl()
        Me.Scout = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxScoutMelee = New System.Windows.Forms.GroupBox()
        Me.ScoutHideMelee = New System.Windows.Forms.CheckBox()
        Me.GroupBoxScoutSecondary = New System.Windows.Forms.GroupBox()
        Me.ScoutHideDrinks = New System.Windows.Forms.CheckBox()
        Me.ScoutHidePistols = New System.Windows.Forms.CheckBox()
        Me.ScoutHideThrowables = New System.Windows.Forms.CheckBox()
        Me.ScoutHideSecondaryInspect = New System.Windows.Forms.CheckBox()
        Me.GroupBoxScoutPrimary = New System.Windows.Forms.GroupBox()
        Me.ScoutHideShortstop = New System.Windows.Forms.CheckBox()
        Me.ScoutHideShortstopPush = New System.Windows.Forms.CheckBox()
        Me.ScoutHideDoubleBarrels = New System.Windows.Forms.CheckBox()
        Me.ScoutHidePrimaryInspect = New System.Windows.Forms.CheckBox()
        Me.ScoutHideScatterguns = New System.Windows.Forms.CheckBox()
        Me.Sniper = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxSniperMelee = New System.Windows.Forms.GroupBox()
        Me.SniperHideMelee = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSniperSecondary = New System.Windows.Forms.GroupBox()
        Me.SniperHideSMGs = New System.Windows.Forms.CheckBox()
        Me.SniperHideThrowables = New System.Windows.Forms.CheckBox()
        Me.SniperHideSecondaryInspect = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSniperPrimary = New System.Windows.Forms.GroupBox()
        Me.SniperHideHuntsman = New System.Windows.Forms.CheckBox()
        Me.SniperHidePrimaryInspect = New System.Windows.Forms.CheckBox()
        Me.SniperHideRifles = New System.Windows.Forms.CheckBox()
        Me.Soldier = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxSoldierMelee = New System.Windows.Forms.GroupBox()
        Me.SoldierHideMelee = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSoldierSecondary = New System.Windows.Forms.GroupBox()
        Me.SoldierHideBison = New System.Windows.Forms.CheckBox()
        Me.SoldierHideShotguns = New System.Windows.Forms.CheckBox()
        Me.SoldierHideBanners = New System.Windows.Forms.CheckBox()
        Me.SoldierHideSecondaryInspect = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSoldierPrimary = New System.Windows.Forms.GroupBox()
        Me.BtnOriginalInfo = New System.Windows.Forms.Button()
        Me.SoldierHideMangler = New System.Windows.Forms.CheckBox()
        Me.SoldierHideOriginal = New System.Windows.Forms.CheckBox()
        Me.SoldierHidePrimaryInspect = New System.Windows.Forms.CheckBox()
        Me.SoldierHideRockets = New System.Windows.Forms.CheckBox()
        Me.Demoman = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxDemoMelee = New System.Windows.Forms.GroupBox()
        Me.DemomanHideMelee = New System.Windows.Forms.CheckBox()
        Me.GroupBoxDemoSecondary = New System.Windows.Forms.GroupBox()
        Me.DemomanHideStickybombs = New System.Windows.Forms.CheckBox()
        Me.DemomanHideSecondaryInspect = New System.Windows.Forms.CheckBox()
        Me.GroupBoxDemoPrimary = New System.Windows.Forms.GroupBox()
        Me.DemomanHidePrimaryInspect = New System.Windows.Forms.CheckBox()
        Me.DemomanHideGrenades = New System.Windows.Forms.CheckBox()
        Me.Medic = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxMedicMelee = New System.Windows.Forms.GroupBox()
        Me.MedicHideMelee = New System.Windows.Forms.CheckBox()
        Me.GroupBoxMedicSecondary = New System.Windows.Forms.GroupBox()
        Me.MedicHideMediguns = New System.Windows.Forms.CheckBox()
        Me.MedicHideSecondaryInspect = New System.Windows.Forms.CheckBox()
        Me.GroupBoxMedicPrimary = New System.Windows.Forms.GroupBox()
        Me.MedicHidePrimaryInspect = New System.Windows.Forms.CheckBox()
        Me.MedicHidePrimaries = New System.Windows.Forms.CheckBox()
        Me.Heavy = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxHeavyMelee = New System.Windows.Forms.GroupBox()
        Me.HeavyHideMelee = New System.Windows.Forms.CheckBox()
        Me.GroupBoxHeavySecondary = New System.Windows.Forms.GroupBox()
        Me.HeavyHideShotguns = New System.Windows.Forms.CheckBox()
        Me.HeavyHideConsumables = New System.Windows.Forms.CheckBox()
        Me.HeavyHideSecondaryInspect = New System.Windows.Forms.CheckBox()
        Me.GroupBoxHeavyPrimary = New System.Windows.Forms.GroupBox()
        Me.HeavyHidePrimaryInspect = New System.Windows.Forms.CheckBox()
        Me.HeavyHideMiniguns = New System.Windows.Forms.CheckBox()
        Me.Pyro = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxPyroMelee = New System.Windows.Forms.GroupBox()
        Me.PyroHideMelee = New System.Windows.Forms.CheckBox()
        Me.GroupBoxPyroSecondary = New System.Windows.Forms.GroupBox()
        Me.PyroHideShotguns = New System.Windows.Forms.CheckBox()
        Me.PyroHideFlareGuns = New System.Windows.Forms.CheckBox()
        Me.PyroHideThermalThruster = New System.Windows.Forms.CheckBox()
        Me.PyroHideGasPasser = New System.Windows.Forms.CheckBox()
        Me.PyroHideSecondaryInspect = New System.Windows.Forms.CheckBox()
        Me.GroupBoxPyroPrimary = New System.Windows.Forms.GroupBox()
        Me.PyroHidePrimaryInspect = New System.Windows.Forms.CheckBox()
        Me.PyroHideFlamethrowers = New System.Windows.Forms.CheckBox()
        Me.Spy = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxSpyPrimary = New System.Windows.Forms.GroupBox()
        Me.SpyHidePrimaryInspect = New System.Windows.Forms.CheckBox()
        Me.SpyHideRevolvers = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSpyMelee = New System.Windows.Forms.GroupBox()
        Me.SpyHideMeleeInspect = New System.Windows.Forms.CheckBox()
        Me.SpyHideMelee = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSpySecondary = New System.Windows.Forms.GroupBox()
        Me.SpyHideSappers = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSpyPDA = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SpyHideDisguiseKit = New System.Windows.Forms.CheckBox()
        Me.SpyHideDeadRinger = New System.Windows.Forms.CheckBox()
        Me.SpyHideInvisWatch = New System.Windows.Forms.CheckBox()
        Me.Engineer = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxEngineerPrimary = New System.Windows.Forms.GroupBox()
        Me.EngineerHidePomson = New System.Windows.Forms.CheckBox()
        Me.EngineerHidePrimaryInspect = New System.Windows.Forms.CheckBox()
        Me.EngineerHideShotguns = New System.Windows.Forms.CheckBox()
        Me.GroupBoxEngineerMelee = New System.Windows.Forms.GroupBox()
        Me.EngineerHideGunslinger = New System.Windows.Forms.CheckBox()
        Me.EngineerHideMeleeInspect = New System.Windows.Forms.CheckBox()
        Me.EngineerHideWrenches = New System.Windows.Forms.CheckBox()
        Me.GroupBoxEngineerSecondary = New System.Windows.Forms.GroupBox()
        Me.EngineerHideShortCircuit = New System.Windows.Forms.CheckBox()
        Me.EngineerHidePistols = New System.Windows.Forms.CheckBox()
        Me.EngineerHideWrangler = New System.Windows.Forms.CheckBox()
        Me.EngineerHideSecondaryInspect = New System.Windows.Forms.CheckBox()
        Me.GroupBoxEngineerPDA = New System.Windows.Forms.GroupBox()
        Me.EngineerHideToolbox = New System.Windows.Forms.CheckBox()
        Me.EngineerHidePDA = New System.Windows.Forms.CheckBox()
        Me.ClassIconList = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnInstall = New System.Windows.Forms.Button()
        Me.BtnSelectFolder = New System.Windows.Forms.Button()
        Me.Manual = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.OutputBox = New System.Windows.Forms.RichTextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.GroupBox31 = New System.Windows.Forms.GroupBox()
        Me.InputBox = New System.Windows.Forms.RichTextBox()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.InputPath = New System.Windows.Forms.TextBox()
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.ViewmodelTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnLaunchTF2 = New System.Windows.Forms.Button()
        Me.TabControlMenus.SuspendLayout()
        Me.Advanced.SuspendLayout()
        CType(Me.PictureBoxGuide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlClasses.SuspendLayout()
        Me.Scout.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxScoutMelee.SuspendLayout()
        Me.GroupBoxScoutSecondary.SuspendLayout()
        Me.GroupBoxScoutPrimary.SuspendLayout()
        Me.Sniper.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBoxSniperMelee.SuspendLayout()
        Me.GroupBoxSniperSecondary.SuspendLayout()
        Me.GroupBoxSniperPrimary.SuspendLayout()
        Me.Soldier.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBoxSoldierMelee.SuspendLayout()
        Me.GroupBoxSoldierSecondary.SuspendLayout()
        Me.GroupBoxSoldierPrimary.SuspendLayout()
        Me.Demoman.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBoxDemoMelee.SuspendLayout()
        Me.GroupBoxDemoSecondary.SuspendLayout()
        Me.GroupBoxDemoPrimary.SuspendLayout()
        Me.Medic.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBoxMedicMelee.SuspendLayout()
        Me.GroupBoxMedicSecondary.SuspendLayout()
        Me.GroupBoxMedicPrimary.SuspendLayout()
        Me.Heavy.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupBoxHeavyMelee.SuspendLayout()
        Me.GroupBoxHeavySecondary.SuspendLayout()
        Me.GroupBoxHeavyPrimary.SuspendLayout()
        Me.Pyro.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.GroupBoxPyroMelee.SuspendLayout()
        Me.GroupBoxPyroSecondary.SuspendLayout()
        Me.GroupBoxPyroPrimary.SuspendLayout()
        Me.Spy.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.GroupBoxSpyPrimary.SuspendLayout()
        Me.GroupBoxSpyMelee.SuspendLayout()
        Me.GroupBoxSpySecondary.SuspendLayout()
        Me.GroupBoxSpyPDA.SuspendLayout()
        Me.Engineer.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.GroupBoxEngineerPrimary.SuspendLayout()
        Me.GroupBoxEngineerMelee.SuspendLayout()
        Me.GroupBoxEngineerSecondary.SuspendLayout()
        Me.GroupBoxEngineerPDA.SuspendLayout()
        Me.Manual.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        Me.GroupBox31.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlMenus
        '
        Me.TabControlMenus.AccessibleName = "TabControlMenus"
        Me.TabControlMenus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlMenus.Controls.Add(Me.Advanced)
        Me.TabControlMenus.Controls.Add(Me.Manual)
        Me.TabControlMenus.Location = New System.Drawing.Point(6, 6)
        Me.TabControlMenus.Name = "TabControlMenus"
        Me.TabControlMenus.SelectedIndex = 0
        Me.TabControlMenus.Size = New System.Drawing.Size(615, 614)
        Me.TabControlMenus.TabIndex = 0
        '
        'Advanced
        '
        Me.Advanced.Controls.Add(Me.CheckboxItemtest)
        Me.Advanced.Controls.Add(Me.LabelPath)
        Me.Advanced.Controls.Add(Me.PictureBoxGuide)
        Me.Advanced.Controls.Add(Me.BtnUninstall)
        Me.Advanced.Controls.Add(Me.TabControlClasses)
        Me.Advanced.Controls.Add(Me.BtnInstall)
        Me.Advanced.Controls.Add(Me.BtnSelectFolder)
        Me.Advanced.Location = New System.Drawing.Point(4, 22)
        Me.Advanced.Name = "Advanced"
        Me.Advanced.Padding = New System.Windows.Forms.Padding(3)
        Me.Advanced.Size = New System.Drawing.Size(607, 588)
        Me.Advanced.TabIndex = 0
        Me.Advanced.Text = "Advanced"
        Me.Advanced.UseVisualStyleBackColor = True
        '
        'CheckboxItemtest
        '
        Me.CheckboxItemtest.AccessibleName = "CheckboxItemtest"
        Me.CheckboxItemtest.AutoSize = True
        Me.CheckboxItemtest.Enabled = False
        Me.CheckboxItemtest.Location = New System.Drawing.Point(376, 564)
        Me.CheckboxItemtest.Name = "CheckboxItemtest"
        Me.CheckboxItemtest.Size = New System.Drawing.Size(63, 17)
        Me.CheckboxItemtest.TabIndex = 9
        Me.CheckboxItemtest.Text = "Itemtest"
        Me.CheckboxItemtest.UseVisualStyleBackColor = True
        Me.CheckboxItemtest.Visible = False
        '
        'LabelPath
        '
        Me.LabelPath.AccessibleName = "LabelPath"
        Me.LabelPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelPath.AutoSize = True
        Me.LabelPath.Location = New System.Drawing.Point(187, 568)
        Me.LabelPath.Name = "LabelPath"
        Me.LabelPath.Size = New System.Drawing.Size(142, 13)
        Me.LabelPath.TabIndex = 8
        Me.LabelPath.Text = "Please select your TF2 path."
        '
        'PictureBoxGuide
        '
        Me.PictureBoxGuide.AccessibleName = "PictureBoxGuide"
        Me.PictureBoxGuide.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxGuide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxGuide.Image = Global.CompVMInstaller.My.Resources.Resources.compviewmodelbannersmall
        Me.PictureBoxGuide.Location = New System.Drawing.Point(3, 6)
        Me.PictureBoxGuide.Name = "PictureBoxGuide"
        Me.PictureBoxGuide.Size = New System.Drawing.Size(598, 341)
        Me.PictureBoxGuide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxGuide.TabIndex = 7
        Me.PictureBoxGuide.TabStop = False
        '
        'BtnUninstall
        '
        Me.BtnUninstall.AccessibleName = "BtnUninstall"
        Me.BtnUninstall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnUninstall.Location = New System.Drawing.Point(445, 563)
        Me.BtnUninstall.Name = "BtnUninstall"
        Me.BtnUninstall.Size = New System.Drawing.Size(75, 23)
        Me.BtnUninstall.TabIndex = 6
        Me.BtnUninstall.Text = "Uninstall"
        Me.BtnUninstall.UseVisualStyleBackColor = True
        '
        'TabControlClasses
        '
        Me.TabControlClasses.AccessibleName = "TabControlClasses"
        Me.TabControlClasses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlClasses.Controls.Add(Me.Scout)
        Me.TabControlClasses.Controls.Add(Me.Soldier)
        Me.TabControlClasses.Controls.Add(Me.Pyro)
        Me.TabControlClasses.Controls.Add(Me.Demoman)
        Me.TabControlClasses.Controls.Add(Me.Heavy)
        Me.TabControlClasses.Controls.Add(Me.Engineer)
        Me.TabControlClasses.Controls.Add(Me.Medic)
        Me.TabControlClasses.Controls.Add(Me.Sniper)
        Me.TabControlClasses.Controls.Add(Me.Spy)
        Me.TabControlClasses.ImageList = Me.ClassIconList
        Me.TabControlClasses.Location = New System.Drawing.Point(3, 353)
        Me.TabControlClasses.Name = "TabControlClasses"
        Me.TabControlClasses.Padding = New System.Drawing.Point(4, 4)
        Me.TabControlClasses.SelectedIndex = 0
        Me.TabControlClasses.Size = New System.Drawing.Size(601, 204)
        Me.TabControlClasses.TabIndex = 0
        '
        'Scout
        '
        Me.Scout.Controls.Add(Me.TableLayoutPanel1)
        Me.Scout.ImageIndex = 5
        Me.Scout.Location = New System.Drawing.Point(4, 25)
        Me.Scout.Name = "Scout"
        Me.Scout.Padding = New System.Windows.Forms.Padding(3)
        Me.Scout.Size = New System.Drawing.Size(593, 175)
        Me.Scout.TabIndex = 0
        Me.Scout.Text = "Scout"
        Me.Scout.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxScoutMelee, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxScoutSecondary, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxScoutPrimary, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(581, 163)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBoxScoutMelee
        '
        Me.GroupBoxScoutMelee.AccessibleName = "GroupBoxScoutMelee"
        Me.GroupBoxScoutMelee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxScoutMelee.AutoSize = True
        Me.GroupBoxScoutMelee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxScoutMelee.Controls.Add(Me.ScoutHideMelee)
        Me.GroupBoxScoutMelee.Location = New System.Drawing.Point(389, 3)
        Me.GroupBoxScoutMelee.Name = "GroupBoxScoutMelee"
        Me.GroupBoxScoutMelee.Size = New System.Drawing.Size(189, 157)
        Me.GroupBoxScoutMelee.TabIndex = 1
        Me.GroupBoxScoutMelee.TabStop = False
        Me.GroupBoxScoutMelee.Text = "Melee"
        '
        'ScoutHideMelee
        '
        Me.ScoutHideMelee.AccessibleName = "ScoutHideMelee"
        Me.ScoutHideMelee.AutoSize = True
        Me.ScoutHideMelee.Location = New System.Drawing.Point(6, 19)
        Me.ScoutHideMelee.Name = "ScoutHideMelee"
        Me.ScoutHideMelee.Size = New System.Drawing.Size(80, 17)
        Me.ScoutHideMelee.TabIndex = 8
        Me.ScoutHideMelee.Text = "Hide Melee"
        Me.ScoutHideMelee.UseVisualStyleBackColor = True
        '
        'GroupBoxScoutSecondary
        '
        Me.GroupBoxScoutSecondary.AccessibleName = "GroupBoxScoutSecondary"
        Me.GroupBoxScoutSecondary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxScoutSecondary.AutoSize = True
        Me.GroupBoxScoutSecondary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxScoutSecondary.Controls.Add(Me.ScoutHideDrinks)
        Me.GroupBoxScoutSecondary.Controls.Add(Me.ScoutHidePistols)
        Me.GroupBoxScoutSecondary.Controls.Add(Me.ScoutHideThrowables)
        Me.GroupBoxScoutSecondary.Controls.Add(Me.ScoutHideSecondaryInspect)
        Me.GroupBoxScoutSecondary.Location = New System.Drawing.Point(196, 3)
        Me.GroupBoxScoutSecondary.Name = "GroupBoxScoutSecondary"
        Me.GroupBoxScoutSecondary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxScoutSecondary.TabIndex = 1
        Me.GroupBoxScoutSecondary.TabStop = False
        Me.GroupBoxScoutSecondary.Text = "Secondary"
        '
        'ScoutHideDrinks
        '
        Me.ScoutHideDrinks.AccessibleName = "ScoutHideDrinks"
        Me.ScoutHideDrinks.AutoSize = True
        Me.ScoutHideDrinks.Location = New System.Drawing.Point(6, 65)
        Me.ScoutHideDrinks.Name = "ScoutHideDrinks"
        Me.ScoutHideDrinks.Size = New System.Drawing.Size(114, 17)
        Me.ScoutHideDrinks.TabIndex = 7
        Me.ScoutHideDrinks.Text = "Hide Consumables"
        Me.ViewmodelTooltip.SetToolTip(Me.ScoutHideDrinks, "Bonk! Atomic Punch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Crit-a-Cola")
        Me.ScoutHideDrinks.UseVisualStyleBackColor = True
        '
        'ScoutHidePistols
        '
        Me.ScoutHidePistols.AccessibleName = "ScoutHidePistols"
        Me.ScoutHidePistols.AutoSize = True
        Me.ScoutHidePistols.Location = New System.Drawing.Point(6, 19)
        Me.ScoutHidePistols.Name = "ScoutHidePistols"
        Me.ScoutHidePistols.Size = New System.Drawing.Size(81, 17)
        Me.ScoutHidePistols.TabIndex = 4
        Me.ScoutHidePistols.Text = "Hide Pistols"
        Me.ViewmodelTooltip.SetToolTip(Me.ScoutHidePistols, "Pistol" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Winger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pretty Boy's Pocket Pistol")
        Me.ScoutHidePistols.UseVisualStyleBackColor = True
        '
        'ScoutHideThrowables
        '
        Me.ScoutHideThrowables.AccessibleName = "ScoutHideThrowables"
        Me.ScoutHideThrowables.AutoSize = True
        Me.ScoutHideThrowables.Location = New System.Drawing.Point(6, 42)
        Me.ScoutHideThrowables.Name = "ScoutHideThrowables"
        Me.ScoutHideThrowables.Size = New System.Drawing.Size(106, 17)
        Me.ScoutHideThrowables.TabIndex = 6
        Me.ScoutHideThrowables.Text = "Hide Throwables"
        Me.ViewmodelTooltip.SetToolTip(Me.ScoutHideThrowables, "Mad Milk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Flying Guillotine")
        Me.ScoutHideThrowables.UseMnemonic = False
        Me.ScoutHideThrowables.UseVisualStyleBackColor = True
        '
        'ScoutHideSecondaryInspect
        '
        Me.ScoutHideSecondaryInspect.AccessibleName = "ScoutHideSecondaryInspect"
        Me.ScoutHideSecondaryInspect.AutoSize = True
        Me.ScoutHideSecondaryInspect.Location = New System.Drawing.Point(6, 88)
        Me.ScoutHideSecondaryInspect.Name = "ScoutHideSecondaryInspect"
        Me.ScoutHideSecondaryInspect.Size = New System.Drawing.Size(145, 17)
        Me.ScoutHideSecondaryInspect.TabIndex = 5
        Me.ScoutHideSecondaryInspect.Text = "Hide Secondary Inspects"
        Me.ScoutHideSecondaryInspect.UseVisualStyleBackColor = True
        '
        'GroupBoxScoutPrimary
        '
        Me.GroupBoxScoutPrimary.AccessibleName = "GroupBoxScoutPrimary"
        Me.GroupBoxScoutPrimary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxScoutPrimary.AutoSize = True
        Me.GroupBoxScoutPrimary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxScoutPrimary.Controls.Add(Me.ScoutHideShortstop)
        Me.GroupBoxScoutPrimary.Controls.Add(Me.ScoutHideShortstopPush)
        Me.GroupBoxScoutPrimary.Controls.Add(Me.ScoutHideDoubleBarrels)
        Me.GroupBoxScoutPrimary.Controls.Add(Me.ScoutHidePrimaryInspect)
        Me.GroupBoxScoutPrimary.Controls.Add(Me.ScoutHideScatterguns)
        Me.GroupBoxScoutPrimary.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxScoutPrimary.Name = "GroupBoxScoutPrimary"
        Me.GroupBoxScoutPrimary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxScoutPrimary.TabIndex = 0
        Me.GroupBoxScoutPrimary.TabStop = False
        Me.GroupBoxScoutPrimary.Text = "Primary"
        '
        'ScoutHideShortstop
        '
        Me.ScoutHideShortstop.AutoSize = True
        Me.ScoutHideShortstop.Location = New System.Drawing.Point(6, 65)
        Me.ScoutHideShortstop.Name = "ScoutHideShortstop"
        Me.ScoutHideShortstop.Size = New System.Drawing.Size(96, 17)
        Me.ScoutHideShortstop.TabIndex = 8
        Me.ScoutHideShortstop.Text = "Hide Shortstop"
        Me.ScoutHideShortstop.UseVisualStyleBackColor = True
        '
        'ScoutHideShortstopPush
        '
        Me.ScoutHideShortstopPush.AutoSize = True
        Me.ScoutHideShortstopPush.Location = New System.Drawing.Point(6, 88)
        Me.ScoutHideShortstopPush.Name = "ScoutHideShortstopPush"
        Me.ScoutHideShortstopPush.Size = New System.Drawing.Size(149, 17)
        Me.ScoutHideShortstopPush.TabIndex = 3
        Me.ScoutHideShortstopPush.Text = "Hide Shortstop Push Anim"
        Me.ViewmodelTooltip.SetToolTip(Me.ScoutHideShortstopPush, "Appears when using alternate fire (right click) with the Shortstop equipped")
        Me.ScoutHideShortstopPush.UseVisualStyleBackColor = True
        '
        'ScoutHideDoubleBarrels
        '
        Me.ScoutHideDoubleBarrels.AutoSize = True
        Me.ScoutHideDoubleBarrels.Location = New System.Drawing.Point(6, 42)
        Me.ScoutHideDoubleBarrels.Name = "ScoutHideDoubleBarrels"
        Me.ScoutHideDoubleBarrels.Size = New System.Drawing.Size(120, 17)
        Me.ScoutHideDoubleBarrels.TabIndex = 2
        Me.ScoutHideDoubleBarrels.Text = "Hide Double Barrels"
        Me.ViewmodelTooltip.SetToolTip(Me.ScoutHideDoubleBarrels, "Force-A-Nature" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Soda Popper")
        Me.ScoutHideDoubleBarrels.UseMnemonic = False
        Me.ScoutHideDoubleBarrels.UseVisualStyleBackColor = True
        '
        'ScoutHidePrimaryInspect
        '
        Me.ScoutHidePrimaryInspect.AutoSize = True
        Me.ScoutHidePrimaryInspect.Location = New System.Drawing.Point(6, 111)
        Me.ScoutHidePrimaryInspect.Name = "ScoutHidePrimaryInspect"
        Me.ScoutHidePrimaryInspect.Size = New System.Drawing.Size(128, 17)
        Me.ScoutHidePrimaryInspect.TabIndex = 1
        Me.ScoutHidePrimaryInspect.Text = "Hide Primary Inspects"
        Me.ScoutHidePrimaryInspect.UseVisualStyleBackColor = True
        '
        'ScoutHideScatterguns
        '
        Me.ScoutHideScatterguns.AccessibleName = "ScoutHideScatterguns"
        Me.ScoutHideScatterguns.AutoSize = True
        Me.ScoutHideScatterguns.Location = New System.Drawing.Point(6, 19)
        Me.ScoutHideScatterguns.Name = "ScoutHideScatterguns"
        Me.ScoutHideScatterguns.Size = New System.Drawing.Size(108, 17)
        Me.ScoutHideScatterguns.TabIndex = 0
        Me.ScoutHideScatterguns.Text = "Hide Scatterguns"
        Me.ViewmodelTooltip.SetToolTip(Me.ScoutHideScatterguns, "Scattergun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Baby Face's Blaster" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Back Scatter")
        Me.ScoutHideScatterguns.UseVisualStyleBackColor = True
        '
        'Sniper
        '
        Me.Sniper.Controls.Add(Me.TableLayoutPanel2)
        Me.Sniper.ImageIndex = 6
        Me.Sniper.Location = New System.Drawing.Point(4, 25)
        Me.Sniper.Name = "Sniper"
        Me.Sniper.Size = New System.Drawing.Size(593, 175)
        Me.Sniper.TabIndex = 2
        Me.Sniper.Text = "Sniper"
        Me.Sniper.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBoxSniperMelee, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBoxSniperSecondary, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBoxSniperPrimary, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(581, 163)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GroupBoxSniperMelee
        '
        Me.GroupBoxSniperMelee.AccessibleName = "GroupBoxSniperMelee"
        Me.GroupBoxSniperMelee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSniperMelee.AutoSize = True
        Me.GroupBoxSniperMelee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxSniperMelee.Controls.Add(Me.SniperHideMelee)
        Me.GroupBoxSniperMelee.Location = New System.Drawing.Point(389, 3)
        Me.GroupBoxSniperMelee.Name = "GroupBoxSniperMelee"
        Me.GroupBoxSniperMelee.Size = New System.Drawing.Size(189, 157)
        Me.GroupBoxSniperMelee.TabIndex = 1
        Me.GroupBoxSniperMelee.TabStop = False
        Me.GroupBoxSniperMelee.Text = "Melee"
        '
        'SniperHideMelee
        '
        Me.SniperHideMelee.AccessibleName = "SniperHideMelee"
        Me.SniperHideMelee.AutoSize = True
        Me.SniperHideMelee.Location = New System.Drawing.Point(6, 19)
        Me.SniperHideMelee.Name = "SniperHideMelee"
        Me.SniperHideMelee.Size = New System.Drawing.Size(80, 17)
        Me.SniperHideMelee.TabIndex = 8
        Me.SniperHideMelee.Text = "Hide Melee"
        Me.SniperHideMelee.UseVisualStyleBackColor = True
        '
        'GroupBoxSniperSecondary
        '
        Me.GroupBoxSniperSecondary.AccessibleName = "GroupBoxSniperSecondary"
        Me.GroupBoxSniperSecondary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSniperSecondary.AutoSize = True
        Me.GroupBoxSniperSecondary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxSniperSecondary.Controls.Add(Me.SniperHideSMGs)
        Me.GroupBoxSniperSecondary.Controls.Add(Me.SniperHideThrowables)
        Me.GroupBoxSniperSecondary.Controls.Add(Me.SniperHideSecondaryInspect)
        Me.GroupBoxSniperSecondary.Location = New System.Drawing.Point(196, 3)
        Me.GroupBoxSniperSecondary.Name = "GroupBoxSniperSecondary"
        Me.GroupBoxSniperSecondary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxSniperSecondary.TabIndex = 1
        Me.GroupBoxSniperSecondary.TabStop = False
        Me.GroupBoxSniperSecondary.Text = "Secondary"
        '
        'SniperHideSMGs
        '
        Me.SniperHideSMGs.AccessibleName = "SniperHideSMGs"
        Me.SniperHideSMGs.AutoSize = True
        Me.SniperHideSMGs.Location = New System.Drawing.Point(6, 19)
        Me.SniperHideSMGs.Name = "SniperHideSMGs"
        Me.SniperHideSMGs.Size = New System.Drawing.Size(80, 17)
        Me.SniperHideSMGs.TabIndex = 4
        Me.SniperHideSMGs.Text = "Hide SMGs"
        Me.ViewmodelTooltip.SetToolTip(Me.SniperHideSMGs, "Submachine Gun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cleaner's Carbine")
        Me.SniperHideSMGs.UseVisualStyleBackColor = True
        '
        'SniperHideThrowables
        '
        Me.SniperHideThrowables.AccessibleName = "SniperHideThrowables"
        Me.SniperHideThrowables.AutoSize = True
        Me.SniperHideThrowables.Location = New System.Drawing.Point(6, 42)
        Me.SniperHideThrowables.Name = "SniperHideThrowables"
        Me.SniperHideThrowables.Size = New System.Drawing.Size(106, 17)
        Me.SniperHideThrowables.TabIndex = 6
        Me.SniperHideThrowables.Text = "Hide Throwables"
        Me.ViewmodelTooltip.SetToolTip(Me.SniperHideThrowables, "Jarate")
        Me.SniperHideThrowables.UseMnemonic = False
        Me.SniperHideThrowables.UseVisualStyleBackColor = True
        '
        'SniperHideSecondaryInspect
        '
        Me.SniperHideSecondaryInspect.AccessibleName = "SniperHideSecondaryInspect"
        Me.SniperHideSecondaryInspect.AutoSize = True
        Me.SniperHideSecondaryInspect.Location = New System.Drawing.Point(6, 65)
        Me.SniperHideSecondaryInspect.Name = "SniperHideSecondaryInspect"
        Me.SniperHideSecondaryInspect.Size = New System.Drawing.Size(145, 17)
        Me.SniperHideSecondaryInspect.TabIndex = 5
        Me.SniperHideSecondaryInspect.Text = "Hide Secondary Inspects"
        Me.SniperHideSecondaryInspect.UseVisualStyleBackColor = True
        '
        'GroupBoxSniperPrimary
        '
        Me.GroupBoxSniperPrimary.AccessibleName = "GroupBoxSniperPrimary"
        Me.GroupBoxSniperPrimary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSniperPrimary.AutoSize = True
        Me.GroupBoxSniperPrimary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxSniperPrimary.Controls.Add(Me.SniperHideHuntsman)
        Me.GroupBoxSniperPrimary.Controls.Add(Me.SniperHidePrimaryInspect)
        Me.GroupBoxSniperPrimary.Controls.Add(Me.SniperHideRifles)
        Me.GroupBoxSniperPrimary.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxSniperPrimary.Name = "GroupBoxSniperPrimary"
        Me.GroupBoxSniperPrimary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxSniperPrimary.TabIndex = 0
        Me.GroupBoxSniperPrimary.TabStop = False
        Me.GroupBoxSniperPrimary.Text = "Primary"
        '
        'SniperHideHuntsman
        '
        Me.SniperHideHuntsman.AccessibleName = "SniperHideHuntsman"
        Me.SniperHideHuntsman.AutoSize = True
        Me.SniperHideHuntsman.Location = New System.Drawing.Point(6, 42)
        Me.SniperHideHuntsman.Name = "SniperHideHuntsman"
        Me.SniperHideHuntsman.Size = New System.Drawing.Size(99, 17)
        Me.SniperHideHuntsman.TabIndex = 2
        Me.SniperHideHuntsman.Text = "Hide Huntsman"
        Me.SniperHideHuntsman.UseMnemonic = False
        Me.SniperHideHuntsman.UseVisualStyleBackColor = True
        '
        'SniperHidePrimaryInspect
        '
        Me.SniperHidePrimaryInspect.AccessibleName = "SniperHidePrimaryInspect"
        Me.SniperHidePrimaryInspect.AutoSize = True
        Me.SniperHidePrimaryInspect.Location = New System.Drawing.Point(6, 65)
        Me.SniperHidePrimaryInspect.Name = "SniperHidePrimaryInspect"
        Me.SniperHidePrimaryInspect.Size = New System.Drawing.Size(128, 17)
        Me.SniperHidePrimaryInspect.TabIndex = 1
        Me.SniperHidePrimaryInspect.Text = "Hide Primary Inspects"
        Me.SniperHidePrimaryInspect.UseVisualStyleBackColor = True
        '
        'SniperHideRifles
        '
        Me.SniperHideRifles.AccessibleName = "SniperHideRifles"
        Me.SniperHideRifles.AutoSize = True
        Me.SniperHideRifles.Location = New System.Drawing.Point(6, 19)
        Me.SniperHideRifles.Name = "SniperHideRifles"
        Me.SniperHideRifles.Size = New System.Drawing.Size(110, 17)
        Me.SniperHideRifles.TabIndex = 0
        Me.SniperHideRifles.Text = "Hide Sniper Rifles"
        Me.ViewmodelTooltip.SetToolTip(Me.SniperHideRifles, "Sniper Rifle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sydney Sleeper" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bazaar Bargain" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Machina" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hitman's Heatmaker" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Classi" &
        "c")
        Me.SniperHideRifles.UseVisualStyleBackColor = True
        '
        'Soldier
        '
        Me.Soldier.Controls.Add(Me.TableLayoutPanel3)
        Me.Soldier.ImageIndex = 7
        Me.Soldier.Location = New System.Drawing.Point(4, 25)
        Me.Soldier.Name = "Soldier"
        Me.Soldier.Padding = New System.Windows.Forms.Padding(3)
        Me.Soldier.Size = New System.Drawing.Size(593, 175)
        Me.Soldier.TabIndex = 1
        Me.Soldier.Text = "Soldier"
        Me.Soldier.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBoxSoldierMelee, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBoxSoldierSecondary, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBoxSoldierPrimary, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(581, 163)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'GroupBoxSoldierMelee
        '
        Me.GroupBoxSoldierMelee.AccessibleName = "GroupBoxSoldierMelee"
        Me.GroupBoxSoldierMelee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSoldierMelee.AutoSize = True
        Me.GroupBoxSoldierMelee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxSoldierMelee.Controls.Add(Me.SoldierHideMelee)
        Me.GroupBoxSoldierMelee.Location = New System.Drawing.Point(389, 3)
        Me.GroupBoxSoldierMelee.Name = "GroupBoxSoldierMelee"
        Me.GroupBoxSoldierMelee.Size = New System.Drawing.Size(189, 157)
        Me.GroupBoxSoldierMelee.TabIndex = 1
        Me.GroupBoxSoldierMelee.TabStop = False
        Me.GroupBoxSoldierMelee.Text = "Melee"
        '
        'SoldierHideMelee
        '
        Me.SoldierHideMelee.AccessibleName = "SoldierHideMelee"
        Me.SoldierHideMelee.AutoSize = True
        Me.SoldierHideMelee.Location = New System.Drawing.Point(6, 19)
        Me.SoldierHideMelee.Name = "SoldierHideMelee"
        Me.SoldierHideMelee.Size = New System.Drawing.Size(80, 17)
        Me.SoldierHideMelee.TabIndex = 8
        Me.SoldierHideMelee.Text = "Hide Melee"
        Me.SoldierHideMelee.UseVisualStyleBackColor = True
        '
        'GroupBoxSoldierSecondary
        '
        Me.GroupBoxSoldierSecondary.AccessibleName = "GroupBoxSoldierSecondary"
        Me.GroupBoxSoldierSecondary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSoldierSecondary.AutoSize = True
        Me.GroupBoxSoldierSecondary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxSoldierSecondary.Controls.Add(Me.SoldierHideBison)
        Me.GroupBoxSoldierSecondary.Controls.Add(Me.SoldierHideShotguns)
        Me.GroupBoxSoldierSecondary.Controls.Add(Me.SoldierHideBanners)
        Me.GroupBoxSoldierSecondary.Controls.Add(Me.SoldierHideSecondaryInspect)
        Me.GroupBoxSoldierSecondary.Location = New System.Drawing.Point(196, 3)
        Me.GroupBoxSoldierSecondary.Name = "GroupBoxSoldierSecondary"
        Me.GroupBoxSoldierSecondary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxSoldierSecondary.TabIndex = 1
        Me.GroupBoxSoldierSecondary.TabStop = False
        Me.GroupBoxSoldierSecondary.Text = "Secondary"
        '
        'SoldierHideBison
        '
        Me.SoldierHideBison.AccessibleName = "SoldierHideBison"
        Me.SoldierHideBison.AutoSize = True
        Me.SoldierHideBison.Location = New System.Drawing.Point(6, 65)
        Me.SoldierHideBison.Name = "SoldierHideBison"
        Me.SoldierHideBison.Size = New System.Drawing.Size(77, 17)
        Me.SoldierHideBison.TabIndex = 7
        Me.SoldierHideBison.Text = "Hide Bison"
        Me.ViewmodelTooltip.SetToolTip(Me.SoldierHideBison, "Righteous Bison")
        Me.SoldierHideBison.UseVisualStyleBackColor = True
        '
        'SoldierHideShotguns
        '
        Me.SoldierHideShotguns.AccessibleName = "SoldierHideShotguns"
        Me.SoldierHideShotguns.AutoSize = True
        Me.SoldierHideShotguns.Location = New System.Drawing.Point(6, 19)
        Me.SoldierHideShotguns.Name = "SoldierHideShotguns"
        Me.SoldierHideShotguns.Size = New System.Drawing.Size(96, 17)
        Me.SoldierHideShotguns.TabIndex = 4
        Me.SoldierHideShotguns.Text = "Hide Shotguns"
        Me.ViewmodelTooltip.SetToolTip(Me.SoldierHideShotguns, "Shotgun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reserve Shooter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Panic Attack")
        Me.SoldierHideShotguns.UseVisualStyleBackColor = True
        '
        'SoldierHideBanners
        '
        Me.SoldierHideBanners.AccessibleName = "SoldierHideBanners"
        Me.SoldierHideBanners.AutoSize = True
        Me.SoldierHideBanners.Location = New System.Drawing.Point(6, 42)
        Me.SoldierHideBanners.Name = "SoldierHideBanners"
        Me.SoldierHideBanners.Size = New System.Drawing.Size(90, 17)
        Me.SoldierHideBanners.TabIndex = 6
        Me.SoldierHideBanners.Text = "Hide Banners"
        Me.ViewmodelTooltip.SetToolTip(Me.SoldierHideBanners, "Buff Banner" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Battalion's Backup" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Concheror")
        Me.SoldierHideBanners.UseMnemonic = False
        Me.SoldierHideBanners.UseVisualStyleBackColor = True
        '
        'SoldierHideSecondaryInspect
        '
        Me.SoldierHideSecondaryInspect.AccessibleName = "SoldierHideSecondaryInspect"
        Me.SoldierHideSecondaryInspect.AutoSize = True
        Me.SoldierHideSecondaryInspect.Location = New System.Drawing.Point(6, 88)
        Me.SoldierHideSecondaryInspect.Name = "SoldierHideSecondaryInspect"
        Me.SoldierHideSecondaryInspect.Size = New System.Drawing.Size(145, 17)
        Me.SoldierHideSecondaryInspect.TabIndex = 5
        Me.SoldierHideSecondaryInspect.Text = "Hide Secondary Inspects"
        Me.SoldierHideSecondaryInspect.UseVisualStyleBackColor = True
        '
        'GroupBoxSoldierPrimary
        '
        Me.GroupBoxSoldierPrimary.AccessibleName = "GroupBoxSoldierPrimary"
        Me.GroupBoxSoldierPrimary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSoldierPrimary.AutoSize = True
        Me.GroupBoxSoldierPrimary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxSoldierPrimary.Controls.Add(Me.BtnOriginalInfo)
        Me.GroupBoxSoldierPrimary.Controls.Add(Me.SoldierHideMangler)
        Me.GroupBoxSoldierPrimary.Controls.Add(Me.SoldierHideOriginal)
        Me.GroupBoxSoldierPrimary.Controls.Add(Me.SoldierHidePrimaryInspect)
        Me.GroupBoxSoldierPrimary.Controls.Add(Me.SoldierHideRockets)
        Me.GroupBoxSoldierPrimary.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxSoldierPrimary.Name = "GroupBoxSoldierPrimary"
        Me.GroupBoxSoldierPrimary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxSoldierPrimary.TabIndex = 0
        Me.GroupBoxSoldierPrimary.TabStop = False
        Me.GroupBoxSoldierPrimary.Text = "Primary"
        '
        'BtnOriginalInfo
        '
        Me.BtnOriginalInfo.AccessibleName = "BtnOriginalInfo"
        Me.BtnOriginalInfo.FlatAppearance.BorderSize = 0
        Me.BtnOriginalInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnOriginalInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnOriginalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOriginalInfo.Location = New System.Drawing.Point(98, 38)
        Me.BtnOriginalInfo.Name = "BtnOriginalInfo"
        Me.BtnOriginalInfo.Size = New System.Drawing.Size(47, 23)
        Me.BtnOriginalInfo.TabIndex = 4
        Me.BtnOriginalInfo.Text = "?"
        Me.ViewmodelTooltip.SetToolTip(Me.BtnOriginalInfo, "Due to an animation bug, the Original is always" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hidden if any other Soldier weap" &
        "ons are hidden." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.BtnOriginalInfo.UseVisualStyleBackColor = True
        '
        'SoldierHideMangler
        '
        Me.SoldierHideMangler.AccessibleName = "SoldierHideMangler"
        Me.SoldierHideMangler.AutoSize = True
        Me.SoldierHideMangler.Location = New System.Drawing.Point(6, 137)
        Me.SoldierHideMangler.Name = "SoldierHideMangler"
        Me.SoldierHideMangler.Size = New System.Drawing.Size(113, 17)
        Me.SoldierHideMangler.TabIndex = 3
        Me.SoldierHideMangler.Text = "Hide Cow Mangler"
        Me.SoldierHideMangler.UseVisualStyleBackColor = True
        Me.SoldierHideMangler.Visible = False
        '
        'SoldierHideOriginal
        '
        Me.SoldierHideOriginal.AccessibleName = "SoldierHideOriginal"
        Me.SoldierHideOriginal.AutoSize = True
        Me.SoldierHideOriginal.Checked = True
        Me.SoldierHideOriginal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SoldierHideOriginal.Enabled = False
        Me.SoldierHideOriginal.Location = New System.Drawing.Point(6, 42)
        Me.SoldierHideOriginal.Name = "SoldierHideOriginal"
        Me.SoldierHideOriginal.Size = New System.Drawing.Size(86, 17)
        Me.SoldierHideOriginal.TabIndex = 2
        Me.SoldierHideOriginal.Text = "Hide Original"
        Me.SoldierHideOriginal.UseMnemonic = False
        Me.SoldierHideOriginal.UseVisualStyleBackColor = True
        '
        'SoldierHidePrimaryInspect
        '
        Me.SoldierHidePrimaryInspect.AccessibleName = "SoldierHidePrimaryInspect"
        Me.SoldierHidePrimaryInspect.AutoSize = True
        Me.SoldierHidePrimaryInspect.Location = New System.Drawing.Point(6, 65)
        Me.SoldierHidePrimaryInspect.Name = "SoldierHidePrimaryInspect"
        Me.SoldierHidePrimaryInspect.Size = New System.Drawing.Size(128, 17)
        Me.SoldierHidePrimaryInspect.TabIndex = 1
        Me.SoldierHidePrimaryInspect.Text = "Hide Primary Inspects"
        Me.SoldierHidePrimaryInspect.UseVisualStyleBackColor = True
        '
        'SoldierHideRockets
        '
        Me.SoldierHideRockets.AccessibleName = "SoldierHideRockets"
        Me.SoldierHideRockets.AutoSize = True
        Me.SoldierHideRockets.Location = New System.Drawing.Point(6, 19)
        Me.SoldierHideRockets.Name = "SoldierHideRockets"
        Me.SoldierHideRockets.Size = New System.Drawing.Size(139, 17)
        Me.SoldierHideRockets.TabIndex = 0
        Me.SoldierHideRockets.Text = "Hide Rocket Launchers"
        Me.ViewmodelTooltip.SetToolTip(Me.SoldierHideRockets, "Rocket Launcher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Direct Hit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Black Box" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rocket Jumper" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Liberty Launcher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cow Mang" &
        "ler 5000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Beggar's Bazooka" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Air Strike")
        Me.SoldierHideRockets.UseVisualStyleBackColor = True
        '
        'Demoman
        '
        Me.Demoman.Controls.Add(Me.TableLayoutPanel4)
        Me.Demoman.ImageIndex = 0
        Me.Demoman.Location = New System.Drawing.Point(4, 25)
        Me.Demoman.Name = "Demoman"
        Me.Demoman.Size = New System.Drawing.Size(593, 175)
        Me.Demoman.TabIndex = 3
        Me.Demoman.Text = "Demoman"
        Me.Demoman.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBoxDemoMelee, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBoxDemoSecondary, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBoxDemoPrimary, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(581, 163)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'GroupBoxDemoMelee
        '
        Me.GroupBoxDemoMelee.AccessibleName = "GroupBoxDemoMelee"
        Me.GroupBoxDemoMelee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDemoMelee.AutoSize = True
        Me.GroupBoxDemoMelee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxDemoMelee.Controls.Add(Me.DemomanHideMelee)
        Me.GroupBoxDemoMelee.Location = New System.Drawing.Point(389, 3)
        Me.GroupBoxDemoMelee.Name = "GroupBoxDemoMelee"
        Me.GroupBoxDemoMelee.Size = New System.Drawing.Size(189, 157)
        Me.GroupBoxDemoMelee.TabIndex = 1
        Me.GroupBoxDemoMelee.TabStop = False
        Me.GroupBoxDemoMelee.Text = "Melee"
        '
        'DemomanHideMelee
        '
        Me.DemomanHideMelee.AccessibleName = "DemomanHideMelee"
        Me.DemomanHideMelee.AutoSize = True
        Me.DemomanHideMelee.Location = New System.Drawing.Point(6, 19)
        Me.DemomanHideMelee.Name = "DemomanHideMelee"
        Me.DemomanHideMelee.Size = New System.Drawing.Size(80, 17)
        Me.DemomanHideMelee.TabIndex = 8
        Me.DemomanHideMelee.Text = "Hide Melee"
        Me.DemomanHideMelee.UseVisualStyleBackColor = True
        '
        'GroupBoxDemoSecondary
        '
        Me.GroupBoxDemoSecondary.AccessibleName = "GroupBoxDemoSecondary"
        Me.GroupBoxDemoSecondary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDemoSecondary.AutoSize = True
        Me.GroupBoxDemoSecondary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxDemoSecondary.Controls.Add(Me.DemomanHideStickybombs)
        Me.GroupBoxDemoSecondary.Controls.Add(Me.DemomanHideSecondaryInspect)
        Me.GroupBoxDemoSecondary.Location = New System.Drawing.Point(196, 3)
        Me.GroupBoxDemoSecondary.Name = "GroupBoxDemoSecondary"
        Me.GroupBoxDemoSecondary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxDemoSecondary.TabIndex = 1
        Me.GroupBoxDemoSecondary.TabStop = False
        Me.GroupBoxDemoSecondary.Text = "Secondary"
        '
        'DemomanHideStickybombs
        '
        Me.DemomanHideStickybombs.AccessibleName = "DemomanHideStickybombs"
        Me.DemomanHideStickybombs.AutoSize = True
        Me.DemomanHideStickybombs.Location = New System.Drawing.Point(6, 19)
        Me.DemomanHideStickybombs.Name = "DemomanHideStickybombs"
        Me.DemomanHideStickybombs.Size = New System.Drawing.Size(159, 17)
        Me.DemomanHideStickybombs.TabIndex = 4
        Me.DemomanHideStickybombs.Text = "Hide Stickybomb Launchers"
        Me.ViewmodelTooltip.SetToolTip(Me.DemomanHideStickybombs, "Stickybomb Launcher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Scottish Resistance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sticky Jumper" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quickiebomb Launcher")
        Me.DemomanHideStickybombs.UseVisualStyleBackColor = True
        '
        'DemomanHideSecondaryInspect
        '
        Me.DemomanHideSecondaryInspect.AccessibleName = "DemomanHideSecondaryInspect"
        Me.DemomanHideSecondaryInspect.AutoSize = True
        Me.DemomanHideSecondaryInspect.Location = New System.Drawing.Point(6, 42)
        Me.DemomanHideSecondaryInspect.Name = "DemomanHideSecondaryInspect"
        Me.DemomanHideSecondaryInspect.Size = New System.Drawing.Size(145, 17)
        Me.DemomanHideSecondaryInspect.TabIndex = 5
        Me.DemomanHideSecondaryInspect.Text = "Hide Secondary Inspects"
        Me.DemomanHideSecondaryInspect.UseVisualStyleBackColor = True
        '
        'GroupBoxDemoPrimary
        '
        Me.GroupBoxDemoPrimary.AccessibleName = "GroupBoxDemoPrimary"
        Me.GroupBoxDemoPrimary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDemoPrimary.AutoSize = True
        Me.GroupBoxDemoPrimary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxDemoPrimary.Controls.Add(Me.DemomanHidePrimaryInspect)
        Me.GroupBoxDemoPrimary.Controls.Add(Me.DemomanHideGrenades)
        Me.GroupBoxDemoPrimary.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxDemoPrimary.Name = "GroupBoxDemoPrimary"
        Me.GroupBoxDemoPrimary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxDemoPrimary.TabIndex = 0
        Me.GroupBoxDemoPrimary.TabStop = False
        Me.GroupBoxDemoPrimary.Text = "Primary"
        '
        'DemomanHidePrimaryInspect
        '
        Me.DemomanHidePrimaryInspect.AccessibleName = "DemomanHidePrimaryInspect"
        Me.DemomanHidePrimaryInspect.AutoSize = True
        Me.DemomanHidePrimaryInspect.Location = New System.Drawing.Point(6, 42)
        Me.DemomanHidePrimaryInspect.Name = "DemomanHidePrimaryInspect"
        Me.DemomanHidePrimaryInspect.Size = New System.Drawing.Size(128, 17)
        Me.DemomanHidePrimaryInspect.TabIndex = 1
        Me.DemomanHidePrimaryInspect.Text = "Hide Primary Inspects"
        Me.DemomanHidePrimaryInspect.UseVisualStyleBackColor = True
        '
        'DemomanHideGrenades
        '
        Me.DemomanHideGrenades.AccessibleName = "DemomanHideGrenades"
        Me.DemomanHideGrenades.AutoSize = True
        Me.DemomanHideGrenades.Location = New System.Drawing.Point(6, 19)
        Me.DemomanHideGrenades.Name = "DemomanHideGrenades"
        Me.DemomanHideGrenades.Size = New System.Drawing.Size(145, 17)
        Me.DemomanHideGrenades.TabIndex = 0
        Me.DemomanHideGrenades.Text = "Hide Grenade Launchers"
        Me.ViewmodelTooltip.SetToolTip(Me.DemomanHideGrenades, "Grenade Launcher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loch-n-Load" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loose Cannon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Iron Bomber")
        Me.DemomanHideGrenades.UseVisualStyleBackColor = True
        '
        'Medic
        '
        Me.Medic.Controls.Add(Me.TableLayoutPanel5)
        Me.Medic.ImageIndex = 3
        Me.Medic.Location = New System.Drawing.Point(4, 25)
        Me.Medic.Name = "Medic"
        Me.Medic.Size = New System.Drawing.Size(593, 175)
        Me.Medic.TabIndex = 4
        Me.Medic.Text = "Medic"
        Me.Medic.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBoxMedicMelee, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBoxMedicSecondary, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBoxMedicPrimary, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(581, 163)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'GroupBoxMedicMelee
        '
        Me.GroupBoxMedicMelee.AccessibleName = "GroupBoxMedicMelee"
        Me.GroupBoxMedicMelee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxMedicMelee.AutoSize = True
        Me.GroupBoxMedicMelee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxMedicMelee.Controls.Add(Me.MedicHideMelee)
        Me.GroupBoxMedicMelee.Location = New System.Drawing.Point(389, 3)
        Me.GroupBoxMedicMelee.Name = "GroupBoxMedicMelee"
        Me.GroupBoxMedicMelee.Size = New System.Drawing.Size(189, 157)
        Me.GroupBoxMedicMelee.TabIndex = 1
        Me.GroupBoxMedicMelee.TabStop = False
        Me.GroupBoxMedicMelee.Text = "Melee"
        '
        'MedicHideMelee
        '
        Me.MedicHideMelee.AccessibleName = "MedicHideMelee"
        Me.MedicHideMelee.AutoSize = True
        Me.MedicHideMelee.Location = New System.Drawing.Point(6, 19)
        Me.MedicHideMelee.Name = "MedicHideMelee"
        Me.MedicHideMelee.Size = New System.Drawing.Size(80, 17)
        Me.MedicHideMelee.TabIndex = 8
        Me.MedicHideMelee.Text = "Hide Melee"
        Me.MedicHideMelee.UseVisualStyleBackColor = True
        '
        'GroupBoxMedicSecondary
        '
        Me.GroupBoxMedicSecondary.AccessibleName = "GroupBoxMedicSecondary"
        Me.GroupBoxMedicSecondary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxMedicSecondary.AutoSize = True
        Me.GroupBoxMedicSecondary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxMedicSecondary.Controls.Add(Me.MedicHideMediguns)
        Me.GroupBoxMedicSecondary.Controls.Add(Me.MedicHideSecondaryInspect)
        Me.GroupBoxMedicSecondary.Location = New System.Drawing.Point(196, 3)
        Me.GroupBoxMedicSecondary.Name = "GroupBoxMedicSecondary"
        Me.GroupBoxMedicSecondary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxMedicSecondary.TabIndex = 1
        Me.GroupBoxMedicSecondary.TabStop = False
        Me.GroupBoxMedicSecondary.Text = "Secondary"
        '
        'MedicHideMediguns
        '
        Me.MedicHideMediguns.AccessibleName = "MedicHideMediguns"
        Me.MedicHideMediguns.AutoSize = True
        Me.MedicHideMediguns.Location = New System.Drawing.Point(6, 19)
        Me.MedicHideMediguns.Name = "MedicHideMediguns"
        Me.MedicHideMediguns.Size = New System.Drawing.Size(97, 17)
        Me.MedicHideMediguns.TabIndex = 4
        Me.MedicHideMediguns.Text = "Hide Mediguns"
        Me.ViewmodelTooltip.SetToolTip(Me.MedicHideMediguns, "Medi Gun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kritzkrieg" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quick-Fix" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vaccinator")
        Me.MedicHideMediguns.UseVisualStyleBackColor = True
        '
        'MedicHideSecondaryInspect
        '
        Me.MedicHideSecondaryInspect.AccessibleName = "MedicHideSecondaryInspect"
        Me.MedicHideSecondaryInspect.AutoSize = True
        Me.MedicHideSecondaryInspect.Location = New System.Drawing.Point(6, 42)
        Me.MedicHideSecondaryInspect.Name = "MedicHideSecondaryInspect"
        Me.MedicHideSecondaryInspect.Size = New System.Drawing.Size(145, 17)
        Me.MedicHideSecondaryInspect.TabIndex = 5
        Me.MedicHideSecondaryInspect.Text = "Hide Secondary Inspects"
        Me.MedicHideSecondaryInspect.UseVisualStyleBackColor = True
        '
        'GroupBoxMedicPrimary
        '
        Me.GroupBoxMedicPrimary.AccessibleName = "GroupBoxMedicPrimary"
        Me.GroupBoxMedicPrimary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxMedicPrimary.AutoSize = True
        Me.GroupBoxMedicPrimary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxMedicPrimary.Controls.Add(Me.MedicHidePrimaryInspect)
        Me.GroupBoxMedicPrimary.Controls.Add(Me.MedicHidePrimaries)
        Me.GroupBoxMedicPrimary.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxMedicPrimary.Name = "GroupBoxMedicPrimary"
        Me.GroupBoxMedicPrimary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxMedicPrimary.TabIndex = 0
        Me.GroupBoxMedicPrimary.TabStop = False
        Me.GroupBoxMedicPrimary.Text = "Primary"
        '
        'MedicHidePrimaryInspect
        '
        Me.MedicHidePrimaryInspect.AccessibleName = "MedicHidePrimaryInspect"
        Me.MedicHidePrimaryInspect.AutoSize = True
        Me.MedicHidePrimaryInspect.Location = New System.Drawing.Point(6, 42)
        Me.MedicHidePrimaryInspect.Name = "MedicHidePrimaryInspect"
        Me.MedicHidePrimaryInspect.Size = New System.Drawing.Size(128, 17)
        Me.MedicHidePrimaryInspect.TabIndex = 1
        Me.MedicHidePrimaryInspect.Text = "Hide Primary Inspects"
        Me.MedicHidePrimaryInspect.UseVisualStyleBackColor = True
        Me.MedicHidePrimaryInspect.Visible = False
        '
        'MedicHidePrimaries
        '
        Me.MedicHidePrimaries.AccessibleName = "MedicHidePrimaries"
        Me.MedicHidePrimaries.AutoSize = True
        Me.MedicHidePrimaries.Location = New System.Drawing.Point(6, 19)
        Me.MedicHidePrimaries.Name = "MedicHidePrimaries"
        Me.MedicHidePrimaries.Size = New System.Drawing.Size(93, 17)
        Me.MedicHidePrimaries.TabIndex = 0
        Me.MedicHidePrimaries.Text = "Hide Primaries"
        Me.ViewmodelTooltip.SetToolTip(Me.MedicHidePrimaries, "Syringe Gun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Blutsauger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Crusader's Crossbow" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Overdose")
        Me.MedicHidePrimaries.UseVisualStyleBackColor = True
        '
        'Heavy
        '
        Me.Heavy.Controls.Add(Me.TableLayoutPanel6)
        Me.Heavy.ImageIndex = 2
        Me.Heavy.Location = New System.Drawing.Point(4, 25)
        Me.Heavy.Name = "Heavy"
        Me.Heavy.Size = New System.Drawing.Size(593, 175)
        Me.Heavy.TabIndex = 6
        Me.Heavy.Text = "Heavy"
        Me.Heavy.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBoxHeavyMelee, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBoxHeavySecondary, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBoxHeavyPrimary, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(581, 163)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'GroupBoxHeavyMelee
        '
        Me.GroupBoxHeavyMelee.AccessibleName = "GroupBoxHeavyMelee"
        Me.GroupBoxHeavyMelee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxHeavyMelee.AutoSize = True
        Me.GroupBoxHeavyMelee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxHeavyMelee.Controls.Add(Me.HeavyHideMelee)
        Me.GroupBoxHeavyMelee.Location = New System.Drawing.Point(389, 3)
        Me.GroupBoxHeavyMelee.Name = "GroupBoxHeavyMelee"
        Me.GroupBoxHeavyMelee.Size = New System.Drawing.Size(189, 157)
        Me.GroupBoxHeavyMelee.TabIndex = 1
        Me.GroupBoxHeavyMelee.TabStop = False
        Me.GroupBoxHeavyMelee.Text = "Melee"
        '
        'HeavyHideMelee
        '
        Me.HeavyHideMelee.AccessibleName = "HeavyHideMelee"
        Me.HeavyHideMelee.AutoSize = True
        Me.HeavyHideMelee.Location = New System.Drawing.Point(6, 19)
        Me.HeavyHideMelee.Name = "HeavyHideMelee"
        Me.HeavyHideMelee.Size = New System.Drawing.Size(80, 17)
        Me.HeavyHideMelee.TabIndex = 8
        Me.HeavyHideMelee.Text = "Hide Melee"
        Me.HeavyHideMelee.UseVisualStyleBackColor = True
        '
        'GroupBoxHeavySecondary
        '
        Me.GroupBoxHeavySecondary.AccessibleName = "GroupBoxHeavySecondary"
        Me.GroupBoxHeavySecondary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxHeavySecondary.AutoSize = True
        Me.GroupBoxHeavySecondary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxHeavySecondary.Controls.Add(Me.HeavyHideShotguns)
        Me.GroupBoxHeavySecondary.Controls.Add(Me.HeavyHideConsumables)
        Me.GroupBoxHeavySecondary.Controls.Add(Me.HeavyHideSecondaryInspect)
        Me.GroupBoxHeavySecondary.Location = New System.Drawing.Point(196, 3)
        Me.GroupBoxHeavySecondary.Name = "GroupBoxHeavySecondary"
        Me.GroupBoxHeavySecondary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxHeavySecondary.TabIndex = 1
        Me.GroupBoxHeavySecondary.TabStop = False
        Me.GroupBoxHeavySecondary.Text = "Secondary"
        '
        'HeavyHideShotguns
        '
        Me.HeavyHideShotguns.AccessibleName = "HeavyHideShotguns"
        Me.HeavyHideShotguns.AutoSize = True
        Me.HeavyHideShotguns.Location = New System.Drawing.Point(6, 19)
        Me.HeavyHideShotguns.Name = "HeavyHideShotguns"
        Me.HeavyHideShotguns.Size = New System.Drawing.Size(96, 17)
        Me.HeavyHideShotguns.TabIndex = 4
        Me.HeavyHideShotguns.Text = "Hide Shotguns"
        Me.ViewmodelTooltip.SetToolTip(Me.HeavyHideShotguns, "Shotgun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Family Business" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Panic Attack")
        Me.HeavyHideShotguns.UseVisualStyleBackColor = True
        '
        'HeavyHideConsumables
        '
        Me.HeavyHideConsumables.AccessibleName = "HeavyHideConsumables"
        Me.HeavyHideConsumables.AutoSize = True
        Me.HeavyHideConsumables.Location = New System.Drawing.Point(6, 42)
        Me.HeavyHideConsumables.Name = "HeavyHideConsumables"
        Me.HeavyHideConsumables.Size = New System.Drawing.Size(114, 17)
        Me.HeavyHideConsumables.TabIndex = 6
        Me.HeavyHideConsumables.Text = "Hide Consumables"
        Me.ViewmodelTooltip.SetToolTip(Me.HeavyHideConsumables, "Sandvich" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dalokohs Bar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Buffalo Steak Sandvich")
        Me.HeavyHideConsumables.UseMnemonic = False
        Me.HeavyHideConsumables.UseVisualStyleBackColor = True
        '
        'HeavyHideSecondaryInspect
        '
        Me.HeavyHideSecondaryInspect.AccessibleName = "HeavyHideSecondaryInspect"
        Me.HeavyHideSecondaryInspect.AutoSize = True
        Me.HeavyHideSecondaryInspect.Location = New System.Drawing.Point(6, 65)
        Me.HeavyHideSecondaryInspect.Name = "HeavyHideSecondaryInspect"
        Me.HeavyHideSecondaryInspect.Size = New System.Drawing.Size(145, 17)
        Me.HeavyHideSecondaryInspect.TabIndex = 5
        Me.HeavyHideSecondaryInspect.Text = "Hide Secondary Inspects"
        Me.HeavyHideSecondaryInspect.UseVisualStyleBackColor = True
        '
        'GroupBoxHeavyPrimary
        '
        Me.GroupBoxHeavyPrimary.AccessibleName = "GroupBoxHeavyPrimary"
        Me.GroupBoxHeavyPrimary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxHeavyPrimary.AutoSize = True
        Me.GroupBoxHeavyPrimary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxHeavyPrimary.Controls.Add(Me.HeavyHidePrimaryInspect)
        Me.GroupBoxHeavyPrimary.Controls.Add(Me.HeavyHideMiniguns)
        Me.GroupBoxHeavyPrimary.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxHeavyPrimary.Name = "GroupBoxHeavyPrimary"
        Me.GroupBoxHeavyPrimary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxHeavyPrimary.TabIndex = 0
        Me.GroupBoxHeavyPrimary.TabStop = False
        Me.GroupBoxHeavyPrimary.Text = "Primary"
        '
        'HeavyHidePrimaryInspect
        '
        Me.HeavyHidePrimaryInspect.AccessibleName = "HeavyHidePrimaryInspect"
        Me.HeavyHidePrimaryInspect.AutoSize = True
        Me.HeavyHidePrimaryInspect.Location = New System.Drawing.Point(6, 42)
        Me.HeavyHidePrimaryInspect.Name = "HeavyHidePrimaryInspect"
        Me.HeavyHidePrimaryInspect.Size = New System.Drawing.Size(128, 17)
        Me.HeavyHidePrimaryInspect.TabIndex = 1
        Me.HeavyHidePrimaryInspect.Text = "Hide Primary Inspects"
        Me.HeavyHidePrimaryInspect.UseVisualStyleBackColor = True
        '
        'HeavyHideMiniguns
        '
        Me.HeavyHideMiniguns.AccessibleName = "HeavyHideMiniguns"
        Me.HeavyHideMiniguns.AutoSize = True
        Me.HeavyHideMiniguns.Location = New System.Drawing.Point(6, 19)
        Me.HeavyHideMiniguns.Name = "HeavyHideMiniguns"
        Me.HeavyHideMiniguns.Size = New System.Drawing.Size(93, 17)
        Me.HeavyHideMiniguns.TabIndex = 0
        Me.HeavyHideMiniguns.Text = "Hide Miniguns"
        Me.ViewmodelTooltip.SetToolTip(Me.HeavyHideMiniguns, "Minigun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Natascha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Brass Beast" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tomislav" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Huo-Long Heater")
        Me.HeavyHideMiniguns.UseVisualStyleBackColor = True
        '
        'Pyro
        '
        Me.Pyro.Controls.Add(Me.TableLayoutPanel7)
        Me.Pyro.ImageIndex = 4
        Me.Pyro.Location = New System.Drawing.Point(4, 25)
        Me.Pyro.Name = "Pyro"
        Me.Pyro.Size = New System.Drawing.Size(593, 175)
        Me.Pyro.TabIndex = 7
        Me.Pyro.Text = "Pyro"
        Me.Pyro.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBoxPyroMelee, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBoxPyroSecondary, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBoxPyroPrimary, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(581, 163)
        Me.TableLayoutPanel7.TabIndex = 2
        '
        'GroupBoxPyroMelee
        '
        Me.GroupBoxPyroMelee.AccessibleName = "GroupBoxPyroMelee"
        Me.GroupBoxPyroMelee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxPyroMelee.AutoSize = True
        Me.GroupBoxPyroMelee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxPyroMelee.Controls.Add(Me.PyroHideMelee)
        Me.GroupBoxPyroMelee.Location = New System.Drawing.Point(389, 3)
        Me.GroupBoxPyroMelee.Name = "GroupBoxPyroMelee"
        Me.GroupBoxPyroMelee.Size = New System.Drawing.Size(189, 157)
        Me.GroupBoxPyroMelee.TabIndex = 1
        Me.GroupBoxPyroMelee.TabStop = False
        Me.GroupBoxPyroMelee.Text = "Melee"
        '
        'PyroHideMelee
        '
        Me.PyroHideMelee.AccessibleName = "PyroHideMelee"
        Me.PyroHideMelee.AutoSize = True
        Me.PyroHideMelee.Location = New System.Drawing.Point(6, 19)
        Me.PyroHideMelee.Name = "PyroHideMelee"
        Me.PyroHideMelee.Size = New System.Drawing.Size(80, 17)
        Me.PyroHideMelee.TabIndex = 8
        Me.PyroHideMelee.Text = "Hide Melee"
        Me.PyroHideMelee.UseVisualStyleBackColor = True
        '
        'GroupBoxPyroSecondary
        '
        Me.GroupBoxPyroSecondary.AccessibleName = "GroupBoxPyroSecondary"
        Me.GroupBoxPyroSecondary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxPyroSecondary.AutoSize = True
        Me.GroupBoxPyroSecondary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxPyroSecondary.Controls.Add(Me.PyroHideShotguns)
        Me.GroupBoxPyroSecondary.Controls.Add(Me.PyroHideFlareGuns)
        Me.GroupBoxPyroSecondary.Controls.Add(Me.PyroHideThermalThruster)
        Me.GroupBoxPyroSecondary.Controls.Add(Me.PyroHideGasPasser)
        Me.GroupBoxPyroSecondary.Controls.Add(Me.PyroHideSecondaryInspect)
        Me.GroupBoxPyroSecondary.Location = New System.Drawing.Point(196, 3)
        Me.GroupBoxPyroSecondary.Name = "GroupBoxPyroSecondary"
        Me.GroupBoxPyroSecondary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxPyroSecondary.TabIndex = 1
        Me.GroupBoxPyroSecondary.TabStop = False
        Me.GroupBoxPyroSecondary.Text = "Secondary"
        '
        'PyroHideShotguns
        '
        Me.PyroHideShotguns.AccessibleName = "PyroHideShotguns"
        Me.PyroHideShotguns.AutoSize = True
        Me.PyroHideShotguns.Location = New System.Drawing.Point(6, 19)
        Me.PyroHideShotguns.Name = "PyroHideShotguns"
        Me.PyroHideShotguns.Size = New System.Drawing.Size(96, 17)
        Me.PyroHideShotguns.TabIndex = 4
        Me.PyroHideShotguns.Text = "Hide Shotguns"
        Me.ViewmodelTooltip.SetToolTip(Me.PyroHideShotguns, "Shotgun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reserve Shooter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Panic Attack")
        Me.PyroHideShotguns.UseVisualStyleBackColor = True
        '
        'PyroHideFlareGuns
        '
        Me.PyroHideFlareGuns.AccessibleName = "PyroHideFlareGuns"
        Me.PyroHideFlareGuns.AutoSize = True
        Me.PyroHideFlareGuns.Location = New System.Drawing.Point(6, 42)
        Me.PyroHideFlareGuns.Name = "PyroHideFlareGuns"
        Me.PyroHideFlareGuns.Size = New System.Drawing.Size(102, 17)
        Me.PyroHideFlareGuns.TabIndex = 6
        Me.PyroHideFlareGuns.Text = "Hide Flare Guns"
        Me.ViewmodelTooltip.SetToolTip(Me.PyroHideFlareGuns, "Flare Gun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Detonator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Manmelter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Scorch Shot")
        Me.PyroHideFlareGuns.UseMnemonic = False
        Me.PyroHideFlareGuns.UseVisualStyleBackColor = True
        '
        'PyroHideThermalThruster
        '
        Me.PyroHideThermalThruster.AccessibleName = "PyroHideThermalThruster"
        Me.PyroHideThermalThruster.AutoSize = True
        Me.PyroHideThermalThruster.Location = New System.Drawing.Point(6, 65)
        Me.PyroHideThermalThruster.Name = "PyroHideThermalThruster"
        Me.PyroHideThermalThruster.Size = New System.Drawing.Size(131, 17)
        Me.PyroHideThermalThruster.TabIndex = 6
        Me.PyroHideThermalThruster.Text = "Hide Thermal Thruster"
        Me.PyroHideThermalThruster.UseMnemonic = False
        Me.PyroHideThermalThruster.UseVisualStyleBackColor = True
        '
        'PyroHideGasPasser
        '
        Me.PyroHideGasPasser.AccessibleName = "PyroHideGasPasser"
        Me.PyroHideGasPasser.AutoSize = True
        Me.PyroHideGasPasser.Location = New System.Drawing.Point(6, 88)
        Me.PyroHideGasPasser.Name = "PyroHideGasPasser"
        Me.PyroHideGasPasser.Size = New System.Drawing.Size(105, 17)
        Me.PyroHideGasPasser.TabIndex = 6
        Me.PyroHideGasPasser.Text = "Hide Gas Passer"
        Me.PyroHideGasPasser.UseMnemonic = False
        Me.PyroHideGasPasser.UseVisualStyleBackColor = True
        '
        'PyroHideSecondaryInspect
        '
        Me.PyroHideSecondaryInspect.AccessibleName = "PyroHideSecondaryInspect"
        Me.PyroHideSecondaryInspect.AutoSize = True
        Me.PyroHideSecondaryInspect.Location = New System.Drawing.Point(6, 111)
        Me.PyroHideSecondaryInspect.Name = "PyroHideSecondaryInspect"
        Me.PyroHideSecondaryInspect.Size = New System.Drawing.Size(145, 17)
        Me.PyroHideSecondaryInspect.TabIndex = 5
        Me.PyroHideSecondaryInspect.Text = "Hide Secondary Inspects"
        Me.PyroHideSecondaryInspect.UseVisualStyleBackColor = True
        '
        'GroupBoxPyroPrimary
        '
        Me.GroupBoxPyroPrimary.AccessibleName = "GroupBoxPyroPrimary"
        Me.GroupBoxPyroPrimary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxPyroPrimary.AutoSize = True
        Me.GroupBoxPyroPrimary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxPyroPrimary.Controls.Add(Me.PyroHidePrimaryInspect)
        Me.GroupBoxPyroPrimary.Controls.Add(Me.PyroHideFlamethrowers)
        Me.GroupBoxPyroPrimary.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxPyroPrimary.Name = "GroupBoxPyroPrimary"
        Me.GroupBoxPyroPrimary.Size = New System.Drawing.Size(187, 157)
        Me.GroupBoxPyroPrimary.TabIndex = 0
        Me.GroupBoxPyroPrimary.TabStop = False
        Me.GroupBoxPyroPrimary.Text = "Primary"
        '
        'PyroHidePrimaryInspect
        '
        Me.PyroHidePrimaryInspect.AccessibleName = "PyroHidePrimaryInspect"
        Me.PyroHidePrimaryInspect.AutoSize = True
        Me.PyroHidePrimaryInspect.Location = New System.Drawing.Point(6, 42)
        Me.PyroHidePrimaryInspect.Name = "PyroHidePrimaryInspect"
        Me.PyroHidePrimaryInspect.Size = New System.Drawing.Size(128, 17)
        Me.PyroHidePrimaryInspect.TabIndex = 1
        Me.PyroHidePrimaryInspect.Text = "Hide Primary Inspects"
        Me.PyroHidePrimaryInspect.UseVisualStyleBackColor = True
        '
        'PyroHideFlamethrowers
        '
        Me.PyroHideFlamethrowers.AccessibleName = "PyroHideFlamethrowers"
        Me.PyroHideFlamethrowers.AutoSize = True
        Me.PyroHideFlamethrowers.Location = New System.Drawing.Point(6, 19)
        Me.PyroHideFlamethrowers.Name = "PyroHideFlamethrowers"
        Me.PyroHideFlamethrowers.Size = New System.Drawing.Size(119, 17)
        Me.PyroHideFlamethrowers.TabIndex = 0
        Me.PyroHideFlamethrowers.Text = "Hide Flamethrowers"
        Me.ViewmodelTooltip.SetToolTip(Me.PyroHideFlamethrowers, "Flame Thrower" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Backburner" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Degreaser" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Phlogistinator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dragon's Fury")
        Me.PyroHideFlamethrowers.UseVisualStyleBackColor = True
        '
        'Spy
        '
        Me.Spy.Controls.Add(Me.TableLayoutPanel10)
        Me.Spy.ImageIndex = 8
        Me.Spy.Location = New System.Drawing.Point(4, 25)
        Me.Spy.Name = "Spy"
        Me.Spy.Size = New System.Drawing.Size(593, 175)
        Me.Spy.TabIndex = 8
        Me.Spy.Text = "Spy"
        Me.Spy.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.GroupBoxSpyPDA, 0, 1)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(587, 169)
        Me.TableLayoutPanel10.TabIndex = 2
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.Controls.Add(Me.GroupBoxSpyPrimary, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.GroupBoxSpyMelee, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.GroupBoxSpySecondary, 1, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(581, 70)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'GroupBoxSpyPrimary
        '
        Me.GroupBoxSpyPrimary.AccessibleName = "GroupBoxSpyPrimary"
        Me.GroupBoxSpyPrimary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSpyPrimary.AutoSize = True
        Me.GroupBoxSpyPrimary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxSpyPrimary.Controls.Add(Me.SpyHidePrimaryInspect)
        Me.GroupBoxSpyPrimary.Controls.Add(Me.SpyHideRevolvers)
        Me.GroupBoxSpyPrimary.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxSpyPrimary.Name = "GroupBoxSpyPrimary"
        Me.GroupBoxSpyPrimary.Size = New System.Drawing.Size(187, 64)
        Me.GroupBoxSpyPrimary.TabIndex = 0
        Me.GroupBoxSpyPrimary.TabStop = False
        Me.GroupBoxSpyPrimary.Text = "Primary"
        '
        'SpyHidePrimaryInspect
        '
        Me.SpyHidePrimaryInspect.AccessibleName = "SpyHidePrimaryInspect"
        Me.SpyHidePrimaryInspect.AutoSize = True
        Me.SpyHidePrimaryInspect.Location = New System.Drawing.Point(6, 42)
        Me.SpyHidePrimaryInspect.Name = "SpyHidePrimaryInspect"
        Me.SpyHidePrimaryInspect.Size = New System.Drawing.Size(128, 17)
        Me.SpyHidePrimaryInspect.TabIndex = 5
        Me.SpyHidePrimaryInspect.Text = "Hide Primary Inspects"
        Me.SpyHidePrimaryInspect.UseVisualStyleBackColor = True
        '
        'SpyHideRevolvers
        '
        Me.SpyHideRevolvers.AccessibleName = "SpyHideRevolvers"
        Me.SpyHideRevolvers.AutoSize = True
        Me.SpyHideRevolvers.Location = New System.Drawing.Point(6, 19)
        Me.SpyHideRevolvers.Name = "SpyHideRevolvers"
        Me.SpyHideRevolvers.Size = New System.Drawing.Size(99, 17)
        Me.SpyHideRevolvers.TabIndex = 4
        Me.SpyHideRevolvers.Text = "Hide Revolvers"
        Me.ViewmodelTooltip.SetToolTip(Me.SpyHideRevolvers, "Revolver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ambassador" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L'Etranger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enforcer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Diamondback")
        Me.SpyHideRevolvers.UseVisualStyleBackColor = True
        '
        'GroupBoxSpyMelee
        '
        Me.GroupBoxSpyMelee.AccessibleName = "GroupBoxSpyMelee"
        Me.GroupBoxSpyMelee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSpyMelee.AutoSize = True
        Me.GroupBoxSpyMelee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxSpyMelee.Controls.Add(Me.SpyHideMeleeInspect)
        Me.GroupBoxSpyMelee.Controls.Add(Me.SpyHideMelee)
        Me.GroupBoxSpyMelee.Location = New System.Drawing.Point(389, 3)
        Me.GroupBoxSpyMelee.Name = "GroupBoxSpyMelee"
        Me.GroupBoxSpyMelee.Size = New System.Drawing.Size(189, 64)
        Me.GroupBoxSpyMelee.TabIndex = 1
        Me.GroupBoxSpyMelee.TabStop = False
        Me.GroupBoxSpyMelee.Text = "Melee"
        '
        'SpyHideMeleeInspect
        '
        Me.SpyHideMeleeInspect.AccessibleName = "SpyHideMeleeInspect"
        Me.SpyHideMeleeInspect.AutoSize = True
        Me.SpyHideMeleeInspect.Location = New System.Drawing.Point(6, 42)
        Me.SpyHideMeleeInspect.Name = "SpyHideMeleeInspect"
        Me.SpyHideMeleeInspect.Size = New System.Drawing.Size(123, 17)
        Me.SpyHideMeleeInspect.TabIndex = 10
        Me.SpyHideMeleeInspect.Text = "Hide Melee Inspects"
        Me.SpyHideMeleeInspect.UseVisualStyleBackColor = True
        '
        'SpyHideMelee
        '
        Me.SpyHideMelee.AccessibleName = "SpyHideMelee"
        Me.SpyHideMelee.AutoSize = True
        Me.SpyHideMelee.Location = New System.Drawing.Point(6, 19)
        Me.SpyHideMelee.Name = "SpyHideMelee"
        Me.SpyHideMelee.Size = New System.Drawing.Size(80, 17)
        Me.SpyHideMelee.TabIndex = 12
        Me.SpyHideMelee.Text = "Hide Melee"
        Me.ViewmodelTooltip.SetToolTip(Me.SpyHideMelee, "Knife" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your Eternal Reward" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conniver's Kunai" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Big Earner" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spy-cicle")
        Me.SpyHideMelee.UseVisualStyleBackColor = True
        '
        'GroupBoxSpySecondary
        '
        Me.GroupBoxSpySecondary.AccessibleName = "GroupBoxSpySecondary"
        Me.GroupBoxSpySecondary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSpySecondary.AutoSize = True
        Me.GroupBoxSpySecondary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxSpySecondary.Controls.Add(Me.SpyHideSappers)
        Me.GroupBoxSpySecondary.Location = New System.Drawing.Point(196, 3)
        Me.GroupBoxSpySecondary.Name = "GroupBoxSpySecondary"
        Me.GroupBoxSpySecondary.Size = New System.Drawing.Size(187, 64)
        Me.GroupBoxSpySecondary.TabIndex = 1
        Me.GroupBoxSpySecondary.TabStop = False
        Me.GroupBoxSpySecondary.Text = "Secondary"
        '
        'SpyHideSappers
        '
        Me.SpyHideSappers.AccessibleName = "SpyHideSappers"
        Me.SpyHideSappers.AutoSize = True
        Me.SpyHideSappers.Location = New System.Drawing.Point(6, 19)
        Me.SpyHideSappers.Name = "SpyHideSappers"
        Me.SpyHideSappers.Size = New System.Drawing.Size(90, 17)
        Me.SpyHideSappers.TabIndex = 8
        Me.SpyHideSappers.Text = "Hide Sappers"
        Me.ViewmodelTooltip.SetToolTip(Me.SpyHideSappers, "Sapper" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Red-Tape Recorder")
        Me.SpyHideSappers.UseVisualStyleBackColor = True
        '
        'GroupBoxSpyPDA
        '
        Me.GroupBoxSpyPDA.AccessibleName = "GroupBoxSpyPDA"
        Me.GroupBoxSpyPDA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSpyPDA.AutoSize = True
        Me.GroupBoxSpyPDA.Controls.Add(Me.Button2)
        Me.GroupBoxSpyPDA.Controls.Add(Me.SpyHideDisguiseKit)
        Me.GroupBoxSpyPDA.Controls.Add(Me.SpyHideDeadRinger)
        Me.GroupBoxSpyPDA.Controls.Add(Me.SpyHideInvisWatch)
        Me.GroupBoxSpyPDA.Location = New System.Drawing.Point(3, 79)
        Me.GroupBoxSpyPDA.Name = "GroupBoxSpyPDA"
        Me.GroupBoxSpyPDA.Size = New System.Drawing.Size(581, 87)
        Me.GroupBoxSpyPDA.TabIndex = 2
        Me.GroupBoxSpyPDA.TabStop = False
        Me.GroupBoxSpyPDA.Text = "PDA"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(134, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 78)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "?"
        Me.ViewmodelTooltip.SetToolTip(Me.Button2, "Due to the complexity of the Spy's animation files, these are always shown." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In a" &
        " future release, these might become hideable.")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SpyHideDisguiseKit
        '
        Me.SpyHideDisguiseKit.AutoSize = True
        Me.SpyHideDisguiseKit.Enabled = False
        Me.SpyHideDisguiseKit.Location = New System.Drawing.Point(9, 65)
        Me.SpyHideDisguiseKit.Name = "SpyHideDisguiseKit"
        Me.SpyHideDisguiseKit.Size = New System.Drawing.Size(106, 17)
        Me.SpyHideDisguiseKit.TabIndex = 14
        Me.SpyHideDisguiseKit.Text = "Hide Disguise Kit"
        Me.SpyHideDisguiseKit.UseVisualStyleBackColor = True
        '
        'SpyHideDeadRinger
        '
        Me.SpyHideDeadRinger.AutoSize = True
        Me.SpyHideDeadRinger.Enabled = False
        Me.SpyHideDeadRinger.Location = New System.Drawing.Point(9, 42)
        Me.SpyHideDeadRinger.Name = "SpyHideDeadRinger"
        Me.SpyHideDeadRinger.Size = New System.Drawing.Size(111, 17)
        Me.SpyHideDeadRinger.TabIndex = 13
        Me.SpyHideDeadRinger.Text = "Hide Dead Ringer"
        Me.SpyHideDeadRinger.UseVisualStyleBackColor = True
        '
        'SpyHideInvisWatch
        '
        Me.SpyHideInvisWatch.AutoSize = True
        Me.SpyHideInvisWatch.Enabled = False
        Me.SpyHideInvisWatch.Location = New System.Drawing.Point(9, 19)
        Me.SpyHideInvisWatch.Name = "SpyHideInvisWatch"
        Me.SpyHideInvisWatch.Size = New System.Drawing.Size(119, 17)
        Me.SpyHideInvisWatch.TabIndex = 12
        Me.SpyHideInvisWatch.Text = "Hide Invis Watches"
        Me.ViewmodelTooltip.SetToolTip(Me.SpyHideInvisWatch, "Invis Watch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cloak and Dagger")
        Me.SpyHideInvisWatch.UseVisualStyleBackColor = True
        '
        'Engineer
        '
        Me.Engineer.Controls.Add(Me.TableLayoutPanel9)
        Me.Engineer.ImageIndex = 1
        Me.Engineer.Location = New System.Drawing.Point(4, 25)
        Me.Engineer.Name = "Engineer"
        Me.Engineer.Size = New System.Drawing.Size(593, 175)
        Me.Engineer.TabIndex = 5
        Me.Engineer.Text = "Engineer"
        Me.Engineer.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel11, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.GroupBoxEngineerPDA, 0, 1)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(587, 169)
        Me.TableLayoutPanel9.TabIndex = 3
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel11.ColumnCount = 3
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.Controls.Add(Me.GroupBoxEngineerPrimary, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.GroupBoxEngineerMelee, 2, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.GroupBoxEngineerSecondary, 1, 0)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(581, 93)
        Me.TableLayoutPanel11.TabIndex = 1
        '
        'GroupBoxEngineerPrimary
        '
        Me.GroupBoxEngineerPrimary.AccessibleName = "GroupBoxEngineerPrimary"
        Me.GroupBoxEngineerPrimary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxEngineerPrimary.AutoSize = True
        Me.GroupBoxEngineerPrimary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxEngineerPrimary.Controls.Add(Me.EngineerHidePomson)
        Me.GroupBoxEngineerPrimary.Controls.Add(Me.EngineerHidePrimaryInspect)
        Me.GroupBoxEngineerPrimary.Controls.Add(Me.EngineerHideShotguns)
        Me.GroupBoxEngineerPrimary.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxEngineerPrimary.Name = "GroupBoxEngineerPrimary"
        Me.GroupBoxEngineerPrimary.Size = New System.Drawing.Size(187, 87)
        Me.GroupBoxEngineerPrimary.TabIndex = 0
        Me.GroupBoxEngineerPrimary.TabStop = False
        Me.GroupBoxEngineerPrimary.Text = "Primary"
        '
        'EngineerHidePomson
        '
        Me.EngineerHidePomson.AccessibleName = "EngineerHidePomson"
        Me.EngineerHidePomson.AutoSize = True
        Me.EngineerHidePomson.Location = New System.Drawing.Point(6, 42)
        Me.EngineerHidePomson.Name = "EngineerHidePomson"
        Me.EngineerHidePomson.Size = New System.Drawing.Size(89, 17)
        Me.EngineerHidePomson.TabIndex = 6
        Me.EngineerHidePomson.Text = "Hide Pomson"
        Me.ViewmodelTooltip.SetToolTip(Me.EngineerHidePomson, "Pomson 6000")
        Me.EngineerHidePomson.UseMnemonic = False
        Me.EngineerHidePomson.UseVisualStyleBackColor = True
        '
        'EngineerHidePrimaryInspect
        '
        Me.EngineerHidePrimaryInspect.AccessibleName = "EngineerHidePrimaryInspect"
        Me.EngineerHidePrimaryInspect.AutoSize = True
        Me.EngineerHidePrimaryInspect.Location = New System.Drawing.Point(6, 65)
        Me.EngineerHidePrimaryInspect.Name = "EngineerHidePrimaryInspect"
        Me.EngineerHidePrimaryInspect.Size = New System.Drawing.Size(128, 17)
        Me.EngineerHidePrimaryInspect.TabIndex = 5
        Me.EngineerHidePrimaryInspect.Text = "Hide Primary Inspects"
        Me.EngineerHidePrimaryInspect.UseVisualStyleBackColor = True
        '
        'EngineerHideShotguns
        '
        Me.EngineerHideShotguns.AccessibleName = "EngineerHideShotguns"
        Me.EngineerHideShotguns.AutoSize = True
        Me.EngineerHideShotguns.Location = New System.Drawing.Point(6, 19)
        Me.EngineerHideShotguns.Name = "EngineerHideShotguns"
        Me.EngineerHideShotguns.Size = New System.Drawing.Size(96, 17)
        Me.EngineerHideShotguns.TabIndex = 4
        Me.EngineerHideShotguns.Text = "Hide Shotguns"
        Me.ViewmodelTooltip.SetToolTip(Me.EngineerHideShotguns, "Shotgun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Frontier Justice" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Widowmaker" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rescue Ranger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Panic Attack")
        Me.EngineerHideShotguns.UseVisualStyleBackColor = True
        '
        'GroupBoxEngineerMelee
        '
        Me.GroupBoxEngineerMelee.AccessibleName = "GroupBoxEngineerMelee"
        Me.GroupBoxEngineerMelee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxEngineerMelee.AutoSize = True
        Me.GroupBoxEngineerMelee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxEngineerMelee.Controls.Add(Me.EngineerHideGunslinger)
        Me.GroupBoxEngineerMelee.Controls.Add(Me.EngineerHideMeleeInspect)
        Me.GroupBoxEngineerMelee.Controls.Add(Me.EngineerHideWrenches)
        Me.GroupBoxEngineerMelee.Location = New System.Drawing.Point(389, 3)
        Me.GroupBoxEngineerMelee.Name = "GroupBoxEngineerMelee"
        Me.GroupBoxEngineerMelee.Size = New System.Drawing.Size(189, 87)
        Me.GroupBoxEngineerMelee.TabIndex = 1
        Me.GroupBoxEngineerMelee.TabStop = False
        Me.GroupBoxEngineerMelee.Text = "Melee"
        '
        'EngineerHideGunslinger
        '
        Me.EngineerHideGunslinger.AccessibleName = "EngineerHideGunslinger"
        Me.EngineerHideGunslinger.AutoSize = True
        Me.EngineerHideGunslinger.Location = New System.Drawing.Point(6, 42)
        Me.EngineerHideGunslinger.Name = "EngineerHideGunslinger"
        Me.EngineerHideGunslinger.Size = New System.Drawing.Size(101, 17)
        Me.EngineerHideGunslinger.TabIndex = 16
        Me.EngineerHideGunslinger.Text = "Hide Gunslinger"
        Me.EngineerHideGunslinger.UseVisualStyleBackColor = True
        '
        'EngineerHideMeleeInspect
        '
        Me.EngineerHideMeleeInspect.AccessibleName = "EngineerHideMeleeInspect"
        Me.EngineerHideMeleeInspect.AutoSize = True
        Me.EngineerHideMeleeInspect.Location = New System.Drawing.Point(6, 65)
        Me.EngineerHideMeleeInspect.Name = "EngineerHideMeleeInspect"
        Me.EngineerHideMeleeInspect.Size = New System.Drawing.Size(123, 17)
        Me.EngineerHideMeleeInspect.TabIndex = 15
        Me.EngineerHideMeleeInspect.Text = "Hide Melee Inspects"
        Me.EngineerHideMeleeInspect.UseVisualStyleBackColor = True
        '
        'EngineerHideWrenches
        '
        Me.EngineerHideWrenches.AccessibleName = "EngineerHideWrenches"
        Me.EngineerHideWrenches.AutoSize = True
        Me.EngineerHideWrenches.Location = New System.Drawing.Point(6, 19)
        Me.EngineerHideWrenches.Name = "EngineerHideWrenches"
        Me.EngineerHideWrenches.Size = New System.Drawing.Size(100, 17)
        Me.EngineerHideWrenches.TabIndex = 12
        Me.EngineerHideWrenches.Text = "Hide Wrenches"
        Me.ViewmodelTooltip.SetToolTip(Me.EngineerHideWrenches, "Wrench" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Southern Hospitality" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jag" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Eureka Effect")
        Me.EngineerHideWrenches.UseVisualStyleBackColor = True
        '
        'GroupBoxEngineerSecondary
        '
        Me.GroupBoxEngineerSecondary.AccessibleName = "GroupBoxEngineerSecondary"
        Me.GroupBoxEngineerSecondary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxEngineerSecondary.AutoSize = True
        Me.GroupBoxEngineerSecondary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxEngineerSecondary.Controls.Add(Me.EngineerHideShortCircuit)
        Me.GroupBoxEngineerSecondary.Controls.Add(Me.EngineerHidePistols)
        Me.GroupBoxEngineerSecondary.Controls.Add(Me.EngineerHideWrangler)
        Me.GroupBoxEngineerSecondary.Controls.Add(Me.EngineerHideSecondaryInspect)
        Me.GroupBoxEngineerSecondary.Location = New System.Drawing.Point(196, 3)
        Me.GroupBoxEngineerSecondary.Name = "GroupBoxEngineerSecondary"
        Me.GroupBoxEngineerSecondary.Size = New System.Drawing.Size(187, 87)
        Me.GroupBoxEngineerSecondary.TabIndex = 1
        Me.GroupBoxEngineerSecondary.TabStop = False
        Me.GroupBoxEngineerSecondary.Text = "Secondary"
        '
        'EngineerHideShortCircuit
        '
        Me.EngineerHideShortCircuit.AutoSize = True
        Me.EngineerHideShortCircuit.Location = New System.Drawing.Point(6, 88)
        Me.EngineerHideShortCircuit.Name = "EngineerHideShortCircuit"
        Me.EngineerHideShortCircuit.Size = New System.Drawing.Size(108, 17)
        Me.EngineerHideShortCircuit.TabIndex = 11
        Me.EngineerHideShortCircuit.Text = "Hide Short Circuit"
        Me.EngineerHideShortCircuit.UseVisualStyleBackColor = True
        Me.EngineerHideShortCircuit.Visible = False
        '
        'EngineerHidePistols
        '
        Me.EngineerHidePistols.AccessibleName = "EngineerHidePistols"
        Me.EngineerHidePistols.AutoSize = True
        Me.EngineerHidePistols.Location = New System.Drawing.Point(6, 19)
        Me.EngineerHidePistols.Name = "EngineerHidePistols"
        Me.EngineerHidePistols.Size = New System.Drawing.Size(81, 17)
        Me.EngineerHidePistols.TabIndex = 8
        Me.EngineerHidePistols.Text = "Hide Pistols"
        Me.ViewmodelTooltip.SetToolTip(Me.EngineerHidePistols, "Pistol")
        Me.EngineerHidePistols.UseVisualStyleBackColor = True
        '
        'EngineerHideWrangler
        '
        Me.EngineerHideWrangler.AccessibleName = "EngineerHideWrangler"
        Me.EngineerHideWrangler.AutoSize = True
        Me.EngineerHideWrangler.Location = New System.Drawing.Point(6, 42)
        Me.EngineerHideWrangler.Name = "EngineerHideWrangler"
        Me.EngineerHideWrangler.Size = New System.Drawing.Size(94, 17)
        Me.EngineerHideWrangler.TabIndex = 10
        Me.EngineerHideWrangler.Text = "Hide Wrangler"
        Me.EngineerHideWrangler.UseMnemonic = False
        Me.EngineerHideWrangler.UseVisualStyleBackColor = True
        '
        'EngineerHideSecondaryInspect
        '
        Me.EngineerHideSecondaryInspect.AccessibleName = "EngineerHideSecondaryInspect"
        Me.EngineerHideSecondaryInspect.AutoSize = True
        Me.EngineerHideSecondaryInspect.Location = New System.Drawing.Point(6, 65)
        Me.EngineerHideSecondaryInspect.Name = "EngineerHideSecondaryInspect"
        Me.EngineerHideSecondaryInspect.Size = New System.Drawing.Size(145, 17)
        Me.EngineerHideSecondaryInspect.TabIndex = 9
        Me.EngineerHideSecondaryInspect.Text = "Hide Secondary Inspects"
        Me.EngineerHideSecondaryInspect.UseVisualStyleBackColor = True
        '
        'GroupBoxEngineerPDA
        '
        Me.GroupBoxEngineerPDA.AccessibleName = "GroupBoxEngineerPDA"
        Me.GroupBoxEngineerPDA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxEngineerPDA.AutoSize = True
        Me.GroupBoxEngineerPDA.Controls.Add(Me.EngineerHideToolbox)
        Me.GroupBoxEngineerPDA.Controls.Add(Me.EngineerHidePDA)
        Me.GroupBoxEngineerPDA.Location = New System.Drawing.Point(3, 102)
        Me.GroupBoxEngineerPDA.Name = "GroupBoxEngineerPDA"
        Me.GroupBoxEngineerPDA.Size = New System.Drawing.Size(581, 64)
        Me.GroupBoxEngineerPDA.TabIndex = 2
        Me.GroupBoxEngineerPDA.TabStop = False
        Me.GroupBoxEngineerPDA.Text = "PDA"
        '
        'EngineerHideToolbox
        '
        Me.EngineerHideToolbox.AccessibleName = "EngineerHideToolbox"
        Me.EngineerHideToolbox.AutoSize = True
        Me.EngineerHideToolbox.Location = New System.Drawing.Point(9, 42)
        Me.EngineerHideToolbox.Name = "EngineerHideToolbox"
        Me.EngineerHideToolbox.Size = New System.Drawing.Size(142, 17)
        Me.EngineerHideToolbox.TabIndex = 13
        Me.EngineerHideToolbox.Text = "Hide Toolbox Carry Anim"
        Me.ViewmodelTooltip.SetToolTip(Me.EngineerHideToolbox, "Appears when placing or carrying a building")
        Me.EngineerHideToolbox.UseVisualStyleBackColor = True
        '
        'EngineerHidePDA
        '
        Me.EngineerHidePDA.AccessibleName = "EngineerHidePDA"
        Me.EngineerHidePDA.AutoSize = True
        Me.EngineerHidePDA.Location = New System.Drawing.Point(9, 19)
        Me.EngineerHidePDA.Name = "EngineerHidePDA"
        Me.EngineerHidePDA.Size = New System.Drawing.Size(73, 17)
        Me.EngineerHidePDA.TabIndex = 12
        Me.EngineerHidePDA.Text = "Hide PDA"
        Me.ViewmodelTooltip.SetToolTip(Me.EngineerHidePDA, "Construction PDA (slot 4)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Destruction PDA (slot 5)")
        Me.EngineerHidePDA.UseVisualStyleBackColor = True
        '
        'ClassIconList
        '
        Me.ClassIconList.ImageStream = CType(resources.GetObject("ClassIconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ClassIconList.TransparentColor = System.Drawing.Color.Transparent
        Me.ClassIconList.Images.SetKeyName(0, "Leaderboard_class_demoman.png")
        Me.ClassIconList.Images.SetKeyName(1, "Leaderboard_class_engineer.png")
        Me.ClassIconList.Images.SetKeyName(2, "Leaderboard_class_heavy.png")
        Me.ClassIconList.Images.SetKeyName(3, "Leaderboard_class_medic.png")
        Me.ClassIconList.Images.SetKeyName(4, "Leaderboard_class_pyro.png")
        Me.ClassIconList.Images.SetKeyName(5, "Leaderboard_class_scout.png")
        Me.ClassIconList.Images.SetKeyName(6, "Leaderboard_class_sniper.png")
        Me.ClassIconList.Images.SetKeyName(7, "Leaderboard_class_soldier.png")
        Me.ClassIconList.Images.SetKeyName(8, "Leaderboard_class_spy.png")
        '
        'BtnInstall
        '
        Me.BtnInstall.AccessibleName = "BtnInstall"
        Me.BtnInstall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInstall.Enabled = False
        Me.BtnInstall.Location = New System.Drawing.Point(526, 563)
        Me.BtnInstall.Name = "BtnInstall"
        Me.BtnInstall.Size = New System.Drawing.Size(75, 23)
        Me.BtnInstall.TabIndex = 0
        Me.BtnInstall.Text = "Install"
        Me.BtnInstall.UseVisualStyleBackColor = True
        '
        'BtnSelectFolder
        '
        Me.BtnSelectFolder.AccessibleName = "BtnSelectFolder"
        Me.BtnSelectFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectFolder.Enabled = False
        Me.BtnSelectFolder.Location = New System.Drawing.Point(6, 563)
        Me.BtnSelectFolder.Name = "BtnSelectFolder"
        Me.BtnSelectFolder.Size = New System.Drawing.Size(175, 23)
        Me.BtnSelectFolder.TabIndex = 1
        Me.BtnSelectFolder.Text = "Select ""Team Fortress 2"" Folder"
        Me.ViewmodelTooltip.SetToolTip(Me.BtnSelectFolder, "test")
        Me.BtnSelectFolder.UseVisualStyleBackColor = True
        '
        'Manual
        '
        Me.Manual.Controls.Add(Me.TableLayoutPanel12)
        Me.Manual.Location = New System.Drawing.Point(4, 22)
        Me.Manual.Name = "Manual"
        Me.Manual.Padding = New System.Windows.Forms.Padding(3)
        Me.Manual.Size = New System.Drawing.Size(607, 588)
        Me.Manual.TabIndex = 1
        Me.Manual.Text = "Manual"
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.GroupBox30, 1, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.GroupBox31, 0, 0)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(659, 433)
        Me.TableLayoutPanel12.TabIndex = 4
        '
        'GroupBox30
        '
        Me.GroupBox30.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox30.Controls.Add(Me.OutputBox)
        Me.GroupBox30.Controls.Add(Me.SaveButton)
        Me.GroupBox30.Location = New System.Drawing.Point(332, 3)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(324, 427)
        Me.GroupBox30.TabIndex = 2
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "Output File"
        '
        'OutputBox
        '
        Me.OutputBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputBox.Location = New System.Drawing.Point(6, 77)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.Size = New System.Drawing.Size(312, 350)
        Me.OutputBox.TabIndex = 9
        Me.OutputBox.Text = ""
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(236, 45)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(82, 26)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "Save..."
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'GroupBox31
        '
        Me.GroupBox31.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox31.Controls.Add(Me.InputBox)
        Me.GroupBox31.Controls.Add(Me.LoadButton)
        Me.GroupBox31.Controls.Add(Me.RefreshButton)
        Me.GroupBox31.Controls.Add(Me.InputPath)
        Me.GroupBox31.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox31.Name = "GroupBox31"
        Me.GroupBox31.Size = New System.Drawing.Size(323, 427)
        Me.GroupBox31.TabIndex = 1
        Me.GroupBox31.TabStop = False
        Me.GroupBox31.Text = "Input File"
        '
        'InputBox
        '
        Me.InputBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputBox.Location = New System.Drawing.Point(6, 77)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(311, 350)
        Me.InputBox.TabIndex = 8
        Me.InputBox.Text = ""
        Me.InputBox.WordWrap = False
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(6, 45)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(82, 26)
        Me.LoadButton.TabIndex = 7
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshButton.Location = New System.Drawing.Point(235, 45)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(82, 26)
        Me.RefreshButton.TabIndex = 6
        Me.RefreshButton.Text = "Convert"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'InputPath
        '
        Me.InputPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputPath.Location = New System.Drawing.Point(6, 19)
        Me.InputPath.Name = "InputPath"
        Me.InputPath.Size = New System.Drawing.Size(311, 20)
        Me.InputPath.TabIndex = 0
        '
        'BtnAbout
        '
        Me.BtnAbout.AccessibleName = "BtnAbout"
        Me.BtnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAbout.FlatAppearance.BorderSize = 0
        Me.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAbout.Location = New System.Drawing.Point(544, 2)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(75, 23)
        Me.BtnAbout.TabIndex = 6
        Me.BtnAbout.Text = "About..."
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'BtnLaunchTF2
        '
        Me.BtnLaunchTF2.AccessibleName = "BtnLaunchTF2"
        Me.BtnLaunchTF2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLaunchTF2.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLaunchTF2.FlatAppearance.BorderSize = 0
        Me.BtnLaunchTF2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLaunchTF2.Location = New System.Drawing.Point(448, 2)
        Me.BtnLaunchTF2.Name = "BtnLaunchTF2"
        Me.BtnLaunchTF2.Size = New System.Drawing.Size(84, 23)
        Me.BtnLaunchTF2.TabIndex = 7
        Me.BtnLaunchTF2.Text = "Launch TF2"
        Me.BtnLaunchTF2.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AccessibleName = "MainForm"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 626)
        Me.Controls.Add(Me.BtnLaunchTF2)
        Me.Controls.Add(Me.BtnAbout)
        Me.Controls.Add(Me.TabControlMenus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(550, 360)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Competitive Viewmodel Installer"
        Me.TabControlMenus.ResumeLayout(False)
        Me.Advanced.ResumeLayout(False)
        Me.Advanced.PerformLayout()
        CType(Me.PictureBoxGuide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlClasses.ResumeLayout(False)
        Me.Scout.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBoxScoutMelee.ResumeLayout(False)
        Me.GroupBoxScoutMelee.PerformLayout()
        Me.GroupBoxScoutSecondary.ResumeLayout(False)
        Me.GroupBoxScoutSecondary.PerformLayout()
        Me.GroupBoxScoutPrimary.ResumeLayout(False)
        Me.GroupBoxScoutPrimary.PerformLayout()
        Me.Sniper.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBoxSniperMelee.ResumeLayout(False)
        Me.GroupBoxSniperMelee.PerformLayout()
        Me.GroupBoxSniperSecondary.ResumeLayout(False)
        Me.GroupBoxSniperSecondary.PerformLayout()
        Me.GroupBoxSniperPrimary.ResumeLayout(False)
        Me.GroupBoxSniperPrimary.PerformLayout()
        Me.Soldier.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBoxSoldierMelee.ResumeLayout(False)
        Me.GroupBoxSoldierMelee.PerformLayout()
        Me.GroupBoxSoldierSecondary.ResumeLayout(False)
        Me.GroupBoxSoldierSecondary.PerformLayout()
        Me.GroupBoxSoldierPrimary.ResumeLayout(False)
        Me.GroupBoxSoldierPrimary.PerformLayout()
        Me.Demoman.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBoxDemoMelee.ResumeLayout(False)
        Me.GroupBoxDemoMelee.PerformLayout()
        Me.GroupBoxDemoSecondary.ResumeLayout(False)
        Me.GroupBoxDemoSecondary.PerformLayout()
        Me.GroupBoxDemoPrimary.ResumeLayout(False)
        Me.GroupBoxDemoPrimary.PerformLayout()
        Me.Medic.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.GroupBoxMedicMelee.ResumeLayout(False)
        Me.GroupBoxMedicMelee.PerformLayout()
        Me.GroupBoxMedicSecondary.ResumeLayout(False)
        Me.GroupBoxMedicSecondary.PerformLayout()
        Me.GroupBoxMedicPrimary.ResumeLayout(False)
        Me.GroupBoxMedicPrimary.PerformLayout()
        Me.Heavy.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.GroupBoxHeavyMelee.ResumeLayout(False)
        Me.GroupBoxHeavyMelee.PerformLayout()
        Me.GroupBoxHeavySecondary.ResumeLayout(False)
        Me.GroupBoxHeavySecondary.PerformLayout()
        Me.GroupBoxHeavyPrimary.ResumeLayout(False)
        Me.GroupBoxHeavyPrimary.PerformLayout()
        Me.Pyro.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.GroupBoxPyroMelee.ResumeLayout(False)
        Me.GroupBoxPyroMelee.PerformLayout()
        Me.GroupBoxPyroSecondary.ResumeLayout(False)
        Me.GroupBoxPyroSecondary.PerformLayout()
        Me.GroupBoxPyroPrimary.ResumeLayout(False)
        Me.GroupBoxPyroPrimary.PerformLayout()
        Me.Spy.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.GroupBoxSpyPrimary.ResumeLayout(False)
        Me.GroupBoxSpyPrimary.PerformLayout()
        Me.GroupBoxSpyMelee.ResumeLayout(False)
        Me.GroupBoxSpyMelee.PerformLayout()
        Me.GroupBoxSpySecondary.ResumeLayout(False)
        Me.GroupBoxSpySecondary.PerformLayout()
        Me.GroupBoxSpyPDA.ResumeLayout(False)
        Me.GroupBoxSpyPDA.PerformLayout()
        Me.Engineer.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.GroupBoxEngineerPrimary.ResumeLayout(False)
        Me.GroupBoxEngineerPrimary.PerformLayout()
        Me.GroupBoxEngineerMelee.ResumeLayout(False)
        Me.GroupBoxEngineerMelee.PerformLayout()
        Me.GroupBoxEngineerSecondary.ResumeLayout(False)
        Me.GroupBoxEngineerSecondary.PerformLayout()
        Me.GroupBoxEngineerPDA.ResumeLayout(False)
        Me.GroupBoxEngineerPDA.PerformLayout()
        Me.Manual.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.GroupBox30.ResumeLayout(False)
        Me.GroupBox31.ResumeLayout(False)
        Me.GroupBox31.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Advanced As System.Windows.Forms.TabPage
    Friend WithEvents Manual As System.Windows.Forms.TabPage
    Friend WithEvents TabControlClasses As System.Windows.Forms.TabControl
    Friend WithEvents Scout As System.Windows.Forms.TabPage
    Friend WithEvents Soldier As System.Windows.Forms.TabPage
    Friend WithEvents Sniper As System.Windows.Forms.TabPage
    Friend WithEvents Demoman As System.Windows.Forms.TabPage
    Friend WithEvents Medic As System.Windows.Forms.TabPage
    Friend WithEvents Engineer As System.Windows.Forms.TabPage
    Friend WithEvents Heavy As System.Windows.Forms.TabPage
    Friend WithEvents Pyro As System.Windows.Forms.TabPage
    Friend WithEvents Spy As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnInstall As Button
    Friend WithEvents BtnSelectFolder As Button
    Friend WithEvents GroupBoxScoutPrimary As GroupBox
    Friend WithEvents GroupBoxScoutMelee As GroupBox
    Friend WithEvents GroupBoxScoutSecondary As GroupBox
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents GroupBoxSpyPrimary As GroupBox
    Friend WithEvents GroupBoxSpyMelee As GroupBox
    Friend WithEvents GroupBoxSpyPDA As GroupBox
    Friend WithEvents ScoutHideMelee As CheckBox
    Friend WithEvents ScoutHideDrinks As CheckBox
    Friend WithEvents ScoutHidePistols As CheckBox
    Friend WithEvents ScoutHideThrowables As CheckBox
    Friend WithEvents ScoutHideSecondaryInspect As CheckBox
    Friend WithEvents ScoutHideShortstopPush As CheckBox
    Friend WithEvents ScoutHideDoubleBarrels As CheckBox
    Friend WithEvents ScoutHidePrimaryInspect As CheckBox
    Friend WithEvents ScoutHideScatterguns As CheckBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBoxSniperMelee As GroupBox
    Friend WithEvents SniperHideMelee As CheckBox
    Friend WithEvents GroupBoxSniperSecondary As GroupBox
    Friend WithEvents SniperHideSMGs As CheckBox
    Friend WithEvents SniperHideThrowables As CheckBox
    Friend WithEvents SniperHideSecondaryInspect As CheckBox
    Friend WithEvents GroupBoxSniperPrimary As GroupBox
    Friend WithEvents SniperHideHuntsman As CheckBox
    Friend WithEvents SniperHidePrimaryInspect As CheckBox
    Friend WithEvents SniperHideRifles As CheckBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents GroupBoxSoldierMelee As GroupBox
    Friend WithEvents SoldierHideMelee As CheckBox
    Friend WithEvents GroupBoxSoldierSecondary As GroupBox
    Friend WithEvents SoldierHideBison As CheckBox
    Friend WithEvents SoldierHideShotguns As CheckBox
    Friend WithEvents SoldierHideBanners As CheckBox
    Friend WithEvents SoldierHideSecondaryInspect As CheckBox
    Friend WithEvents GroupBoxSoldierPrimary As GroupBox
    Friend WithEvents SoldierHideMangler As CheckBox
    Friend WithEvents SoldierHideOriginal As CheckBox
    Friend WithEvents SoldierHidePrimaryInspect As CheckBox
    Friend WithEvents SoldierHideRockets As CheckBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents GroupBoxDemoMelee As GroupBox
    Friend WithEvents DemomanHideMelee As CheckBox
    Friend WithEvents GroupBoxDemoSecondary As GroupBox
    Friend WithEvents DemomanHideStickybombs As CheckBox
    Friend WithEvents DemomanHideSecondaryInspect As CheckBox
    Friend WithEvents GroupBoxDemoPrimary As GroupBox
    Friend WithEvents DemomanHidePrimaryInspect As CheckBox
    Friend WithEvents DemomanHideGrenades As CheckBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents GroupBoxMedicMelee As GroupBox
    Friend WithEvents MedicHideMelee As CheckBox
    Friend WithEvents GroupBoxMedicSecondary As GroupBox
    Friend WithEvents MedicHideMediguns As CheckBox
    Friend WithEvents MedicHideSecondaryInspect As CheckBox
    Friend WithEvents GroupBoxMedicPrimary As GroupBox
    Friend WithEvents MedicHidePrimaryInspect As CheckBox
    Friend WithEvents MedicHidePrimaries As CheckBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents GroupBoxHeavyMelee As GroupBox
    Friend WithEvents HeavyHideMelee As CheckBox
    Friend WithEvents GroupBoxHeavySecondary As GroupBox
    Friend WithEvents HeavyHideShotguns As CheckBox
    Friend WithEvents HeavyHideConsumables As CheckBox
    Friend WithEvents HeavyHideSecondaryInspect As CheckBox
    Friend WithEvents GroupBoxHeavyPrimary As GroupBox
    Friend WithEvents HeavyHidePrimaryInspect As CheckBox
    Friend WithEvents HeavyHideMiniguns As CheckBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents GroupBoxPyroMelee As GroupBox
    Friend WithEvents PyroHideMelee As CheckBox
    Friend WithEvents GroupBoxPyroSecondary As GroupBox
    Friend WithEvents PyroHideShotguns As CheckBox
    Friend WithEvents PyroHideFlareGuns As CheckBox
    Friend WithEvents PyroHideThermalThruster As CheckBox
    Friend WithEvents PyroHideGasPasser As CheckBox
    Friend WithEvents PyroHideSecondaryInspect As CheckBox
    Friend WithEvents GroupBoxPyroPrimary As GroupBox
    Friend WithEvents PyroHidePrimaryInspect As CheckBox
    Friend WithEvents PyroHideFlamethrowers As CheckBox
    Friend WithEvents GroupBoxSpySecondary As GroupBox
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents GroupBox30 As GroupBox
    Private WithEvents OutputBox As RichTextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents GroupBox31 As GroupBox
    Friend WithEvents InputBox As RichTextBox
    Friend WithEvents LoadButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents InputPath As TextBox
    Friend WithEvents SpyHidePrimaryInspect As CheckBox
    Friend WithEvents SpyHideRevolvers As CheckBox
    Friend WithEvents SpyHideMeleeInspect As CheckBox
    Friend WithEvents SpyHideMelee As CheckBox
    Friend WithEvents SpyHideSappers As CheckBox
    Friend WithEvents SpyHideDisguiseKit As CheckBox
    Friend WithEvents SpyHideDeadRinger As CheckBox
    Friend WithEvents SpyHideInvisWatch As CheckBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents GroupBoxEngineerPrimary As GroupBox
    Friend WithEvents EngineerHidePomson As CheckBox
    Friend WithEvents EngineerHidePrimaryInspect As CheckBox
    Friend WithEvents EngineerHideShotguns As CheckBox
    Friend WithEvents GroupBoxEngineerMelee As GroupBox
    Friend WithEvents EngineerHideGunslinger As CheckBox
    Friend WithEvents EngineerHideMeleeInspect As CheckBox
    Friend WithEvents EngineerHideWrenches As CheckBox
    Friend WithEvents GroupBoxEngineerSecondary As GroupBox
    Friend WithEvents EngineerHideShortCircuit As CheckBox
    Friend WithEvents EngineerHidePistols As CheckBox
    Friend WithEvents EngineerHideWrangler As CheckBox
    Friend WithEvents EngineerHideSecondaryInspect As CheckBox
    Friend WithEvents GroupBoxEngineerPDA As GroupBox
    Friend WithEvents EngineerHideToolbox As CheckBox
    Friend WithEvents EngineerHidePDA As CheckBox
    Private WithEvents TabControlMenus As TabControl
    Friend WithEvents ScoutHideShortstop As CheckBox
    Friend WithEvents BtnUninstall As Button
    Friend WithEvents BtnAbout As Button
    Friend WithEvents ViewmodelTooltip As ToolTip
    Friend WithEvents PictureBoxGuide As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelPath As Label
    Friend WithEvents ClassIconList As ImageList
    Friend WithEvents BtnLaunchTF2 As Button
    Friend WithEvents CheckboxItemtest As CheckBox
    Friend WithEvents BtnOriginalInfo As Button
    Friend WithEvents Button2 As Button
End Class
