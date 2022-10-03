Public Class FrmLevel5
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If FrmGame.game.Player.iscollidingwith(New Hitbox(PictureBox1)) And FrmGame.game.isActiveForm(Me) Then
            FrmGame.game.moveToStage(9, "platform")
        End If
        If FrmGame.game.Player.iscollidingwith(FrmGame.game.l5platform6.hitbox) And FrmGame.game.isActiveForm(Me) Then
            FrmGame.game.moveToStage(11, "platform")
        End If
    End Sub
End Class