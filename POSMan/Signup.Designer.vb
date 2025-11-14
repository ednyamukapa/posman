<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup))
        Me.loginPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSignup = New Guna.UI2.WinForms.Guna2Button()
        Me.userType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lableName = New System.Windows.Forms.Label()
        Me.loginPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginPanel
        '
        Me.loginPanel.Controls.Add(Me.txtPassword)
        Me.loginPanel.Controls.Add(Me.Label3)
        Me.loginPanel.Controls.Add(Me.Button2)
        Me.loginPanel.Controls.Add(Me.Button1)
        Me.loginPanel.Controls.Add(Me.btnSignup)
        Me.loginPanel.Controls.Add(Me.userType)
        Me.loginPanel.Controls.Add(Me.txtUsername)
        Me.loginPanel.Controls.Add(Me.Label2)
        Me.loginPanel.Controls.Add(Me.Label1)
        Me.loginPanel.Controls.Add(Me.lableName)
        Me.loginPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loginPanel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loginPanel.Location = New System.Drawing.Point(12, 12)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.ShadowDecoration.Parent = Me.loginPanel
        Me.loginPanel.Size = New System.Drawing.Size(383, 264)
        Me.loginPanel.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.AutoRoundedCorners = True
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderRadius = 10
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(134, 170)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(200, 36)
        Me.txtPassword.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(115, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "User"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Admin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSignup
        '
        Me.btnSignup.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSignup.Animated = True
        Me.btnSignup.AutoRoundedCorners = True
        Me.btnSignup.BackColor = System.Drawing.Color.Transparent
        Me.btnSignup.BorderRadius = 17
        Me.btnSignup.CheckedState.Parent = Me.btnSignup
        Me.btnSignup.CustomImages.Parent = Me.btnSignup
        Me.btnSignup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSignup.ForeColor = System.Drawing.Color.White
        Me.btnSignup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSignup.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSignup.HoverState.FillColor = System.Drawing.Color.White
        Me.btnSignup.HoverState.ForeColor = System.Drawing.Color.Blue
        Me.btnSignup.HoverState.Parent = Me.btnSignup
        Me.btnSignup.Image = CType(resources.GetObject("btnSignup.Image"), System.Drawing.Image)
        Me.btnSignup.Location = New System.Drawing.Point(196, 216)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.ShadowDecoration.Parent = Me.btnSignup
        Me.btnSignup.Size = New System.Drawing.Size(138, 37)
        Me.btnSignup.TabIndex = 6
        Me.btnSignup.Text = "Signup"
        '
        'userType
        '
        Me.userType.BackColor = System.Drawing.Color.Transparent
        Me.userType.BorderRadius = 10
        Me.userType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.userType.FocusedColor = System.Drawing.Color.Empty
        Me.userType.FocusedState.Parent = Me.userType
        Me.userType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.userType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.userType.FormattingEnabled = True
        Me.userType.HoverState.Parent = Me.userType
        Me.userType.ItemHeight = 30
        Me.userType.Items.AddRange(New Object() {"Admin", "User"})
        Me.userType.ItemsAppearance.Parent = Me.userType
        Me.userType.Location = New System.Drawing.Point(134, 74)
        Me.userType.Name = "userType"
        Me.userType.ShadowDecoration.Parent = Me.userType
        Me.userType.Size = New System.Drawing.Size(200, 36)
        Me.userType.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.AutoRoundedCorners = True
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.BorderRadius = 10
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(134, 124)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(200, 36)
        Me.txtUsername.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User"
        '
        'lableName
        '
        Me.lableName.AutoSize = True
        Me.lableName.BackColor = System.Drawing.Color.Transparent
        Me.lableName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lableName.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lableName.ForeColor = System.Drawing.Color.Blue
        Me.lableName.Location = New System.Drawing.Point(128, 10)
        Me.lableName.Name = "lableName"
        Me.lableName.Size = New System.Drawing.Size(111, 36)
        Me.lableName.TabIndex = 0
        Me.lableName.Text = "Signup"
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 286)
        Me.Controls.Add(Me.loginPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Signup"
        Me.ShowIcon = False
        Me.Text = "Signup"
        Me.loginPanel.ResumeLayout(False)
        Me.loginPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents loginPanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSignup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents userType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lableName As System.Windows.Forms.Label
End Class
