Public Class FrmGame
    Public game As Game
    Dim leftTick As Integer = 0, rightTick = 0

    Private Sub FrmGame_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        game.keyuptick(e)
    End Sub

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        game = New Game(Me, FrmSaves.gameSave)
    End Sub

    Private Sub FrmGame_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        game.keydowntick(e)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            game.tick() ' This runs no matter what stage it is
        Catch ex As Exception ' auto closes when the game is closed, currently it doesn't close due to each form being hidden not closed
            MsgBox(ex.Message)
            'FrmTitle.Close()
            'FrmSaves.Close()
            'FrmCreate.Close()
            ' Me.Close()
            'FrmStage2.Close()
            'frmStage3.Close()
            'FrmStage4.Close()
            'FrmStage5.Close()
        End Try
    End Sub

    Private Sub picGlasses_Click(sender As Object, e As EventArgs) Handles picGlasses.Click
        If game.Player.inproximityof(New Hitbox(game.glasses.picEntity), 50) Then
            game.Player.recieve(game.glasses)
        End If
    End Sub

    Private Sub picNoteBoard_Click(sender As Object, e As EventArgs) Handles picNoteBoard.Click
        If game.Player.inproximityof(New Hitbox(game.noteboard.picEntity), 50) Then
            game.read(0)
        End If
    End Sub

    Private Sub tmrLeftDoubleClick_Tick(sender As Object, e As EventArgs) Handles tmrLeftDoubleClick.Tick
        game.leftClick = False
        leftTick += 1
        If leftTick >= 2 Then
            game.leftClick = True
            leftTick = 0
            tmrLeftDoubleClick.Stop()
        End If
    End Sub

    Private Sub tmrRightDoubleClick_Tick(sender As Object, e As EventArgs) Handles tmrRightDoubleClick.Tick
        game.rightClick = False
        rightTick += 1
        If rightTick >= 2 Then
            game.rightClick = True
            rightTick = 0
            tmrRightDoubleClick.Stop()
        End If
    End Sub
End Class