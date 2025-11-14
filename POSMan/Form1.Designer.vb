<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.progressSplash = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.timerSplash = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblTitle.Location = New System.Drawing.Point(88, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(236, 64)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "POSMan"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'progressSplash
        '
        Me.progressSplash.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.progressSplash.Location = New System.Drawing.Point(12, 87)
        Me.progressSplash.Name = "progressSplash"
        Me.progressSplash.ProgressColor = System.Drawing.Color.DarkGray
        Me.progressSplash.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.progressSplash.ShadowDecoration.BorderRadius = 1
        Me.progressSplash.ShadowDecoration.Parent = Me.progressSplash
        Me.progressSplash.Size = New System.Drawing.Size(386, 10)
        Me.progressSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressSplash.TabIndex = 2
        Me.progressSplash.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'timerSplash
        '
        '
        'splashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 106)
        Me.Controls.Add(Me.progressSplash)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "splashScreen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splashScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents progressSplash As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents timerSplash As System.Windows.Forms.Timer

End Class
