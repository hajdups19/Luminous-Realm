Public Class FrmStage2
    Private Sub FrmStage2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        FrmGame.game.keydowntick(e)
    End Sub
    Private Sub FrmStage2_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        FrmGame.game.keyuptick(e)
    End Sub

    Private Sub FrmStage2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmGame.game.frmAttached = Me
        FrmGame.game.bolMenu = False
    End Sub

    Private Sub picNoteLeft_Click(sender As Object, e As EventArgs) Handles picNoteLeft.Click
        If FrmGame.game.Player.inproximityof(New Hitbox(FrmGame.game.leftnote.picEntity), 50) Then
            FrmGame.game.read(1)
        End If
    End Sub

    Private Sub picNoteTop_Click(sender As Object, e As EventArgs) Handles picNoteTop.Click
        If FrmGame.game.Player.inproximityof(New Hitbox(FrmGame.game.upnote.picEntity), 50) Then
            FrmGame.game.read(2)
        End If
    End Sub

    Private Sub picNoteBottom_Click(sender As Object, e As EventArgs) Handles picNoteBottom.Click
        If FrmGame.game.Player.inproximityof(New Hitbox(FrmGame.game.downnote.picEntity), 50) Then
            FrmGame.game.read(3)
        End If
    End Sub

    Private Sub picNoteRight_Click(sender As Object, e As EventArgs) Handles picNoteRight.Click
        If FrmGame.game.Player.inproximityof(New Hitbox(FrmGame.game.rightnote.picEntity), 50) Then
            FrmGame.game.read(4)
        End If
    End Sub

    Private Sub picCeremonyKey_Click(sender As Object, e As EventArgs) Handles picCeremonyKey.Click
        If FrmGame.game.Player.inproximityof(New Hitbox(FrmGame.game.key.picEntity), 50) Then
            FrmGame.game.Player.recieve(FrmGame.game.key)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class