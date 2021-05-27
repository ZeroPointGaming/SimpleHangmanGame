Public Class Form1
    Private IntegerWrongGuess As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelWord.Text = "Welcome!"
        Label1.Text = "Health = 100"
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim WordString As String
        Dim objRandom As New Random
        Dim IntegerTelling As Integer
        Dim ArrayWords(100) As String 'Word list rnd section
        Dim IntegerRandom As Integer
        Dim BooleanPresent As Boolean
        Dim CharacterGuessingBox As Char
        Const Alphabet As String = "abcdefghijklmnopqrstuvwxyz"

        LabelWord.Text = String.Empty
        HangmanBox.Image = My.Resources.HangmanHead
        UsedLettersList.Items.Clear()

        IntegerRandom = objRandom.Next(0, 101)

        ArrayWords(0) = "Sanders"
        ArrayWords(1) = "endpaper"
        ArrayWords(2) = "unsoaped"
        ArrayWords(3) = "sorption"
        ArrayWords(4) = "straight"
        ArrayWords(5) = "cleverly"
        ArrayWords(6) = "fishline"
        ArrayWords(7) = "katmandu"
        ArrayWords(8) = "crocoite"
        ArrayWords(9) = "degumme"
        ArrayWords(10) = "partners"
        ArrayWords(11) = "isoprene"
        ArrayWords(12) = "kotzebu"
        ArrayWords(13) = "curlicue"
        ArrayWords(14) = "loyalism"
        ArrayWords(15) = "stendha"
        ArrayWords(16) = "closeout"
        ArrayWords(17) = "paneling"
        ArrayWords(18) = "mirepoix"
        ArrayWords(19) = "girolamo"
        ArrayWords(20) = "unsmutty"
        ArrayWords(21) = "pitchier"
        ArrayWords(22) = "discased"
        ArrayWords(23) = "gildsman"
        ArrayWords(24) = "sauncier"
        ArrayWords(25) = "foreseen"
        ArrayWords(26) = "glenview"
        ArrayWords(27) = "moldable"
        ArrayWords(28) = "melamdim"
        ArrayWords(29) = "surfable"
        ArrayWords(30) = "gingelly"
        ArrayWords(31) = "lewisham"
        ArrayWords(32) = "tractrix"
        ArrayWords(33) = "subcaste"
        ArrayWords(34) = "clubbier"
        ArrayWords(35) = "monotype"
        ArrayWords(36) = "waxiness"
        ArrayWords(37) = "shorties"
        ArrayWords(38) = "sitarist"
        ArrayWords(39) = "islamism"
        ArrayWords(40) = "misgraft"
        ArrayWords(41) = "teetotum"
        ArrayWords(42) = "phyletic"
        ArrayWords(43) = "stockier"
        ArrayWords(44) = "formnail"
        ArrayWords(45) = "exilable"
        ArrayWords(46) = "coaldale"
        ArrayWords(47) = "esculent"
        ArrayWords(48) = "depeople"
        ArrayWords(49) = "leveeing"
        ArrayWords(50) = "suborner"
        ArrayWords(51) = "communed"
        ArrayWords(52) = "overfish"
        ArrayWords(53) = "moonshot"
        ArrayWords(54) = "botryoid"
        ArrayWords(55) = "herewith"
        ArrayWords(56) = "amortise"
        ArrayWords(57) = "landless"
        ArrayWords(58) = "tomahawk"
        ArrayWords(59) = "winnipeg"
        ArrayWords(60) = "coxalgia"
        ArrayWords(61) = "unmasked"
        ArrayWords(62) = "matelote"
        ArrayWords(63) = "wildfowl"
        ArrayWords(64) = "oreshoot"
        ArrayWords(65) = "misprize"
        ArrayWords(66) = "adhesion"
        ArrayWords(67) = "baetylic"
        ArrayWords(68) = "swayback"
        ArrayWords(69) = "outmated"
        ArrayWords(70) = "putative"
        ArrayWords(71) = "tallness"
        ArrayWords(72) = "floralia"
        ArrayWords(73) = "unsombre"
        ArrayWords(74) = "saponite"
        ArrayWords(75) = "recement"
        ArrayWords(76) = "gunflint"
        ArrayWords(77) = "probably"
        ArrayWords(78) = "dockland"
        ArrayWords(79) = "unlumped"
        ArrayWords(80) = "underfed"
        ArrayWords(81) = "vizirial"
        ArrayWords(82) = "attiring"
        ArrayWords(83) = "earthpea"
        ArrayWords(84) = "vitellus"
        ArrayWords(85) = "dateline"
        ArrayWords(86) = "frothily"
        ArrayWords(87) = "aegyptus"
        ArrayWords(88) = "greegree"
        ArrayWords(89) = "hockshop"
        ArrayWords(90) = "tovarich"
        ArrayWords(91) = "paradrop"
        ArrayWords(92) = "overmean"
        ArrayWords(93) = "santiago"
        ArrayWords(94) = "intwined"
        ArrayWords(95) = "nomistic"
        ArrayWords(96) = "stormier"
        ArrayWords(97) = "farthing"
        ArrayWords(98) = "prentice"
        ArrayWords(99) = "sorrento"
        ArrayWords(100) = "rosarian"

        WordString = ArrayWords(IntegerRandom)

        Select Case IntegerRandom
            Case Is = 1
                Me.LabelWord.Text = "________"
            Case Is = 2
                Me.LabelWord.Text = "________"
            Case Is = 3
                Me.LabelWord.Text = "________"
            Case Is = 4
                Me.LabelWord.Text = "________"
            Case Is = 5
                Me.LabelWord.Text = "________"
            Case Is = 6
                Me.LabelWord.Text = "________"
            Case Is = 6
                Me.LabelWord.Text = "________"
            Case Is = 7
                Me.LabelWord.Text = "________"
            Case Is = 8
                Me.LabelWord.Text = "________"
            Case Is = 9
                Me.LabelWord.Text = "________"
            Case Is = 10
                Me.LabelWord.Text = "________"
            Case Is = 11
                Me.LabelWord.Text = "________"
            Case Is = 12
                Me.LabelWord.Text = "________"
            Case Is = 13
                Me.LabelWord.Text = "________"
            Case Is = 14
                Me.LabelWord.Text = "________"
            Case Is = 15
                Me.LabelWord.Text = "________"
            Case Is = 16
                Me.LabelWord.Text = "________"
            Case Is = 17
                Me.LabelWord.Text = "________"
            Case Is = 18
                Me.LabelWord.Text = "________"
            Case Is = 19
                Me.LabelWord.Text = "________"
            Case Is = 20
                Me.LabelWord.Text = "________"
            Case Is = 21
                Me.LabelWord.Text = "________"
            Case Is = 22
                Me.LabelWord.Text = "________"
            Case Is = 23
                Me.LabelWord.Text = "________"
            Case Is = 24
                Me.LabelWord.Text = "________"
            Case Is = 25
                Me.LabelWord.Text = "________"
            Case Is = 26
                Me.LabelWord.Text = "________"
            Case Is = 27
                Me.LabelWord.Text = "________"
            Case Is = 28
                Me.LabelWord.Text = "________"
            Case Is = 29
                Me.LabelWord.Text = "________"
            Case Is = 30
                Me.LabelWord.Text = "________"
            Case Is = 31
                Me.LabelWord.Text = "________"
            Case Is = 32
                Me.LabelWord.Text = "________"
            Case Is = 33
                Me.LabelWord.Text = "________"
            Case Is = 34
                Me.LabelWord.Text = "________"
            Case Is = 35
                Me.LabelWord.Text = "________"
            Case Is = 36
                Me.LabelWord.Text = "________"
            Case Is = 37
                Me.LabelWord.Text = "________"
            Case Is = 38
                Me.LabelWord.Text = "________"
            Case Is = 39
                Me.LabelWord.Text = "________"
            Case Is = 40
                Me.LabelWord.Text = "________"
            Case Is = 41
                Me.LabelWord.Text = "________"
            Case Is = 42
                Me.LabelWord.Text = "________"
            Case Is = 43
                Me.LabelWord.Text = "________"
            Case Is = 44
                Me.LabelWord.Text = "________"
            Case Is = 45
                Me.LabelWord.Text = "________"
            Case Is = 46
                Me.LabelWord.Text = "________"
            Case Is = 47
                Me.LabelWord.Text = "________"
            Case Is = 48
                Me.LabelWord.Text = "________"
            Case Is = 49
                Me.LabelWord.Text = "________"
            Case Is = 50
                Me.LabelWord.Text = "________"
            Case Is = 51
                Me.LabelWord.Text = "________"
            Case Is = 52
                Me.LabelWord.Text = "________"
            Case Is = 53
                Me.LabelWord.Text = "________"
            Case Is = 54
                Me.LabelWord.Text = "________"
            Case Is = 55
                Me.LabelWord.Text = "________"
            Case Is = 56
                Me.LabelWord.Text = "________"
            Case Is = 57
                Me.LabelWord.Text = "________"
            Case Is = 58
                Me.LabelWord.Text = "________"
            Case Is = 59
                Me.LabelWord.Text = "________"
            Case Is = 60
                Me.LabelWord.Text = "________"
            Case Is = 61
                Me.LabelWord.Text = "________"
            Case Is = 62
                Me.LabelWord.Text = "________"
            Case Is = 63
                Me.LabelWord.Text = "________"
            Case Is = 64
                Me.LabelWord.Text = "________"
            Case Is = 65
                Me.LabelWord.Text = "________"
            Case Is = 66
                Me.LabelWord.Text = "________"
            Case Is = 67
                Me.LabelWord.Text = "________"
            Case Is = 68
                Me.LabelWord.Text = "________"
            Case Is = 69
                Me.LabelWord.Text = "________"
            Case Is = 70
                Me.LabelWord.Text = "________"
            Case Is = 71
                Me.LabelWord.Text = "________"
            Case Is = 72
                Me.LabelWord.Text = "________"
            Case Is = 73
                Me.LabelWord.Text = "________"
            Case Is = 74
                Me.LabelWord.Text = "________"
            Case Is = 75
                Me.LabelWord.Text = "________"
            Case Is = 76
                Me.LabelWord.Text = "________"
            Case Is = 77
                Me.LabelWord.Text = "________"
            Case Is = 78
                Me.LabelWord.Text = "________"
            Case Is = 79
                Me.LabelWord.Text = "________"
            Case Is = 80
                Me.LabelWord.Text = "________"
            Case Is = 81
                Me.LabelWord.Text = "________"
            Case Is = 82
                Me.LabelWord.Text = "________"
            Case Is = 83
                Me.LabelWord.Text = "________"
            Case Is = 84
                Me.LabelWord.Text = "________"
            Case Is = 85
                Me.LabelWord.Text = "________"
            Case Is = 86
                Me.LabelWord.Text = "________"
            Case Is = 87
                Me.LabelWord.Text = "________"
            Case Is = 88
                Me.LabelWord.Text = "________"
            Case Is = 89
                Me.LabelWord.Text = "________"
            Case Is = 90
                Me.LabelWord.Text = "________"
            Case Is = 91
                Me.LabelWord.Text = "________"
            Case Is = 92
                Me.LabelWord.Text = "________"
            Case Is = 93
                Me.LabelWord.Text = "________"
            Case Is = 94
                Me.LabelWord.Text = "________"
            Case Is = 95
                Me.LabelWord.Text = "________"
            Case Is = 96
                Me.LabelWord.Text = "________"
            Case Is = 97
                Me.LabelWord.Text = "________"
            Case Is = 98
                Me.LabelWord.Text = "________"
            Case Is = 99
                Me.LabelWord.Text = "________"
            Case Is = 100
                Me.LabelWord.Text = "________"
        End Select

        WordString.ToCharArray()

        Do
            CharacterGuessingBox = InputBox("Input Letter Selction").ToLower
            If InStr(Alphabet, CharacterGuessingBox) = 0 Then

                MsgBox("you can only use letters!", MsgBoxResult.Cancel)
                If MsgBoxResult.Abort Then
                    Exit Sub
                End If
            ElseIf UsedLettersList.Items.Contains(CharacterGuessingBox) = False Then
                BooleanPresent = False
                UsedLettersList.Items.Add(CharacterGuessingBox)

                For IntegerTelling = 0 To Integer.Parse(ArrayWords(IntegerRandom).Length - 1) Step 1
                    If WordString(IntegerTelling) = CharacterGuessingBox Then
                        Me.LabelWord.Text = LabelWord.Text.Remove(IntegerTelling, 1)
                        Me.LabelWord.Text = LabelWord.Text.Insert(IntegerTelling, CharacterGuessingBox)
                        BooleanPresent = True
                    End If
                Next

                If BooleanPresent = False Then
                    IntegerWrongGuess += 1
                    If IntegerWrongGuess = 2 Then
                        HangmanBox.Visible = True
                    ElseIf IntegerWrongGuess = 4 Then
                        HangmanBox.Image = My.Resources.HangmanHead_1
                    ElseIf IntegerWrongGuess = 6 Then
                        HangmanBox.Image = My.Resources.HangmanHead_2
                    ElseIf IntegerWrongGuess = 8 Then
                        HangmanBox.Image = My.Resources.HangmanHeadDead
                    ElseIf IntegerWrongGuess = 10 Then
                        HangmanBox.Image = My.Resources.HangmanHeadFullDead
                    End If
                Else
                    'MessageBox.Show("That letter has been guessed already!")
                End If
            End If

        Loop Until LabelWord.Text = ArrayWords(IntegerRandom) Or IntegerWrongGuess = 10
        If IntegerWrongGuess = 10 Then
            MessageBox.Show("You Lose! The answe was " & ArrayWords(IntegerRandom).ToString, "Loser")
        ElseIf LabelWord.Text = ArrayWords(IntegerRandom) Then
            MessageBox.Show("You Won!", "Winner")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LabelWord.Text = ""
        IntegerWrongGuess = 0
        UsedLettersList.Items.Clear()
        HangmanBox.Visible = False
        HangmanBox.Image = My.Resources.HangmanHead
        Label1.Text = "Health = 100"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IntegerWrongGuess = 10
        LabelWord.Text = ""
        UsedLettersList.Items.Clear()
        HangmanBox.Visible = False
        HangmanBox.Image = My.Resources.HangmanHead
        Label1.Text = "Health = 100"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If IntegerWrongGuess = 0 Then
            Label1.Text = "Health = 100"
        ElseIf IntegerWrongGuess = 1 Then
            Label1.Text = "Health = 90"
        ElseIf IntegerWrongGuess = 2 Then
            Label1.Text = "Health = 80"
        ElseIf IntegerWrongGuess = 3 Then
            Label1.Text = "Health = 70"
        ElseIf IntegerWrongGuess = 4 Then
            Label1.Text = "Health = 60"
        ElseIf IntegerWrongGuess = 5 Then
            Label1.Text = "Health = 50"
        ElseIf IntegerWrongGuess = 6 Then
            Label1.Text = "Health = 40"
        ElseIf IntegerWrongGuess = 7 Then
            Label1.Text = "Health = 30"
        ElseIf IntegerWrongGuess = 8 Then
            Label1.Text = "Health = 20"
        ElseIf IntegerWrongGuess = 9 Then
            Label1.Text = "Health = 10"
        ElseIf IntegerWrongGuess = 10 Then
            Label1.Text = "Health = 0"
        End If
    End Sub
End Class
