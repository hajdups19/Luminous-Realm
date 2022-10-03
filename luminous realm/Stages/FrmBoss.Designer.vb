<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBoss
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBoss))
        Me.picPlatform = New System.Windows.Forms.PictureBox()
        Me.picRoomTemplate = New System.Windows.Forms.PictureBox()
        Me.picIlluminantDuke = New System.Windows.Forms.PictureBox()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.picHealth = New System.Windows.Forms.PictureBox()
        Me.picStamina = New System.Windows.Forms.PictureBox()
        Me.picHealthbar = New System.Windows.Forms.PictureBox()
        Me.picStaminabar = New System.Windows.Forms.PictureBox()
        Me.picBossbar = New System.Windows.Forms.PictureBox()
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoomTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIlluminantDuke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStamina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHealthbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStaminabar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBossbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlatform
        '
        Me.picPlatform.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.stage5_background
        Me.picPlatform.Location = New System.Drawing.Point(24, 388)
        Me.picPlatform.Name = "picPlatform"
        Me.picPlatform.Size = New System.Drawing.Size(786, 28)
        Me.picPlatform.TabIndex = 0
        Me.picPlatform.TabStop = False
        '
        'picRoomTemplate
        '
        Me.picRoomTemplate.BackColor = System.Drawing.Color.Transparent
        Me.picRoomTemplate.BackgroundImage = CType(resources.GetObject("picRoomTemplate.BackgroundImage"), System.Drawing.Image)
        Me.picRoomTemplate.Location = New System.Drawing.Point(0, 0)
        Me.picRoomTemplate.Name = "picRoomTemplate"
        Me.picRoomTemplate.Size = New System.Drawing.Size(832, 441)
        Me.picRoomTemplate.TabIndex = 6
        Me.picRoomTemplate.TabStop = False
        Me.picRoomTemplate.Tag = "design"
        Me.picRoomTemplate.Visible = False
        '
        'picIlluminantDuke
        '
        Me.picIlluminantDuke.BackColor = System.Drawing.Color.Transparent
        Me.picIlluminantDuke.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.Illuminant_Duke
        Me.picIlluminantDuke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picIlluminantDuke.Location = New System.Drawing.Point(355, 38)
        Me.picIlluminantDuke.Name = "picIlluminantDuke"
        Me.picIlluminantDuke.Size = New System.Drawing.Size(120, 120)
        Me.picIlluminantDuke.TabIndex = 7
        Me.picIlluminantDuke.TabStop = False
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.Transparent
        Me.picIcon.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.player_male_icon
        Me.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picIcon.Location = New System.Drawing.Point(24, 348)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(50, 50)
        Me.picIcon.TabIndex = 8
        Me.picIcon.TabStop = False
        '
        'picHealth
        '
        Me.picHealth.BackColor = System.Drawing.Color.Transparent
        Me.picHealth.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.health_icon
        Me.picHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picHealth.Location = New System.Drawing.Point(80, 348)
        Me.picHealth.Name = "picHealth"
        Me.picHealth.Size = New System.Drawing.Size(25, 25)
        Me.picHealth.TabIndex = 9
        Me.picHealth.TabStop = False
        '
        'picStamina
        '
        Me.picStamina.BackColor = System.Drawing.Color.Transparent
        Me.picStamina.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.stamina_icon
        Me.picStamina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picStamina.Location = New System.Drawing.Point(80, 373)
        Me.picStamina.Name = "picStamina"
        Me.picStamina.Size = New System.Drawing.Size(25, 25)
        Me.picStamina.TabIndex = 10
        Me.picStamina.TabStop = False
        '
        'picHealthbar
        '
        Me.picHealthbar.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.health_bar
        Me.picHealthbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHealthbar.Location = New System.Drawing.Point(111, 352)
        Me.picHealthbar.Name = "picHealthbar"
        Me.picHealthbar.Size = New System.Drawing.Size(100, 20)
        Me.picHealthbar.TabIndex = 11
        Me.picHealthbar.TabStop = False
        '
        'picStaminabar
        '
        Me.picStaminabar.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.stamina_bar
        Me.picStaminabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStaminabar.Location = New System.Drawing.Point(111, 377)
        Me.picStaminabar.Name = "picStaminabar"
        Me.picStaminabar.Size = New System.Drawing.Size(100, 20)
        Me.picStaminabar.TabIndex = 12
        Me.picStaminabar.TabStop = False
        '
        'picBossbar
        '
        Me.picBossbar.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.boss_bar
        Me.picBossbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBossbar.Location = New System.Drawing.Point(206, 12)
        Me.picBossbar.Name = "picBossbar"
        Me.picBossbar.Size = New System.Drawing.Size(400, 20)
        Me.picBossbar.TabIndex = 13
        Me.picBossbar.TabStop = False
        '
        'FrmBoss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.background_submenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 441)
        Me.Controls.Add(Me.picBossbar)
        Me.Controls.Add(Me.picStaminabar)
        Me.Controls.Add(Me.picHealthbar)
        Me.Controls.Add(Me.picStamina)
        Me.Controls.Add(Me.picHealth)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.picIlluminantDuke)
        Me.Controls.Add(Me.picPlatform)
        Me.Controls.Add(Me.picRoomTemplate)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBoss"
        Me.Text = "Luminous Realm"
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoomTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIlluminantDuke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStamina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHealthbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStaminabar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBossbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlatform As PictureBox
    Friend WithEvents picRoomTemplate As PictureBox
    Friend WithEvents picIlluminantDuke As PictureBox
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents picHealth As PictureBox
    Friend WithEvents picStamina As PictureBox
    Friend WithEvents picHealthbar As PictureBox
    Friend WithEvents picStaminabar As PictureBox
    Friend WithEvents picBossbar As PictureBox
End Class
