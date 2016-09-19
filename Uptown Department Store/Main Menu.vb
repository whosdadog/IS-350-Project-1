Public Class MainMenu
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Logo.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Separator_Line.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Shoes_Click(sender As Object, e As EventArgs) Handles Shoes.Click
        ShoesForm.Show()
        Close()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Close()
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        AboutForm.Show()
        Close()
    End Sub
End Class