<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGame))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picAngelStatue = New System.Windows.Forms.PictureBox()
        Me.picComputer = New System.Windows.Forms.PictureBox()
        Me.picMonitor = New System.Windows.Forms.PictureBox()
        Me.picKeyboard = New System.Windows.Forms.PictureBox()
        Me.picDesk = New System.Windows.Forms.PictureBox()
        Me.picBookshelf = New System.Windows.Forms.PictureBox()
        Me.picBed = New System.Windows.Forms.PictureBox()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picRoomTemplate = New System.Windows.Forms.PictureBox()
        Me.picDoor = New System.Windows.Forms.PictureBox()
        Me.picGlasses = New System.Windows.Forms.PictureBox()
        Me.picNoteBoard = New System.Windows.Forms.PictureBox()
        Me.picDesk2 = New System.Windows.Forms.PictureBox()
        Me.tmrLeftDoubleClick = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRightDoubleClick = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picAngelStatue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKeyboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDesk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBookshelf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoomTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGlasses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNoteBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDesk2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'picAngelStatue
        '
        Me.picAngelStatue.BackColor = System.Drawing.Color.Transparent
        Me.picAngelStatue.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.angel_statue
        Me.picAngelStatue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAngelStatue.Location = New System.Drawing.Point(639, 282)
        Me.picAngelStatue.Name = "picAngelStatue"
        Me.picAngelStatue.Size = New System.Drawing.Size(160, 135)
        Me.picAngelStatue.TabIndex = 10
        Me.picAngelStatue.TabStop = False
        Me.picAngelStatue.Tag = "angel statue"
        '
        'picComputer
        '
        Me.picComputer.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.pc
        Me.picComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picComputer.Location = New System.Drawing.Point(775, 34)
        Me.picComputer.Name = "picComputer"
        Me.picComputer.Size = New System.Drawing.Size(20, 40)
        Me.picComputer.TabIndex = 9
        Me.picComputer.TabStop = False
        Me.picComputer.Tag = "computer"
        '
        'picMonitor
        '
        Me.picMonitor.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.computer
        Me.picMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMonitor.Location = New System.Drawing.Point(600, 34)
        Me.picMonitor.Name = "picMonitor"
        Me.picMonitor.Size = New System.Drawing.Size(90, 10)
        Me.picMonitor.TabIndex = 8
        Me.picMonitor.TabStop = False
        Me.picMonitor.Tag = "monitor"
        '
        'picKeyboard
        '
        Me.picKeyboard.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.keyboard
        Me.picKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picKeyboard.Location = New System.Drawing.Point(614, 49)
        Me.picKeyboard.Name = "picKeyboard"
        Me.picKeyboard.Size = New System.Drawing.Size(65, 25)
        Me.picKeyboard.TabIndex = 7
        Me.picKeyboard.TabStop = False
        Me.picKeyboard.Tag = "keyboard"
        '
        'picDesk
        '
        Me.picDesk.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.desk
        Me.picDesk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDesk.Location = New System.Drawing.Point(519, 24)
        Me.picDesk.Name = "picDesk"
        Me.picDesk.Size = New System.Drawing.Size(250, 50)
        Me.picDesk.TabIndex = 6
        Me.picDesk.TabStop = False
        Me.picDesk.Tag = "desk"
        '
        'picBookshelf
        '
        Me.picBookshelf.BackgroundImage = CType(resources.GetObject("picBookshelf.BackgroundImage"), System.Drawing.Image)
        Me.picBookshelf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBookshelf.Location = New System.Drawing.Point(25, 24)
        Me.picBookshelf.Name = "picBookshelf"
        Me.picBookshelf.Size = New System.Drawing.Size(350, 100)
        Me.picBookshelf.TabIndex = 5
        Me.picBookshelf.TabStop = False
        Me.picBookshelf.Tag = "bookshelf"
        '
        'picBed
        '
        Me.picBed.BackgroundImage = CType(resources.GetObject("picBed.BackgroundImage"), System.Drawing.Image)
        Me.picBed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBed.Location = New System.Drawing.Point(25, 267)
        Me.picBed.Name = "picBed"
        Me.picBed.Size = New System.Drawing.Size(100, 150)
        Me.picBed.TabIndex = 4
        Me.picBed.TabStop = False
        Me.picBed.Tag = "bed"
        '
        'picLock
        '
        Me.picLock.BackColor = System.Drawing.Color.Transparent
        Me.picLock.BackgroundImage = CType(resources.GetObject("picLock.BackgroundImage"), System.Drawing.Image)
        Me.picLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLock.Location = New System.Drawing.Point(719, 194)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(50, 50)
        Me.picLock.TabIndex = 2
        Me.picLock.TabStop = False
        Me.picLock.Tag = "lock"
        '
        'picRoomTemplate
        '
        Me.picRoomTemplate.BackColor = System.Drawing.Color.Transparent
        Me.picRoomTemplate.BackgroundImage = CType(resources.GetObject("picRoomTemplate.BackgroundImage"), System.Drawing.Image)
        Me.picRoomTemplate.Location = New System.Drawing.Point(0, 0)
        Me.picRoomTemplate.Name = "picRoomTemplate"
        Me.picRoomTemplate.Size = New System.Drawing.Size(832, 441)
        Me.picRoomTemplate.TabIndex = 3
        Me.picRoomTemplate.TabStop = False
        Me.picRoomTemplate.Tag = "design"
        Me.picRoomTemplate.Visible = False
        '
        'picDoor
        '
        Me.picDoor.BackgroundImage = CType(resources.GetObject("picDoor.BackgroundImage"), System.Drawing.Image)
        Me.picDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDoor.Location = New System.Drawing.Point(802, 178)
        Me.picDoor.Name = "picDoor"
        Me.picDoor.Size = New System.Drawing.Size(30, 90)
        Me.picDoor.TabIndex = 11
        Me.picDoor.TabStop = False
        Me.picDoor.Tag = "door"
        '
        'picGlasses
        '
        Me.picGlasses.BackColor = System.Drawing.Color.Transparent
        Me.picGlasses.BackgroundImage = CType(resources.GetObject("picGlasses.BackgroundImage"), System.Drawing.Image)
        Me.picGlasses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picGlasses.Location = New System.Drawing.Point(534, 49)
        Me.picGlasses.Name = "picGlasses"
        Me.picGlasses.Size = New System.Drawing.Size(50, 20)
        Me.picGlasses.TabIndex = 12
        Me.picGlasses.TabStop = False
        Me.picGlasses.Tag = "glasses"
        '
        'picNoteBoard
        '
        Me.picNoteBoard.BackColor = System.Drawing.Color.Transparent
        Me.picNoteBoard.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.noteboard
        Me.picNoteBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picNoteBoard.InitialImage = Global.Luminous_Realm.My.Resources.Resources.luminous_realm_icon
        Me.picNoteBoard.Location = New System.Drawing.Point(455, 327)
        Me.picNoteBoard.Name = "picNoteBoard"
        Me.picNoteBoard.Size = New System.Drawing.Size(100, 90)
        Me.picNoteBoard.TabIndex = 14
        Me.picNoteBoard.TabStop = False
        Me.picNoteBoard.Tag = "noteboard"
        '
        'picDesk2
        '
        Me.picDesk2.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.desk2
        Me.picDesk2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDesk2.Location = New System.Drawing.Point(759, 24)
        Me.picDesk2.Name = "picDesk2"
        Me.picDesk2.Size = New System.Drawing.Size(50, 145)
        Me.picDesk2.TabIndex = 15
        Me.picDesk2.TabStop = False
        '
        'tmrLeftDoubleClick
        '
        Me.tmrLeftDoubleClick.Interval = 120
        '
        'tmrRightDoubleClick
        '
        Me.tmrRightDoubleClick.Interval = 120
        '
        'FrmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 441)
        Me.Controls.Add(Me.picComputer)
        Me.Controls.Add(Me.picDesk2)
        Me.Controls.Add(Me.picNoteBoard)
        Me.Controls.Add(Me.picGlasses)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.picDoor)
        Me.Controls.Add(Me.picAngelStatue)
        Me.Controls.Add(Me.picMonitor)
        Me.Controls.Add(Me.picKeyboard)
        Me.Controls.Add(Me.picDesk)
        Me.Controls.Add(Me.picBookshelf)
        Me.Controls.Add(Me.picBed)
        Me.Controls.Add(Me.picRoomTemplate)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGame"
        Me.Text = "Luminous Realm"
        CType(Me.picAngelStatue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKeyboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDesk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBookshelf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoomTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGlasses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNoteBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDesk2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picLock As PictureBox
    Friend WithEvents picRoomTemplate As PictureBox
    Friend WithEvents picBed As PictureBox
    Friend WithEvents picBookshelf As PictureBox
    Friend WithEvents picDesk As PictureBox
    Friend WithEvents picKeyboard As PictureBox
    Friend WithEvents picMonitor As PictureBox
    Friend WithEvents picComputer As PictureBox
    Friend WithEvents picAngelStatue As PictureBox
    Friend WithEvents picDoor As PictureBox
    Friend WithEvents picGlasses As PictureBox
    Friend WithEvents picNoteBoard As PictureBox
    Friend WithEvents picDesk2 As PictureBox
    Friend WithEvents tmrLeftDoubleClick As Timer
    Friend WithEvents tmrRightDoubleClick As Timer
End Class
