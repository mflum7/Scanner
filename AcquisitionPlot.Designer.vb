<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AcquisitionPlot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PausedDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAvailableDataAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAvailableDataToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalyseAvailableDatatemporaryFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayChannelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ch0ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ch1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ch2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ch3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ch4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ch5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ch6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ch7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X14ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X18ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiChannelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FillScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlotYFromBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlotZFromBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.SaveDataToolStripMenuItem, Me.PausedDataToolStripMenuItem, Me.ConfigurationToolStripMenuItem, Me.DisplayChannelToolStripMenuItem, Me.ScaleToolStripMenuItem, Me.MultiChannelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1056, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.AToolStripMenuItem.Text = "[ACQUISITION MENU]"
        '
        'SaveDataToolStripMenuItem
        '
        Me.SaveDataToolStripMenuItem.Name = "SaveDataToolStripMenuItem"
        Me.SaveDataToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.SaveDataToolStripMenuItem.Text = "Save Data"
        '
        'PausedDataToolStripMenuItem
        '
        Me.PausedDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAvailableDataAsToolStripMenuItem, Me.SaveAvailableDataToToolStripMenuItem, Me.AnalyseAvailableDatatemporaryFileToolStripMenuItem})
        Me.PausedDataToolStripMenuItem.Name = "PausedDataToolStripMenuItem"
        Me.PausedDataToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.PausedDataToolStripMenuItem.Text = "Paused Data"
        '
        'SaveAvailableDataAsToolStripMenuItem
        '
        Me.SaveAvailableDataAsToolStripMenuItem.Name = "SaveAvailableDataAsToolStripMenuItem"
        Me.SaveAvailableDataAsToolStripMenuItem.Size = New System.Drawing.Size(345, 26)
        Me.SaveAvailableDataAsToolStripMenuItem.Text = "Save Available Data As ...."
        '
        'SaveAvailableDataToToolStripMenuItem
        '
        Me.SaveAvailableDataToToolStripMenuItem.Name = "SaveAvailableDataToToolStripMenuItem"
        Me.SaveAvailableDataToToolStripMenuItem.Size = New System.Drawing.Size(345, 26)
        Me.SaveAvailableDataToToolStripMenuItem.Text = "Save Available Data to []"
        '
        'AnalyseAvailableDatatemporaryFileToolStripMenuItem
        '
        Me.AnalyseAvailableDatatemporaryFileToolStripMenuItem.Name = "AnalyseAvailableDatatemporaryFileToolStripMenuItem"
        Me.AnalyseAvailableDatatemporaryFileToolStripMenuItem.Size = New System.Drawing.Size(345, 26)
        Me.AnalyseAvailableDatatemporaryFileToolStripMenuItem.Text = "Analyse Available Data (temporary file)"
        '
        'ConfigurationToolStripMenuItem
        '
        Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
        Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.ConfigurationToolStripMenuItem.Text = "Configuration"
        '
        'DisplayChannelToolStripMenuItem
        '
        Me.DisplayChannelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ch0ToolStripMenuItem, Me.Ch1ToolStripMenuItem, Me.Ch2ToolStripMenuItem, Me.Ch3ToolStripMenuItem, Me.Ch4ToolStripMenuItem, Me.Ch5ToolStripMenuItem, Me.Ch6ToolStripMenuItem, Me.Ch7ToolStripMenuItem})
        Me.DisplayChannelToolStripMenuItem.Name = "DisplayChannelToolStripMenuItem"
        Me.DisplayChannelToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.DisplayChannelToolStripMenuItem.Text = "Display Channel"
        '
        'Ch0ToolStripMenuItem
        '
        Me.Ch0ToolStripMenuItem.Name = "Ch0ToolStripMenuItem"
        Me.Ch0ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.Ch0ToolStripMenuItem.Text = "Ch 0"
        '
        'Ch1ToolStripMenuItem
        '
        Me.Ch1ToolStripMenuItem.Name = "Ch1ToolStripMenuItem"
        Me.Ch1ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.Ch1ToolStripMenuItem.Text = "Ch 1"
        '
        'Ch2ToolStripMenuItem
        '
        Me.Ch2ToolStripMenuItem.Name = "Ch2ToolStripMenuItem"
        Me.Ch2ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.Ch2ToolStripMenuItem.Text = "Ch 2"
        '
        'Ch3ToolStripMenuItem
        '
        Me.Ch3ToolStripMenuItem.Name = "Ch3ToolStripMenuItem"
        Me.Ch3ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.Ch3ToolStripMenuItem.Text = "Ch 3"
        '
        'Ch4ToolStripMenuItem
        '
        Me.Ch4ToolStripMenuItem.Name = "Ch4ToolStripMenuItem"
        Me.Ch4ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.Ch4ToolStripMenuItem.Text = "Ch 4"
        '
        'Ch5ToolStripMenuItem
        '
        Me.Ch5ToolStripMenuItem.Name = "Ch5ToolStripMenuItem"
        Me.Ch5ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.Ch5ToolStripMenuItem.Text = "Ch 5"
        '
        'Ch6ToolStripMenuItem
        '
        Me.Ch6ToolStripMenuItem.Name = "Ch6ToolStripMenuItem"
        Me.Ch6ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.Ch6ToolStripMenuItem.Text = "Ch 6"
        '
        'Ch7ToolStripMenuItem
        '
        Me.Ch7ToolStripMenuItem.Name = "Ch7ToolStripMenuItem"
        Me.Ch7ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.Ch7ToolStripMenuItem.Text = "Ch 7"
        '
        'ScaleToolStripMenuItem
        '
        Me.ScaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.X8ToolStripMenuItem, Me.X4ToolStripMenuItem, Me.X2ToolStripMenuItem, Me.X1ToolStripMenuItem, Me.X12ToolStripMenuItem, Me.X14ToolStripMenuItem, Me.X18ToolStripMenuItem})
        Me.ScaleToolStripMenuItem.Name = "ScaleToolStripMenuItem"
        Me.ScaleToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.ScaleToolStripMenuItem.Text = "Scale"
        '
        'X8ToolStripMenuItem
        '
        Me.X8ToolStripMenuItem.Name = "X8ToolStripMenuItem"
        Me.X8ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.X8ToolStripMenuItem.Text = "x8"
        '
        'X4ToolStripMenuItem
        '
        Me.X4ToolStripMenuItem.Name = "X4ToolStripMenuItem"
        Me.X4ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.X4ToolStripMenuItem.Text = "x4"
        '
        'X2ToolStripMenuItem
        '
        Me.X2ToolStripMenuItem.Name = "X2ToolStripMenuItem"
        Me.X2ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.X2ToolStripMenuItem.Text = "x2"
        '
        'X1ToolStripMenuItem
        '
        Me.X1ToolStripMenuItem.Name = "X1ToolStripMenuItem"
        Me.X1ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.X1ToolStripMenuItem.Text = "x1"
        '
        'X12ToolStripMenuItem
        '
        Me.X12ToolStripMenuItem.Name = "X12ToolStripMenuItem"
        Me.X12ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.X12ToolStripMenuItem.Text = "x1/2"
        '
        'X14ToolStripMenuItem
        '
        Me.X14ToolStripMenuItem.Name = "X14ToolStripMenuItem"
        Me.X14ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.X14ToolStripMenuItem.Text = "x1/4"
        '
        'X18ToolStripMenuItem
        '
        Me.X18ToolStripMenuItem.Name = "X18ToolStripMenuItem"
        Me.X18ToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.X18ToolStripMenuItem.Text = "x1/8"
        '
        'MultiChannelToolStripMenuItem
        '
        Me.MultiChannelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowAllToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.StackToolStripMenuItem, Me.FillScreenToolStripMenuItem, Me.ToolStripMenuItem2, Me.PlotYFromBottomToolStripMenuItem, Me.PlotZFromBottomToolStripMenuItem})
        Me.MultiChannelToolStripMenuItem.Name = "MultiChannelToolStripMenuItem"
        Me.MultiChannelToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.MultiChannelToolStripMenuItem.Text = "Multi-Channel"
        '
        'ShowAllToolStripMenuItem
        '
        Me.ShowAllToolStripMenuItem.Name = "ShowAllToolStripMenuItem"
        Me.ShowAllToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ShowAllToolStripMenuItem.Text = "Show All"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CascadeToolStripMenuItem.Text = "Cascade"
        '
        'StackToolStripMenuItem
        '
        Me.StackToolStripMenuItem.Name = "StackToolStripMenuItem"
        Me.StackToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.StackToolStripMenuItem.Text = "Stack"
        '
        'FillScreenToolStripMenuItem
        '
        Me.FillScreenToolStripMenuItem.Name = "FillScreenToolStripMenuItem"
        Me.FillScreenToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.FillScreenToolStripMenuItem.Text = "Fill Screen"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(216, 26)
        Me.ToolStripMenuItem2.Text = "`"
        '
        'PlotYFromBottomToolStripMenuItem
        '
        Me.PlotYFromBottomToolStripMenuItem.Name = "PlotYFromBottomToolStripMenuItem"
        Me.PlotYFromBottomToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.PlotYFromBottomToolStripMenuItem.Text = "Plot Y from Bottom"
        '
        'PlotZFromBottomToolStripMenuItem
        '
        Me.PlotZFromBottomToolStripMenuItem.Name = "PlotZFromBottomToolStripMenuItem"
        Me.PlotZFromBottomToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.PlotZFromBottomToolStripMenuItem.Text = "Plot Z from Bottom"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(213, 6)
        '
        'frmAcquisitionPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 38.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 516)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "frmAcquisitionPlot"
        Me.Text = "Acquisition C-Scan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PausedDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAvailableDataAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAvailableDataToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnalyseAvailableDatatemporaryFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayChannelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ch0ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ch1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ch2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ch3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ch4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ch5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ch6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ch7ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X12ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X14ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X18ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiChannelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FillScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PlotYFromBottomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlotZFromBottomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
