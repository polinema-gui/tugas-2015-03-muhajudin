Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Dim input As Integer = Convert.ToInt32(Me.inputText.Text)
        If input <> "0" Then
            Select Case Convert.ToString(Me.pilihanCombo.SelectedItem)
                Case "Pyramid"
                    Me.hasilText.Text = Me.pyramid(input)
                    Exit Select
                Case "Hollow Pyramid"
                    Me.hasilText.Text = Me.hollowPyramid(input)
                    Exit Select
                Case "Inverted Pyramid"
                    Me.hasilText.Text = Me.invertedPyramid(input)
                    Exit Select
                Case "Inverted Hollow Pyramid"
                    Me.hasilText.Text = Me.invertedHollowPyramid(input)
                    Exit Select
                Case Nothing
                    MessageBox.Show("Silahkan pilih pola terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Exit Select
            End Select
        Else
            MessageBox.Show("Silahkan masukkan angka terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Function hollowPyramid(ByVal input As Integer) As String
        Dim bintang As String = String.Empty
        Dim angka1 As Integer = input
        Dim i As Integer = 1
        Do While (i <= angka1)
            Dim angka2 As Integer = ((input + i) - 1)
            Dim j As Integer = 1
            Do While (j <= angka2)
                If (j > (input - i)) Then
                    If (((i = ((input - j) + 1)) Or (j = ((input + i) - 1))) Or (i = input)) Then
                        bintang = (bintang & " *")
                    Else
                        bintang = (bintang & "  ")
                    End If
                Else
                    bintang = (bintang & "  ")
                End If
                j += 1
            Loop
            bintang = (bintang & ChrW(13) & ChrW(10))
            i += 1
        Loop
        Return bintang
    End Function

    Private Function invertedHollowPyramid(ByVal input As Integer) As String
        Dim angka2 As Integer
        Dim bintang As String = String.Empty
        Dim angka As Integer = input
Label_0089:
        angka2 = 1
        If (angka >= angka2) Then
            Dim angka1 As Integer = ((input + angka) - 1)
            Dim i As Integer = 1
            Do While (i <= angka1)
                If (i > (input - angka)) Then
                    If (((angka = ((input - i) + 1)) Or (i = ((input + angka) - 1))) Or (angka = input)) Then
                        bintang = (bintang & " *")
                    Else
                        bintang = (bintang & "  ")
                    End If
                Else
                    bintang = (bintang & "  ")
                End If
                i += 1
            Loop
            bintang = (bintang & ChrW(13) & ChrW(10))
            angka = (angka + -1)
            GoTo Label_0089
        End If
        Return bintang



    End Function

    Private Function invertedPyramid(ByVal input As Integer) As String
        Dim angka2 As Integer
        Dim bintang As String = String.Empty
        Dim angka As Integer = input
Label_005D:
        angka2 = 1
        If (angka >= angka2) Then
            Dim angka1 As Integer = ((input + angka) - 1)
            Dim i As Integer = 1
            Do While (i <= angka1)
                If (i > (input - angka)) Then
                    bintang = (bintang & " *")
                Else
                    bintang = (bintang & "  ")
                End If
                i += 1
            Loop
            bintang = (bintang & ChrW(13) & ChrW(10))
            angka = (angka + -1)
            GoTo Label_005D
        End If
        Return bintang
    End Function

    Private Function pyramid(ByVal input As Integer) As String
        Dim bintang As String = String.Empty
        Dim angka1 As Integer = input
        Dim i As Integer = 1
        Do While (i <= angka1)
            Dim angka2 As Integer = ((input + i) - 1)
            Dim j As Integer = 1
            Do While (j <= angka2)
                If (j > (input - i)) Then
                    bintang = (bintang & " *")
                Else
                    bintang = (bintang & "  ")
                End If
                j += 1
            Loop
            bintang = (bintang & ChrW(13) & ChrW(10))
            i += 1
        Loop
        Return bintang
    End Function

End Class