<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTitle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTitle))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picTitleScreen = New System.Windows.Forms.PictureBox()
        CType(Me.picTitleScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlay.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.Button
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(331, 150)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(150, 50)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'picTitleScreen
        '
        Me.picTitleScreen.BackColor = System.Drawing.Color.Transparent
        Me.picTitleScreen.BackgroundImage = CType(resources.GetObject("picTitleScreen.BackgroundImage"), System.Drawing.Image)
        Me.picTitleScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picTitleScreen.Location = New System.Drawing.Point(191, 0)
        Me.picTitleScreen.Name = "picTitleScreen"
        Me.picTitleScreen.Size = New System.Drawing.Size(430, 150)
        Me.picTitleScreen.TabIndex = 3
        Me.picTitleScreen.TabStop = False
        '
        'FrmTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.titlebackground10
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 441)
        Me.Controls.Add(Me.picTitleScreen)
        Me.Controls.Add(Me.btnPlay)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTitle"
        Me.Text = "Luminous Realm"
        CType(Me.picTitleScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picTitleScreen As PictureBox
End Class
