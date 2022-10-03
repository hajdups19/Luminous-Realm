Public Class frmStage3
    Private Sub frmStage3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        FrmGame.game.keydowntick(e)
    End Sub

    Private Sub frmStage3_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        FrmGame.game.keyuptick(e)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not IsDBNull(picBottomDoor) Then

        End If
    End Sub

    Private Sub picOldMan_Click(sender As Object, e As EventArgs) Handles picOldMan.Click
        If FrmGame.game.Player.inproximityof(New Hitbox(picOldMan), 50) Then
            FrmGame.game.read(5)
        End If
    End Sub

    Private Sub frmStage3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmGame.game.bolMenu = False
    End Sub

End Class