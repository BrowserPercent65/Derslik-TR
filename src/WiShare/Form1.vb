Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Shell("cmd /c netsh wlan start hostednetwork", AppWinStyle.Hide)
        Button1.Enabled = False







    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.TextLength > "7" Then
            Label3.Visible = False
            Button4.Enabled = True

        Else
            Label3.Visible = True
            Button4.Enabled = False

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("cmd /c netsh wlan stop hostednetwork", AppWinStyle.Hide)
        ListBox1.Items.Clear()

        Button4.Enabled = True
        DurdurToolStripMenuItem1.Enabled = False

    End Sub

    Private Sub DurdurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DurdurToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub DurdurToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DurdurToolStripMenuItem1.Click
        Shell("cmd /c netsh wlan stop hostednetwork", AppWinStyle.Hide)
        ListBox1.Items.Clear()
        Button1.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Add(TextBox1.Text + " Bağlantısı Bulunuyor")
        Shell("cmd /c netsh wlan set hostednetwork mode=allow ssid=" + TextBox1.Text + " key=" + TextBox2.Text + " keyusage=persistent", AppWinStyle.Hide)
        Button2.Enabled = True
        Button1.Enabled = True
        Button4.Enabled = False
        DurdurToolStripMenuItem1.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If

    End Sub
End Class
