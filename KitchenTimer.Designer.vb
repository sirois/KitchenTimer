<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KitchenTimer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.OneSecButton = New System.Windows.Forms.Button()
        Me.ThreeSecButton = New System.Windows.Forms.Button()
        Me.TenSecButton = New System.Windows.Forms.Button()
        Me.OneMinButton = New System.Windows.Forms.Button()
        Me.ThreeMinButton = New System.Windows.Forms.Button()
        Me.TenMinButton = New System.Windows.Forms.Button()
        Me.SingleTimer4 = New Assignment1KitchenTimer.SingleTimer()
        Me.SingleTimer3 = New Assignment1KitchenTimer.SingleTimer()
        Me.SingleTimer2 = New Assignment1KitchenTimer.SingleTimer()
        Me.SingleTimer1 = New Assignment1KitchenTimer.SingleTimer()
        Me.SuspendLayout()
        '
        'OneSecButton
        '
        Me.OneSecButton.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneSecButton.Location = New System.Drawing.Point(65, 448)
        Me.OneSecButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OneSecButton.Name = "OneSecButton"
        Me.OneSecButton.Size = New System.Drawing.Size(218, 73)
        Me.OneSecButton.TabIndex = 4
        Me.OneSecButton.Tag = "1"
        Me.OneSecButton.Text = "1 Second"
        Me.OneSecButton.UseVisualStyleBackColor = True
        '
        'ThreeSecButton
        '
        Me.ThreeSecButton.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThreeSecButton.Location = New System.Drawing.Point(289, 448)
        Me.ThreeSecButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ThreeSecButton.Name = "ThreeSecButton"
        Me.ThreeSecButton.Size = New System.Drawing.Size(218, 73)
        Me.ThreeSecButton.TabIndex = 5
        Me.ThreeSecButton.Tag = "3"
        Me.ThreeSecButton.Text = "3 Seconds"
        Me.ThreeSecButton.UseVisualStyleBackColor = True
        '
        'TenSecButton
        '
        Me.TenSecButton.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenSecButton.Location = New System.Drawing.Point(513, 448)
        Me.TenSecButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TenSecButton.Name = "TenSecButton"
        Me.TenSecButton.Size = New System.Drawing.Size(218, 73)
        Me.TenSecButton.TabIndex = 6
        Me.TenSecButton.Tag = "10"
        Me.TenSecButton.Text = "10 Seconds"
        Me.TenSecButton.UseVisualStyleBackColor = True
        '
        'OneMinButton
        '
        Me.OneMinButton.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneMinButton.Location = New System.Drawing.Point(65, 545)
        Me.OneMinButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OneMinButton.Name = "OneMinButton"
        Me.OneMinButton.Size = New System.Drawing.Size(218, 73)
        Me.OneMinButton.TabIndex = 7
        Me.OneMinButton.Tag = "1"
        Me.OneMinButton.Text = "1 Minute"
        Me.OneMinButton.UseVisualStyleBackColor = True
        '
        'ThreeMinButton
        '
        Me.ThreeMinButton.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThreeMinButton.Location = New System.Drawing.Point(289, 545)
        Me.ThreeMinButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ThreeMinButton.Name = "ThreeMinButton"
        Me.ThreeMinButton.Size = New System.Drawing.Size(218, 73)
        Me.ThreeMinButton.TabIndex = 8
        Me.ThreeMinButton.Tag = "3"
        Me.ThreeMinButton.Text = "3 Minutes"
        Me.ThreeMinButton.UseVisualStyleBackColor = True
        '
        'TenMinButton
        '
        Me.TenMinButton.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenMinButton.Location = New System.Drawing.Point(513, 545)
        Me.TenMinButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TenMinButton.Name = "TenMinButton"
        Me.TenMinButton.Size = New System.Drawing.Size(218, 73)
        Me.TenMinButton.TabIndex = 9
        Me.TenMinButton.Tag = "10"
        Me.TenMinButton.Text = "10 Minutes"
        Me.TenMinButton.UseVisualStyleBackColor = True
        '
        'SingleTimer4
        '
        Me.SingleTimer4.BackColor = System.Drawing.Color.DarkTurquoise
        Me.SingleTimer4.Location = New System.Drawing.Point(403, 225)
        Me.SingleTimer4.Margin = New System.Windows.Forms.Padding(5)
        Me.SingleTimer4.Name = "SingleTimer4"
        Me.SingleTimer4.Size = New System.Drawing.Size(365, 197)
        Me.SingleTimer4.TabIndex = 13
        '
        'SingleTimer3
        '
        Me.SingleTimer3.BackColor = System.Drawing.Color.DarkTurquoise
        Me.SingleTimer3.Location = New System.Drawing.Point(28, 225)
        Me.SingleTimer3.Margin = New System.Windows.Forms.Padding(5)
        Me.SingleTimer3.Name = "SingleTimer3"
        Me.SingleTimer3.Size = New System.Drawing.Size(365, 197)
        Me.SingleTimer3.TabIndex = 12
        '
        'SingleTimer2
        '
        Me.SingleTimer2.BackColor = System.Drawing.Color.DarkTurquoise
        Me.SingleTimer2.Location = New System.Drawing.Point(404, 18)
        Me.SingleTimer2.Margin = New System.Windows.Forms.Padding(5)
        Me.SingleTimer2.Name = "SingleTimer2"
        Me.SingleTimer2.Size = New System.Drawing.Size(365, 197)
        Me.SingleTimer2.TabIndex = 11
        '
        'SingleTimer1
        '
        Me.SingleTimer1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.SingleTimer1.Location = New System.Drawing.Point(28, 18)
        Me.SingleTimer1.Margin = New System.Windows.Forms.Padding(5)
        Me.SingleTimer1.Name = "SingleTimer1"
        Me.SingleTimer1.Size = New System.Drawing.Size(365, 197)
        Me.SingleTimer1.TabIndex = 10
        '
        'KitchenTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 636)
        Me.Controls.Add(Me.SingleTimer4)
        Me.Controls.Add(Me.SingleTimer3)
        Me.Controls.Add(Me.SingleTimer2)
        Me.Controls.Add(Me.SingleTimer1)
        Me.Controls.Add(Me.TenMinButton)
        Me.Controls.Add(Me.ThreeMinButton)
        Me.Controls.Add(Me.OneMinButton)
        Me.Controls.Add(Me.TenSecButton)
        Me.Controls.Add(Me.ThreeSecButton)
        Me.Controls.Add(Me.OneSecButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "KitchenTimer"
        Me.Text = "Jeremy Sirois's Kitchen Timer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OneSecButton As Button
    Friend WithEvents ThreeSecButton As Button
    Friend WithEvents TenSecButton As Button
    Friend WithEvents OneMinButton As Button
    Friend WithEvents ThreeMinButton As Button
    Friend WithEvents TenMinButton As Button
    Friend WithEvents SingleTimer1 As SingleTimer
    Friend WithEvents SingleTimer2 As SingleTimer
    Friend WithEvents SingleTimer3 As SingleTimer
    Friend WithEvents SingleTimer4 As SingleTimer
End Class
