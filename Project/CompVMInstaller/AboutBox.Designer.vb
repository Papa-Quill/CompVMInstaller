<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelAppName = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.LabelLicense = New System.Windows.Forms.LinkLabel()
        Me.LabelForumLink = New System.Windows.Forms.LinkLabel()
        Me.LabelRequirements = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelVersion
        '
        Me.LabelVersion.AccessibleName = "LabelVersion"
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelVersion.Location = New System.Drawing.Point(64, 322)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(41, 15)
        Me.LabelVersion.TabIndex = 3
        Me.LabelVersion.Text = "Label3"
        '
        'LabelAppName
        '
        Me.LabelAppName.AccessibleName = "LabelAppName"
        Me.LabelAppName.AutoSize = True
        Me.LabelAppName.BackColor = System.Drawing.Color.Transparent
        Me.LabelAppName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAppName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelAppName.Location = New System.Drawing.Point(63, 286)
        Me.LabelAppName.Name = "LabelAppName"
        Me.LabelAppName.Size = New System.Drawing.Size(56, 21)
        Me.LabelAppName.TabIndex = 4
        Me.LabelAppName.Text = "Label1"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AccessibleName = "LabelCopyright"
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.BackColor = System.Drawing.Color.Transparent
        Me.LabelCopyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCopyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCopyright.Location = New System.Drawing.Point(64, 307)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(41, 15)
        Me.LabelCopyright.TabIndex = 5
        Me.LabelCopyright.Text = "Label2"
        '
        'LabelLicense
        '
        Me.LabelLicense.AccessibleName = "LabelLicense"
        Me.LabelLicense.AutoSize = True
        Me.LabelLicense.BackColor = System.Drawing.Color.Transparent
        Me.LabelLicense.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLicense.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelLicense.LinkArea = New System.Windows.Forms.LinkArea(57, 4)
        Me.LabelLicense.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LabelLicense.LinkColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelLicense.Location = New System.Drawing.Point(16, 368)
        Me.LabelLicense.Name = "LabelLicense"
        Me.LabelLicense.Size = New System.Drawing.Size(347, 21)
        Me.LabelLicense.TabIndex = 8
        Me.LabelLicense.TabStop = True
        Me.LabelLicense.Text = "This program is licensed under the GNU GPL v3, available here."
        Me.LabelLicense.UseCompatibleTextRendering = True
        '
        'LabelForumLink
        '
        Me.LabelForumLink.AccessibleName = "LabelForumLink"
        Me.LabelForumLink.AutoSize = True
        Me.LabelForumLink.BackColor = System.Drawing.Color.Transparent
        Me.LabelForumLink.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelForumLink.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelForumLink.LinkArea = New System.Windows.Forms.LinkArea(43, 33)
        Me.LabelForumLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LabelForumLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelForumLink.Location = New System.Drawing.Point(16, 347)
        Me.LabelForumLink.Name = "LabelForumLink"
        Me.LabelForumLink.Size = New System.Drawing.Size(422, 21)
        Me.LabelForumLink.TabIndex = 9
        Me.LabelForumLink.TabStop = True
        Me.LabelForumLink.Text = "This program is an installer for yttrium's hidden competitive TF2 viewmodels."
        Me.LabelForumLink.UseCompatibleTextRendering = True
        Me.LabelForumLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LabelRequirements
        '
        Me.LabelRequirements.AccessibleName = "LabelRequirements"
        Me.LabelRequirements.AutoSize = True
        Me.LabelRequirements.BackColor = System.Drawing.Color.Transparent
        Me.LabelRequirements.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRequirements.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelRequirements.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LabelRequirements.LinkColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelRequirements.Location = New System.Drawing.Point(16, 389)
        Me.LabelRequirements.Name = "LabelRequirements"
        Me.LabelRequirements.Size = New System.Drawing.Size(422, 37)
        Me.LabelRequirements.TabIndex = 10
        Me.LabelRequirements.Text = "This program is tightly integrated with Valve's vpk and studiomdl programs," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and " &
    "will not work without them, nor a valid Team Fortress 2 license."
        Me.LabelRequirements.UseCompatibleTextRendering = True
        Me.LabelRequirements.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CompVMInstaller.My.Resources.Resources.icon1
        Me.PictureBox2.InitialImage = Global.CompVMInstaller.My.Resources.Resources.icon1
        Me.PictureBox2.Location = New System.Drawing.Point(13, 288)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(480, 270)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'AboutBox1
        '
        Me.AccessibleName = "FormAbout"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(505, 434)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelRequirements)
        Me.Controls.Add(Me.LabelForumLink)
        Me.Controls.Add(Me.LabelLicense)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelCopyright)
        Me.Controls.Add(Me.LabelAppName)
        Me.Controls.Add(Me.LabelVersion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox1"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormAbout"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelAppName As Label
    Friend WithEvents LabelCopyright As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelLicense As LinkLabel
    Friend WithEvents LabelForumLink As LinkLabel
    Friend WithEvents LabelRequirements As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
End Class
