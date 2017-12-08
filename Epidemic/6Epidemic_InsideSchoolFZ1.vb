Public Class _6Epidemic_InsideSchoolFZ1
    Dim rngsupply As Integer
    Dim rngsupplycounter As Integer
    Dim MaxSupplyCount As Integer
    Dim RoomText As Integer
    Private Sub btnStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatus.Click
        MessageBox.Show("Name: " & Globals.Family.Character(1).Name & " Gender: " & Globals.Family.Character(1).Gender & vbCrLf & "Wife's Name: " & Globals.Family.Character(2).Name & vbCrLf & "First Child: " & Globals.Family.Character(3).Name & "      Gender: " & Globals.Family.Character(3).Gender & vbCrLf & "Second Child: " & Globals.Family.Character(4).Name & "       Gender: " & Globals.Family.Character(4).Gender & vbCrLf & "Third Child: " & Globals.Family.Character(0).Name & "        Gender: " & Globals.Family.Character(0).Gender & vbCrLf & "Supply Count: " & Globals.Family.Character(1).SupplyCount & vbCrLf & "Furries Defeated: " & Globals.Family.Character(1).FurriesDefeated & vbCrLf & "Furries Saved: " & Globals.Family.Character(1).FurriesSaved & vbCrLf & "Location: " & Globals.Family.Character(1).Location)
    End Sub

    Private Sub _6Epidemic_InsideSchoolFZ1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Globals.Family.Character(1).Location = "Inside " & Globals.Family.Character(3).Name & "'s school"
        btnNoEnter.Hide()
        btnYesEnter.Hide()
        btnEnter.Hide()
        lblEncounter.Text = "You come across " & Globals.Family.Character(3).Name & "'s school. You see shoeprints leading towards the school." & vbCrLf & "The mud from their shoes is left in the halls of the abandoned school. You decide to explore the halls," & vbCrLf & "but notice that the gym is heavily blocked by tables, bookshelves, and desks."
    End Sub

    Private Sub btnYesEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYesEnter.Click
        btnNoEnter.Hide()
        btnYesEnter.Hide()
        btnExplore.Show()
        If Globals.Family.Character(1).SupplyCount < 0 Then
            rngsupply = Globals.Family.Character(1).SupplyCount
            Globals.Family.Character(1).SupplyCount = 0
        End If

        If RoomText = 0 Then
            If rngsupplycounter > 40 Then
                lblEncounter.Text = "Inside the classroom, you find boxs filled with tools, parts, and even some snacks"
            Else
                lblEncounter.Text = "A scavenger is gathering tools and catches you off guard holding you at knife point. You have no other option but to give you your supplies"

            End If
        ElseIf RoomText = 1 Then

            If rngsupplycounter > 40 Then
                lblEncounter.Text = "You find a broken radio making some noises, but also find cabinets that have not been looted."
            Else
                lblEncounter.Text = "A furry locked in the room pounces on you. While it tries to bite you in the scuffle you use your weapon" & vbCrLf & "and kill the furry. You suffer some wounds, you need your supplies to lessen the pain."
            End If
        ElseIf RoomText = 2 Then

            If rngsupplycounter > 40 Then
                lblEncounter.Text = "Inside the classroom, you find boxs filled with tools, parts, and even some snacks"
            Else
                rngsupply = 0
                lblEncounter.Text = "You find only textbooks. Nothing that can help you."
            End If
        End If

            If rngsupplycounter > 40 Then
                lblEncounter.Text += vbCrLf & "You found " & rngsupply & " supplies"
                Globals.Family.Character(1).SupplyCount = Globals.Family.Character(1).SupplyCount + rngsupply
            Else
                lblEncounter.Text += vbCrLf & "You lost " & rngsupply & " supplies"
            Globals.Family.Character(1).SupplyCount = Globals.Family.Character(1).SupplyCount - rngsupply
            If Globals.Family.Character(1).SupplyCount < 0 Then
                rngsupply = Globals.Family.Character(1).SupplyCount
                Globals.Family.Character(1).SupplyCount = 0
            End If
            End If
    End Sub

    Private Sub btnNoEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEnter.Click
        btnNoEnter.Hide()
        btnYesEnter.Hide()
        btnExplore.Show()
    End Sub

    Private Sub btnExplore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplore.Click
        rngsupply = Globals.Randomizer.Next(0, 20)
        rngsupplycounter = Globals.Randomizer.Next(0, 100)
        RoomText = Globals.Randomizer.Next(0, 2)
        MaxSupplyCount = 50
        If Globals.Family.Character(1).SupplyCount < 0 Then
            Globals.Family.Character(1).SupplyCount = 0
        End If
        If MaxSupplyCount < Globals.Family.Character(1).SupplyCount Then
            btnExplore.Hide()
            btnNoEnter.Hide()
            btnYesEnter.Hide()
            btnEnter.Show()
            lblEncounter.Text = "You hear a loud screech in the school's gymnasium. The gym was origanally locked, but now the door has been" & vbCrLf & "torn open.The gym leads to the only open exit where " & Globals.Family.Character(3).Name & " could have gone as you see the mud from their shoe" & vbCrLf & "continue into the room."
        Else
            btnNoEnter.Show()
            btnYesEnter.Show()
            btnExplore.Hide()
            If RoomText = 0 Then
                lblEncounter.Text = "While searching through the classrooms, you see a door locked but it looks that it may be able to lockpick." & vbCrLf & "Do you want to enter?"
            ElseIf RoomText = 1 Then
                lblEncounter.Text = "You hear noises behind a closed classroom. The door is unlocked." & vbCrLf & "Do you want to enter?"
            ElseIf RoomText = 2 Then
                lblEncounter.Text = "You recognize one of " & Globals.Family.Character(3).Name & "'s classes. Perhaps they are in the room." & vbCrLf & "Do you want to enter?"
            End If
        End If
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Me.Hide()
        _7Epidemic_FurryBoss1_FurryMutant.Show()
    End Sub
End Class