Public Class FrmBoss

    Private Sub FrmBoss_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        FrmGame.game.keydowntick(e)
    End Sub
    Private Sub FrmBoss_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        FrmGame.game.keyuptick(e)
    End Sub
End Class