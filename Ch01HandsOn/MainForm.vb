' Project:          Ch01HandsOn
' Programmer:       Victoria Brown 
' Date:             01/06/2015
' Description:      This project displays current promotions for each department.

Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MusicButton.Click
        ' Display "Get a free MP3 download with purchase of a CD" and code M608.

        PromotionLabel.Text = "Get a free MP3 download with purchase of a CD"

        PromotionCodeLabel.Text = "M608"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' Print the form.
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Close the project

        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BooksButton_Click(sender As Object, e As EventArgs) Handles BooksButton.Click
        ' Display "Buy two, get the second one for half price" and code B608.

        PromotionLabel.Text = "Buy two, get the second one for half price"

        PromotionCodeLabel.Text = "B608"
    End Sub

    Private Sub PeriodicalsButton_Click(sender As Object, e As EventArgs) Handles PeriodicalsButton.Click
        ' Display "Elite members receive 10% off every purchase" and code P608.

        PromotionLabel.Text = "Elite members receive 10% off every purchase"

        PromotionCodeLabel.Text = "P608"
    End Sub

    Private Sub CoffeeBarButton_Click(sender As Object, e As EventArgs) Handles CoffeeBarButton.Click
        ' Display "Celebrate the season with 20% off specialty drinks" and code C608.
        PromotionLabel.Text = "Celebrate the season with 20% off specialty drinks"

        PromotionCodeLabel.Text = "C608"
    End Sub
End Class
