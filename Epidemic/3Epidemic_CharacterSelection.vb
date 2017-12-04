Public Class Epidemic_CharacterSelection3

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Try


            ' Validate your inputs here.
            ' Throw exception if any invalid inputs.

            Globals.Family.Character(1).Name = txtFamilyMember1.Text.ToString()
            Globals.Family.Character(2).Name = txtFamilyMember2.Text.ToString()
            Globals.Family.Character(3).Name = txtFamilyMember3.Text.ToString()
            Globals.Family.Character(4).Name = txtFamilyMember4.Text.ToString()
            Globals.Family.Character(0).Name = txtFamilyMember5.Text.ToString()

            If radProM.Checked Then
                Globals.Family.Character(1).Gender = "Male"
            ElseIf radProF.Checked Then
                Globals.Family.Character(1).Gender = "Female"
            End If

            Globals.Family.Character(2).Gender = "Female"

            If radK1M.Checked Then
                Globals.Family.Character(3).Gender = "Male"
            ElseIf radK1F.Checked Then
                Globals.Family.Character(3).Gender = "Female"
            ElseIf radK1O.Checked Then
                Globals.Family.Character(3).Gender = "Other"
            End If

            If radK2M.Checked Then
                Globals.Family.Character(4).Gender = "Male"
            ElseIf radK2F.Checked Then
                Globals.Family.Character(4).Gender = "Female"
            ElseIf radK2O.Checked Then
                Globals.Family.Character(4).Gender = "Other"
            End If


            If radK3M.Checked Then
                Globals.Family.Character(0).Gender = "Male"
            ElseIf radK3F.Checked Then
                Globals.Family.Character(0).Gender = "Female"
            ElseIf radK3O.Checked Then
                Globals.Family.Character(0).Gender = "Other"
            End If


            For counter As Integer = 0 To (Globals.Family.Character.Length - 1)
                If Globals.Family.Character(counter).Name = "" Then
                    Throw New Exception("Please enter all five party members names")
                End If
                If Globals.Family.Character(counter).Gender = "" Then
                    Throw New Exception("Please enter all five party members genders")
                End If
            Next
            Me.Hide()
            Epidemic_PresentDay4.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Epidemic_CharacterSelection3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class