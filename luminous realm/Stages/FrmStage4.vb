Public Class FrmStage4
    Private Sub FrmStage4_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        FrmGame.game.keydowntick(e)
    End Sub

    Private Sub FrmStage4_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        FrmGame.game.keyuptick(e)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub picSwordShrine_Click(sender As Object, e As EventArgs) Handles picSwordShrine.Click
        If FrmGame.game.Player.inproximityof(New Hitbox(FrmGame.game.swordshrine.picEntity), 50) Then
            FrmGame.game.Player.recieve(FrmGame.game.swordshrine)
            FrmTitle.changeImage(picSwordShrine, "solbound_sword_shrine_empty.png")
        End If
    End Sub
End Class