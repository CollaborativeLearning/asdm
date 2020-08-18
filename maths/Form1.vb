Public Class Form1
    Dim a, b, c As Integer

    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        txt1.Clear()
        txt2.Clear()
        txtres.Clear()
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Application.Exit()
    End Sub

    Private Sub mulbtn_Click(sender As Object, e As EventArgs) Handles mulbtn.Click
        a = txt1.Text
        b = txt2.Text

        c = a * b
        txtres.Text = c
    End Sub

    Private Sub divbtn_Click(sender As Object, e As EventArgs) Handles divbtn.Click
        a = txt1.Text
        b = txt2.Text

        c = b / a
        txtres.Text = c
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        a = txt1.Text
        b = txt2.Text

        c = b - a
        txtres.Text = c
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        a = txt1.Text
        b = txt2.Text

        c = a + b
        txtres.Text = c
    End Sub
End Class
