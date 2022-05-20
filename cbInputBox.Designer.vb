<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cbInputBox
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlanPosition = New System.Windows.Forms.TextBox()
        Me.txtCurrentPosition = New System.Windows.Forms.TextBox()
        Me.Command10 = New System.Windows.Forms.Button()
        Me.Command11 = New System.Windows.Forms.Button()
        Me.Command12 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prompt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edit Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current Position"
        '
        'txtPlanPosition
        '
        Me.txtPlanPosition.Location = New System.Drawing.Point(178, 74)
        Me.txtPlanPosition.Name = "txtPlanPosition"
        Me.txtPlanPosition.Size = New System.Drawing.Size(73, 22)
        Me.txtPlanPosition.TabIndex = 3
        '
        'txtCurrentPosition
        '
        Me.txtCurrentPosition.Location = New System.Drawing.Point(178, 115)
        Me.txtCurrentPosition.Name = "txtCurrentPosition"
        Me.txtCurrentPosition.Size = New System.Drawing.Size(73, 22)
        Me.txtCurrentPosition.TabIndex = 4
        '
        'Command10
        '
        Me.Command10.Location = New System.Drawing.Point(257, 69)
        Me.Command10.Name = "Command10"
        Me.Command10.Size = New System.Drawing.Size(73, 33)
        Me.Command10.TabIndex = 5
        Me.Command10.Text = "Enter"
        Me.Command10.UseVisualStyleBackColor = True
        '
        'Command11
        '
        Me.Command11.Location = New System.Drawing.Point(257, 110)
        Me.Command11.Name = "Command11"
        Me.Command11.Size = New System.Drawing.Size(73, 33)
        Me.Command11.TabIndex = 6
        Me.Command11.Text = "Teach"
        Me.Command11.UseVisualStyleBackColor = True
        '
        'Command12
        '
        Me.Command12.Location = New System.Drawing.Point(257, 156)
        Me.Command12.Name = "Command12"
        Me.Command12.Size = New System.Drawing.Size(73, 33)
        Me.Command12.TabIndex = 7
        Me.Command12.Text = "Cancel"
        Me.Command12.UseVisualStyleBackColor = True
        '
        'cbInputBox
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(345, 201)
        Me.ControlBox = False
        Me.Controls.Add(Me.Command12)
        Me.Controls.Add(Me.Command11)
        Me.Controls.Add(Me.Command10)
        Me.Controls.Add(Me.txtCurrentPosition)
        Me.Controls.Add(Me.txtPlanPosition)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cbInputBox"
        Me.Text = "Input Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlanPosition As TextBox
    Friend WithEvents txtCurrentPosition As TextBox
    Friend WithEvents Command10 As Button
    Friend WithEvents Command11 As Button
    Friend WithEvents Command12 As Button
End Class
