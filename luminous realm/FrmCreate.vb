Imports Newtonsoft.Json, System.IO
Public Class FrmCreate
    Dim intDifficulty As Integer = 0

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not TextBox1.Text.Length = 0 Then
            lblName.ForeColor = Color.Black
            Using writer As JsonTextWriter = New JsonTextWriter(File.CreateText(FrmSaves.save))
                writer.WriteStartObject()
                writer.WritePropertyName("Name")
                writer.WriteValue(TextBox1.Text)
                writer.WritePropertyName("Gender")
                writer.WriteValue("male")
                writer.WritePropertyName("Difficulty")
                writer.WriteValue(intDifficulty)
                writer.WritePropertyName("Stage")
                writer.WriteValue(1)
                writer.WritePropertyName("Tutorial")
                writer.WriteValue(True)
                writer.WritePropertyName("Stage 3 Unlocked")
                writer.WriteValue(False)
                writer.WritePropertyName("Stage 4 Unlocked")
                writer.WriteValue(False)
                writer.WritePropertyName("Stage 5 Unlocked")
                writer.WriteValue(False)
                writer.WriteEndObject()
            End Using
            FrmSaves.Show()
            Me.Hide()
        Else
            lblName.ForeColor = Color.Red
            TextBox1.Focus()
        End If
    End Sub

    Private Sub FrmCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateDifficulties()
    End Sub

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        intDifficulty = 0
        lblDifficultyChoice.Text = "Normal Difficulty"
        lblDifficultyDesc.Text = "The Default experience of Luminous Realm. Stamina consumption is limited and Illuminant duke does minimal damage without extra moves from the original. Recommended for new players."
        updateDifficulties()
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        intDifficulty = 1
        lblDifficultyChoice.Text = "Hard Difficulty"
        lblDifficultyDesc.Text = "Luminous Realm with increased amount of challenge. Stamina consumption is increased for each move and Illuminant duke does extra damage with additional moves to challenge the player. Recommended for players willing to take a challenge."
        updateDifficulties()
    End Sub

    Private Sub btnMaster_Click(sender As Object, e As EventArgs) Handles btnMaster.Click
        lblDifficultyChoice.Text = "Master Difficulty"
        lblDifficultyDesc.Text = "The toughest challenge in Luminous Realm. Stamina consumption is brutal for each move and Illuminant duke does 2x the damage of hard and is faster. Recommended for experienced players that are good in Luminous Realm and understand the mechanics of the game."
        intDifficulty = 2
        updateDifficulties()
    End Sub

    Private Sub updateDifficulty(btn As Button, difficulty As Integer)
        Dim s As String
        Select Case difficulty
            Case 0
                s = "normal"
            Case 1
                s = "hard"
            Case 2
                s = "master"
            Case Else
                s = "normal"
        End Select
        If intDifficulty = difficulty Then
            FrmTitle.selectButton(btn, s & "_icon")
        Else
            FrmTitle.setButton(btn, s & "_icon")
        End If
    End Sub

    Private Sub updateDifficulties()
        updateDifficulty(btnNormal, 0)
        updateDifficulty(btnHard, 1)
        updateDifficulty(btnMaster, 2)
    End Sub

    Private Sub btnCreate_MouseEnter(sender As Object, e As EventArgs) Handles btnCreate.MouseEnter
        FrmTitle.highlightbutton(btnCreate, "Button")
    End Sub

    Private Sub btnCreate_MouseLeave(sender As Object, e As EventArgs) Handles btnCreate.MouseLeave
        FrmTitle.setButton(btnCreate, "Button")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub


    Private Sub btnNormal_MouseEnter(sender As Object, e As EventArgs) Handles btnNormal.MouseEnter
        If Not intDifficulty = 0 Then
            FrmTitle.highlightbutton(btnNormal, "normal_icon")
        End If
    End Sub

    Private Sub btnNormal_MouseLeave(sender As Object, e As EventArgs) Handles btnNormal.MouseLeave
        updateDifficulties()
    End Sub

    Private Sub btnHard_MouseEnter(sender As Object, e As EventArgs) Handles btnHard.MouseEnter
        If Not intDifficulty = 1 Then
            FrmTitle.highlightbutton(btnHard, "hard_icon")
        End If

    End Sub

    Private Sub btnHard_MouseLeave(sender As Object, e As EventArgs) Handles btnHard.MouseLeave
        updateDifficulties()
    End Sub

    Private Sub btnMaster_MouseEnter(sender As Object, e As EventArgs) Handles btnMaster.MouseEnter
        If Not intDifficulty = 2 Then
            FrmTitle.highlightbutton(btnMaster, "master_icon")
        End If
    End Sub

    Private Sub btnMaster_MouseLeave(sender As Object, e As EventArgs) Handles btnMaster.MouseLeave
        updateDifficulties()
    End Sub
End Class