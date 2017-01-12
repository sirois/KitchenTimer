Public Class SingleTimer

    Public beepDelay As Integer = 0
    Private chimes = 1
    Public Alarm As Media.SystemSound

    Private Sub SingleTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableButtons()
        uncheck()

    End Sub

    Friend Sub addSeconds(tag As Integer)
        If (Not (StopButton.Enabled And Not ClearButton.Enabled)) Then
            If ((SecondsCounter1.value + tag) > SecondsCounter1.maxvalue And MinutesCounter1.value < MinutesCounter1.maxvalue) Then
                MinutesCounter1.value += 1
                SecondsCounter1.setValue((SecondsCounter1.value + tag) - (SecondsCounter1.maxvalue + 1))

            ElseIf (SecondsCounter1.value + tag <= SecondsCounter1.maxvalue) Then
                SecondsCounter1.value += tag
            ElseIf ((SecondsCounter1.value + tag) > SecondsCounter1.maxvalue And MinutesCounter1.value = MinutesCounter1.maxvalue) Then
                SecondsCounter1.setToMax()
            End If
        End If
        disableButtons()
        SecondsCounter1.TimeLabel.Text = SecondsCounter1.value.ToString("D2")
        MinutesCounter1.TimeLabel.Text = MinutesCounter1.value.ToString("D2")
    End Sub

    Friend Sub addMinutes(tag As Integer)
        If (Not (StopButton.Enabled And Not ClearButton.Enabled)) Then
            MinutesCounter1.increaseBy(tag)

        End If
        MinutesCounter1.TimeLabel.Text = MinutesCounter1.value.ToString("D2")
        disableButtons()
    End Sub

    Public Event unselectOthers(Sender As Object, e As EventArgs)
    Public Sub singleTimerClicked(sender As Object, e As System.EventArgs) Handles Me.Click, ClearButton.Click, ColonLabel.Click, MinutesCounter1.Click, SecondsCounter1.Click, StartButton.Click, StopButton.Click, Title.Click, SecondsCounter1.aClicked, MinutesCounter1.aClicked

        Title.Checked = True
        RaiseEvent unselectOthers(Me, e)


    End Sub

    Public Sub startButtonClicked(sender As Object, e As EventArgs) Handles StartButton.Click
        Timer1.Start()
        StartButton.Enabled = False
        disableButtons()
    End Sub

    Public Sub stopButtonClicked(sender As Object, e As EventArgs) Handles StopButton.Click
        Timer1.Stop()
        ColonLabel.Show()
        disableButtons()
        SecondsCounter1.TimeLabel.ForeColor = Color.Black
        MinutesCounter1.TimeLabel.ForeColor = Color.Black
        ColonLabel.ForeColor = Color.Black
    End Sub

    Public Sub clearButtonClicked(sender As Object, e As EventArgs) Handles ClearButton.Click
        Timer1.Stop()
        SecondsCounter1.reset()
        MinutesCounter1.reset()
        SecondsCounter1.TimeLabel.Text = SecondsCounter1.value.ToString("D2")
        MinutesCounter1.TimeLabel.Text = MinutesCounter1.value.ToString("D2")
        disableButtons()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If SecondsCounter1.value = 0 And MinutesCounter1.value = 0 Then
            ''''alarms?
            SecondsCounter1.TimeLabel.ForeColor = Color.DarkRed
            MinutesCounter1.TimeLabel.ForeColor = Color.DarkRed
            ColonLabel.ForeColor = Color.DarkRed
            If chimes Mod beepDelay = 0 Then
                My.Computer.Audio.PlaySystemSound(Alarm)

            End If
            chimes += 1
            If (ColonLabel.Visible) Then
                ColonLabel.Hide()
            Else
                ColonLabel.Show()
            End If


        ElseIf SecondsCounter1.value = 0 And MinutesCounter1.value > 0 Then
            SecondsCounter1.setToMax()
            MinutesCounter1.increaseBy(-1)
        Else
            SecondsCounter1.value -= 1

        End If


        disableButtons()
        SecondsCounter1.TimeLabel.Text = SecondsCounter1.value.ToString("D2")
        MinutesCounter1.TimeLabel.Text = MinutesCounter1.value.ToString("D2")
    End Sub



    Private Sub disableButtons()
        If (MinutesCounter1.isZero And SecondsCounter1.isZero And Timer1.Enabled = False) Then
            StartButton.Enabled = False
            StopButton.Enabled = False
            ClearButton.Enabled = False
        ElseIf (MinutesCounter1.isZero And SecondsCounter1.isZero And Timer1.Enabled = True) Then
            StartButton.Enabled = False
            StopButton.Enabled = True
            ClearButton.Enabled = False
        ElseIf ((Not MinutesCounter1.isZero Or Not SecondsCounter1.isZero) And Timer1.Enabled = True) Then
            StartButton.Enabled = False
            StopButton.Enabled = True
            ClearButton.Enabled = True
        ElseIf ((Not MinutesCounter1.isZero Or Not SecondsCounter1.isZero) And Timer1.Enabled = False) Then
            StartButton.Enabled = True
            StopButton.Enabled = False
            ClearButton.Enabled = True
        End If
    End Sub
    Public Sub check()
        Title.Checked = True
        BackColor = Color.DeepSkyBlue
    End Sub
    Public Sub uncheck()
        Title.Checked = False
        BackColor = Color.DarkTurquoise
    End Sub

End Class