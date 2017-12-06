Public Class _18GameOver1

    Private Sub _18GameOver1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GameOverCode = 1 Then
            lblGOText.Text = "You decided you didn’t care enough to go looking for " & Globals.Family.Character(3).Name & ". They never ended up coming back, and " & Globals.Family.Character(4).Name & " and " & Globals.Family.Character(0).Name & vbCrLf & " never forgave you for not leaving to look for " & Globals.Family.Character(3).Name & ". You live the rest of your life stuck in the quarantine zone," & vbCrLf & "knowing that " & Globals.Family.Character(3).Name & " spent the rest of their life running from the furries."
        End If
    End Sub

    Private Sub btnTryAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTryAgain.Click
        Me.Hide()
        Epidemic_CharacterSelection3.Show()
    End Sub
End Class