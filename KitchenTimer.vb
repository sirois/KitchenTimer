Public Class KitchenTimer
    Dim SelectedTimer As SingleTimer
    Private Sub SingleTimer1_Load(sender As Object, e As EventArgs)

    End Sub
    Private Sub SingleTimer2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub SingleTimer3_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub SingleTimer4_Load(sender As Object, e As EventArgs)

    End Sub



    Private Sub KitchenTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        SingleTimer1.Title.Text = "Back Left"
        SingleTimer1.Alarm = Media.SystemSounds.Hand

        SingleTimer2.Title.Text = "Back Right"
        SingleTimer2.Alarm = Media.SystemSounds.Beep

        SingleTimer3.Title.Text = "Front Left"
        SingleTimer3.Alarm = Media.SystemSounds.Asterisk

        SingleTimer4.Title.Text = "Back Right"
        SingleTimer4.Alarm = Media.SystemSounds.Question


        SingleTimer1.beepDelay = 1
        SingleTimer2.beepDelay = 2
        SingleTimer3.beepDelay = 3
        SingleTimer4.beepDelay = 4

        SelectedTimer = SingleTimer1
        SelectedTimer.check()

    End Sub

    Private Sub OneSecButton_Click(sender As Object, e As EventArgs) Handles OneSecButton.Click, ThreeSecButton.Click, TenSecButton.Click
        SelectedTimer.addSeconds(sender.Tag)
    End Sub

    Private Sub OneMinButton_Click(sender As Object, e As EventArgs) Handles OneMinButton.Click, ThreeMinButton.Click, TenMinButton.Click
        SelectedTimer.addMinutes(sender.Tag)
    End Sub

    Public Sub timerSelected(sender As Object, e As EventArgs) Handles SingleTimer1.unselectOthers, SingleTimer2.unselectOthers, SingleTimer3.unselectOthers, SingleTimer4.unselectOthers
        SingleTimer1.uncheck()
        SingleTimer2.uncheck()
        SingleTimer3.uncheck()
        SingleTimer4.uncheck()
        SelectedTimer = sender
        SelectedTimer.check()


    End Sub

End Class
