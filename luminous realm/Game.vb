Imports Newtonsoft.Json, System.IO
'Peter Hajduk 3/10/22 Luminous Realm, A 2D game focused on exploring the land of Sol, uncovering the path towards the mountain of the Illuminant duke and defeating it.
Public Class Game ' Where majority of the game code is kept :D
    Public picFrame As New PictureBox ' The active frame to allow for resizing the window
    Public frmAttached As Form ' The form that is attached to the game
    Public Player As PlayerEntity
    Public enemies As New List(Of EnemyEntity)
    Public Entities As New List(Of Entity) ' Where all the entities are stored in
    Public intStage As Integer = 1 ' the player stage
    Public bed As Entity, bookshelf As Entity, desk As Entity, desk2 As Entity, glasses As ItemEntity, keyboard As Entity, computer As Entity, monitor As Entity, lock As Entity, door As Entity, angel As Entity, noteboard As Entity ' Stage 1 assets
    Public key As ItemEntity, leftnote As Entity, rightnote As Entity, upnote As Entity, downnote As Entity, portal As Entity, bench As Entity, leftdoor As Entity, rightdoor As Entity, topdoor As Entity, bottomdoor As Entity ' Stage 2 Assets
    Public oldman As Entity, porch As Entity, gravestone1 As Entity, gravestone2 As Entity, gravestone3 As Entity, gravestone4 As Entity, gravestone5 As Entity, gravestone6 As Entity, s3bottomdoor As Entity ' Stage 3 Assets
    Public sol1 As Entity, sol2 As Entity, sol3 As Entity, sol4 As Entity, sol5 As Entity, sol6 As Entity, sol7 As Entity, sol8 As Entity, sol9 As Entity, sol10 As Entity, sol11 As Entity, sol12 As Entity, swordshrine As ItemEntity, s4topdoor As Entity ' Stage 4 Assets
    Public wall1 As Entity, wall2 As Entity, wall3 As Entity, wall4 As Entity, wall5 As Entity, wall6 As Entity, wall7 As Entity, authunit As Entity
    Public l1platform1 As Entity, l1platform2 As Entity, l1platform3 As Entity, l1platform4 As Entity, l1platform5 As Entity, l1platform6 As Entity
    Public l2platform1 As Entity, l2platform2 As Entity, l2platform3 As Entity, l2platform4 As Entity, l2platform5 As Entity, l2platform6 As Entity, l2platform7 As Entity
    Public l3platform1 As Entity, l3platform2 As Entity, l3platform3 As Entity, l3platform4 As Entity, l3platform5 As Entity, l3platform6 As Entity, l3platform7 As Entity, l3platform8 As Entity, l3platform9 As Entity, l3platform10 As Entity, l3platform11 As Entity
    Public l4platform1 As Entity, l4platform2 As Entity, l4platform3 As Entity, l4platform4 As Entity, l4platform5 As Entity, l4platform6 As Entity, l4platform7 As Entity
    Public l5platform1 As Entity, l5platform2 As Entity, l5platform3 As Entity, l5platform4 As Entity, l5platform5 As Entity, l5platform6 As Entity
    Public dukeplatform As Entity, illuminantDuke As IlluminantDukeEntity, healthbar As Entity, staminabar As Entity, health As Entity, stamina As Entity, hudicon As Entity, bossbar As Entity
    Public currentSave As SaveData
    Public pmtMovement As PromptEntity
    Public backgroundDim As Entity ' darkens the background for noteboards
    Public lblTitle As Entity
    Public lblDesc As Entity
    Public bolMenu As Boolean ' whether the player is inside of a menu usually a noteboard or dialogue
    Public btnClose As Entity
    Public bolVerified As Boolean ' whether you verified at the beginning of the game
    Public leftClick As Boolean = True, rightClick As Boolean = True 'For dashing, a mechanic in Luminous Realm
    Public isFlatMovement As Boolean = False ' whether it's the 2d top down movement or the platformer 2D movement
    Public Sub New(form As Form, save As SaveData) ' initialises global assets
        FrmTitle.guiscale = 1
        currentSave = save
        Me.frmAttached = form

        backgroundDim = New Entity("blur", New PictureBox, Me, False, True, 0, 0, False)
        configure(New Entity("frame", picFrame, Me, False, True, 0, 0, False), 0, 0, 832, 441, "stage1_frame.png")
        configure(backgroundDim, 0, 0, 832, 441, "blur.png")
        lblTitle = New Entity("title", New Label(), Me, False, True, 25, 25, False)
        lblDesc = New Entity("desc", New Label(), Me, False, True, 25, 85, False)
        btnClose = New Entity("close", New Button, Me, False, True, 315, 325, False)
        Dim titlefont As Font = New Font(frmAttached.Font.FontFamily, Single.Parse(16), FontStyle.Bold)
        Dim descfont As Font = New Font(frmAttached.Font.FontFamily, Single.Parse(12), FontStyle.Regular)
        Dim btnFont As Font = New Font(frmAttached.Font.FontFamily, Single.Parse(16), FontStyle.Bold)
        lblConfigure(lblTitle, 25, 25, 780, 40, titlefont)
        lblConfigure(lblDesc, 25, 85, 780, 300, descfont)
        btnConfigure(btnClose, 315, 325, 200, 50, btnFont)
        backgroundDim.picEntity.BackgroundImageLayout = ImageLayout.Tile
        frmAttached.Controls.Add(picFrame)


        Player = New PlayerEntity(New PictureBox(), Me, 200, 100)
        configure(Player, picFrame.Location.X + 25, picFrame.Location.Y - 25, 50, 100, "player.png")
        loadStage1Assets()

        'key.picEntity.BringToFront()
        'desk.picEntity.SendToBack()
        backgroundDim.picEntity.Visible = False
        lblTitle.lblEntity.Visible = False
        lblDesc.lblEntity.Visible = False
        btnClose.btnEntity.Visible = False
        picFrame.SendToBack()
        backgroundDim.picEntity.BringToFront()
        lblTitle.lblEntity.BringToFront()
        lblDesc.lblEntity.BringToFront()
        btnClose.btnEntity.BringToFront()
    End Sub

    'For each of the loading stages, the entities for that stage is initalised and then loaded into the game
    Public Sub loadStage1Assets()
        bed = New Entity("bed", FrmGame.picBed, Me)
        bookshelf = New Entity("bookshelf", FrmGame.picBookshelf, Me)
        desk = New Entity("desk", FrmGame.picDesk, Me)
        desk2 = New Entity("desk2", FrmGame.picDesk2, Me)
        glasses = New ItemEntity(New Item("glasses"), FrmGame.picGlasses, Me)
        keyboard = New Entity("keyboard", FrmGame.picKeyboard, Me)
        computer = New Entity("glasses", FrmGame.picComputer, Me)
        monitor = New Entity("monitor", FrmGame.picMonitor, Me)
        lock = New Entity("lock", FrmGame.picLock, Me)
        door = New Entity("door", FrmGame.picDoor, Me)
        angel = New Entity("angel", FrmGame.picAngelStatue, Me)
        noteboard = New Entity("noteboard", FrmGame.picNoteBoard, Me)
        pmtMovement = New PromptEntity("movement", New PictureBox(), Me, True, Player.intX, Player.picEntity.Location.Y - Player.picEntity.Size.Height, False, 15)
        load(bed)
        load(bookshelf)
        load(desk)
        load(desk2)
        load(glasses)
        load(keyboard)
        load(computer)
        load(monitor)
        load(lock)
        load(desk)
        load(angel)
        load(noteboard)
        load(door)
        pmtMovement.picEntity.BringToFront()
        configure(pmtMovement, Player.picEntity.Location.X - 80, Player.picEntity.Location.Y - Player.picEntity.Size.Height - 25, 160, 40, "movement_prompt.png")
    End Sub
    'For each of the loading stages, the entities for that stage is initalised and then loaded into the game
    Public Sub loadStage2Assets()
        key = New ItemEntity(New Item("key"), FrmStage2.picCeremonyKey, Me)
        leftnote = New Entity("leftnote", FrmStage2.picNoteLeft, Me)
        rightnote = New Entity("rightnote", FrmStage2.picNoteRight, Me)
        upnote = New Entity("upnote", FrmStage2.picNoteTop, Me)
        downnote = New Entity("downnote", FrmStage2.picNoteBottom, Me)
        portal = New Entity("portal", FrmStage2.picPortal, Me)
        bench = New Entity("bench", FrmStage2.picBench, Me)
        leftdoor = New Entity("leftdoor", FrmStage2.picLeftDoor, Me)
        rightdoor = New Entity("rightdoor", FrmStage2.picRightDoor, Me)
        topdoor = New Entity("topdoor", FrmStage2.picTopDoor, Me)
        bottomdoor = New Entity("bottomdoor", FrmStage2.picBottomDoor, Me)
        load(key)
        load(leftnote)
        load(rightnote)
        load(upnote)
        load(downnote)
        load(portal)
        load(bench)
        load(leftdoor)
        load(rightdoor)
        load(topdoor)
        load(bottomdoor)
    End Sub
    'For each of the loading stages, the entities for that stage is initalised and then loaded into the game
    Public Sub loadStage3Assets()
        oldman = New Entity("oldman", frmStage3.picOldMan, Me)
        porch = New Entity("porch", frmStage3.picShack, Me)
        gravestone1 = New Entity("gravestone1", frmStage3.picGravestone1, Me)
        gravestone2 = New Entity("gravestone2", frmStage3.picGravestone2, Me)
        gravestone3 = New Entity("gravestone3", frmStage3.picGravestone3, Me)
        gravestone4 = New Entity("gravestone4", frmStage3.picGravestone4, Me)
        gravestone5 = New Entity("gravestone5", frmStage3.picGravestone5, Me)
        gravestone6 = New Entity("gravestone6", frmStage3.picGravestone6, Me)
        s3bottomdoor = New Entity("bottomdoorstage3", frmStage3.picBottomDoor, Me)

        load(oldman)
        load(porch)
        load(gravestone1)
        load(gravestone2)
        load(gravestone3)
        load(gravestone4)
        load(gravestone5)
        load(gravestone6)
        load(s3bottomdoor)
    End Sub
    'For each of the loading stages, the entities for that stage is initalised and then loaded into the game
    Public Sub loadStage4Assets()
        sol1 = New Entity("sol1", FrmStage4.picSol1, Me)
        sol2 = New Entity("sol2", FrmStage4.picSol2, Me)
        sol3 = New Entity("sol3", FrmStage4.picSol3, Me)
        sol4 = New Entity("sol4", FrmStage4.picSol4, Me)
        sol5 = New Entity("sol5", FrmStage4.picSol5, Me)
        sol6 = New Entity("sol6", FrmStage4.picSol6, Me)
        sol7 = New Entity("sol7", FrmStage4.picSol7, Me)
        sol8 = New Entity("sol8", FrmStage4.picSol8, Me)
        sol9 = New Entity("sol9", FrmStage4.picSol9, Me)
        sol10 = New Entity("sol10", FrmStage4.picSol10, Me)
        sol11 = New Entity("sol11", FrmStage4.picSol11, Me)
        sol12 = New Entity("sol12", FrmStage4.picSol12, Me)
        swordshrine = New ItemEntity(New Item("Solboundsword"), FrmStage4.picSwordShrine, Me)
        s4topdoor = New Entity("topdoorstage4", FrmStage4.picTopDoor, Me)

        load(sol1)
        load(sol2)
        load(sol3)
        load(sol4)
        load(sol5)
        load(sol6)
        load(sol7)
        load(sol8)
        load(sol9)
        load(sol10)
        load(sol11)
        load(sol12)
        load(swordshrine)
        load(s4topdoor)
    End Sub
    'For each of the loading stages, the entities for that stage is initalised and then loaded into the game
    Public Sub loadStage5Assets()
        wall1 = New Entity("wall1", FrmStage5.picWall1, Me)
        wall2 = New Entity("wall2", FrmStage5.picWall2, Me)
        wall3 = New Entity("wall3", FrmStage5.picWall3, Me)
        wall4 = New Entity("wall4", FrmStage5.picWall4, Me)
        wall5 = New Entity("wall5", FrmStage5.picWall5, Me)
        wall6 = New Entity("wall6", FrmStage5.picWall6, Me)
        wall7 = New Entity("wall7", FrmStage5.picWall7, Me)
        authunit = New Entity("authunit", FrmStage5.picAuthUnit, Me)

        load(wall1)
        load(wall2)
        load(wall3)
        load(wall4)
        load(wall5)
        load(wall6)
        load(wall7)
        load(authunit)
    End Sub
    'For each of the loading levels, the entities for that stage is initalised and then loaded into the game
    Public Sub loadLevel1Assets()
        l1platform1 = New Entity("platform1level1", FrmLevel1.picPlatform1, Me)
        l1platform2 = New Entity("platform2level1", FrmLevel1.picPlatform2, Me)
        l1platform3 = New Entity("platform3level1", FrmLevel1.picPlatform3, Me)
        l1platform4 = New Entity("platform4level1", FrmLevel1.picPlatform4, Me)
        l1platform5 = New Entity("platform5level1", FrmLevel1.picPlatform5, Me)
        l1platform6 = New Entity("platform6level1", FrmLevel1.picPlatform6, Me)

        load(l1platform1)
        load(l1platform2)
        load(l1platform3)
        load(l1platform4)
        load(l1platform5)
        load(l1platform6)
    End Sub
    'For each of the loading levels, the entities for that stage is initalised and then loaded into the game
    Public Sub loadLevel2Assets()
        l2platform1 = New Entity("platform1level2", FrmLevel2.picPlatform1, Me)
        l2platform2 = New Entity("platform2level2", FrmLevel2.picPlatform2, Me)
        l2platform3 = New Entity("platform3level2", FrmLevel2.picPlatform3, Me)
        l2platform4 = New Entity("platform4level2", FrmLevel2.picPlatform4, Me)
        l2platform5 = New Entity("platform5level2", FrmLevel2.picPlatform5, Me)
        l2platform6 = New Entity("platform6level2", FrmLevel2.picPlatform6, Me)
        l2platform7 = New Entity("platform7level2", FrmLevel2.picPlatform7, Me)

        load(l2platform1)
        load(l2platform2)
        load(l2platform3)
        load(l2platform4)
        load(l2platform5)
        load(l2platform6)
        load(l2platform7)
    End Sub
    'For each of the loading levels, the entities for that stage is initalised and then loaded into the game
    Public Sub loadLevel3Assets()
        l3platform1 = New Entity("platform1level3", FrmLevel3.picPlatform1, Me)
        l3platform2 = New Entity("platform2level3", FrmLevel3.picPlatform2, Me)
        l3platform3 = New Entity("platform3level3", FrmLevel3.picPlatform3, Me)
        l3platform4 = New Entity("platform4level3", FrmLevel3.picPlatform4, Me)
        l3platform5 = New Entity("platform5level3", FrmLevel3.picPlatform5, Me)
        l3platform6 = New Entity("platform6level3", FrmLevel3.picPlatform6, Me)
        l3platform7 = New Entity("platform7level3", FrmLevel3.picPlatform7, Me)
        l3platform8 = New Entity("platform8level3", FrmLevel3.picPlatform8, Me)
        l3platform9 = New Entity("platform9level3", FrmLevel3.picPlatform9, Me)
        l3platform10 = New Entity("platform10level3", FrmLevel3.picPlatform10, Me)
        l3platform11 = New Entity("platform11level3", FrmLevel3.picPlatform11, Me)

        load(l3platform1)
        load(l3platform2)
        load(l3platform3)
        load(l3platform4)
        load(l3platform5)
        load(l3platform6)
        load(l3platform7)
        load(l3platform8)
        load(l3platform9)
        load(l3platform10)
        load(l3platform11)
    End Sub
    'For each of the loading levels, the entities for that stage is initalised and then loaded into the game
    Public Sub loadLevel4Assets()
        l4platform1 = New Entity("platform1level4", FrmLevel4.picPlatform1, Me)
        l4platform2 = New Entity("platform2level4", FrmLevel4.picPlatform2, Me)
        l4platform3 = New Entity("platform3level4", FrmLevel4.picPlatform3, Me)
        l4platform4 = New Entity("platform4level4", FrmLevel4.picPlatform4, Me)
        l4platform5 = New Entity("platform5level4", FrmLevel4.picPlatform5, Me)
        l4platform6 = New Entity("platform6level4", FrmLevel4.picPlatform6, Me)
        l4platform7 = New Entity("platform7level4", FrmLevel4.picPlatform7, Me)

        load(l4platform1)
        load(l4platform2)
        load(l4platform3)
        load(l4platform4)
        load(l4platform5)
        load(l4platform6)
        load(l4platform7)
    End Sub
    'For each of the loading levels, the entities for that stage is initalised and then loaded into the game
    Public Sub loadLevel5Assets()
        l5platform1 = New Entity("platform1level5", FrmLevel5.picPlatform1, Me)
        l5platform2 = New Entity("platform2level5", FrmLevel5.picPlatform2, Me)
        l5platform3 = New Entity("platform3level5", FrmLevel5.picPlatform3, Me)
        l5platform4 = New Entity("platform4level5", FrmLevel5.picPlatform4, Me)
        l5platform5 = New Entity("platform5level5", FrmLevel5.picPlatform5, Me)
        l5platform6 = New Entity("platform6level5", FrmLevel5.picPlatform6, Me)

        load(l5platform1)
        load(l5platform2)
        load(l5platform3)
        load(l5platform4)
        load(l5platform5)
        load(l5platform6)
    End Sub

    Public Sub load(entity As Entity) 'adds an entity to the list
        Entities.Add(entity)
    End Sub

    Public Sub Save(save As SaveData) ' writes the data from the currentsave onto the json file depicted by it's path
        Using writer As JsonTextWriter = New JsonTextWriter(File.CreateText(save.strPath))
            writer.WriteStartObject()
            writer.WritePropertyName("Name")
            writer.WriteValue(save.strName)
            writer.WritePropertyName("Gender")
            writer.WriteValue(save.strGender)
            writer.WritePropertyName("Difficulty")
            writer.WriteValue(save.intDifficulty)
            writer.WritePropertyName("Stage")
            writer.WriteValue(save.intStage)
            writer.WritePropertyName("Tutorial")
            writer.WriteValue(save.bolTutorial)
            writer.WritePropertyName("Stage 3 Unlocked")
            writer.WriteValue(save.bolStage3)
            writer.WritePropertyName("Stage 4 Unlocked")
            writer.WriteValue(save.bolStage4)
            writer.WritePropertyName("Stage 5 Unlocked")
            writer.WriteValue(save.BolStage5)
            writer.WritePropertyName("Illuminant Defeated")
            writer.WriteValue(save.bolBeatenGame)
            writer.WriteEndObject()
        End Using
    End Sub
    'configures entities
    Public Sub configure(entity As Entity, intx As Integer, inty As Integer, width As Integer, height As Integer, img As String) ' properties of the entity are set, it stills needs to be added to a form
        entity.picEntity.Location = New Point(intx, inty)
        entity.picEntity.Width = width
        entity.picEntity.Height = height
        entity.picEntity.BackgroundImageLayout = ImageLayout.Zoom
        FrmTitle.changeImage(entity.picEntity, img)
    End Sub
    'configures label entities
    Public Sub lblConfigure(entity As Entity, intx As Integer, inty As Integer, width As Integer, height As Integer, font As Font)
        entity.lblEntity.BackColor = Color.Transparent
        entity.lblEntity.AutoSize = False
        entity.lblEntity.Font = font
        entity.lblEntity.Location = New Point(intx, inty)
        entity.lblEntity.Size = New Size(width, height)
    End Sub
    'configures button entities
    Public Sub btnConfigure(entity As Entity, intx As Integer, inty As Integer, width As Integer, height As Integer, font As Font)
        entity.btnEntity.BackColor = Color.Transparent
        entity.btnEntity.Font = font
        entity.btnEntity.Location = New Point(intx, inty)
        entity.btnEntity.Size = New Size(width, height)
    End Sub

    Private Sub autohighlight(pic As PictureBox, name As String) 'highlights an image when close by
        Try
            If Player.inproximityof(New Hitbox(pic), 50) Then ' checks if player is in range
                FrmTitle.changeImage(pic, name & "_highlighted.png")
            Else
                FrmTitle.changeImage(pic, name & ".png")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub stageMovementCheck() ' checks for each collision then either move stages or lock/unlock the lock
        Select Case intStage
            Case 1
                If Player.inproximityof(New Hitbox(lock.picEntity), 100) And Not IsDBNull(FrmGame.picLock) Then
                    FrmTitle.changeImage(FrmGame.picLock, "lock_unlocked.png")
                Else
                    FrmTitle.changeImage(FrmGame.picLock, "lock_locked.png")
                End If
                autohighlight(noteboard.picEntity, "noteboard")

                If Player.iscollidingwith(New Hitbox(door.picEntity)) And isActiveForm(FrmGame) Then
                    currentSave.bolTutorial = False
                    moveToStage(2, "left")
                End If
                autohighlight(glasses.picEntity, "glasses")
            Case 2
                If Not bolMenu Then
                    If Player.iscollidingwith(New Hitbox(FrmStage2.picLeftDoor)) And isActiveForm(FrmStage2) Then
                        moveToStage(1, "right")
                    End If
                    If Player.iscollidingwith(New Hitbox(FrmStage2.picTopDoor)) And isActiveForm(FrmStage2) And Player.inventory.contains(Player.inventory.getItem("key")) Then
                        moveToStage(3, "down")
                    End If
                    If Player.iscollidingwith(New Hitbox(FrmStage2.picBottomDoor)) And isActiveForm(FrmStage2) And Player.inventory.contains(Player.inventory.getItem("worthy")) Then
                        moveToStage(4, "up")
                    End If
                    If Player.iscollidingwith(New Hitbox(FrmStage2.picRightDoor)) And isActiveForm(FrmStage2) And Player.inventory.contains(Player.inventory.getItem("Solboundsword")) Then
                        moveToStage(5, "left")
                    End If
                    autohighlight(FrmStage2.picCeremonyKey, "hall_of_sols_key")
                End If
            Case 3
                If Player.iscollidingwith(New Hitbox(frmStage3.picBottomDoor)) And isActiveForm(frmStage3) Then
                    moveToStage(2, "up")
                End If
            Case 4
                If Player.iscollidingwith(New Hitbox(s4topdoor.picEntity)) And isActiveForm(FrmStage4) Then
                    moveToStage(2, "down")
                End If
                autohighlight(swordshrine.picEntity, "solbound_sword_shrine")
        End Select
    End Sub

    Public Sub moveToStage(stage As Integer, fromDir As String) ' Moves the player and background between forms
        frmAttached.Controls.Remove(picFrame)
        frmAttached.Hide()

        Select Case stage ' Changes the form attached to the new form
            Case 1
                frmAttached = FrmGame
                currentSave.intStage = 1
            Case 2
                frmAttached = FrmStage2
                currentSave.intStage = 2
            Case 3
                frmAttached = frmStage3
                currentSave.intStage = 3
            Case 4
                frmAttached = FrmStage4
                currentSave.intStage = 4
            Case 5
                frmAttached = FrmStage5
                currentSave.intStage = 5
            Case 6
                frmAttached = FrmLevel1
                currentSave.intStage = 6
            Case 7
                frmAttached = FrmLevel2
                currentSave.intStage = 7
            Case 8
                frmAttached = FrmLevel3
                currentSave.intStage = 8
            Case 9
                frmAttached = FrmLevel4
                currentSave.intStage = 9
            Case 10
                frmAttached = FrmLevel5
                currentSave.intStage = 10
            Case 11
                frmAttached = FrmBoss
                currentSave.intStage = 11
            Case Else
                frmAttached = FrmGame
                currentSave.intStage = 1
        End Select
        Select Case fromDir ' sets the position that the player goes to
            Case "left"
                Player.intX = 50
                Player.intY = 215
            Case "right"
                Player.intX = 400
                Player.intY = 215
            Case "up"
                Player.intX = 400
                Player.intY = 50
            Case "down"
                Player.intX = 400
                Player.intY = 200
            Case "platform"
                Player.intX = 0
                Player.intY = 350
        End Select
        Player.picEntity.Location = New Point(FrmTitle.intScaledValue(25) + FrmTitle.intScaledValue(Player.intX), FrmTitle.intScaledValue(25) + FrmTitle.intScaledValue(Player.intY)) 'Allows resizing of the window whilst retaining key elements
        Player.hitbox = New Hitbox(Player.picEntity)
        Entities.Clear()
        Entities.Add(Player)

        Save(currentSave)
        frmAttached.Show()
        'changes the forms of key elements to the player experience
        lblTitle.changeForms(frmAttached, "lbl")
        lblDesc.changeForms(frmAttached, "lbl")
        backgroundDim.changeForms(frmAttached, "pic")
        Player.changeForms(frmAttached, "pic")
        frmAttached.Controls.Add(picFrame)
        picFrame.SendToBack()
        backgroundDim.picEntity.BringToFront()
        lblTitle.lblEntity.BringToFront()
        lblDesc.lblEntity.BringToFront()

        Select Case stage ' loads the appropiate updates
            Case 1
                loadStage1Assets()
            Case 2
                loadStage2Assets()
            Case 3
                loadStage3Assets()
            Case 4
                loadStage4Assets()
            Case 5
                loadStage5Assets()
            Case 6
                loadLevel1Assets()
            Case 7
                loadLevel2Assets()
            Case 8
                loadLevel3Assets()
            Case 9
                loadLevel4Assets()
            Case 10
                loadLevel5Assets()
            Case 11
                loadFinalBoss()
        End Select
        Me.intStage = stage
    End Sub

    Public Sub loadFinalBoss() ' initalises entites for the boss and loads them
        dukeplatform = New Entity("dukeplatform", FrmBoss.picPlatform, Me)
        illuminantDuke = New IlluminantDukeEntity("illuminantduke", FrmBoss.picIlluminantDuke, Me, FrmBoss.picIlluminantDuke.Location.X - 25, FrmBoss.picIlluminantDuke.Location.Y - 25, 400, New Integer() {10, 25, 50})
        healthbar = New Entity("healthbar", FrmBoss.picHealthbar, Me)
        staminabar = New Entity("staminabar", FrmBoss.picStaminabar, Me)
        health = New Entity("health", FrmBoss.picHealth, Me)
        stamina = New Entity("stamina", FrmBoss.picStamina, Me)
        bossbar = New Entity("bossbar", FrmBoss.picBossbar, Me)
        hudicon = New Entity("playerhud", FrmBoss.picIcon, Me)
        load(dukeplatform)
        load(illuminantDuke)
        illuminantDuke.picEntity.BringToFront()
    End Sub

    Public Function isActiveForm(form As Form)
        If frmAttached.Equals(form) Then ' Checks if the form attached to the game is equal to the form being checked for. This is to prevent looping from collisions of previous forms
            Return True
        Else Return False
        End If
    End Function

    Private Sub move(direction As String, ByRef bolDir As Boolean)
        Player.direction = direction
        bolDir = True
        pmtMovement.isDestructing = True
    End Sub

    Public Sub keydowntick(e As KeyEventArgs)
        If Not bolMenu Then
            If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
                move("up", Player.moveup) ' moves up or jumps (if in platformer mode) when the w/up arrow is detected
            End If
            If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then ' detects if the left key is pressed and moves left, also with dash functionality in platformer mode
                If Not leftClick And Not Player.moveleft Then Player.isDash = True
                If leftClick Then FrmGame.tmrLeftDoubleClick.Start()
                move("left", Player.moveleft)
            End If
            If e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
                move("down", Player.movedown) ' moves down when the key is pressed
            End If
            If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then ' detects if the right key is pressed and moves left, also with dash functionality in platformer mode
                If Not rightClick And Not Player.moveright Then Player.isDash = True
                If rightClick Then FrmGame.tmrRightDoubleClick.Start()
                move("right", Player.moveright)
            End If
            If e.KeyCode = Keys.Space And isFlatMovement Then
                move("up", Player.moveup) ' adds the space to jump functionality
            End If
            If e.KeyCode = Keys.F3 Then
                moveToStage(11, "platform") ' An experimental menu which skips you to the boss fight for debugging/testing
            End If
            If e.KeyCode = Keys.E Then
                If isActiveForm(FrmGame) Then
                    If Player.inproximityof(New Hitbox(noteboard.picEntity), 50) Then
                        read(0) ' reads the noteboard when in range of the noteboard and press e to view
                    End If
                    If Player.inproximityof(New Hitbox(glasses.picEntity), 50) Then
                        Player.recieve(glasses) ' recieves the glasses
                    End If
                    If Player.inproximityof(New Hitbox(lock.picEntity), 100) And Not bolVerified Then
                        FrmVerification.ShowDialog() ' displays the prompt for "verification"
                    End If
                End If
                If isActiveForm(FrmStage2) Then 'appropiately moves the player to the correct prompt for the noteboard
                    If Player.inproximityof(New Hitbox(leftnote.picEntity), 50) Then read(1)
                    If Player.inproximityof(New Hitbox(upnote.picEntity), 50) Then read(2)
                    If Player.inproximityof(New Hitbox(downnote.picEntity), 50) Then read(3)
                    If Player.inproximityof(New Hitbox(rightnote.picEntity), 50) Then read(4)
                    If Player.inproximityof(key, 50) Then
                        Player.recieve(key) ' takes the key when player is in range
                        currentSave.bolStage3 = True
                        key.remove()
                    End If
                End If
                If isActiveForm(frmStage3) Then
                    If Player.inproximityof(New Hitbox(oldman.picEntity), 50) Then read(5) ' dialogue with the old man
                End If
                If isActiveForm(FrmStage4) Then
                    If Player.inproximityof(New Hitbox(swordshrine.picEntity), 50) Then
                        Player.recieve(swordshrine)
                        currentSave.BolStage5 = True
                        FrmTitle.changeImage(swordshrine.picEntity, "solbound_sword_shrine_empty.png")
                    End If
                End If
                If isActiveForm(FrmStage5) Then
                    If Player.inproximityof(authunit, 50) And Not bolVerified Then
                        FrmVerification.ShowDialog()
                    End If
                End If
            End If
        End If
        If e.KeyCode = Keys.Escape Then If bolMenu Then bolMenu = False
    End Sub
    Public Sub displayMessage() ' displays the noteboard message 
        bolMenu = True
        backgroundDim.picEntity.Visible = True
        lblTitle.lblEntity.Visible = True
        lblDesc.lblEntity.Visible = True
        btnClose.btnEntity.Visible = False
    End Sub
    Public Sub read(noteindex As Integer)
        If Not noteindex = 5 Then ' noteindex 5 is the old man's dialogue
            If Player.inventory.contains(Player.inventory.getItem("glasses")) Then ' makes sure the player has glasses
                Select Case noteindex
                    Case 0 ' The first stage message
                        lblTitle.lblEntity.Text = "Important Notice"
                        lblDesc.lblEntity.Text = "The colonised area of Sol has been invaded by the Illuminant Duke, a master of deception, able to create a veneer at any point. You, the player, are one of only 3 citizens left in Sol and must save us all from the illuminant duke's trap. Deception is the key to escaping your world and climbing the mountain to the Illuminant Duke. Don't believe everything you see around you as it could be a disguise to something more sinister. To exit the house, simply enter into the password lock the following code: 89 27 43 50. Once outside, collect the key left on my desk and visit me in the hall of sols. I'll direct you to the path towards saving the citizens of Sol."
                        displayMessage()
                    Case 1 ' the left noteboard of stage 2
                        lblTitle.lblEntity.Text = "Player's Humble Home"
                        lblDesc.lblEntity.Text = "This is the player's start of the game. Knowledge can be acquired here through books and is useful in another reality."
                        displayMessage()
                    Case 2 ' The top noteboard of stage 2
                        lblTitle.lblEntity.Text = "The Hall of Souls"
                        lblDesc.lblEntity.Text = "Here lies the unfortunate death of many citizens of Sol through the power of the Illuminant Duke. The old man lives here waiting for the next hero to save the sols from the corrupt Illuminant Duke."
                        displayMessage()
                    Case 3 ' The bottom noteboard of stage 2
                        lblTitle.lblEntity.Text = "The Solbound Shrine"
                        lblDesc.lblEntity.Text = "Only for the worthy hero able to wield this powerful weapon. The citizens before you built this weapon however was unable to use it against the Illuminant Duke. The trapped ghosts of sol live here, desiring their own freedom from the curse set upon them."
                        displayMessage()
                    Case 4 ' The right noteboard of stage 2
                        lblTitle.lblEntity.Text = "The Luminescence Gate"
                        lblDesc.lblEntity.Text = "Only the worthy can go through this gate as it's cursed by the Illuminant Duke that noone can enter the mountain he sits on top of. The members of sol discovered a loophole, however can only work using their unusable creation, the Solbound Sword. It's reccommended to gain knowledge to bypass the authenication unit built into the mountain, first obtained in the humble home you started from."
                        displayMessage()
                End Select
            Else ' You can't read
                lblTitle.lblEntity.Text = "Player attempts to read this message!"
                lblDesc.lblEntity.Text = "You can't read this message as you don't have your glasses on you. Get the glasses from your desk to read the message."
                displayMessage()
            End If
        Else ' Dialogue is kept here
            lblTitle.lblEntity.Text = "The Old Man Speaks"
            lblDesc.lblEntity.Text = "Hello traveller, I knew you'd be here. The Illuminant Duke murdered your family and many others. We have a weapon in the solbound shrine, however noone has ever able to wield the weapon... except you. Wield the sword in the solbound shrine and use it to enter through the Luminescence gate. Once you authorise yourself using the password obtained through knowledge in books, climb the mountain of fluorescence and obtain the truth of the realm, there you'll discover the path towards the Illuminant Duke."
            If Not Player.inventory.contains(Player.inventory.getItem("worthy")) Then
                currentSave.bolStage4 = True
                Player.inventory.addItem(New Item("worthy"))
            End If
            displayMessage()
        End If

    End Sub
    Public Sub keyuptick(e As KeyEventArgs) ' removes movement when the key is released
        If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
            Player.moveup = False
        ElseIf e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
            Player.moveleft = False
        ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
            Player.movedown = False
        ElseIf e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
            Player.moveright = False
        End If
        If e.KeyCode = Keys.Space And isFlatMovement Then
            Player.moveup = False
        End If
    End Sub

    Public Sub updateItems() ' determines if the stage has been reached then removes the item and adds it to the player's inventory for it to be used. To save time when playing in multiple sessions.
        If Not currentSave.bolTutorial And isActiveForm(FrmGame) Then
            lock.remove()
            glasses.remove()
            If Not Player.inventory.contains(Player.inventory.getItem("glasses")) Then
                Player.inventory.addItem(New Item("glasses"))
            End If
        End If
        If isActiveForm(FrmStage2) Then
            If currentSave.bolStage3 Then
                key.remove()
                If Not Player.inventory.contains(Player.inventory.getItem("key")) Then
                    Player.inventory.addItem(New Item("key"))
                End If
            End If
        End If
        If currentSave.bolStage4 Then
            If Not Player.inventory.contains(Player.inventory.getItem("worthy")) Then
                Player.inventory.addItem(New Item("worthy"))
            End If
        End If
        If currentSave.BolStage5 Then
            If Not Player.inventory.contains(Player.inventory.getItem("Solboundsword")) Then
                Player.inventory.addItem(New Item("Solboundsword"))
                FrmTitle.changeImage(FrmStage4.picSwordShrine, "solbound_sword_shrine_empty.png")
            End If
        End If
    End Sub

    Public Sub tick() ' runs every 0.05 seconds / 20 tps
        stageMovementCheck()
        If frmAttached.Width >= 1500 And frmAttached.Height >= 800 Then ' determines the scale of the game itself
            FrmTitle.guiscale = 2
        Else
            FrmTitle.guiscale = 1
        End If
        updateItems() 'Updates the items with the data from the save file
        'modifies the frame to be in the center of the screen and to adjust to gui scaling
        If Not picFrame.Size = New Size(832 * FrmTitle.guiscale, 441 * FrmTitle.guiscale) Then picFrame.Size = New Size(832 * FrmTitle.guiscale, 441 * FrmTitle.guiscale)
        If Not picFrame.Location = New Point((frmAttached.Width - (848 * FrmTitle.guiscale)) / 2, (frmAttached.Height - (480 * FrmTitle.guiscale)) / 2) Then picFrame.Location = New Point((frmAttached.Width - (848 * FrmTitle.guiscale)) / 2, (frmAttached.Height - (480 * FrmTitle.guiscale)) / 2)
        If Not bolMenu Then
            Player.tick()
            If isActiveForm(FrmBoss) Then 'allows the illuminant duke to function
                illuminantDuke.tick()
                healthbar.width = Player.health
                staminabar.width = Player.stamina
                bossbar.width = illuminantDuke.health
            End If
            pmtMovement.tick()
            backgroundDim.picEntity.Visible = False
            lblTitle.lblEntity.Visible = False
            lblDesc.lblEntity.Visible = False
            btnClose.btnEntity.Visible = False
        End If

        For Each e As Entity In Entities
            e.tick()
            e.changeFramePos(picFrame)
        Next

        If intStage >= 6 And intStage <= 11 Then
            isFlatMovement = True
        Else
            isFlatMovement = False
        End If
    End Sub
