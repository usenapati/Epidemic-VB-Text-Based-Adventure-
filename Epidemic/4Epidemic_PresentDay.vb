Public Class Epidemic_PresentDay4

    Private Sub Epidemic_PresentDay4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Globals.Family.Character(1).Location = "Quarantine Zone"
    End Sub

    Private Sub btnGO1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGO1.Click
        Me.Hide()

    End Sub

    Private Sub btnQZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQZ.Click
        Dim RNGSupplyAmount As Integer
        RNGSupplyAmount = Globals.Randomizer.Next(10, 20)
        MessageBox.Show("You retrieved " & RNGSupplyAmount & " supplies back in your complex.")
        Globals.Family.Character(1).SupplyCount = Globals.Family.Character(1).SupplyCount + RNGSupplyAmount
        Globals.Family.Character(1).MoralityCounter = Globals.Family.Character(1).MoralityCounter + 2
        btnQZ.Hide()
    End Sub

    Private Sub btnFZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFZ.Click
        _5Epidemic_EntrancetoFZ.Show()
        Me.Hide()
    End Sub

    Private Sub btnStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatus.Click
        MessageBox.Show("Name: " & Globals.Family.Character(1).Name & " Gender: " & Globals.Family.Character(1).Gender & vbCrLf & "Wife's Name: " & Globals.Family.Character(2).Name & vbCrLf & "First Child: " & Globals.Family.Character(3).Name & "      Gender: " & Globals.Family.Character(3).Gender & vbCrLf & "Second Child: " & Globals.Family.Character(4).Name & "       Gender: " & Globals.Family.Character(4).Gender & vbCrLf & "Third Child: " & Globals.Family.Character(0).Name & "        Gender: " & Globals.Family.Character(0).Gender & vbCrLf & "Supply Count: " & Globals.Family.Character(1).SupplyCount & vbCrLf & "Furries Defeated: " & Globals.Family.Character(1).FurriesDefeated & vbCrLf & "Furries Saved: " & Globals.Family.Character(1).FurriesSaved & vbCrLf & "Location: " & Globals.Family.Character(1).Location)
    End Sub
End Class