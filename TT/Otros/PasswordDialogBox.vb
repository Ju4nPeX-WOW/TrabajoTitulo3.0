Public Class PasswordDialogBox
    Inherits Form
    Friend WithEvents tbPassword As New TextBox With {.PasswordChar = "*"c, .Parent = Me}
    Friend WithEvents Label1 As New Label With {.Parent = Me}
    Friend WithEvents okButton As New Button With {.Text = "OK", .Parent = Me}
    Friend Shadows WithEvents cancelButton As New Button With {.Text = "Cancel", .Parent = Me}
    Public Property Password As String = ""
    Sub New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Size = New Size(200, 150)
        Me.Text = "Enter Password"
        tbPassword.Left = Me.ClientRectangle.Width \ 2 - tbPassword.ClientRectangle.Width \ 2
        tbPassword.Top = Me.ClientRectangle.Height \ 2 - tbPassword.ClientRectangle.Height \ 2
        Label1.AutoSize = True
        Label1.Text = "Please enter a password"
        Label1.Left = (Me.ClientRectangle.Width \ 2) - (Label1.ClientRectangle.Width \ 2)
        okButton.Left = Me.ClientRectangle.Width - 5 - okButton.ClientRectangle.Width
        okButton.Top = Me.ClientRectangle.Height - 5 - okButton.Height
        cancelButton.Left = 5
        cancelButton.Top = Me.ClientRectangle.Height - 5 - cancelButton.Height
    End Sub
    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        If PasswordMeetsCriteria(tbPassword.Text) Then
            Me.Password = tbPassword.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Password is invalid, please re-enter your password or cancel.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Function PasswordMeetsCriteria(password As String) As Boolean
        Dim validCharacters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ`1234567890-=~!@#$%^&*()_+,./;'[]\<>?:""{}"
        For Each c As Char In password
            If validCharacters.IndexOf(c) = -1 Then Return False
        Next
        Return True
    End Function
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Password = ""
    End Sub
End Class
