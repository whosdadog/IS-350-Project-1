Public Class ShoesForm
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ShoesQuit_Click(sender As Object, e As EventArgs) Handles ShoesQuit.Click
        MainMenu.Show()

        Close()
    End Sub
End Class