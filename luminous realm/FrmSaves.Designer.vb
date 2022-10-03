<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSaves
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSaves))
        Me.btnPlayer1 = New System.Windows.Forms.Button()
        Me.btnPlayer2 = New System.Windows.Forms.Button()
        Me.btnPlayer3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer3 = New System.Windows.Forms.PictureBox()
        Me.lblStage1 = New System.Windows.Forms.Label()
        Me.lblStage2 = New System.Windows.Forms.Label()
        Me.lblStage3 = New System.Windows.Forms.Label()
        Me.lblDifficulty1 = New System.Windows.Forms.Label()
        Me.lblDifficulty2 = New System.Windows.Forms.Label()
        Me.lblDifficulty3 = New System.Windows.Forms.Label()
        Me.btnClear1 = New System.Windows.Forms.Button()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.btnClear3 = New System.Windows.Forms.Button()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlayer1
        '
        Me.btnPlayer1.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.Button
        Me.btnPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayer1.FlatAppearance.BorderSize = 0
        Me.btnPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer1.Location = New System.Drawing.Point(334, 41)
        Me.btnPlayer1.Name = "btnPlayer1"
        Me.btnPlayer1.Size = New System.Drawing.Size(250, 80)
        Me.btnPlayer1.TabIndex = 0
        Me.btnPlayer1.Text = "Empty Save"
        Me.btnPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayer1.UseVisualStyleBackColor = True
        '
        'btnPlayer2
        '
        Me.btnPlayer2.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.Button
        Me.btnPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayer2.FlatAppearance.BorderSize = 0
        Me.btnPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer2.Location = New System.Drawing.Point(334, 171)
        Me.btnPlayer2.Name = "btnPlayer2"
        Me.btnPlayer2.Size = New System.Drawing.Size(250, 80)
        Me.btnPlayer2.TabIndex = 1
        Me.btnPlayer2.Text = "Empty Save"
        Me.btnPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayer2.UseVisualStyleBackColor = True
        '
        'btnPlayer3
        '
        Me.btnPlayer3.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.Button
        Me.btnPlayer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayer3.FlatAppearance.BorderSize = 0
        Me.btnPlayer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer3.Location = New System.Drawing.Point(334, 298)
        Me.btnPlayer3.Name = "btnPlayer3"
        Me.btnPlayer3.Size = New System.Drawing.Size(250, 80)
        Me.btnPlayer3.TabIndex = 2
        Me.btnPlayer3.Text = "Empty Save"
        Me.btnPlayer3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayer3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'picPlayer1
        '
        Me.picPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPlayer1.Location = New System.Drawing.Point(248, 41)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(80, 80)
        Me.picPlayer1.TabIndex = 3
        Me.picPlayer1.TabStop = False
        '
        'picPlayer2
        '
        Me.picPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPlayer2.Location = New System.Drawing.Point(248, 171)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(80, 80)
        Me.picPlayer2.TabIndex = 4
        Me.picPlayer2.TabStop = False
        '
        'picPlayer3
        '
        Me.picPlayer3.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPlayer3.Location = New System.Drawing.Point(248, 298)
        Me.picPlayer3.Name = "picPlayer3"
        Me.picPlayer3.Size = New System.Drawing.Size(80, 80)
        Me.picPlayer3.TabIndex = 5
        Me.picPlayer3.TabStop = False
        '
        'lblStage1
        '
        Me.lblStage1.AutoSize = True
        Me.lblStage1.BackColor = System.Drawing.Color.Transparent
        Me.lblStage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStage1.Location = New System.Drawing.Point(498, 92)
        Me.lblStage1.Name = "lblStage1"
        Me.lblStage1.Size = New System.Drawing.Size(65, 20)
        Me.lblStage1.TabIndex = 7
        Me.lblStage1.Text = "Stage 1"
        Me.lblStage1.Visible = False
        '
        'lblStage2
        '
        Me.lblStage2.AutoSize = True
        Me.lblStage2.BackColor = System.Drawing.Color.Transparent
        Me.lblStage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStage2.Location = New System.Drawing.Point(498, 222)
        Me.lblStage2.Name = "lblStage2"
        Me.lblStage2.Size = New System.Drawing.Size(65, 20)
        Me.lblStage2.TabIndex = 8
        Me.lblStage2.Text = "Stage 1"
        Me.lblStage2.Visible = False
        '
        'lblStage3
        '
        Me.lblStage3.AutoSize = True
        Me.lblStage3.BackColor = System.Drawing.Color.Transparent
        Me.lblStage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStage3.Location = New System.Drawing.Point(498, 349)
        Me.lblStage3.Name = "lblStage3"
        Me.lblStage3.Size = New System.Drawing.Size(65, 20)
        Me.lblStage3.TabIndex = 9
        Me.lblStage3.Text = "Stage 1"
        Me.lblStage3.Visible = False
        '
        'lblDifficulty1
        '
        Me.lblDifficulty1.AutoSize = True
        Me.lblDifficulty1.BackColor = System.Drawing.Color.Transparent
        Me.lblDifficulty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty1.Location = New System.Drawing.Point(498, 54)
        Me.lblDifficulty1.Name = "lblDifficulty1"
        Me.lblDifficulty1.Size = New System.Drawing.Size(59, 20)
        Me.lblDifficulty1.TabIndex = 12
        Me.lblDifficulty1.Text = "Normal"
        Me.lblDifficulty1.Visible = False
        '
        'lblDifficulty2
        '
        Me.lblDifficulty2.AutoSize = True
        Me.lblDifficulty2.BackColor = System.Drawing.Color.Transparent
        Me.lblDifficulty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty2.Location = New System.Drawing.Point(498, 183)
        Me.lblDifficulty2.Name = "lblDifficulty2"
        Me.lblDifficulty2.Size = New System.Drawing.Size(59, 20)
        Me.lblDifficulty2.TabIndex = 13
        Me.lblDifficulty2.Text = "Normal"
        Me.lblDifficulty2.Visible = False
        '
        'lblDifficulty3
        '
        Me.lblDifficulty3.AutoSize = True
        Me.lblDifficulty3.BackColor = System.Drawing.Color.Transparent
        Me.lblDifficulty3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty3.Location = New System.Drawing.Point(498, 311)
        Me.lblDifficulty3.Name = "lblDifficulty3"
        Me.lblDifficulty3.Size = New System.Drawing.Size(59, 20)
        Me.lblDifficulty3.TabIndex = 14
        Me.lblDifficulty3.Text = "Normal"
        Me.lblDifficulty3.Visible = False
        '
        'btnClear1
        '
        Me.btnClear1.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.clear_icon
        Me.btnClear1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClear1.FlatAppearance.BorderSize = 0
        Me.btnClear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear1.Location = New System.Drawing.Point(587, 41)
        Me.btnClear1.Name = "btnClear1"
        Me.btnClear1.Size = New System.Drawing.Size(80, 80)
        Me.btnClear1.TabIndex = 15
        Me.btnClear1.UseVisualStyleBackColor = True
        '
        'btnClear2
        '
        Me.btnClear2.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.clear_icon
        Me.btnClear2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClear2.FlatAppearance.BorderSize = 0
        Me.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear2.Location = New System.Drawing.Point(587, 171)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(80, 80)
        Me.btnClear2.TabIndex = 16
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'btnClear3
        '
        Me.btnClear3.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.clear_icon
        Me.btnClear3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClear3.FlatAppearance.BorderSize = 0
        Me.btnClear3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear3.Location = New System.Drawing.Point(587, 299)
        Me.btnClear3.Name = "btnClear3"
        Me.btnClear3.Size = New System.Drawing.Size(80, 80)
        Me.btnClear3.TabIndex = 17
        Me.btnClear3.UseVisualStyleBackColor = True
        '
        'FrmSaves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Luminous_Realm.My.Resources.Resources.titlebackground10
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 441)
        Me.Controls.Add(Me.btnClear3)
        Me.Controls.Add(Me.btnClear2)
        Me.Controls.Add(Me.btnClear1)
        Me.Controls.Add(Me.lblDifficulty3)
        Me.Controls.Add(Me.lblDifficulty2)
        Me.Controls.Add(Me.lblDifficulty1)
        Me.Controls.Add(Me.lblStage3)
        Me.Controls.Add(Me.lblStage2)
        Me.Controls.Add(Me.lblStage1)
        Me.Controls.Add(Me.picPlayer3)
        Me.Controls.Add(Me.picPlayer2)
        Me.Controls.Add(Me.picPlayer1)
        Me.Controls.Add(Me.btnPlayer3)
        Me.Controls.Add(Me.btnPlayer2)
        Me.Controls.Add(Me.btnPlayer1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSaves"
        Me.Text = "Luminous Realm"
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlayer1 As Button
    Friend WithEvents btnPlayer2 As Button
    Friend WithEvents btnPlayer3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picPlayer1 As PictureBox
    Friend WithEvents picPlayer2 As PictureBox
    Friend WithEvents picPlayer3 As PictureBox
    Friend WithEvents lblStage1 As Label
    Friend WithEvents lblStage2 As Label
    Friend WithEvents lblStage3 As Label
    Friend WithEvents lblDifficulty1 As Label
    Friend WithEvents lblDifficulty2 As Label
    Friend WithEvents lblDifficulty3 As Label
    Friend WithEvents btnClear1 As Button
    Friend WithEvents btnClear2 As Button
    Friend WithEvents btnClear3 As Button
    Friend WithEvents tmrUpdate As Timer
End Class
