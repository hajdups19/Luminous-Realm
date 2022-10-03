Public Class FrmMountain
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        FrmTitle.highlightbutton(Button1, "Button")
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        FrmTitle.setButton(Button1, "Button")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmLevel1.Close()
        FrmLevel2.Close()
        FrmLevel3.Close()
        FrmLevel4.Close()
        FrmLevel5.Close()
        FrmStage2.Close()
        frmStage3.Close()
        FrmStage4.Close()
        FrmStage5.Close()
        FrmGame.Close()
        FrmSaves.Close()
        Me.Close()
    End Sub
End Class