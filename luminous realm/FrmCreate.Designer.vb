<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreate))
        Me.lblName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.btnNormal = New System.Windows.Forms.Button()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.btnMaster = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblDifficultyChoice = New System.Windows.Forms.Label()
        Me.lblDifficultyDesc = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(250, 89)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(77, 26)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(357, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 26)
        Me.TextBox1.TabIndex = 1
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.BackColor = System.Drawing.Color.Transparent
        Me.lblDifficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.Location = New System.Drawing.Point(250, 189)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(101, 26)
        Me.lblDifficulty.TabIndex = 5
        Me.lblDifficulty.Text = "Difficulty:"
        '
        'btnNormal
        '
        Me.btnNormal.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.normal_icon
        Me.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNormal.FlatAppearance.BorderSize = 0
        Me.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNormal.Location = New System.Drawing.Point(255, 218)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(50, 50)
        Me.btnNormal.TabIndex = 6
        Me.btnNormal.UseVisualStyleBackColor = True
        '
        'btnHard
        '
        Me.btnHard.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.hard_icon
        Me.btnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHard.FlatAppearance.BorderSize = 0
        Me.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHard.Location = New System.Drawing.Point(255, 274)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(50, 50)
        Me.btnHard.TabIndex = 7
        Me.btnHard.UseVisualStyleBackColor = True
        '
        'btnMaster
        '
        Me.btnMaster.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.master_icon
        Me.btnMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaster.FlatAppearance.BorderSize = 0
        Me.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaster.Location = New System.Drawing.Point(255, 330)
        Me.btnMaster.Name = "btnMaster"
        Me.btnMaster.Size = New System.Drawing.Size(50, 50)
        Me.btnMaster.TabIndex = 8
        Me.btnMaster.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.Button
        Me.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreate.FlatAppearance.BorderSize = 0
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(324, 390)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(167, 38)
        Me.btnCreate.TabIndex = 9
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblDifficultyChoice
        '
        Me.lblDifficultyChoice.AutoSize = True
        Me.lblDifficultyChoice.BackColor = System.Drawing.Color.Transparent
        Me.lblDifficultyChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficultyChoice.Location = New System.Drawing.Point(352, 189)
        Me.lblDifficultyChoice.Name = "lblDifficultyChoice"
        Me.lblDifficultyChoice.Size = New System.Drawing.Size(189, 26)
        Me.lblDifficultyChoice.TabIndex = 10
        Me.lblDifficultyChoice.Text = "Normal Difficulty"
        '
        'lblDifficultyDesc
        '
        Me.lblDifficultyDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDifficultyDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficultyDesc.Location = New System.Drawing.Point(311, 222)
        Me.lblDifficultyDesc.Name = "lblDifficultyDesc"
        Me.lblDifficultyDesc.Size = New System.Drawing.Size(212, 165)
        Me.lblDifficultyDesc.TabIndex = 11
        Me.lblDifficultyDesc.Text = "The Default experience of Luminous Realm. Stamina consumption is limited and Illu" &
    "minant duke does minimal damage without extra moves from the original. Recommend" &
    "ed for new players."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 25
        '
        'FrmCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.titlebackground10
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 441)
        Me.Controls.Add(Me.lblDifficultyDesc)
        Me.Controls.Add(Me.lblDifficultyChoice)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnMaster)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.btnNormal)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblName)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCreate"
        Me.Text = "Luminous Realm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblDifficulty As Label
    Friend WithEvents btnNormal As Button
    Friend WithEvents btnHard As Button
    Friend WithEvents btnMaster As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblDifficultyChoice As Label
    Friend WithEvents lblDifficultyDesc As Label
    Friend WithEvents Timer1 As Timer
End Class
