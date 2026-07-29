Class MainWindow
    Private selectedCharacter As String = ""

    Private Sub imgStitch_MouseLeftButtonDown(
        sender As Object,
        e As MouseButtonEventArgs
    )
        selectedCharacter = "Stitch"

        imgStitch.Opacity = 1
        imgAngel.Opacity = 0.5
        btnPlay.IsEnabled = True
    End Sub

    Private Sub imgAngel_MouseLeftButtonDown(
        sender As Object,
        e As MouseButtonEventArgs
    )
        selectedCharacter = "Angel"

        imgAngel.Opacity = 1
        imgStitch.Opacity = 0.5
        btnPlay.IsEnabled = True
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As RoutedEventArgs)
        If selectedCharacter = "" Then
            MessageBox.Show("Please choose a character first.")
            Return
        End If

        MessageBox.Show("You selected " & selectedCharacter & "!")
    End Sub

End Class
