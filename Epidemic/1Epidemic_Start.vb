Public Class StartScreen
    Dim Image As Integer = 0

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
    Private Sub PBxStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBxStart.Click
        Me.Hide()
        Epidemic_Prologue2.Show()
    End Sub

    Private Sub TimerIntro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerIntro.Tick

        Select Case Image
            Case 0
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 1
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 2
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 3
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 4
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 5
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 6
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 7
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 8
                PbxIntro.Image = My.Resources.Frame_2_Ep__Intro
            Case 9
                PbxIntro.Image = My.Resources.Frame_2_Ep__Intro
            Case 10
                PbxIntro.Image = My.Resources.Frame_2_Ep__Intro
            Case 11
                PbxIntro.Image = My.Resources.Frame_3__Semi_Light__Ep__Intro
            Case 12
                PbxIntro.Image = My.Resources.Frame_3__Semi_Light__Ep__Intro
            Case 13
                PbxIntro.Image = My.Resources.Frame_3__Semi_Light__Ep__Intro
            Case 14
                PbxIntro.Image = My.Resources.Frame_4__Bright__Ep__Intro
            Case 15
                PbxIntro.Image = My.Resources.Frame_4__Bright__Ep__Intro
            Case 16
                PbxIntro.Image = My.Resources.Frame_3__Semi_Light__Ep__Intro
            Case 16
                PbxIntro.Image = My.Resources.Frame_3__Semi_Light__Ep__Intro
            Case 17
                PbxIntro.Image = My.Resources.Frame_3__Semi_Light__Ep__Intro
            Case 18
                PbxIntro.Image = My.Resources.Frame_2_Ep__Intro
            Case 19
                PbxIntro.Image = My.Resources.Frame_2_Ep__Intro
            Case 20
                PbxIntro.Image = My.Resources.Frame_2_Ep__Intro
            Case 21
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 22
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 23
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 24
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 25
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 26
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 27
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 28
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 29
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 30
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 31
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 32
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 33
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 34
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 35
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 36
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 37
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 38
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 39
                PbxIntro.Image = My.Resources.Frame_2_Ep__Intro
            Case 40
                PbxIntro.Image = My.Resources.Frame_3__Semi_Light__Ep__Intro
            Case 41
                PbxIntro.Image = My.Resources.Frame_4__Bright__Ep__Intro
            Case 42
                PbxIntro.Image = My.Resources.Frame_4__Bright__Ep__Intro
            Case 43
                PbxIntro.Image = My.Resources.Frame_3__Semi_Light__Ep__Intro
            Case 44
                PbxIntro.Image = My.Resources.Frame_2_Ep__Intro
            Case 45
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 46
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 47
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 48
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 49
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 50
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 51
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 52
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 53
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 54
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 55
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 56
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 57
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 58
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 59
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 60
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 61
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 62
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 63
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 64
                PbxIntro.Image = My.Resources.Frame_2_Ep__Intro
            Case 65
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 66
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 67
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 68
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 69
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 70
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 71
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 72
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 73
                PbxIntro.Image = My.Resources.Frame_3__Semi_Light__Ep__Intro
            Case 74
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 75
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 76
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 77
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 78
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 79
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 80
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 81
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 82
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 83
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 84
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 85
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 86
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 87
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 88
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 89
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 90
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 91
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 92
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 93
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 94
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 95
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 96
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 97
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 98
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 99
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 100
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 101
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 102
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 103
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 104
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 105
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 106
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 107
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 108
                PbxIntro.Image = My.Resources.Frame_5__Final_Lightning__Ep__Intro
            Case 109
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 110
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 111
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 112
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 113
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 114
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 115
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 116
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 117
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 118
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 119
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 120
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 121
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 122
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 123
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 124
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 125
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 126
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 127
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 128
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 129
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 130
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 131
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 132
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 133
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 134
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 135
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 136
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 137
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 138
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 139
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 140
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 141
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 142
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 143
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 144
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 145
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 146
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 147
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 148
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 149
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 150
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 151
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 152
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 153
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
            Case 154
                PbxIntro.Image = My.Resources.Frame_1__Dark__Ep__Intro
        End Select

        Image = (Image + 1) Mod 156
    End Sub
End Class
