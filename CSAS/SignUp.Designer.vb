﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Me.Minimize = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SignUpLabel = New System.Windows.Forms.Label()
        Me.FNtext = New System.Windows.Forms.TextBox()
        Me.LNtext = New System.Windows.Forms.TextBox()
        Me.NumText = New System.Windows.Forms.TextBox()
        Me.UNtext = New System.Windows.Forms.TextBox()
        Me.RegionCombo = New System.Windows.Forms.ComboBox()
        Me.ProvinceCombo = New System.Windows.Forms.ComboBox()
        Me.CityCombo = New System.Windows.Forms.ComboBox()
        Me.SchoolCombo = New System.Windows.Forms.ComboBox()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SchoolLevel = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Minimize
        '
        Me.Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Minimize.BackgroundImage = Global.CSAS.My.Resources.Resources.Minimize
        Me.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimize.FlatAppearance.BorderSize = 0
        Me.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimize.ForeColor = System.Drawing.Color.White
        Me.Minimize.Location = New System.Drawing.Point(769, 7)
        Me.Minimize.Margin = New System.Windows.Forms.Padding(4)
        Me.Minimize.MaximumSize = New System.Drawing.Size(27, 25)
        Me.Minimize.MinimumSize = New System.Drawing.Size(27, 25)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(27, 25)
        Me.Minimize.TabIndex = 2
        Me.Minimize.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.BackgroundImage = Global.CSAS.My.Resources.Resources.ExitButton
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(819, 7)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseButton.MaximumSize = New System.Drawing.Size(27, 25)
        Me.CloseButton.MinimumSize = New System.Drawing.Size(27, 25)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(27, 25)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'SignUpLabel
        '
        Me.SignUpLabel.AutoSize = True
        Me.SignUpLabel.BackColor = System.Drawing.Color.Transparent
        Me.SignUpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SignUpLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.SignUpLabel.Location = New System.Drawing.Point(509, 78)
        Me.SignUpLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SignUpLabel.Name = "SignUpLabel"
        Me.SignUpLabel.Size = New System.Drawing.Size(138, 36)
        Me.SignUpLabel.TabIndex = 5
        Me.SignUpLabel.Text = "SIGN UP"
        '
        'FNtext
        '
        Me.FNtext.BackColor = System.Drawing.Color.White
        Me.FNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FNtext.Location = New System.Drawing.Point(373, 135)
        Me.FNtext.Margin = New System.Windows.Forms.Padding(4)
        Me.FNtext.Name = "FNtext"
        Me.FNtext.Size = New System.Drawing.Size(189, 30)
        Me.FNtext.TabIndex = 6
        Me.FNtext.Text = "First Name"
        Me.FNtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LNtext
        '
        Me.LNtext.BackColor = System.Drawing.Color.White
        Me.LNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.LNtext.Location = New System.Drawing.Point(589, 135)
        Me.LNtext.Margin = New System.Windows.Forms.Padding(4)
        Me.LNtext.Name = "LNtext"
        Me.LNtext.Size = New System.Drawing.Size(189, 30)
        Me.LNtext.TabIndex = 7
        Me.LNtext.Text = "Last Name"
        Me.LNtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumText
        '
        Me.NumText.BackColor = System.Drawing.Color.White
        Me.NumText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.NumText.Location = New System.Drawing.Point(373, 180)
        Me.NumText.Margin = New System.Windows.Forms.Padding(4)
        Me.NumText.Name = "NumText"
        Me.NumText.Size = New System.Drawing.Size(405, 30)
        Me.NumText.TabIndex = 10
        Me.NumText.Text = "Phone Number"
        Me.NumText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UNtext
        '
        Me.UNtext.BackColor = System.Drawing.Color.White
        Me.UNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UNtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.UNtext.Location = New System.Drawing.Point(373, 360)
        Me.UNtext.Margin = New System.Windows.Forms.Padding(4)
        Me.UNtext.Name = "UNtext"
        Me.UNtext.Size = New System.Drawing.Size(405, 30)
        Me.UNtext.TabIndex = 11
        Me.UNtext.Text = "Username"
        Me.UNtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RegionCombo
        '
        Me.RegionCombo.BackColor = System.Drawing.Color.White
        Me.RegionCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.RegionCombo.FormattingEnabled = True
        Me.RegionCombo.Location = New System.Drawing.Point(373, 225)
        Me.RegionCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.RegionCombo.Name = "RegionCombo"
        Me.RegionCombo.Size = New System.Drawing.Size(119, 32)
        Me.RegionCombo.TabIndex = 12
        Me.RegionCombo.Text = "   Region"
        '
        'ProvinceCombo
        '
        Me.ProvinceCombo.BackColor = System.Drawing.Color.White
        Me.ProvinceCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinceCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ProvinceCombo.FormattingEnabled = True
        Me.ProvinceCombo.Location = New System.Drawing.Point(516, 225)
        Me.ProvinceCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.ProvinceCombo.Name = "ProvinceCombo"
        Me.ProvinceCombo.Size = New System.Drawing.Size(119, 32)
        Me.ProvinceCombo.TabIndex = 13
        Me.ProvinceCombo.Text = "  Province"
        '
        'CityCombo
        '
        Me.CityCombo.BackColor = System.Drawing.Color.White
        Me.CityCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.CityCombo.FormattingEnabled = True
        Me.CityCombo.Location = New System.Drawing.Point(659, 225)
        Me.CityCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.CityCombo.Name = "CityCombo"
        Me.CityCombo.Size = New System.Drawing.Size(119, 32)
        Me.CityCombo.TabIndex = 14
        Me.CityCombo.Text = "      City"
        '
        'SchoolCombo
        '
        Me.SchoolCombo.BackColor = System.Drawing.Color.White
        Me.SchoolCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.SchoolCombo.FormattingEnabled = True
        Me.SchoolCombo.Location = New System.Drawing.Point(373, 270)
        Me.SchoolCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.SchoolCombo.Name = "SchoolCombo"
        Me.SchoolCombo.Size = New System.Drawing.Size(404, 32)
        Me.SchoolCombo.TabIndex = 15
        Me.SchoolCombo.Text = "                                  School"
        '
        'PasswordText
        '
        Me.PasswordText.BackColor = System.Drawing.Color.White
        Me.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.PasswordText.Location = New System.Drawing.Point(373, 405)
        Me.PasswordText.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.Size = New System.Drawing.Size(405, 30)
        Me.PasswordText.TabIndex = 16
        Me.PasswordText.Text = "New Password"
        Me.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.CSAS.My.Resources.Resources.SignupBlue
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(483, 450)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 43)
        Me.Button3.TabIndex = 17
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 27)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SchoolLevel
        '
        Me.SchoolLevel.BackColor = System.Drawing.Color.White
        Me.SchoolLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.SchoolLevel.FormattingEnabled = True
        Me.SchoolLevel.Location = New System.Drawing.Point(373, 315)
        Me.SchoolLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.SchoolLevel.Name = "SchoolLevel"
        Me.SchoolLevel.Size = New System.Drawing.Size(404, 32)
        Me.SchoolLevel.TabIndex = 19
        Me.SchoolLevel.Text = "                             School Level"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.LoginSignUp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 591)
        Me.Controls.Add(Me.SchoolLevel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.SchoolCombo)
        Me.Controls.Add(Me.CityCombo)
        Me.Controls.Add(Me.ProvinceCombo)
        Me.Controls.Add(Me.RegionCombo)
        Me.Controls.Add(Me.UNtext)
        Me.Controls.Add(Me.NumText)
        Me.Controls.Add(Me.LNtext)
        Me.Controls.Add(Me.FNtext)
        Me.Controls.Add(Me.SignUpLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Minimize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(853, 591)
        Me.MinimumSize = New System.Drawing.Size(853, 591)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents SignUpLabel As Label
    Friend WithEvents FNtext As TextBox
    Friend WithEvents LNtext As TextBox
    Friend WithEvents NumText As TextBox
    Friend WithEvents UNtext As TextBox
    Friend WithEvents RegionCombo As ComboBox
    Friend WithEvents ProvinceCombo As ComboBox
    Friend WithEvents CityCombo As ComboBox
    Friend WithEvents SchoolCombo As ComboBox
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SchoolLevel As ComboBox
End Class
