Public Class StartScreen

    Private Sub StartScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Globals.Family = New Party
            Globals.Family.Character(1) = New Character()
            Globals.Family.Character(2) = New Character()
            Globals.Family.Character(3) = New Character()
            Globals.Family.Character(4) = New Character()
            Globals.Family.Character(0) = New Character()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Me.Hide()
        Epidemic_Prologue2.Show()
    End Sub
End Class
