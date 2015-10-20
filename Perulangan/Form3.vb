Public Class Form3

    
    Private Function parseMatrix(ByVal matriksText As String) As List(Of List(Of Integer))
        Dim daftar As New List(Of List(Of Integer))
        Dim arrayList As String() = matriksText.Split(New Char() {ChrW(13)})
        Dim length As Integer = arrayList.Length
        Dim angka5 As Integer = (length - 1)
        Dim i As Integer = 0
        Do While (i <= angka5)
            Dim arrayList2 As String() = arrayList(i).Split(New Char() {" "c})
            Dim angka2 As Integer = arrayList2.Length
            daftar.Add(New List(Of Integer))
            Dim angka6 As Integer = (angka2 - 1)
            Dim j As Integer = 0
            Do While (j <= angka6)
                daftar.Item(i).Add(Convert.ToInt32(arrayList2(j)))
                j += 1
            Loop
            If ((i <> 0) AndAlso (daftar.Item(i).Count <> daftar.Item((i - 1)).Count)) Then
                Return Nothing
            End If
            i += 1
        Loop
        Return daftar
    End Function

    Private Sub print(ByVal matrix As List(Of List(Of Integer)))
        Dim str As String = String.Empty
        Dim angka3 As Integer = (matrix.Count - 1)
        Dim i As Integer = 0
        Do While (i <= angka3)
            Dim angka4 As Integer = (matrix.Item(i).Count - 1)
            Dim j As Integer = 0
            Do While (j <= angka4)
                str = (str & Convert.ToString(matrix.Item(i).Item(j)) & ChrW(9))
                j += 1
            Loop
            str = (str & ChrW(13) & ChrW(10))
            i += 1
        Loop
        Me.hasilText.Text = str
    End Sub


    Private Function tambah(ByVal matrix1 As List(Of List(Of Integer)), ByVal matrix2 As List(Of List(Of Integer))) As List(Of List(Of Integer))
        Dim angka3 As Integer = (matrix1.Count - 1)
        Dim i As Integer = 0
        Do While (i <= angka3)
            Dim angka4 As Integer = (matrix1.Item(i).Count - 1)
            Dim j As Integer = 0
            Do While (j <= angka4)
                Dim daftar As List(Of Integer) = matrix1.Item(i)
                Dim angka5 As Integer = j
                daftar.Item(angka5) = (daftar.Item(angka5) + matrix2.Item(i).Item(j))
                j += 1
            Loop
            i += 1
        Loop
        Return matrix1
    End Function

    Private Function kurang(ByVal matrix1 As List(Of List(Of Integer)), ByVal matrix2 As List(Of List(Of Integer))) As List(Of List(Of Integer))
        Dim angka3 As Integer = (matrix1.Count - 1)
        Dim i As Integer = 0
        Do While (i <= angka3)
            Dim angka4 As Integer = (matrix1.Item(i).Count - 1)
            Dim j As Integer = 0
            Do While (j <= angka4)
                Dim daftar As List(Of Integer) = matrix1.Item(i)
                Dim angka5 As Integer = j
                daftar.Item(angka5) = (daftar.Item(angka5) - matrix2.Item(i).Item(j))
                j += 1
            Loop
            i += 1
        Loop
        Return matrix1
    End Function



    Private Function isValidMatrix(ByVal matrix1 As List(Of List(Of Integer)), ByVal matrix2 As List(Of List(Of Integer))) As Boolean
        Return ((matrix1.Count = matrix2.Count) AndAlso (matrix1.Item(0).Count = matrix2.Item(0).Count))
    End Function

    Private Sub hitungButton_Click(sender As Object, e As EventArgs) Handles hitungButton.Click

    End Sub
End Class