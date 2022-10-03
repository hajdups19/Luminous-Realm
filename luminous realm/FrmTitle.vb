Public Class FrmTitle
    'Peter Hajduk 3/10/22 Luminous Realm, A 2D game focused on exploring the land of Sol, uncovering the path towards the mountain of the Illuminant duke and defeating it.
    Public strDirectory As String = Application.StartupPath 'gets the path of the exe
    Dim i As Integer = 0
    Public guiauto As Boolean = True ' whether the gui scales based on window size
    Dim music As Boolean = False ' whether music plays in the title screen
    Public guiscale As Double = 1 ' the current gui scale
    Public intframe As Integer = 10, reverse = True ' animation elements, frame: the current frame; reverse: whether it goes in reverse order
    Public ticks As Integer = 0
    Public animation As New AnimationManager()
    Public currentForm As Form = Me ' the currentform for animation
    Public Function centerwidth()
        Return Me.Width / 2 - (btnPlay.Size.Width / 2) 'Returns the center width of the window
    End Function
    Public Function centerheight()
        Return Me.Height / 2 - btnPlay.Size.Height 'Returns the center height of the window
    End Function
    Sub scalebutton(btn As Button) 'Scales each button to appropriate size
        If Not btn.Size.Equals(New Size(intScaledValue(150), intScaledValue(50))) Then
            btn.Size = New Size(intScaledValue(150), intScaledValue(50))
            btn.Font = New Font(btnPlay.Font.FontFamily, Single.Parse(intScaledValue(12)), FontStyle.Regular)
        End If
    End Sub
    Public Sub changeImage(ByRef item As Control, path As String) ' sets all image related checks to one place for easy debugging
        Try
            Dim img As Image = Image.FromFile(strDirectory & "\resources\" & path)
            item.BackColor = Color.Transparent
            item.BackgroundImage = img
        Catch ex As Exception
            item.BackColor = Color.Red ' A failsafe to let the player know that resources aren't available
        End Try
    End Sub

    Public Sub useAnimatedBackground(form As Form)
        ticks += 1
        If ticks = 8 Then
            animation.animate(intframe, 10, reverse, form, "main menu\titlebackground") ' animates the title screen
            ticks = 0
        End If
    End Sub

    Public Function intScaledValue(base As Integer) ' includes the gui scaling in the original value
        Return base * guiscale
    End Function

    Public Function intTrueValue(base As Integer) ' The value without gui scaling in place.
        Return base / guiscale
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If currentForm IsNot Nothing Then
            If currentForm.Equals(Me) Then
                picTitleScreen.Size = New Size(430 * guiscale, 150 * guiscale)
                scalebutton(btnPlay)
                If Not picTitleScreen.Location.Equals(New Point(centerwidth() - (140 * guiscale), centerheight() - (175 * guiscale))) Then
                    picTitleScreen.Location = New Point(centerwidth() - (140 * guiscale), centerheight() - (175 * guiscale))
                    btnPlay.Location = New Point(centerwidth, centerheight) ' centers the buttons
                End If
            End If
            If currentForm.Width >= 880 And currentForm.Height >= 880 And guiauto Then 'controls the gui scale
                guiscale = 2
            Else
                guiscale = 1
            End If
            useAnimatedBackground(currentForm)
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        currentForm = FrmSaves
        FrmSaves.Show()
        Me.Hide()
    End Sub

    Private Sub checkFolder(path As String)
        If Not IO.Directory.Exists(path) Then
            IO.Directory.CreateDirectory(strDirectory & "\saves")
        End If
    End Sub

    Private Sub checkFile(path As String)
        If Not IO.File.Exists(path) Then
            IO.File.Create(path)
        End If
    End Sub

    Private Sub FrmTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If music Then My.Computer.Audio.Play(strDirectory + "/resources/Luminous Reality alpha.wav", AudioPlayMode.BackgroundLoop)
        checkFolder(strDirectory & "\resources")
        checkFolder(strDirectory & "\saves")
        checkFile(strDirectory & "\saves\Player1.json")
        checkFile(strDirectory & "\saves\Player2.json")
        checkFile(strDirectory & "\saves\Player3.json")
        'IO.File.ReadAllBytes().Length
    End Sub

    Public Sub highlightbutton(btn As Button, path As String)
        setButton(btn, path & "_highlighted")
    End Sub

    Public Sub setButton(btn As Button, path As String) ' Centeralises the button highlighting for debugging
        Try ' Checks if the file exists
            btn.ForeColor = Color.Black
            btn.BackgroundImage = Image.FromFile(strDirectory + "\resources\" & path & ".png")
        Catch ex As Exception 'Colors the text so the user atleast knows it's highlighted
            btn.ForeColor = Color.Red
        End Try
    End Sub

    Public Sub selectButton(btn As Button, path As String)
        setButton(btn, path & "_selected")
    End Sub

    Private Sub btnPlay_MouseLeave(sender As Object, e As EventArgs) Handles btnPlay.MouseLeave
        setButton(btnPlay, "Button")
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPlay_MouseEnter(sender As Object, e As EventArgs) Handles btnPlay.MouseEnter
        highlightbutton(btnPlay, "Button")
    End Sub

End Class
Public Class AnimationManager 'Handles animating pictureboxes/forms, Is used in title screen, player and other models
    Public Sub New()

    End Sub

    Public Sub handleFrames(ByRef frame As Integer, maxFrames As Integer, ByRef reverse As Boolean)
        If reverse Then
            frame -= 1
        Else
            frame += 1
        End If
        If frame = (maxFrames + 1) Then
            reverse = True
            frame -= 2
        End If
        If frame = 0 Then
            reverse = False
            frame = 1
        End If
    End Sub


    Public Sub animate(ByRef frame As Integer, maxFrames As Integer, ByRef reverse As Boolean, item As PictureBox, directory As String)
        handleFrames(frame, maxFrames, reverse)
        FrmTitle.changeImage(item, directory & frame & ".png")
    End Sub

    Public Sub animate(ByRef frame As Integer, maxFrames As Integer, ByRef reverse As Boolean, item As Form, directory As String)
        handleFrames(frame, maxFrames, reverse)
        Try
            item.BackgroundImage = Image.FromFile(FrmTitle.strDirectory & directory & frame & ".png")
        Catch ex As Exception
            item.BackColor = Color.Red
        End Try
    End Sub


End Class
