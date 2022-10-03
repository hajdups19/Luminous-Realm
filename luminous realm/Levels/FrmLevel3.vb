Public Class FrmLevel3
    Private Sub GameKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        FrmGame.game.keydowntick(e)
    End Sub
    Private Sub GameKeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        FrmGame.game.keyuptick(e)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If FrmGame.game.Player.iscollidingwith(New Hitbox(PictureBox1)) And FrmGame.game.isActiveForm(Me) Then
            FrmGame.game.moveToStage(7, "platform")
        End If
        If FrmGame.game.Player.iscollidingwith(FrmGame.game.l3platform11.hitbox) And FrmGame.game.isActiveForm(Me) Then
            FrmGame.game.moveToStage(9, "platform")
        End If
    End Sub
End Class