<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLevel1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLevel1))
        Me.picPlatform5 = New System.Windows.Forms.PictureBox()
        Me.picPlatform4 = New System.Windows.Forms.PictureBox()
        Me.picPlatform3 = New System.Windows.Forms.PictureBox()
        Me.picPlatform2 = New System.Windows.Forms.PictureBox()
        Me.picPlatform1 = New System.Windows.Forms.PictureBox()
        Me.picRoomTemplate = New System.Windows.Forms.PictureBox()
        Me.picPlatform6 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picPlatform5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlatform4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlatform3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlatform2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlatform1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoomTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlatform6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlatform5
        '
        Me.picPlatform5.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.stage5_background
        Me.picPlatform5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlatform5.Location = New System.Drawing.Point(114, 158)
        Me.picPlatform5.Name = "picPlatform5"
        Me.picPlatform5.Size = New System.Drawing.Size(109, 27)
        Me.picPlatform5.TabIndex = 9
        Me.picPlatform5.TabStop = False
        '
        'picPlatform4
        '
        Me.picPlatform4.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.stage4_background
        Me.picPlatform4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlatform4.Location = New System.Drawing.Point(415, 158)
        Me.picPlatform4.Name = "picPlatform4"
        Me.picPlatform4.Size = New System.Drawing.Size(109, 27)
        Me.picPlatform4.TabIndex = 8
        Me.picPlatform4.TabStop = False
        '
        'picPlatform3
        '
        Me.picPlatform3.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.stage4_background
        Me.picPlatform3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlatform3.Location = New System.Drawing.Point(525, 280)
        Me.picPlatform3.Name = "picPlatform3"
        Me.picPlatform3.Size = New System.Drawing.Size(109, 27)
        Me.picPlatform3.TabIndex = 7
        Me.picPlatform3.TabStop = False
        '
        'picPlatform2
        '
        Me.picPlatform2.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.stage4_background
        Me.picPlatform2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlatform2.Location = New System.Drawing.Point(286, 337)
        Me.picPlatform2.Name = "picPlatform2"
        Me.picPlatform2.Size = New System.Drawing.Size(109, 27)
        Me.picPlatform2.TabIndex = 6
        Me.picPlatform2.TabStop = False
        '
        'picPlatform1
        '
        Me.picPlatform1.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.stage4_background
        Me.picPlatform1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlatform1.Location = New System.Drawing.Point(38, 381)
        Me.picPlatform1.Name = "picPlatform1"
        Me.picPlatform1.Size = New System.Drawing.Size(109, 27)
        Me.picPlatform1.TabIndex = 5
        Me.picPlatform1.TabStop = False
        '
        'picRoomTemplate
        '
        Me.picRoomTemplate.BackColor = System.Drawing.Color.Transparent
        Me.picRoomTemplate.BackgroundImage = CType(resources.GetObject("picRoomTemplate.BackgroundImage"), System.Drawing.Image)
        Me.picRoomTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRoomTemplate.Location = New System.Drawing.Point(0, 0)
        Me.picRoomTemplate.Name = "picRoomTemplate"
        Me.picRoomTemplate.Size = New System.Drawing.Size(832, 441)
        Me.picRoomTemplate.TabIndex = 4
        Me.picRoomTemplate.TabStop = False
        Me.picRoomTemplate.Tag = "design"
        Me.picRoomTemplate.Visible = False
        '
        'picPlatform6
        '
        Me.picPlatform6.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.stage4_background
        Me.picPlatform6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlatform6.Location = New System.Drawing.Point(678, 210)
        Me.picPlatform6.Name = "picPlatform6"
        Me.picPlatform6.Size = New System.Drawing.Size(109, 27)
        Me.picPlatform6.TabIndex = 10
        Me.picPlatform6.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(153, 394)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(638, 20)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'FrmLevel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.platformer_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 441)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picPlatform6)
        Me.Controls.Add(Me.picPlatform5)
        Me.Controls.Add(Me.picPlatform4)
        Me.Controls.Add(Me.picPlatform3)
        Me.Controls.Add(Me.picPlatform2)
        Me.Controls.Add(Me.picPlatform1)
        Me.Controls.Add(Me.picRoomTemplate)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLevel1"
        Me.Text = "Luminous Realm"
        CType(Me.picPlatform5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlatform4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlatform3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlatform2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlatform1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoomTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlatform6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picRoomTemplate As PictureBox
    Friend WithEvents picPlatform1 As PictureBox
    Friend WithEvents picPlatform2 As PictureBox
    Friend WithEvents picPlatform3 As PictureBox
    Friend WithEvents picPlatform4 As PictureBox
    Friend WithEvents picPlatform5 As PictureBox
    Friend WithEvents picPlatform6 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
