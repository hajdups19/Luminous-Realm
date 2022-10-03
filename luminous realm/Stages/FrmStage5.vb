Public Class FrmStage5
    Private Sub FrmStage5_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        FrmGame.game.keydowntick(e)
    End Sub

    Private Sub FrmStage5_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        FrmGame.game.keyuptick(e)
    End Sub

    Private Sub FrmStage5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmGame.game.bolMenu = False
    End Sub

    Private Sub picAuthUnit_Click(sender As Object, e As EventArgs) Handles picAuthUnit.Click
        If FrmGame.game.Player.inproximityof(FrmGame.game.authunit, 50) Then
            FrmVerification.ShowDialog()
        End If
    End Sub

End Class