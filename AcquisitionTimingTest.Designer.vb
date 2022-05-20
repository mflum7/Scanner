<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcquisitionTimingTest
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
        Me.txtCycles = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Encoding = New System.Windows.Forms.GroupBox()
        Me.optEncoding2 = New System.Windows.Forms.RadioButton()
        Me.optEncoding = New System.Windows.Forms.RadioButton()
        Me.fmeAD = New System.Windows.Forms.GroupBox()
        Me.optCHs2 = New System.Windows.Forms.RadioButton()
        Me.optCHs3 = New System.Windows.Forms.RadioButton()
        Me.optCHs4 = New System.Windows.Forms.RadioButton()
        Me.optCHs5 = New System.Windows.Forms.RadioButton()
        Me.optCHs6 = New System.Windows.Forms.RadioButton()
        Me.optCHs7 = New System.Windows.Forms.RadioButton()
        Me.optCHs8 = New System.Windows.Forms.RadioButton()
        Me.optCHs1 = New System.Windows.Forms.RadioButton()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Encoding.SuspendLayout()
        Me.fmeAD.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cycles"
        '
        'txtCycles
        '
        Me.txtCycles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCycles.Location = New System.Drawing.Point(76, 23)
        Me.txtCycles.Name = "txtCycles"
        Me.txtCycles.Size = New System.Drawing.Size(100, 22)
        Me.txtCycles.TabIndex = 1
        Me.txtCycles.Text = "1000"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(211, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Start Timming Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Encoding
        '
        Me.Encoding.Controls.Add(Me.optEncoding2)
        Me.Encoding.Controls.Add(Me.optEncoding)
        Me.Encoding.Location = New System.Drawing.Point(26, 71)
        Me.Encoding.Name = "Encoding"
        Me.Encoding.Size = New System.Drawing.Size(149, 95)
        Me.Encoding.TabIndex = 3
        Me.Encoding.TabStop = False
        Me.Encoding.Text = "Encoding"
        '
        'optEncoding2
        '
        Me.optEncoding2.AutoSize = True
        Me.optEncoding2.Location = New System.Drawing.Point(25, 56)
        Me.optEncoding2.Name = "optEncoding2"
        Me.optEncoding2.Size = New System.Drawing.Size(59, 21)
        Me.optEncoding2.TabIndex = 1
        Me.optEncoding2.TabStop = True
        Me.optEncoding2.Text = "BRM"
        Me.optEncoding2.UseVisualStyleBackColor = True
        '
        'optEncoding
        '
        Me.optEncoding.AutoSize = True
        Me.optEncoding.Location = New System.Drawing.Point(25, 29)
        Me.optEncoding.Name = "optEncoding"
        Me.optEncoding.Size = New System.Drawing.Size(84, 21)
        Me.optEncoding.TabIndex = 0
        Me.optEncoding.TabStop = True
        Me.optEncoding.Text = "PCL-833"
        Me.optEncoding.UseVisualStyleBackColor = True
        '
        'fmeAD
        '
        Me.fmeAD.Controls.Add(Me.optCHs2)
        Me.fmeAD.Controls.Add(Me.optCHs3)
        Me.fmeAD.Controls.Add(Me.optCHs4)
        Me.fmeAD.Controls.Add(Me.optCHs5)
        Me.fmeAD.Controls.Add(Me.optCHs6)
        Me.fmeAD.Controls.Add(Me.optCHs7)
        Me.fmeAD.Controls.Add(Me.optCHs8)
        Me.fmeAD.Controls.Add(Me.optCHs1)
        Me.fmeAD.Location = New System.Drawing.Point(31, 184)
        Me.fmeAD.Name = "fmeAD"
        Me.fmeAD.Size = New System.Drawing.Size(143, 144)
        Me.fmeAD.TabIndex = 4
        Me.fmeAD.TabStop = False
        Me.fmeAD.Text = "No of A/D CHs"
        '
        'optCHs2
        '
        Me.optCHs2.AutoSize = True
        Me.optCHs2.Location = New System.Drawing.Point(19, 53)
        Me.optCHs2.Name = "optCHs2"
        Me.optCHs2.Size = New System.Drawing.Size(37, 21)
        Me.optCHs2.TabIndex = 8
        Me.optCHs2.TabStop = True
        Me.optCHs2.Text = "2"
        Me.optCHs2.UseVisualStyleBackColor = True
        '
        'optCHs3
        '
        Me.optCHs3.AutoSize = True
        Me.optCHs3.Location = New System.Drawing.Point(19, 80)
        Me.optCHs3.Name = "optCHs3"
        Me.optCHs3.Size = New System.Drawing.Size(37, 21)
        Me.optCHs3.TabIndex = 7
        Me.optCHs3.TabStop = True
        Me.optCHs3.Text = "3"
        Me.optCHs3.UseVisualStyleBackColor = True
        '
        'optCHs4
        '
        Me.optCHs4.AutoSize = True
        Me.optCHs4.Location = New System.Drawing.Point(18, 107)
        Me.optCHs4.Name = "optCHs4"
        Me.optCHs4.Size = New System.Drawing.Size(37, 21)
        Me.optCHs4.TabIndex = 6
        Me.optCHs4.TabStop = True
        Me.optCHs4.Text = "4"
        Me.optCHs4.UseVisualStyleBackColor = True
        '
        'optCHs5
        '
        Me.optCHs5.AutoSize = True
        Me.optCHs5.Location = New System.Drawing.Point(77, 26)
        Me.optCHs5.Name = "optCHs5"
        Me.optCHs5.Size = New System.Drawing.Size(37, 21)
        Me.optCHs5.TabIndex = 5
        Me.optCHs5.TabStop = True
        Me.optCHs5.Text = "5"
        Me.optCHs5.UseVisualStyleBackColor = True
        '
        'optCHs6
        '
        Me.optCHs6.AutoSize = True
        Me.optCHs6.Location = New System.Drawing.Point(77, 53)
        Me.optCHs6.Name = "optCHs6"
        Me.optCHs6.Size = New System.Drawing.Size(37, 21)
        Me.optCHs6.TabIndex = 4
        Me.optCHs6.TabStop = True
        Me.optCHs6.Text = "6"
        Me.optCHs6.UseVisualStyleBackColor = True
        '
        'optCHs7
        '
        Me.optCHs7.AutoSize = True
        Me.optCHs7.Location = New System.Drawing.Point(77, 80)
        Me.optCHs7.Name = "optCHs7"
        Me.optCHs7.Size = New System.Drawing.Size(37, 21)
        Me.optCHs7.TabIndex = 3
        Me.optCHs7.TabStop = True
        Me.optCHs7.Text = "7"
        Me.optCHs7.UseVisualStyleBackColor = True
        '
        'optCHs8
        '
        Me.optCHs8.AutoSize = True
        Me.optCHs8.Location = New System.Drawing.Point(77, 107)
        Me.optCHs8.Name = "optCHs8"
        Me.optCHs8.Size = New System.Drawing.Size(37, 21)
        Me.optCHs8.TabIndex = 2
        Me.optCHs8.TabStop = True
        Me.optCHs8.Text = "8"
        Me.optCHs8.UseVisualStyleBackColor = True
        '
        'optCHs1
        '
        Me.optCHs1.AutoSize = True
        Me.optCHs1.Location = New System.Drawing.Point(19, 26)
        Me.optCHs1.Name = "optCHs1"
        Me.optCHs1.Size = New System.Drawing.Size(37, 21)
        Me.optCHs1.TabIndex = 0
        Me.optCHs1.TabStop = True
        Me.optCHs1.Text = "1"
        Me.optCHs1.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(225, 140)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(137, 20)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "micro-secs/cycle"
        '
        'lblTime2
        '
        Me.lblTime2.AutoSize = True
        Me.lblTime2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.Location = New System.Drawing.Point(221, 101)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(143, 38)
        Me.lblTime2.TabIndex = 6
        Me.lblTime2.Text = "  0.000   "
        Me.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(252, 291)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(122, 39)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmAcquisitionTimingTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 342)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblTime2)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.fmeAD)
        Me.Controls.Add(Me.Encoding)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCycles)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAcquisitionTimingTest"
        Me.Text = "6"
        Me.Encoding.ResumeLayout(False)
        Me.Encoding.PerformLayout()
        Me.fmeAD.ResumeLayout(False)
        Me.fmeAD.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCycles As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Encoding As GroupBox
    Friend WithEvents optEncoding2 As RadioButton
    Friend WithEvents optEncoding As RadioButton
    Friend WithEvents fmeAD As GroupBox
    Friend WithEvents optCHs2 As RadioButton
    Friend WithEvents optCHs3 As RadioButton
    Friend WithEvents optCHs4 As RadioButton
    Friend WithEvents optCHs5 As RadioButton
    Friend WithEvents optCHs6 As RadioButton
    Friend WithEvents optCHs7 As RadioButton
    Friend WithEvents optCHs8 As RadioButton
    Friend WithEvents optCHs1 As RadioButton
    Friend WithEvents lblTime As Label
    Friend WithEvents lblTime2 As Label
    Friend WithEvents cmdExit As Button
End Class