End Class

Public Class MovementPrompt ' the prompt at the beginning of the game
    Inherits PromptEntity
    Public Sub New(name As String, entity As PictureBox, game As Game, toList As Boolean, intx As Integer, inty As Integer, autoDestroy As Boolean, intDestroyTime As Integer)
        MyBase.New(name, entity, game, toList, intx, inty, autoDestroy, intDestroyTime)
    End Sub
End Class

Public Class PromptEntity
    Inherits Entity
    Protected intTicks As Integer ' the current amount of ticks before the entity is removed
    Public isDestructing As Boolean ' determines if the entity auto distructs
    Protected maxDestroyTicks As Integer ' the set amount of time to destroy
    Public Sub New(name As String, entity As PictureBox, game As Game, toList As Boolean, intx As Integer, inty As Integer, autoDestroy As Boolean, intDestroyTime As Integer)
        MyBase.New(name, entity, game, toList, True, intx, inty, False)
        isDestructing = autoDestroy
        maxDestroyTicks = intDestroyTime
    End Sub
    Public Shadows Sub tick() ' automatically distructs prompt after a few seconds
        intX = game.Player.intX - game.Player.picEntity.Size.Width
        intY = game.Player.intY - (game.Player.picEntity.Size.Height / 2)
        If isDestructing Then
            intTicks += 1
            If intTicks >= maxDestroyTicks Then
                intTicks = 0
                remove()
            End If
        End If
    End Sub
