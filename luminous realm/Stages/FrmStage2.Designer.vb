<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStage2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStage2))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picPortal = New System.Windows.Forms.PictureBox()
        Me.picBench = New System.Windows.Forms.PictureBox()
        Me.picNoteLeft = New System.Windows.Forms.PictureBox()
        Me.picNoteBottom = New System.Windows.Forms.PictureBox()
        Me.picNoteRight = New System.Windows.Forms.PictureBox()
        Me.picNoteTop = New System.Windows.Forms.PictureBox()
        Me.picLeftDoor = New System.Windows.Forms.PictureBox()
        Me.picBottomDoor = New System.Windows.Forms.PictureBox()
        Me.picRightDoor = New System.Windows.Forms.PictureBox()
        Me.picTopDoor = New System.Windows.Forms.PictureBox()
        Me.picRoomTemplate = New System.Windows.Forms.PictureBox()
        Me.picCeremonyKey = New System.Windows.Forms.PictureBox()
        CType(Me.picPortal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBench, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNoteLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNoteBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNoteRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNoteTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoomTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCeremonyKey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'picPortal
        '
        Me.picPortal.BackColor = System.Drawing.Color.Transparent
        Me.picPortal.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.deactivated_portal
        Me.picPortal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPortal.Location = New System.Drawing.Point(599, 306)
        Me.picPortal.Name = "picPortal"
        Me.picPortal.Size = New System.Drawing.Size(165, 105)
        Me.picPortal.TabIndex = 14
        Me.picPortal.TabStop = False
        '
        'picBench
        '
        Me.picBench.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.desk
        Me.picBench.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBench.Location = New System.Drawing.Point(42, 32)
        Me.picBench.Name = "picBench"
        Me.picBench.Size = New System.Drawing.Size(261, 50)
        Me.picBench.TabIndex = 13
        Me.picBench.TabStop = False
        '
        'picNoteLeft
        '
        Me.picNoteLeft.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.noteboard
        Me.picNoteLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNoteLeft.Location = New System.Drawing.Point(33, 112)
        Me.picNoteLeft.Name = "picNoteLeft"
        Me.picNoteLeft.Size = New System.Drawing.Size(60, 60)
        Me.picNoteLeft.TabIndex = 12
        Me.picNoteLeft.TabStop = False
        '
        'picNoteBottom
        '
        Me.picNoteBottom.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.noteboard
        Me.picNoteBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNoteBottom.Location = New System.Drawing.Point(496, 352)
        Me.picNoteBottom.Name = "picNoteBottom"
        Me.picNoteBottom.Size = New System.Drawing.Size(60, 60)
        Me.picNoteBottom.TabIndex = 11
        Me.picNoteBottom.TabStop = False
        '
        'picNoteRight
        '
        Me.picNoteRight.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.noteboard
        Me.picNoteRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNoteRight.Location = New System.Drawing.Point(738, 112)
        Me.picNoteRight.Name = "picNoteRight"
        Me.picNoteRight.Size = New System.Drawing.Size(60, 60)
        Me.picNoteRight.TabIndex = 10
        Me.picNoteRight.TabStop = False
        '
        'picNoteTop
        '
        Me.picNoteTop.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.noteboard
        Me.picNoteTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNoteTop.Location = New System.Drawing.Point(496, 32)
        Me.picNoteTop.Name = "picNoteTop"
        Me.picNoteTop.Size = New System.Drawing.Size(60, 60)
        Me.picNoteTop.TabIndex = 9
        Me.picNoteTop.TabStop = False
        '
        'picLeftDoor
        '
        Me.picLeftDoor.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.door
        Me.picLeftDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLeftDoor.Location = New System.Drawing.Point(30, 180)
        Me.picLeftDoor.Name = "picLeftDoor"
        Me.picLeftDoor.Size = New System.Drawing.Size(30, 120)
        Me.picLeftDoor.TabIndex = 8
        Me.picLeftDoor.TabStop = False
        '
        'picBottomDoor
        '
        Me.picBottomDoor.BackColor = System.Drawing.Color.Transparent
        Me.picBottomDoor.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.gate_locked
        Me.picBottomDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBottomDoor.Location = New System.Drawing.Point(350, 380)
        Me.picBottomDoor.Name = "picBottomDoor"
        Me.picBottomDoor.Size = New System.Drawing.Size(120, 30)
        Me.picBottomDoor.TabIndex = 7
        Me.picBottomDoor.TabStop = False
        '
        'picRightDoor
        '
        Me.picRightDoor.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.door
        Me.picRightDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRightDoor.Location = New System.Drawing.Point(770, 180)
        Me.picRightDoor.Name = "picRightDoor"
        Me.picRightDoor.Size = New System.Drawing.Size(30, 120)
        Me.picRightDoor.TabIndex = 6
        Me.picRightDoor.TabStop = False
        '
        'picTopDoor
        '
        Me.picTopDoor.BackColor = System.Drawing.Color.Transparent
        Me.picTopDoor.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.gate_locked
        Me.picTopDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picTopDoor.Location = New System.Drawing.Point(350, 30)
        Me.picTopDoor.Name = "picTopDoor"
        Me.picTopDoor.Size = New System.Drawing.Size(120, 30)
        Me.picTopDoor.TabIndex = 5
        Me.picTopDoor.TabStop = False
        '
        'picRoomTemplate
        '
        Me.picRoomTemplate.BackColor = System.Drawing.Color.Transparent
        Me.picRoomTemplate.BackgroundImage = CType(resources.GetObject("picRoomTemplate.BackgroundImage"), System.Drawing.Image)
        Me.picRoomTemplate.Location = New System.Drawing.Point(0, 0)
        Me.picRoomTemplate.Name = "picRoomTemplate"
        Me.picRoomTemplate.Size = New System.Drawing.Size(832, 441)
        Me.picRoomTemplate.TabIndex = 4
        Me.picRoomTemplate.TabStop = False
        Me.picRoomTemplate.Tag = "design"
        Me.picRoomTemplate.Visible = False
        '
        'picCeremonyKey
        '
        Me.picCeremonyKey.BackColor = System.Drawing.Color.Transparent
        Me.picCeremonyKey.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.hall_of_sols_key
        Me.picCeremonyKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCeremonyKey.Location = New System.Drawing.Point(180, 55)
        Me.picCeremonyKey.Name = "picCeremonyKey"
        Me.picCeremonyKey.Size = New System.Drawing.Size(40, 15)
        Me.picCeremonyKey.TabIndex = 15
        Me.picCeremonyKey.TabStop = False
        '
        'FrmStage2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.stage2_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 441)
        Me.Controls.Add(Me.picCeremonyKey)
        Me.Controls.Add(Me.picPortal)
        Me.Controls.Add(Me.picBench)
        Me.Controls.Add(Me.picNoteLeft)
        Me.Controls.Add(Me.picNoteBottom)
        Me.Controls.Add(Me.picNoteRight)
        Me.Controls.Add(Me.picNoteTop)
        Me.Controls.Add(Me.picLeftDoor)
        Me.Controls.Add(Me.picBottomDoor)
        Me.Controls.Add(Me.picRightDoor)
        Me.Controls.Add(Me.picTopDoor)
        Me.Controls.Add(Me.picRoomTemplate)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmStage2"
        Me.Text = "Luminous Realm"
        CType(Me.picPortal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBench, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNoteLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNoteBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNoteRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNoteTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoomTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCeremonyKey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picRoomTemplate As PictureBox
    Friend WithEvents picTopDoor As PictureBox
    Friend WithEvents picRightDoor As PictureBox
    Friend WithEvents picBottomDoor As PictureBox
    Friend WithEvents picLeftDoor As PictureBox
    Friend WithEvents picNoteTop As PictureBox
    Friend WithEvents picNoteRight As PictureBox
    Friend WithEvents picNoteBottom As PictureBox
    Friend WithEvents picNoteLeft As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picBench As PictureBox
    Friend WithEvents picPortal As PictureBox
    Friend WithEvents picCeremonyKey As PictureBox
End Class
