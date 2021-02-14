Public Class LoginForm
    Public UN As String
    Public priority As Integer = 0
    Private Sub clr()
        txtUsername.ResetText()
        txtPassword.ResetText()
        ckbAdmin.Enabled = False
        ckbAdmin.Checked = False
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            If (txtUsername.Text = "Admin" And txtPassword.Text = "12345" And ckbAdmin.Checked = True) Then
                My.Forms.frmAdmin.Show()
                priority = 1
                clr()
                Me.Hide()
            ElseIf Not (LoginTableAdapter1.LoginCheck(txtUsername.Text, txtPassword.Text) = Nothing) Then
                My.Forms.frmTeacher.Show()
                UN = txtUsername.Text.ToUpper
                clr()
                Me.Hide()
            Else
                MsgBox("Invalid login details")
                clr()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtUsername_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        Try
            If txtUsername.Text = "Admin" Then
                ckbAdmin.Checked = True
            Else
                ckbAdmin.Checked = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LoginForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clr()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