End Class

Public Class SaveData ' the format for each save is kept here
    Public strName As String, strGender As String, intDifficulty As Integer, intStage As Integer, bolTutorial As Boolean, bolStage3 As Boolean, bolStage4 As Boolean, BolStage5 As Boolean, bolBeatenGame As Boolean
    Public strPath As String ' the path of the save
    Public Sub New(path As String, name As String, gender As String, difficulty As Integer, stage As Integer, istutorial As Boolean, s3unlock As Boolean, s4unlock As Boolean, s5unlock As Boolean)
        strPath = path
        strName = name
        strGender = gender
        intDifficulty = difficulty
        intStage = stage
        bolTutorial = istutorial
        bolStage3 = s3unlock
        bolStage4 = s4unlock
        BolStage5 = s5unlock
        bolBeatenGame = False
    End Sub
End Class

Public Class Hitbox ' the bounding box of the entity that can interact with other entities through collision
    Dim intX As Integer(), intY As Integer(), arrHitbox As Integer()
    Public Sub New(entity As PictureBox)
        Me.arrHitbox = New Integer() {entity.Location.X, entity.Location.X + entity.Size.Width, entity.Location.Y, entity.Location.Y + entity.Size.Height}
        Me.intX = New Integer() {arrHitbox(0), arrHitbox(1)}
        Me.intY = New Integer() {arrHitbox(2), arrHitbox(3)}
    End Sub
    Public Sub New(int As Integer())
        Me.arrHitbox = int
        Me.intX = {arrHitbox(0), arrHitbox(1)}
        Me.intY = {arrHitbox(2), arrHitbox(3)}
    End Sub

    Public Function enlarge(range As Integer) As Hitbox ' returns a larger hitbox by the size
        Return New Hitbox(New Integer() {intX(0) - range, intX(1) + range, intY(0) - range, intY(1) + range})
    End Function
    Public Function getX()
        Return intX ' takes the X position of the hitbox
    End Function
    Public Function getY()
        Return intY ' takes the Y position of the hitbox
    End Function
