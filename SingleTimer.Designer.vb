<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleTimer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ColonLabel = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MinutesCounter1 = New Assignment1KitchenTimer.MinutesCounter()
        Me.SecondsCounter1 = New Assignment1KitchenTimer.SecondsCounter()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StartButton.Location = New System.Drawing.Point(14, 130)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(100, 39)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StopButton.Location = New System.Drawing.Point(122, 130)
        Me.StopButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(100, 39)
        Me.StopButton.TabIndex = 3
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(230, 130)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(100, 39)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ColonLabel
        '
        Me.ColonLabel.AutoSize = True
        Me.ColonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColonLabel.Location = New System.Drawing.Point(156, 75)
        Me.ColonLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ColonLabel.Name = "ColonLabel"
        Me.ColonLabel.Size = New System.Drawing.Size(24, 36)
        Me.ColonLabel.TabIndex = 5
        Me.ColonLabel.Text = ":"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Lucida Console", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(36, 24)
        Me.Title.Margin = New System.Windows.Forms.Padding(4)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(186, 32)
        Me.Title.TabIndex = 6
        Me.Title.TabStop = True
        Me.Title.Text = "positions"
        Me.Title.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MinutesCounter1
        '
        Me.MinutesCounter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinutesCounter1.Location = New System.Drawing.Point(93, 74)
        Me.MinutesCounter1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinutesCounter1.Name = "MinutesCounter1"
        Me.MinutesCounter1.Size = New System.Drawing.Size(56, 37)
        Me.MinutesCounter1.TabIndex = 1
        '
        'SecondsCounter1
        '
        Me.SecondsCounter1.Location = New System.Drawing.Point(189, 74)
        Me.SecondsCounter1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SecondsCounter1.Name = "SecondsCounter1"
        Me.SecondsCounter1.Size = New System.Drawing.Size(56, 37)
        Me.SecondsCounter1.TabIndex = 0
        '
        'SingleTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ColonLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.MinutesCounter1)
        Me.Controls.Add(Me.SecondsCounter1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SingleTimer"
        Me.Size = New System.Drawing.Size(365, 197)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SecondsCounter1 As SecondsCounter
    Friend WithEvents MinutesCounter1 As MinutesCounter
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ColonLabel As Label
    Friend WithEvents Title As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
