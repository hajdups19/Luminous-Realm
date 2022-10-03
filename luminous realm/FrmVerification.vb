Public Class FrmVerification
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If FrmGame.game.intStage = 1 Then ' checks if it's the first stage
                If Integer.Parse(TextBox1.Text).Equals(89274350) Then ' checks for the right code in an integer format
                    FrmGame.game.bolVerified = True
                    Me.Close() ' closes the form to save resources
                    FrmGame.game.lock.remove()
                End If
            Else
                If TextBox1.Text.ToString.ToLower.Equals("deception") Then ' The Stage 5 unlock
                    Me.Close()
                    FrmGame.game.moveToStage(6, "platform") ' moves on the platformer levels
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FrmGame.game.intStage = 1 Then ' loads the backgrounds according to it's stage
            Try
                Label1.ForeColor = Color.Black ' makes the text label readable by changing colour
                BackgroundImage = Image.FromFile(FrmTitle.strDirectory & "\resources\stage1_background.png")
            Catch ex As Exception
            End Try
        Else
            Try
                Label1.ForeColor = Color.White ' makes the text label readable by changing colour
                BackgroundImage = Image.FromFile(FrmTitle.strDirectory & "\resources\stage5_background.png")
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        FrmTitle.highlightbutton(Button1, "button") ' highlights the button
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        FrmTitle.setButton(Button1, "button") ' resets the button to default
    End Sub
End Class