Imports System.Data.OleDb
Imports Newtonsoft.Json, System.IO
Public Class FrmSaves
    Public intSave As Integer
    Public save As String
    Dim i As Integer
    Public gameSave As SaveData
    Private Sub FrmSaves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateSaves()
        lblDifficulty1.BackColor = ColorTranslator.FromHtml("#494949")
        lblDifficulty2.BackColor = ColorTranslator.FromHtml("#494949")
        lblDifficulty3.BackColor = ColorTranslator.FromHtml("#494949")
        lblStage1.BackColor = ColorTranslator.FromHtml("#494949")
        lblStage2.BackColor = ColorTranslator.FromHtml("#494949")
        lblStage3.BackColor = ColorTranslator.FromHtml("#494949")
        lblStage3.BackColor = ColorTranslator.FromHtml("#5d5d5d")
        tmrUpdate.Start()
    End Sub
    Public Sub updateSaves()
        Try
            checkSave(btnPlayer1, 1, lblStage1, lblDifficulty1, picPlayer1, btnClear1)
            checkSave(btnPlayer2, 2, lblStage2, lblDifficulty2, picPlayer2, btnClear2)
            checkSave(btnPlayer3, 3, lblStage3, lblDifficulty3, picPlayer3, btnClear3)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub checkSave(btn As Button, save As Integer, stage As Label, difficulty As Label, icon As PictureBox, clearicon As Button)
        If Not IO.File.ReadAllBytes(FrmTitle.strDirectory & "\saves\Player" & save & ".json").Length = 0 Then
            Dim reader = Linq.JObject.Parse(File.ReadAllText(FrmTitle.strDirectory & "\saves\Player" & save & ".json"))
            btn.Text = reader.Item("Name")
            stage.Visible = True
            difficulty.Visible = True
            stage.Text = "Stage " & String.Format(reader.Item("Stage"))
            Select Case Integer.Parse(reader.Item("Difficulty"))
                Case 0
                    difficulty.Text = "Normal"
                Case 1
                    difficulty.Text = "Hard"
                Case 2
                    difficulty.Text = "Master"
                Case Else
                    difficulty.Text = "Normal"
            End Select
            If reader.Item("Gender").Equals("male") Then
                FrmTitle.changeImage(icon, "player_male_icon.png")
            Else
                FrmTitle.changeImage(icon, "player_male_icon.png")
            End If
            If clearicon.BackgroundImage.Equals(Image.FromFile(FrmTitle.strDirectory & "/resources/clear_icon_disabled.png")) Then
                FrmTitle.changeImage(clearicon, "clear_icon.png")
            End If
        Else
            stage.Visible = False
            difficulty.Visible = False
            btn.Text = "Empty Save"
            FrmTitle.changeImage(icon, "empty_save_icon.png")
            FrmTitle.changeImage(clearicon, "clear_icon_disabled.png")
        End If
    End Sub

    Private Sub displaySave(player As Integer)
        Try
            If IO.File.ReadAllBytes(FrmTitle.strDirectory & "\saves\Player" & player & ".json").Length = 0 Then
                save = FrmTitle.strDirectory & "\saves\Player" & player & ".json"
                FrmTitle.currentForm = FrmCreate
                FrmCreate.Show()
                Me.Hide()
            Else
                Dim reader = Linq.JObject.Parse(File.ReadAllText(FrmTitle.strDirectory & "\saves\Player" & player & ".json"))
                FrmTitle.currentForm = Nothing
                gameSave = New SaveData(FrmTitle.strDirectory & "\saves\Player" & player & ".json", reader.Item("Name"), reader.Item("Gender"), reader.Item("Difficulty"), reader.Item("Stage"), reader.Item("Tutorial"), reader.Item("Stage 3 Unlocked"), reader.Item("Stage 4 Unlocked"), reader.Item("Stage 5 Unlocked"))
                tmrUpdate.Stop()
                FrmGame.Show()
                Me.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlayer1.Click
        displaySave(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPlayer2.Click
        displaySave(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPlayer3.Click
        displaySave(3)
    End Sub

    Private Sub updatePos(y As Integer, btn As Button, difficulty As Label, stage As Label, icon As PictureBox, clear As Button)
        If Not btn.Location.Equals(New Point((Me.Width / 2) - (btn.Width / 2), (Me.Height / 2) - (btn.Height / 2) + FrmTitle.intScaledValue(y))) Then
            btn.Location = New Point((Me.Width / 2) - (btn.Width / 2), (Me.Height / 2) - (btn.Height / 2) + FrmTitle.intScaledValue(y))
            difficulty.Location = New Point(btn.Location.X + FrmTitle.intScaledValue(164), btn.Location.Y + FrmTitle.intScaledValue(12))
            stage.Location = New Point(btn.Location.X + FrmTitle.intScaledValue(164), btn.Location.Y + FrmTitle.intScaledValue(51))
            icon.Location = New Point(btn.Location.X - FrmTitle.intScaledValue(86), btn.Location.Y)
            clear.Location = New Point(btn.Location.X + btn.Width + FrmTitle.intScaledValue(5), btn.Location.Y)
        End If
    End Sub

    Private Sub updateSize(btn As Button, icon As PictureBox, clear As Button)
        scaleElement(btn, 250, 80)
        scaleElement(icon, 80, 80)
        scaleElement(clear, 80, 80)
    End Sub

    Private Sub scaleElement(item As Control, sizeX As Integer, sizeY As Integer)
        If Not item.Size.Equals(New Size(FrmTitle.intScaledValue(sizeX), FrmTitle.intScaledValue(sizeY))) Then
            item.Size = New Size(FrmTitle.intScaledValue(sizeX), FrmTitle.intScaledValue(sizeY))
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        updatePos(-130, btnPlayer1, lblDifficulty1, lblStage1, picPlayer1, btnClear1)
        updatePos(0, btnPlayer2, lblDifficulty2, lblStage2, picPlayer2, btnClear2)
        updatePos(130, btnPlayer3, lblDifficulty3, lblStage3, picPlayer3, btnClear3)
        updateSize(btnPlayer1, picPlayer1, btnClear1)
        updateSize(btnPlayer2, picPlayer2, btnClear2)
        updateSize(btnPlayer3, picPlayer3, btnClear3)
        FrmTitle.useAnimatedBackground(Me)
    End Sub

    Private Sub hoverOver(btn As Button, stage As Label, difficulty As Label)
        FrmTitle.highlightbutton(btn, "Button")
        stage.BackColor = ColorTranslator.FromHtml("#5d5d5d")
        difficulty.BackColor = ColorTranslator.FromHtml("#858585")
    End Sub

    Private Sub resetOver(btn As Button, stage As Label, difficulty As Label)
        FrmTitle.setButton(btn, "Button")
        stage.BackColor = ColorTranslator.FromHtml("#494949")
        difficulty.BackColor = ColorTranslator.FromHtml("#494949")
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btnPlayer1.MouseEnter
        hoverOver(btnPlayer1, lblStage1, lblDifficulty1)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnPlayer1.MouseLeave
        resetOver(btnPlayer1, lblStage1, lblDifficulty1)
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles btnPlayer2.MouseEnter
        hoverOver(btnPlayer2, lblStage2, lblDifficulty2)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnPlayer2.MouseLeave
        resetOver(btnPlayer2, lblStage2, lblDifficulty2)
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles btnPlayer3.MouseEnter
        hoverOver(btnPlayer3, lblStage3, lblDifficulty3)
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles btnPlayer3.MouseLeave
        resetOver(btnPlayer3, lblStage3, lblDifficulty3)
    End Sub

    Private Sub lblDifficulty1_MouseEnter(sender As Object, e As EventArgs) Handles lblDifficulty1.MouseEnter
        hoverOver(btnPlayer1, lblStage1, lblDifficulty1)
    End Sub

    Private Sub lblStage1_MouseEnter(sender As Object, e As EventArgs) Handles lblStage1.MouseEnter
        hoverOver(btnPlayer1, lblStage1, lblDifficulty1)
    End Sub

    Private Sub lblDifficulty2_MouseEnter(sender As Object, e As EventArgs) Handles lblDifficulty2.MouseEnter
        hoverOver(btnPlayer2, lblStage2, lblDifficulty2)
    End Sub

    Private Sub lblStage2_MouseEnter(sender As Object, e As EventArgs) Handles lblStage2.MouseEnter
        hoverOver(btnPlayer2, lblStage2, lblDifficulty2)
    End Sub

    Private Sub lblDifficulty3_MouseEnter(sender As Object, e As EventArgs) Handles lblDifficulty3.MouseEnter
        hoverOver(btnPlayer3, lblStage3, lblDifficulty3)
    End Sub

    Private Sub lblStage3_MouseEnter(sender As Object, e As EventArgs) Handles lblStage3.MouseEnter
        hoverOver(btnPlayer3, lblStage3, lblDifficulty3)
    End Sub

    Private Sub btnClear3_MouseEnter(sender As Object, e As EventArgs) Handles btnClear3.MouseEnter
        If isEnabled(btnPlayer3) Then
            FrmTitle.highlightbutton(btnClear3, "clear_icon")
        End If
    End Sub

    Private Sub btnClear3_MouseLeave(sender As Object, e As EventArgs) Handles btnClear3.MouseLeave
        If isEnabled(btnPlayer3) Then
            FrmTitle.setButton(btnClear3, "clear_icon")
        End If
    End Sub

    Private Sub btnClear2_MouseEnter(sender As Object, e As EventArgs) Handles btnClear2.MouseEnter
        If isEnabled(btnPlayer2) Then
            FrmTitle.highlightbutton(btnClear2, "clear_icon")
        End If
    End Sub

    Private Sub btnClear2_MouseLeave(sender As Object, e As EventArgs) Handles btnClear2.MouseLeave
        If isEnabled(btnPlayer2) Then
            FrmTitle.setButton(btnClear2, "clear_icon")
        End If
    End Sub

    Private Sub btnClear1_MouseEnter(sender As Object, e As EventArgs) Handles btnClear1.MouseEnter
        If isEnabled(btnPlayer1) Then
            FrmTitle.highlightbutton(btnClear1, "clear_icon")
        End If
    End Sub

    Private Sub btnClear1_MouseLeave(sender As Object, e As EventArgs) Handles btnClear1.MouseLeave
        If isEnabled(btnPlayer1) Then
            FrmTitle.setButton(btnClear1, "clear_icon")
        End If
    End Sub

    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        If isEnabled(btnPlayer1) Then '
            My.Computer.FileSystem.DeleteFile(FrmTitle.strDirectory & "\saves\Player1.json")
            IO.File.Create(FrmTitle.strDirectory & "\saves\Player1.json")
            updateSaves()
        End If

    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        If isEnabled(btnPlayer2) Then
            My.Computer.FileSystem.DeleteFile(FrmTitle.strDirectory & "\saves\Player2.json")
            IO.File.Create(FrmTitle.strDirectory & "\saves\Player2.json")
            updateSaves()
        End If
    End Sub

    Private Function isEnabled(btn As Button)
        Try
            If Not btn.Text.Equals("Empty Save") Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try

        Return False
    End Function

    Private Sub btnClear3_Click(sender As Object, e As EventArgs) Handles btnClear3.Click
        If isEnabled(btnPlayer3) Then
            My.Computer.FileSystem.DeleteFile(FrmTitle.strDirectory & "\saves\Player3.json")
            IO.File.Create(FrmTitle.strDirectory & "\saves\Player3.json")
            updateSaves()
        End If
    End Sub

    Private Sub lblDifficulty1_Click(sender As Object, e As EventArgs) Handles lblDifficulty1.Click
        displaySave(1)
    End Sub

    Private Sub lblStage1_Click(sender As Object, e As EventArgs) Handles lblStage1.Click
        displaySave(1)
    End Sub

    Private Sub lblDifficulty2_Click(sender As Object, e As EventArgs) Handles lblDifficulty2.Click
        displaySave(2)
    End Sub

    Private Sub lblStage2_Click(sender As Object, e As EventArgs) Handles lblStage2.Click
        displaySave(2)
    End Sub

    Private Sub lblDifficulty3_Click(sender As Object, e As EventArgs) Handles lblDifficulty3.Click
        displaySave(3)
    End Sub

    Private Sub lblStage3_Click(sender As Object, e As EventArgs) Handles lblStage3.Click
        displaySave(3)
    End Sub
End Class