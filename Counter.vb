Public MustInherit Class Counter

    Public maxvalue As Integer = 30
    Public value As Integer

    Public Function isMax()
        If value = maxvalue Then
            Return True
        End If
        Return False
    End Function

    Public Function isZero()
        If value = 0 Then
            Return True
        End If
        Return False
    End Function

    Public Sub reset()
        value = 0
        TimeLabel.Text = value
    End Sub
    Public Sub setToMax()
        value = maxvalue
        TimeLabel.Text = value

    End Sub

    Public Sub setValue(newvalue As Integer)
        value = newvalue
    End Sub

    Public Event aClicked(Sender As Object, e As EventArgs)

    Private Sub TimeLabel_Click(sender As Object, e As EventArgs) Handles TimeLabel.Click
        RaiseEvent aClicked(sender, e)

    End Sub
End Class
