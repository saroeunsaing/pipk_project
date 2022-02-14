<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Me.Txt_Username = New System.Windows.Forms.TextBox()
        Me.Txt_Password = New System.Windows.Forms.TextBox()
        Me.Btn_Login = New FontAwesome.Sharp.IconButton()
        Me.Btn_Cancel = New FontAwesome.Sharp.IconButton()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Logo = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Username
        '
        Me.Txt_Username.BackColor = System.Drawing.Color.MistyRose
        Me.Txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Username.Location = New System.Drawing.Point(55, 316)
        Me.Txt_Username.Name = "Txt_Username"
        Me.Txt_Username.Size = New System.Drawing.Size(296, 28)
        Me.Txt_Username.TabIndex = 0
        '
        'Txt_Password
        '
        Me.Txt_Password.BackColor = System.Drawing.Color.MistyRose
        Me.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Password.Location = New System.Drawing.Point(55, 390)
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.Size = New System.Drawing.Size(298, 28)
        Me.Txt_Password.TabIndex = 1
        '
        'Btn_Login
        '
        Me.Btn_Login.BackColor = System.Drawing.Color.Khaki
        Me.Btn_Login.FlatAppearance.BorderSize = 0
        Me.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Login.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.Btn_Login.IconColor = System.Drawing.Color.Black
        Me.Btn_Login.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Login.IconSize = 35
        Me.Btn_Login.Location = New System.Drawing.Point(45, 471)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(122, 49)
        Me.Btn_Login.TabIndex = 3
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Login.UseVisualStyleBackColor = False
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.Tomato
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.Btn_Cancel.IconColor = System.Drawing.Color.Black
        Me.Btn_Cancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Cancel.IconSize = 35
        Me.Btn_Cancel.Location = New System.Drawing.Point(203, 471)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(122, 49)
        Me.Btn_Cancel.TabIndex = 4
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_Close
        '
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.Btn_Close.IconColor = System.Drawing.Color.Red
        Me.Btn_Close.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Close.IconSize = 35
        Me.Btn_Close.Location = New System.Drawing.Point(361, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(35, 40)
        Me.Btn_Close.TabIndex = 5
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.MistyRose
        Me.Logo.ForeColor = System.Drawing.Color.DimGray
        Me.Logo.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.Logo.IconColor = System.Drawing.Color.DimGray
        Me.Logo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Logo.IconSize = 200
        Me.Logo.Location = New System.Drawing.Point(77, 49)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(200, 200)
        Me.Logo.TabIndex = 6
        Me.Logo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(26, 421)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 3)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(28, 346)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 3)
        Me.Panel2.TabIndex = 8
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.IconButton1.IconColor = System.Drawing.Color.DarkGray
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 35
        Me.IconButton1.Location = New System.Drawing.Point(23, 309)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(35, 35)
        Me.IconButton1.TabIndex = 9
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.IconButton2.IconColor = System.Drawing.Color.DarkGray
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 35
        Me.IconButton2.Location = New System.Drawing.Point(20, 386)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(35, 35)
        Me.IconButton2.TabIndex = 10
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 27)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "User Login"
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(400, 550)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Txt_Password)
        Me.Controls.Add(Me.Txt_Username)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Login"
        Me.Text = "Login"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Username As TextBox
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents Btn_Login As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Cancel As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Logo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
End Class
