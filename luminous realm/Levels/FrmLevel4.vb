Public Class FrmLevel4
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If FrmGame.game.Player.iscollidingwith(New Hitbox(PictureBox1)) And FrmGame.game.isActiveForm(Me) Then
            FrmGame.game.moveToStage(8, "platform")
        End If
        If FrmGame.game.Player.iscollidingwith(FrmGame.game.l4platform7.hitbox) And FrmGame.game.isActiveForm(Me) Then
            FrmGame.game.moveToStage(10, "platform")
        End If
    End Sub
End Class