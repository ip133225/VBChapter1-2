Public Class Form1

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnFeet.Click
        Label1.Text = "1 Kilo = 3,281 feet"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnYards.Click
        Label1.Text = "1 Kilo = 1,093 yards"
    End Sub

    Private Sub BtnInches_Click(sender As Object, e As EventArgs) Handles BtnInches.Click
        Label1.Text = "1 Kilo = 39,370 inches"
    End Sub

    Private Sub BtnMiles_Click(sender As Object, e As EventArgs) Handles BtnMiles.Click
        Label1.Text = "1 Kilo = 0.6214 Miles"
    End Sub
End Class