End Class

Public Class Inventory ' where items are stored in game
    Dim LstItems As List(Of Item)
    Public Sub New(items As List(Of Item))
        LstItems = items
    End Sub

    Public Function getItem(index As Integer) ' gets the item relative to index
        Return LstItems(index)
    End Function

    Public Function getItem(name As String) ' gets the item based on the name
        For Each e As Item In LstItems
            If e.strname.Equals(name) Then
                Return e
            End If
        Next
        Return Nothing
    End Function

    Public Sub addItem(item As Item) ' adds an item to the list
        LstItems.Add(item)
    End Sub

    Public Function contains(i As Item) ' checks if the item is inside the inventory
        For Each e As Item In LstItems
            If e.Equals(i) Then
                Return True
            End If
        Next
        Return False
    End Function

End Class

Public Class Item ' for ingame items
    Public strname As String
    Public Sub New(name As String)
        Me.strname = name
    End Sub
End Class

Public Class ItemEntity ' For any entity that can be picked up by the player
    Inherits Entity ' vb for class extends Entity
    Public stritem As String
    Public item As Item
    Public bolisRecieved As Boolean
    Public Sub New(item As Item, entity As PictureBox, game As Game)
        MyBase.New(item.strname, entity, game, False, False, entity.Location.X - 25, entity.Location.Y - 25, True)
        Me.item = item
        Me.stritem = item.strname
    End Sub
