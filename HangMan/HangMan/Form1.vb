Public Class Form1
    Public FileName As String = "F:\wordsEn.txt"
    Dim wordname As String
    Dim random As New ArrayList()
    Dim stringreader As String
    Dim selectedword As String
    Dim letter As Char
    Dim letter2 As Char
    Dim letter3 As Char
    Dim letter4 As Char

    Dim charArray() As Char



    Public Function RandomNumber(ByVal low As Int32, ByVal high As Int32) As Integer
        Static RandomNumGen As New System.Random
        Return RandomNumGen.Next(low, high + 1)
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If System.IO.File.Exists(FileName) = True Then



            Dim objReader As New System.IO.StreamReader(FileName)

            random.Add(objReader.ReadLine())
            random.Add(objReader.ReadLine())
            random.Add(objReader.ReadLine())
            random.Add(objReader.ReadLine())
            random.Add(objReader.ReadLine())
            random.Add(objReader.ReadLine())
            random.Add(objReader.ReadLine())
            random.Add(objReader.ReadLine())

        

        End If

        selectedword = random(RandomNumber(0, 5))
        Dim length As Integer
        length = selectedword.Length
        Dim counter As Integer
        charArray = selectedword.ToCharArray




        Do While counter <= length
            lblL1.Text = charArray(0)
            counter = +1
            lblL2.Text = charArray(1)
            counter = +1
            lblL3.Text = charArray(2)
            counter = +1
            lblL4.Text = charArray(3)
            counter = +1
            lblL5.Text += charArray(4)
            counter = +1
            lblL3.Text = charArray(5)
            counter = +1
            lblL4.Text = charArray(6)
            counter = 100

            Exit While

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click

        Dim amount As Integer = selectedword.Count()


        MessageBox.Show(amount)

End Sub
End Class
