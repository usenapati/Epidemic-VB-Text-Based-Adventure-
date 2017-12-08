Public Class _5Epidemic_EntrancetoFZ

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Me.Hide()
        _6Epidemic_InsideSchoolFZ1.Show()
    End Sub

    Private Sub btnStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatus.Click
        MessageBox.Show("Name: " & Globals.Family.Character(1).Name & " Gender: " & Globals.Family.Character(1).Gender & vbCrLf & "Wife's Name: " & Globals.Family.Character(2).Name & vbCrLf & "First Child: " & Globals.Family.Character(3).Name & "      Gender: " & Globals.Family.Character(3).Gender & vbCrLf & "Second Child: " & Globals.Family.Character(4).Name & "       Gender: " & Globals.Family.Character(4).Gender & vbCrLf & "Third Child: " & Globals.Family.Character(0).Name & "        Gender: " & Globals.Family.Character(0).Gender & vbCrLf & "Supply Count: " & Globals.Family.Character(1).SupplyCount & vbCrLf & "Furries Defeated: " & Globals.Family.Character(1).FurriesDefeated & vbCrLf & "Furries Saved: " & Globals.Family.Character(1).FurriesSaved & vbCrLf & "Location: " & Globals.Family.Character(1).Location)
    End Sub

    Private Sub _5Epidemic_EntrancetoFZ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Globals.Family.Character(1).Location = "Quarantine Zone Gate"
        lblExpo.Text = "You decide to leave the quarantine zone in search of " & Globals.Family.Character(3).Name & ". You tell the guards on the way out" & vbCrLf & "and they warn you of the dangers of the Furry Zone beyond the gates. Your friend from the" & vbCrLf & "science lab stops you before you can leave, and says that he may have something that can help you on your way." & vbCrLf & "He hands you a vial and tells you the ingredients that are in it, saying that it may have some way to cure the furries" & vbCrLf & "of their disease. You figure you may find some supplies on your journey to help you make more." & vbCrLf & "You take the vial and leave the zone, embarking towards the building nearest outside: an abandoned school."
    End Sub
End Class