End Class

Public Class IlluminantDukeEntity
    Inherits LivingEntity ' TODO complete Illuminant Duke
    Dim maxAttackDelay As Integer = 400
    Dim attackTick As Integer = 1
    Public Sub New(name As String, entity As PictureBox, game As Game, intX As Integer, intY As Integer, health As Integer, damage As Integer())
        MyBase.New(name, entity, game, intX, intY, health, damage)
        Select Case game.currentSave.intDifficulty 'chooses delay according to difficulty
            Case 0
                maxAttackDelay = 140
            Case 1
                maxAttackDelay = 80
            Case 2
                maxAttackDelay = 20
        End Select
    End Sub

    Public Sub randomXvalue(e As EnemyEntity, r As Random) ' chooses where the spikes go
        e.intX = r.Next(50, 700)
        If e.iscollidingwith(game.illuminantDuke.hitbox) Then
            randomXvalue(e, r)
        End If
    End Sub

    Public Sub spikes() ' runs spike attack
        Dim r As New Random()
        For i = 1 To 4
            Dim e As EnemyEntity = New EnemyEntity("spike" & i, New PictureBox(), game, 0, 0, 999, New Integer() {15, 30, 60})
            game.enemies.Add(e)
            If r.Next(1, 100) = 2 Then ' randomly chooses the winning spike
                e.type = "spikegreen"
                game.configure(e, 0, 0, 40, 40, "spike_health.png")
            Else
                e.type = "spike"
                game.configure(e, 0, 0, 40, 40, "spike.png")
            End If

            randomXvalue(e, r)
            e.intY = 75
            e.picEntity.BringToFront() ' makes the spike visible
        Next
    End Sub
    Public Shadows Sub tick()
        For Each e As EnemyEntity In game.enemies
            e.tick() ' ticks all enemies of illuminant duke
        Next
        attackTick -= 1
        If attackTick <= 0 Then ' chooses the attack when it's cooldown is finished
            spikes()
            attackTick = maxAttackDelay
        End If
    End Sub

