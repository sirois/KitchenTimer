Public Class SecondsCounter
    Inherits Counter

    Sub New()
        maxvalue = 59
    End Sub

    Friend Sub increaseBy(tag As Integer)
        value = value + tag
        If value > maxvalue Then

        End If
    End Sub
End Class
