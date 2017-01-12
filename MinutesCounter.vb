Public Class MinutesCounter
    Inherits Counter

    Sub New()
        maxvalue = 99
    End Sub

    Friend Sub increaseBy(tag As Integer)
        value = value + tag
        If value > maxvalue Then
            value = maxvalue
        End If
    End Sub
End Class