End Class

Public Class LivingEntity
    Inherits Entity
    Public health As Integer
    Public stamina As Integer
    Public doesDamage As Boolean
    Public totalDamage As Integer()
    Public invTicks As Integer ' invulnerability ticks
    Public Sub New(name As String, entity As PictureBox, game As Game, intX As Integer, intY As Integer, health As Integer, damage As Integer())
        MyBase.New(name, entity, game, True, True, intX, intY, True)
        Me.health = health
        Me.stamina = 100
        If damage IsNot Nothing Then ' determines if the entity damages others
            totalDamage = damage
            doesDamage = True
        Else
            doesDamage = False
        End If
    End Sub

    Public Shadows Sub tick()
        If invTicks > 0 Then invTicks -= 1
        MyBase.tick()
    End Sub

    Public Sub damage(amount As Integer())
        damage(amount(game.currentSave.intDifficulty))
    End Sub
    Public Sub damage(amount As Integer)
        If invTicks = 0 Then
            health -= amount
            invTicks = 10
        End If
    End Sub
End Class

Public Class PlayerEntity
    Inherits LivingEntity
    Public moveup As Boolean = False, movedown = False, moveleft = False, moveright = False ' Separates each movement to each boolean to remove the keydown delay
    Public direction = "right"
    Public isDash As Boolean
    Dim intframe As Integer = 0
    Dim reverse As Boolean = False
    Dim staminatick As Integer = 15
    Public cancollide As Boolean = True
    Public Sub New(entity As PictureBox, game As Game, intx As Integer, inty As Integer)
        MyBase.New("player", entity, game, intx, inty, 100, Nothing)
        Me.game = game
        width = 50
        height = 100
    End Sub

    Private Sub leftrightMovement() ' moves left and right and allows for animated player movement
        If moveleft And moveright Then
            decdx = 0
            collision("X")
            FrmTitle.changeImage(picEntity, "/resources/player_right.png")
        ElseIf moveleft Then
            If Not decdx < -8 Then
                decdx = -8 * If(isDash And game.isFlatMovement And stamina >= 35, If(Not onGround, 4, 3), 1)
            End If
        ElseIf moveright Then
            If Not decdx > 8 Then
                decdx = 8 * If(isDash And game.isFlatMovement And stamina >= 35, If(Not onGround, 4, 3), 1)
            End If
        End If
        isDash = False
        If Not decdx = 0 Then decdx -= 2 * (decdx / Math.Abs(decdx))

        If Not collision("X") Then
            intX += decdx
            If Not decdx = 0 Then
                If decdx > 0 Then
                    FrmTitle.animation.animate(intframe, 5, reverse, picEntity, "player_right_walking")
                ElseIf decdx < 0 Then
                    FrmTitle.animation.animate(intframe, 5, reverse, picEntity, "player_left_walking")
                End If
            Else
                intframe = 0
                reverse = False
                If direction.Equals("left") Or direction.Equals("right") Then
                    FrmTitle.changeImage(picEntity, "player_" & direction & ".png")
                Else
                    FrmTitle.changeImage(picEntity, "player_right.png")
                End If
            End If

        End If
    End Sub

    Private Sub updownMovement() ' for up/down movement in top down mode
        If moveup Then ' modifies the velocity according to the movement key presed
            decdy = -8
        ElseIf movedown Then
            decdy = 8
        End If
        If Not decdy = 0 Then decdy -= 2 * (decdy / Math.Abs(decdy))
        If moveup And movedown Then
            decdy = 0
            collision("Y")
        End If
        If Not collision("Y") Then
            intY += decdy ' modifies Y value by it's velocity
        End If
        collision("Y")
    End Sub

    Private Sub topDownMovement() ' movement is split between two different modes
        leftrightMovement()
        updownMovement()
    End Sub

    Private Function gravityCollider()
        For Each e As Entity In game.Entities
            If intY = (e.intY - e.picEntity.Size.Height - 5) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub gravity()
        If moveup And onGround Then
            decdy = -16
            intY -= 1
            onGround = False
        End If

        If Not onGround Then decdy += 2
        If decdy >= 8 Then decdy = 8 ' Down velocity is hard capped at 8
        If collision("Y") Or gravityCollider() Then
            onGround = True
            If decdy > 0 Then decdy = 0
        Else
            onGround = False
            intY += decdy
        End If
    End Sub

    Private Sub flatMovement()
        leftrightMovement()
        gravity()
    End Sub

    Public Shadows Sub tick()
        If game.isFlatMovement Then
            flatMovement()
        Else
            topDownMovement()
        End If
        If health <= 0 Then
            health = 100
            stamina = 100
            game.moveToStage(1, "right")
        End If
        MyBase.tick()
    End Sub
