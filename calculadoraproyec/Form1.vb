Public Class Form1

    Dim TextInput As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Uno.Click
        Concact("1")
    End Sub

    Private Sub Concact(value As String)
        TextInput += value
        Input.Text = TextInput
    End Sub



    Private Sub Dos_Click(sender As Object, e As EventArgs) Handles Dos.Click
        Concact("2")
    End Sub

    Private Sub Multiplicar_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click
        ConcactSign("*")
    End Sub

    Private Sub tres_Click(sender As Object, e As EventArgs) Handles tres.Click
        Concact("3")
    End Sub

    Private Sub cuatro_Click(sender As Object, e As EventArgs) Handles cuatro.Click
        Concact("4")
    End Sub

    Private Sub cinco_Click(sender As Object, e As EventArgs) Handles cinco.Click
        Concact("5")
    End Sub

    Private Sub seis_Click(sender As Object, e As EventArgs) Handles seis.Click
        Concact("6")
    End Sub

    Private Sub siete_Click(sender As Object, e As EventArgs) Handles siete.Click
        Concact("7")
    End Sub

    Private Sub ocho_Click(sender As Object, e As EventArgs) Handles ocho.Click
        Concact("8")
    End Sub

    Private Sub nueve_Click(sender As Object, e As EventArgs) Handles nueve.Click
        Concact("9")
    End Sub

    Private Sub cero_Click(sender As Object, e As EventArgs) Handles cero.Click
        Concact("0")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Concact("/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Concact("+")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Concact("-")
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        If ThereIsError() Then
            SetErrorMessage()
            Return
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Input.Text.Length > 0 Then
            Input.Text = Input.Text.Substring(0, Input.Text.Length - 1)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ResetAll()
    End Sub


    Private Sub SetErrorMessage()
        Input.Text = "Error"
    End Sub

    Private Sub ResetAll()
        ResetInput()
        ResetTextReabable()
    End Sub
    Private Sub ResetInput()
        Input.Clear()
    End Sub

    Private Sub ResetTextReabable()
        TextReadable.Clear()
    End Sub

    Private Sub ConcactSign(value As String)
        TextReadable.Text = TextInput + value

    End Sub

    Private Function ThereIsError() As String
        Return TextInput = ""
    End Function

End Class