End Class

Public Class EnemyEntity
    Inherits LivingEntity
    Public hasgravity As Boolean = True
    Public type As String
    Public Sub New(name As String, entity As PictureBox, game As Game, intX As Integer, intY As Integer, health As Integer, damage As Integer())
        MyBase.New(name, entity, game, intX, intY, health, damage)
        onGround = False
    End Sub
    Public Shadows Sub tick()
        If hasgravity Then
            If Not onGround Then decdy += 2
            If decdy >= 8 Then decdy = 8 ' Down velocity is hard capped at 8
            If collision("Y") Then
                onGround = True
                remove()
                If decdy > 0 Then decdy = 0
            Else
                onGround = False
                intY += decdy
            End If
        End If
        If iscollidingwith(game.Player.hitbox) Then
            If type.Equals("spikegreen") Then
                FrmMountain.Show()
                game.frmAttached.Close()
            Else
                game.Player.damage(totalDamage)
            End If
            game.enemies.Remove(Me)
            remove()
        End If
    End Sub
End Class


Public Class Entity
    Dim frm As Form
    Public intX As Integer ' the coordinates of the entity
    Public intY As Integer
    Protected onGround As Boolean = False
    Public decdx As Decimal 'Velocity of an entity
    Public decdy As Decimal 'dx and dy are the velocity
    Public hitbox As Hitbox
    Protected picFrame As PictureBox ' The frame where positions are calculated from
    Public strName As String ' The entity's name/identifier
    Public picEntity As PictureBox ' for Pictureboxes
    Public lblEntity As Label ' for Labels
    Public btnEntity As Button ' for Buttons
    Public game As Game ' The instance of the game
    Public inventory As New Inventory(New List(Of Item)) ' Where the items are stored in the entity
    Public isCollidable As Boolean ' whether or not it has a collision box
    Public width As Integer, height As Integer

    Public Sub updatesize() ' adjusts size according to gui settings'
        If Not picEntity.Size.Equals(New Size(FrmTitle.intScaledValue(width), FrmTitle.intScaledValue(height))) Then
            picEntity.Size = New Size(FrmTitle.intScaledValue(width), FrmTitle.intScaledValue(height))
        End If
    End Sub
    Public Sub remove()
        frm.Controls.Remove(picEntity)
        game.Entities.Remove(Me)
    End Sub

    Public Sub recieve(entity As ItemEntity) ' recieves items from itementities to the inventory of the entity
        If Not entity.bolisRecieved Then
            inventory.addItem(entity.item)
            entity.remove()
            entity.bolisRecieved = True
        End If
    End Sub
    'sets appropiate properties for each entity
    Public Sub New(name As String, entity As PictureBox, game As Game, toList As Boolean, toForm As Boolean, intx As Integer, inty As Integer, hasCollision As Boolean)
        Me.New(name, entity, game)
        Me.intX = intx
        Me.intY = inty
        Me.isCollidable = hasCollision
        picEntity.BackgroundImageLayout = ImageLayout.Zoom
        If toList Then game.Entities.Add(Me)
        If toForm Then frm.Controls.Add(picEntity)
    End Sub

    Public Sub New(name As String, entity As PictureBox, game As Game)
        hitbox = New Hitbox(entity)
        picEntity = entity
        picFrame = game.picFrame
        frm = game.frmAttached
        Me.strName = name
        Me.intX = picEntity.Location.X - 25
        Me.intY = picEntity.Location.Y - 25
        Me.game = game
        Me.width = picEntity.Size.Width
        Me.height = picEntity.Size.Height
        Me.isCollidable = True
    End Sub

    Public Sub New(name As String, entity As Label, game As Game, tolist As Boolean, toform As Boolean, intx As Integer, inty As Integer, hasCollision As Boolean)
        Me.hitbox = Nothing
        Me.lblEntity = entity
        Me.picFrame = game.picFrame ' Frame is used to calculate the position of the character
        Me.frm = game.frmAttached ' Where the entity is sent to 
        Me.strName = name
        Me.intX = intx
        Me.intY = inty
        Me.game = game
        Me.width = lblEntity.Size.Width
        Me.height = lblEntity.Size.Height
        Me.isCollidable = hasCollision
        If toform Then frm.Controls.Add(lblEntity)
        If tolist Then game.Entities.Add(Me)
    End Sub

    Public Sub New(name As String, entity As Button, game As Game, tolist As Boolean, toform As Boolean, intx As Integer, inty As Integer, hasCollision As Boolean)
        Me.hitbox = Nothing
        Me.btnEntity = entity
        Me.picFrame = game.picFrame ' Frame is used to calculate the position of the character
        Me.frm = game.frmAttached ' Where the entity is sent to 
        Me.strName = name
        Me.intX = intx
        Me.intY = inty
        Me.game = game
        Me.width = btnEntity.Size.Width
        Me.height = btnEntity.Size.Height
        Me.isCollidable = hasCollision
        If toform Then frm.Controls.Add(btnEntity)
        If tolist Then game.Entities.Add(Me)
    End Sub

    Public Sub changeForms(newForm As Form, type As String) ' moves the entity over to the next form
        Select Case type
            Case "pic"
                frm.Controls.Remove(picEntity)
                frm = newForm
                frm.Controls.Add(picEntity)
            Case "btn"
                frm.Controls.Remove(btnEntity)
                frm = newForm
                frm.Controls.Add(btnEntity)
            Case "lbl"
                frm.Controls.Remove(lblEntity)
                frm = newForm
                frm.Controls.Add(lblEntity)
        End Select
    End Sub
    Public Sub changeFramePos(frame As PictureBox) ' changes the frame itself to the new frame
        picFrame = frame
    End Sub

    Public Sub tick()
        updatesize()
        If Not picEntity.Location.Equals(New Point(picFrame.Location.X + FrmTitle.intScaledValue(25) + FrmTitle.intScaledValue(intX), picFrame.Location.Y + FrmTitle.intScaledValue(25) + FrmTitle.intScaledValue(intY))) Then
            picEntity.Location = New Point(picFrame.Location.X + FrmTitle.intScaledValue(25) + FrmTitle.intScaledValue(intX), picFrame.Location.Y + FrmTitle.intScaledValue(25) + FrmTitle.intScaledValue(intY)) 'Allows resizing of the window whilst retaining key elements
        End If
        If intX < 0 Then intX = 0 ' creates a border
        If intY < 0 Then intY = 0 ' creates a border
        If intX > picFrame.Size.Width - 50 - picEntity.Width Then intX = picFrame.Size.Width - 50 - picEntity.Width ' creates a border
        If intY > picFrame.Size.Height - 50 - picEntity.Height Then intY = picFrame.Size.Height - 50 - picEntity.Height ' creates a border
        hitbox = New Hitbox(picEntity)
    End Sub

    Public Function collision(type As String) ' checks for collisions in certain axes
        Select Case type
            Case "X"
                For Each e As Entity In game.Entities ' scans all the entities
                    If iscollidingwith(e.hitbox) And Not e.strName.Equals("player") And Not e.strName.Equals("frame") Then
                        If e.hitbox.getY(0) + 20 < hitbox.getY(1) And e.hitbox.getY(1) - 20 > hitbox.getY(0) Then ' checks for directional collisions
                            If e.intX <= intX Then
                                intX = e.intX + FrmTitle.intTrueValue(e.picEntity.Size.Width) + 5
                                decdx = 0
                            Else
                                intX = e.intX - FrmTitle.intTrueValue(picEntity.Size.Width) - 5
                                decdx = 0
                            End If
                            Return True
                        End If
                    End If
                Next
            Case "Y"
                For Each e As Entity In game.Entities ' scans all the entities
                    If e.isCollidable And iscollidingwith(e.hitbox) And Not e.strName.Equals(strName) And Not e.strName.Equals("frame") Then
                        If e.hitbox.getX(0) + 20 < hitbox.getX(1) And e.hitbox.getX(1) - 20 > hitbox.getX(0) Then ' checks for directional collisions
                            If e.intY <= intY Then
                                intY = e.intY + FrmTitle.intTrueValue(e.picEntity.Size.Height) + 5
                                decdy = 0
                            Else
                                intY = e.intY - FrmTitle.intTrueValue(picEntity.Size.Height) - 5
                                decdy = 0
                            End If
                            Return True
                        End If
                    End If
                Next
        End Select
        Return False
    End Function

    Public Function iscollidingwith(entity As Hitbox)
        Dim cx As Integer = 0, cy = 0 ' The number of present collisions on the x and y axes
        If entity.getX(0) >= hitbox.getX(0) And entity.getX(1) <= hitbox.getX(1) Then ' Checks if the entity is inside the player
            cx += 1
        End If

        For Each i In hitbox.getX
            If entity.getX(1) >= i And i >= entity.getX(0) Then 'Checks for the X axis collision on the edges where the first one doesn't detect. eg. edges of the hitbox
                cx += 1
            End If
        Next

        If entity.getY(0) >= hitbox.getY(0) And entity.getY(1) <= hitbox.getY(1) Then ' Detects when the player is inside the object
            cy += 1
        End If

        For Each i In hitbox.getY ' Detects if the player is on the edges of the y axis
            If entity.getY(0) <= i And entity.getY(1) >= i Then
                cy += 1
            End If
        Next

        If cx >= 1 And cy >= 1 Then ' detects if there's an x and y collision and runs 
            Return True
        Else
            Return False
        End If
    End Function

    Public Function inproximityof(entity As Entity, range As Integer) ' detects if the entity is an proximity of an image determined by the range
        Return iscollidingwith(entity.hitbox.enlarge(range))
    End Function
    Public Function inproximityof(entity As Hitbox, range As Integer)
        Return iscollidingwith(entity.enlarge(range))
    End Function
End Class
